using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Praebeunda.Verbum;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttributes;

namespace Tentāmina
{
  [AsyncOverloads]
  public sealed partial class TentāmenReī<Hoc>
  {
    public static sealed void Exsistat(in Hoc? prōductum, in string error = string.Empty)
              => new TentāmenReī(prōductum: prōductum)
                        .Exsistat(error: error);
    public static sealed void Vacat(in Hoc? prōductum, in string error = string.Empty)
              => new TentāmenReī(prōductum: prōductum)
                        .Vacat(error: error);
    public static sealed void Aequētur(in IEqualityComparer<Hoc> comparātor,
                                       in Hoc tentandum, in Hoc? prōductum = null,
                                       in string error = string.Empty)
              => new TentāmenReī(prōductum: prōductum)
                        .Aequētur(tentandum: tentandum, comparātor: comparātor, error: error);
    public static sealed void Differātur(in IEqualityComparer<Hoc> comparātor,
                                         in Hoc tentandum, in Hoc? prōductum = null,
                                         in string error = string.Empty)
              => new TentāmenReī(prōductum: prōductum)
                        .Differātur(tentandum: tentandum, comparātor: comparātor, error: error);
    public static sealed void Intersit(in IComparer<Hoc> comparātor,
                                       in Hoc tentandum, in Hoc? prōductum = null,
                                       in string error = string.Empty)
              => new TentāmenReī(prōductum: prōductum)
                        .Intersit(tentandum: tentandum, comparātor: comparātor, error: error);
    public static sealed void Extrāsit(in IComparer<Hoc> comparātor,
                                       in Hoc tentandum, in Hoc? prōductum = null,
                                       in string error = string.Empty)
              => new TentāmenReī(prōductum: prōductum)
                        .Extrāsit(tentandum: tentandum, comparātor: comparātor, error: error);
    public static sealed void Subsit(in IComparer<Hoc> comparātor,
                                     in Hoc tentandum, in Hoc? prōductum = null,
                                     in string error = string.Empty)
              => new TentāmenReī(prōductum: prōductum)
                        .Subsit(tentandum: tentandum, comparātor: comparātor, error: error);
    public static sealed void Supersit(in IComparer<Hoc> comparātor,
                                       in Hoc tentandum, in Hoc? prōductum = null,
                                       in string error = string.Empty)
              => new TentāmenReī(prōductum: prōductum)
                        .Supersit(tentandum: tentandum, comparātor: comparātor, error: error);
    public static sealed void IntersitAequāturve(in IComparer<Hoc> comparātor,
                                                 in Hoc tentandum, in Hoc? prōductum = null,
                                                 in string error = string.Empty)
              => new TentāmenReī(prōductum: prōductum)
                        .IntersitAequāturve(tentandum: tentandum, comparātor: comparātor, error: error);
    public static sealed void ExtrāsitAequāturve(in IComparer<Hoc> comparātor,
                                                 in Hoc tentandum, in Hoc? prōductum = null,
                                                 in string error = string.Empty)
              => new TentāmenReī(prōductum: prōductum)
                        .ExtrāsitAequāturve(tentandum, comparātor: comparātor, error: error);
    public static sealed void SubsitAequāturve(in IComparer<Hoc> comparātor,
                                               in Hoc tentandum, in Hoc? prōductum = null,
                                               in string error = string.Empty)
              => new TentāmenReī(prōductum: prōductum)
                        .SubsitAequāturve(tentandum: tentandum, comparātor: comparātor, error: error);
    public static sealed void SupersitAequāturve(in IComparer<Hoc> comparātor,
                                                 in Hoc tentandum, in Hoc? prōductum = null,
                                                 in string error = string.Empty)
              => new TentāmenReī(prōductum: prōductum)
                        .SupersitAequāturve(tentandum: tentandum, comparātor: comparātor, error: error);
    public static sealed void Aequētur(in Hoc tentandum, in Hoc? prōductum = null,
                                       in string error = string.Empty) where Hoc : IEquatable<Hoc>
              => new TentāmenReī(prōductum: prōductum)
                        .Aequētur(tentandum: tentandum, error: error);
    public static sealed void Differātur(in Hoc tentandum, in Hoc? prōductum = null,
                                         in string error = string.Empty) where Hoc : IEquatable<Hoc>
              => new TentāmenReī(prōductum: prōductum)
                        .Differātur(tentandum: tentandum, error: error);
    public static sealed void Intersit(in Tuple<Hoc, Hoc> tentandum, in Hoc? prōductum = null,
                                       in string error = string.Empty) where Hoc : IComparable<Hoc>
              => new TentāmenReī(prōductum: prōductum)
                        .Intersit(tentandum: tentandum, error: error);
    public static sealed void Extrāsit(in Tuple<Hoc, Hoc> tentandum, in Hoc? prōductum = null,
                                       in string error = string.Empty) where Hoc : IComparable<Hoc>
              => new TentāmenReī(prōductum: prōductum)
                        .Extrāsit(tentandum: tentandum, error: error);
    public static sealed void Subsit(in Hoc tentandum, in Hoc? prōductum = null,
                                     in string error = string.Empty) where Hoc : IComparable<Hoc>
              => new TentāmenReī(prōductum: prōductum)
                        .Subsit(tentandum: tentandum, error: error);
    public static sealed void Supersit(in Hoc tentandum, in Hoc? prōductum = null,
                                       in string error = string.Empty) where Hoc : IComparable<Hoc>
              => new TentāmenReī(prōductum: prōductum)
                        .Supersit(tentandum: tentandum, error: error);
    public static sealed void IntersitAequāturve(in Tuple<Hoc, Hoc> tentanda, in Hoc? prōductum = null,
                                                 in string error = string.Empty) where Hoc : IComparable<Hoc>
              => new TentāmenReī(prōductum: prōductum)
                        .IntersitAequāturve(tentanda: tentanda, error: error);
    public static sealed void ExtrāsitAequāturve(in Tuple<Hoc, Hoc> tentanda, in Hoc? prōductum = null,
                                                 in string error = string.Empty) where Hoc : IComparable<Hoc>
              => new TentāmenReī(prōductum: prōductum)
                        .ExtrāsitAequāturve(tentanda: tentanda, error: error);
    public static sealed void SubsitAequāturve(in Hoc tentandum, in Hoc? prōductum = null,
                                               in string error = string.Empty) where Hoc : IComparable<Hoc>
              => new TentāmenReī(prōductum: prōductum)
                        .SubsitAequāturve(tentandum: tentandum, error: error);
    public static sealed void SupersitAequāturve(in Hoc tentandum, in Hoc? prōductum = null,
                                                 in string error = string.Empty) where Hoc : IComparable<Hoc>
              => new TentāmenReī(prōductum: prōductum)
                        .SupersitAequāturve(tentandum: tentandum, error: error);

