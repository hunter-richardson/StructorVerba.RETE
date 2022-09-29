using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Praebeunda.Verbum;
using Ēnumerātiōnēs.Catēgoria;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttributes;
using Lombok.NET.PropertyGenerators.SingletonAttributes;

namespace Tentāmina
{
  [Singleton]
  [AsyncOverloads]
  public sealed partial class Necesse
  {
    public static readonly Necesse Quod = Instance;
    public void Vērust<Hoc>(in Predicate<Hoc?> tentāmen, in Hoc? prōductum = null,
                            in string error = string.Empty)
              => Assert.That.IsTrue(tentāmen.Invoke(prōductum), error);
    public void Vērust<Hoc>(in Boolean tentāmen, in string error = string.Empty)
              => Assert.That.IsTrue(tentāmen, error);
    public void Falsust<Hoc>(in Predicate<Hoc?> tentāmen, in Hoc? prōductum = null,
                            in string error = string.Empty)
              => Assert.That.IsFalse(tentāmen.Invoke(prōductum), error);
    public void Falsust<Hoc>(in Boolean tentāmen, in string error = string.Empty)
              => Assert.That.IsFalse(tentāmen, error);
    public void Exsistit(in Verbum? verbum = null, in string error = string.Empty)
              => Assert.That.IsFalse(string.IsNullOrWhitespace(verbum?.Scrīptum), error);
    public void Exsistit<Hoc>(in Hoc prōductum = null, in string error = string.Empty)
              => Assert.That.IsNotNull(prōductum, error);
    public void Vacat(in Verbum? verbum = null, in string error = string.Empty)
              => Assert.That.IsTrue(string.IsNullOrWhitespace(verbum?.Scrīptum), error);
    public void Vacat<Hoc>(in Hoc prōductum = null, in string error = string.Empty)
              => Assert.That.IsNull(prōductum, error);

    public void Aequātur(in int tentandus, in Numerus? numerus = null, in string error = string.Empty)
       => await AequāturAsync(tentandum: tentandus, prōductum: numerus?.Minūtal, error: error);

    public void Aequātur(in string scrīptum, in Verbum? verbum = null,
                         in string error = string.Empty)
              => new TentāmenVerbī(verbum: verbum).Aequētur(scrīptum: scrīptum, error: error);

    public void Aequātur(in string scrīptum, in Verbum? verbum = null,
                         in string error = string.Empty)
    {
      await ExsistitAsync(verbum: verbum, error: error);
      Assert.That.AreEqual(verbum.Scrīptum, scrīptum,
                           StringComparison.OrdinalIgnoreCase, error);
    }

    public void Aequātur(in Catēgoria catēgoria, in Verbum? verbum = null,
                         in string error = string.Empty)
    {
      await ExsistitAsync(verbum: verbum, error: error);
      Assert.That.AreEqual(verbum.Catēgoria, catēgoria, error);
    }

    public void Aequātur<Hoc>(in IEqualityComparer<Hoc> comparātor,  in Hoc tentandum,
                              in Hoc? prōductum = null,
                              in string error = string.Empty)
    {
      await ExsistitAsync(prōductum: prōductum, error: error);
      Assert.That.IsTrue(comparātor.Equals(prōductum, tentandum), error);
    }

    public void Aequātur<Hoc>(in Hoc tentandum, in Hoc? prōductum = null,
                              in string error = string.Empty)
              where Hoc : IEquatable<Hoc>
    {
      await ExsistitAsync(prōductum: prōductum, error: error);
      Assert.That.AreEqual(prōductum, tentandum, error);
    }

    public void Differtur(in int tentandus, in Numerus? numerus = null, in string error = string.Empty)
       => await DifferturAsync(tentandum: tentandus, prōductum: numerus?.Minūtal, error: error);

    public void Differtur(in string scrīptum, in Verbum? verbum = null,
                          in string error = string.Empty)
    {
      await ExsistitAsync(verbum: verbum, error: error);
      Assert.That.AreNotEqual(verbum.Scrīptum, scrīptum,
                              StringComparison.OrdinalIgnoreCase, error);
    }