    private readonly Hoc? Prōductum { get; }

    public TentāmenReī(in Hoc? prōductum = null)
              => Prōductum = prōductum;

    public sealed void Exsistat(in string error = string.Empty)
              => Assert.That.IsNotNull(Prōductum, error);
    public sealed void Vacat(in string error = string.Empty)
              => Assert.That.IsNull(Prōductum, error);

    public sealed void Aequētur(in Hoc tentandum, in IEqualityComparer<Hoc> comparātor,
                                in string error = string.Empty)
    {
      Exsistat(error: error);
      Assert.That.IsTrue(comparātor.Equals(prōductum, tentandum), error);
    }

    public sealed void Differātur(in Hoc tentandum, in IEqualityComparer<Hoc> comparātor,
                                  in string error = string.Empty)
    {
      Exsistat(error: error);
      Assert.That.IsFalse(comparātor.Equals(prōductum, tentandum), error);
    }

    public sealed void Intersit(in Tuple<Hoc, Hoc> tentanda, in IComparer<Hoc> comparātor,
                                in string error = string.Empty)
    {
      Exsistat(error: error);
      Assert.That.IsTrue(prōductum.IsBetween(tentanda, comparātor, false), error);
    }

    public sealed void Extrāsit(in Tuple<Hoc, Hoc> tentanda, in IComparer<Hoc> comparātor,
                                in string error = string.Empty)
    {
      Exsistat(error: error);
      Assert.That.IsFalse(prōductum.IsBetween(tentanda, comparātor, false), error);
    }

    public sealed void Subsit(in Hoc tentandum, in IComparer<Hoc> comparātor,
                              in string error = string.Empty)
    {
      Exsistat(error: error);
      Assert.That.IsTrue(comparātor.Compare(prōductum, tentandum) < 0, error);
    }