    public void Differtur<Hoc>(in IEqualityComparer<Hoc> comparātor, in Hoc tentandum,
                               in Hoc? prōductum = null,
                               in string error = string.Empty)
    {
      await ExsistitAsync(prōductum: prōductum, error: error);
      Assert.That.IsFalse(comparātor.Equals(prōductum, tentandum), error);
    }

    public void Differtur<Hoc>(in Hoc tentandum, in Hoc? prōductum = null,
                               in string error = string.Empty)
              where Hoc : IEquatable<Hoc>
    {
      await ExsistitAsync(prōductum: prōductum, error: error);
      Assert.That.AreNotEqual(prōductum, tentandum, error);
    }

    public void Interest(in int tentandus, in Numerus? numerus = null, in string error = string.Empty)
       => await InterestAsync(tentandum: tentandus, prōductum: numerus?.Minūtal, error: error);

    public void Interest<Hoc>(in IComparer<Hoc> comparātor, in Tuple<Hoc, Hoc> tentanda,
                              in Hoc? prōductum = null,
                              in string error = string.Empty)
    {
      await ExsistitAsync(prōductum: prōductum, error: error);
      Assert.That.IsTrue(prōductum.IsBetween(tentanda, comparātor, false), error);
    }

    public void Interest<Hoc>(in Tuple<Hoc, Hoc> tentandum, in Hoc? prōductum = null,
                              in string error = string.Empty)
              where Hoc : IComparable<Hoc>
    {
      await ExsistitAsync(prōductum: prōductum, error: error);
      Assert.That.IsTrue(prōductum.IsBetween(tentandum, false), error);
    }

    public void Extrādest(in int tentandus, in Numerus? numerus = null, in string error = string.Empty)
       => await ExtrādestAsync(tentandum: tentandus, prōductum: numerus?.Minūtal, error: error);

    public void Extrādest<Hoc>(in IComparer<Hoc> comparātor, in Tuple<Hoc, Hoc> tentanda,
                               in Hoc? prōductum = null,
                               in string error = string.Empty)
    {
      await ExsistitAsync(prōductum: prōductum, error: error);
      Assert.That.IsFalse(prōductum.IsBetween(tentanda, comparātor, false), error);
    }

    public void Extrādest<Hoc>(in Tuple<Hoc, Hoc> tentandum, in Hoc? prōductum = null,
                              in string error = string.Empty)
              where Hoc : IComparable<Hoc>
    {
      await ExsistitAsync(prōductum: prōductum, error: error);
      Assert.That.IsFalse(prōductum.IsBetween(tentandum, false), error);
    }

    public void Subest(in int tentandus, in Numerus? numerus = null, in string error = string.Empty)
       => await SubestAsync(tentandum: tentandus, prōductum: numerus?.Minūtal, error: error);

    public void Subest<Hoc>(in IComparer<Hoc> comparātor, in Hoc tentandum,
                            in Hoc? prōductum = null,
                            in string error = string.Empty)
    {
      await ExsistitAsync(prōductum: prōductum, error: error);
      Assert.That.IsTrue(comparātor.Compare(prōductum, tentandum) < 0, error);
    }

    public void Subest<Hoc>(in Hoc tentandum, in Hoc? prōductum = null,
                            in string error = string.Empty)
              where Hoc : IComparable<Hoc>
    {
      await ExsistitAsync(prōductum: prōductum, error: error);
      Assert.That.IsTrue(prōductum < tentandum, error);
    }

    public void Superest(in int tentandus, in Numerus? numerus = null, in string error = string.Empty)
       => await SuperestAsync(tentandum: tentandus, prōductum: numerus?.Minūtal, error: error);

    public void Superest<Hoc>(in IComparer<Hoc> comparātor, in Hoc tentandum,
                              in Hoc? prōductum = null,
                              in string error = string.Empty)
    {
      await ExsistitAsync(prōductum: prōductum, error: error);
      Assert.That.IsTrue(comparātor.Compare(prōductum, tentandum) > 0, error);
    }

    public void Superest<Hoc>(in Hoc tentandum, in Hoc? prōductum = null,
                              in string error = string.Empty)
              where Hoc : IComparable<Hoc>
    {
      await ExsistitAsync(prōductum: prōductum, error: error);
      Assert.That.IsTrue(prōductum > tentandum, error);
    }

    public void InterestAequāturve(in int tentandus, in Numerus? numerus = null, in string error = string.Empty)
       => await InterestAequāturveAsync(tentandum: tentandus, prōductum: numerus?.Minūtal, error: error);

    public void InterestAequāturve<Hoc>(in IComparer<Hoc> comparātor, in Tuple<Hoc, Hoc> tendanda,
                                        in Hoc? prōductum = null,
                                        in string error = string.Empty)
    {
      await ExsistitAsync(prōductum: prōductum, error: error);
      Assert.That.IsTrue(prōductum.IsBetween(tendanda, comparātor, true), error);
    }

    public void InterestAequāturve<Hoc>(in Tuple<Hoc, Hoc> tentanda, in Hoc? prōductum = null,
                                        in string error = string.Empty)
              where Hoc : IComparable<Hoc>
    {
      await ExsistitAsync(prōductum: prōductum, error: error);
      Assert.That.IsTrue(prōductum.IsBetween(tentanda, true), error);
    }

    public void ExtrādestAequāturve(in int tentandus, in Numerus? numerus = null, in string error = string.Empty)
       => await ExtrādestAequāturveAsync(tentandum: tentandus, prōductum: numerus?.Minūtal, error: error);

    public void ExtrādestAequāturve<Hoc>(in IComparer<Hoc> comparātor, in Tuple<Hoc, Hoc> tentanda,
                                        in Hoc? prōductum = null,
                                        in string error = string.Empty)
    {
      await ExsistitAsync(prōductum: prōductum, error: error);
      Assert.That.IsFalse(prōductum.IsBetween(tentanda, comparātor, true), error);
    }

    public void ExtrādestAequāturve<Hoc>(in Tuple<Hoc, Hoc> tentanda, in Hoc? prōductum = null,
                                        in string error = string.Empty)
              where Hoc : IComparable<Hoc>
    {
      await ExsistitAsync(prōductum: prōductum, error: error);
      Assert.That.IsFalse(prōductum.IsBetween(tentanda, true), error);
    }

    public void SubestAequāturve(in int tentandus, in Numerus? numerus = null, in string error = string.Empty)
       => await SubestAequāturveAsync(tentandum: tentandus, prōductum: numerus?.Minūtal, error: error);

    public void SubestAequāturve<Hoc>(in IComparer<Hoc> comparātor, in Hoc tentandum,
                                      in Hoc? prōductum = null,
                                      in string error = string.Empty)
    {
      await ExsistitAsync(prōductum: prōductum, error: error);
      Assert.That.IsTrue(comparātor.Compare(prōductum, tentandum) <= 0, error);
    }

    public void SubestAequāturve<Hoc>(in Hoc tentandum, in Hoc? prōductum = null,
                                      in string error = string.Empty)
              where Hoc : IComparable<Hoc>
    {
      await ExsistitAsync(prōductum: prōductum, error: error);
      Assert.That.IsTrue(prōductum <= tentandum, error);
    }

    public void SuperestAequāturve(in int tentandus, in Numerus? numerus = null, in string error = string.Empty)
       => await SuperestAequāturveAsync(tentandum: tentandus, prōductum: numerus?.Minūtal, error: error);

    public void SuperestAequāturve<Hoc>(in IComparer<Hoc> comparātor, in Hoc tentandum,
                                        in Hoc? prōductum = null,
                                        in string error = string.Empty)
    {
      await ExsistitAsync(prōductum: prōductum, error: error);
      Assert.That.IsTrue(comparātor.Compare(prōductum, tentandum) >= 0, error);
    }

    public void SuperestAequāturve<Hoc>(in Hoc tentandum, in Hoc? prōductum = null,
                                        in string error = string.Empty)
              where Hoc : IComparable<Hoc>
    {
      await ExsistitAsync(prōductum: prōductum, error: error);
      Assert.That.IsTrue(prōductum >= tentandum, error);
    }
  }
}