    public sealed void Supersit(in Hoc tentandum, in IComparer<Hoc> comparātor,
                                in string error = string.Empty)
    {
      Exsistat(error: error);
      Assert.That.IsTrue(comparātor.Compare(prōductum, tentandum) > 0, error);
    }

    public sealed void IntersitAequāturve(in Tuple<Hoc, Hoc> tendanda, in IComparer<Hoc> comparātor,
                                          in string error = string.Empty)
    {
      Exsistat(error: error);
      Assert.That.IsTrue(prōductum.IsBetween(tendanda, comparātor, true), error);
    }

    public sealed void ExtrāsitAequāturve(in Tuple<Hoc, Hoc> tentanda, in IComparer<Hoc> comparātor,
                                          in string error = string.Empty)
    {
      Exsistat(error: error);
      Assert.That.IsFalse(prōductum.IsBetween(tentanda, comparātor, true), error);
    }

    public sealed void SubsitAequāturve(in Hoc tentandum, in IComparer<Hoc> comparātor,
                                        in string error = string.Empty)
    {
      Exsistat(error: error);
      Assert.That.IsTrue(comparātor.Compare(prōductum, tentandum) <= 0, error);
    }

    public sealed void SupersitAequāturve(in Hoc tentandum, in IComparer<Hoc> comparātor,
                                          in string error = string.Empty)
    {
      Exsistat(error: error);
      Assert.That.IsTrue(comparātor.Compare(prōductum, tentandum) >= 0, error);
    }

    public sealed void Aequētur(in Hoc tentandum,
                                in string error = string.Empty)
              where Hoc : IEquatable<Hoc>
    {
      Exsistat(error: error);
      Assert.That.AreEqual(prōductum, tentandum, error);
    }

    public sealed void Differātur(in Hoc tentandum,
                                  in string error = string.Empty)
              where Hoc : IEquatable<Hoc>
    {
      Exsistat(error: error);
      Assert.That.AreNotEqual(prōductum, tentandum, error);
    }

    public sealed void Intersit(in Tuple<Hoc, Hoc> tentandum,
                                in string error = string.Empty)
              where Hoc : IComparable<Hoc>
    {
      Exsistat(error: error);
      Assert.That.IsTrue(prōductum.IsBetween(tentandum, false), error);
    }

    public sealed void Extrāsit(in Tuple<Hoc, Hoc> tentandum,
                                in string error = string.Empty)
              where Hoc : IComparable<Hoc>
    {
      Exsistat(error: error);
      Assert.That.IsFalse(prōductum.IsBetween(tentandum, false), error);
    }

    public sealed void Subsit(in Hoc tentandum,
                              in string error = string.Empty)
              where Hoc : IComparable<Hoc>
    {
      Exsistat(error: error);
      Assert.That.IsTrue(prōductum < tentandum, error);
    }

    public sealed void Supersit(in Hoc tentandum,
                                in string error = string.Empty)
              where Hoc : IComparable<Hoc>
    {
      Exsistat(error: error);
      Assert.That.IsTrue(prōductum > tentandum, error);
    }

    public sealed void IntersitAequāturve(in Tuple<Hoc, Hoc> tentanda,
                                          in string error = string.Empty)
              where Hoc : IComparable<Hoc>
    {
      Exsistat(error: error);
      Assert.That.IsTrue(prōductum.IsBetween(tentanda, true), error);
    }

    public sealed void ExtrāsitAequāturve(in Tuple<Hoc, Hoc> tentanda,
                                          in string error = string.Empty)
              where Hoc : IComparable<Hoc>
    {
      Exsistat(error: error);
      Assert.That.IsFalse(prōductum.IsBetween(tentanda, true), error);
    }

    public sealed void SubsitAequāturve(in Hoc tentandum,
                                        in string error = string.Empty)
              where Hoc : IComparable<Hoc>
    {
      Exsistat(error: error);
      Assert.That.IsTrue(prōductum <= tentandum, error);
    }

    public sealed void SupersitAequāturve(in Hoc tentandum,
                                          in string error = string.Empty)
              where Hoc : IComparable<Hoc>
    {
      Exsistat(error: error);
      Assert.That.IsTrue(prōductum >= tentandum, error);
    }
  }
}
