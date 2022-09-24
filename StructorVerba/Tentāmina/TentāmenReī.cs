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
              => new TentāmenReī(prōductum).Exsistat(error: error);
    public static sealed void Vacat(in Hoc? prōductum, in string error = string.Empty)
              => new TentāmenReī(prōductum).Vacat(error: error);
    public static sealed void Aequētur(in IEqualityComparer<Hoc> equalityComparer,
                                       in Hoc tendandum, in Hoc? prōductum = null,
                                       in string error = string.Empty)
              => new TentāmenReī(prōductum).Aequētur(tendandum, equalityComparer, error);
    public static sealed void Differātur(in IEqualityComparer<Hoc> equalityComparer,
                                         in Hoc tendandum, in Hoc? prōductum = null,
                                         in string error = string.Empty)
              => new TentāmenReī(prōductum).Differātur(tendandum, equalityComparer, error);
    public static sealed void Intersit(in IComparer<Hoc> equalityComparer,
                                       in Hoc tendandum, in Hoc? prōductum = null,
                                       in string error = string.Empty)
              => new TentāmenReī(prōductum).Intersit(tendandum, equalityComparer, error);
    public static sealed void Extrāsit(in IComparer<Hoc> equalityComparer,
                                       in Hoc tendandum, in Hoc? prōductum = null,
                                       in string error = string.Empty)
              => new TentāmenReī(prōductum).Extrāsit(tendandum, equalityComparer, error);
    public static sealed void Subsit(in IComparer<Hoc> equalityComparer,
                                     in Hoc tendandum, in Hoc? prōductum = null,
                                     in string error = string.Empty)
              => new TentāmenReī(prōductum).Subsit(tendandum, equalityComparer, error);
    public static sealed void Supersit(in IComparer<Hoc> equalityComparer,
                                       in Hoc tendandum, in Hoc? prōductum = null,
                                       in string error = string.Empty)
              => new TentāmenReī(prōductum).Supersit(tendandum, equalityComparer, error);
    public static sealed void IntersitAequāturve(in IComparer<Hoc> equalityComparer,
                                                 in Hoc tendandum, in Hoc? prōductum = null,
                                                 in string error = string.Empty)
              => new TentāmenReī(prōductum).IntersitAequāturve(tendandum, equalityComparer, error);
    public static sealed void ExtrāsitAequāturve(in IComparer<Hoc> equalityComparer,
                                                 in Hoc tendandum, in Hoc? prōductum = null,
                                                 in string error = string.Empty)
              => new TentāmenReī(prōductum).ExtrāsitAequāturve(tendandum, equalityComparer, error);
    public static sealed void SubsitAequāturve(in IComparer<Hoc> equalityComparer,
                                               in Hoc tendandum, in Hoc? prōductum = null,
                                               in string error = string.Empty)
              => new TentāmenReī(prōductum).SubsitAequāturve(tendandum, equalityComparer, error);
    public static sealed void SupersitAequāturve(in IComparer<Hoc> equalityComparer,
                                                 in Hoc tendandum, in Hoc? prōductum = null,
                                                 in string error = string.Empty)
              => new TentāmenReī(prōductum).SupersitAequāturve(tendandum, equalityComparer, error);
    public static sealed void Aequētur(in Hoc tendandum, in Hoc? prōductum = null,
                                       in string error = string.Empty) where Hoc : IEquatable<Hoc>
              => new TentāmenReī(prōductum).Aequētur(tendandum, error);
    public static sealed void Differātur(in Hoc tendandum, in Hoc? prōductum = null,
                                         in string error = string.Empty) where Hoc : IEquatable<Hoc>
              => new TentāmenReī(prōductum).Differātur(tendandum, error);
    public static sealed void Intersit(in Tuple<Hoc, Hoc> tendandum, in Hoc? prōductum = null,
                                       in string error = string.Empty) where Hoc : IComparable<Hoc>
              => new TentāmenReī(prōductum).Intersit(tendandum, equalityComparer, error);
    public static sealed void Extrāsit(in Tuple<Hoc, Hoc> tendandum, in Hoc? prōductum = null,
                                       in string error = string.Empty) where Hoc : IComparable<Hoc>
              => new TentāmenReī(prōductum).Extrāsit(tendandum, equalityComparer, error);
    public static sealed void Subsit(in Hoc tendandum, in Hoc? prōductum = null,
                                     in string error = string.Empty) where Hoc : IComparable<Hoc>
              => new TentāmenReī(prōductum).Subsit(tendandum, equalityComparer, error);
    public static sealed void Supersit(in Hoc tendandum, in Hoc? prōductum = null,
                                       in string error = string.Empty) where Hoc : IComparable<Hoc>
              => new TentāmenReī(prōductum).Supersit(tendandum, equalityComparer, error);
    public static sealed void IntersitAequāturve(in Tuple<Hoc, Hoc> tendandum, in Hoc? prōductum = null,
                                                 in string error = string.Empty) where Hoc : IComparable<Hoc>
              => new TentāmenReī(prōductum).IntersitAequāturve(tendandum, equalityComparer, error);
    public static sealed void ExtrāsitAequāturve(in Tuple<Hoc, Hoc> tendandum, in Hoc? prōductum = null,
                                                 in string error = string.Empty) where Hoc : IComparable<Hoc>
              => new TentāmenReī(prōductum).ExtrāsitAequāturve(tendandum, equalityComparer, error);
    public static sealed void SubsitAequāturve(in Hoc tendandum, in Hoc? prōductum = null,
                                               in string error = string.Empty) where Hoc : IComparable<Hoc>
              => new TentāmenReī(prōductum).SubsitAequāturve(tendandum, equalityComparer, error);
    public static sealed void SupersitAequāturve(in Hoc tendandum, in Hoc? prōductum = null,
                                                 in string error = string.Empty) where Hoc : IComparable<Hoc>
              => new TentāmenReī(prōductum).SupersitAequāturve(tendandum, equalityComparer, error);

    private readonly Hoc? Prōductum { get; }

    public TentāmenReī(in Hoc? prōductum = null)
              => Prōductum = prōductum;

    public sealed void Exsistat(in string error = string.Empty)
              => Assert.That.IsNotNull(Prōductum, error);
    public sealed void Vacat(in string error = string.Empty)
              => Assert.That.IsNull(Prōductum, error);

    public sealed void Aequētur(in Hoc tendandum, in IEqualityComparer<Hoc> equalityComparer,
                                in string error = string.Empty)
    {
      Exsistat(error: error);
      Assert.That.IsTrue(equalityComparer.Equals(prōductum, tendandum), error);
    }

    public sealed void Differātur(in Hoc tendandum, in IEqualityComparer<Hoc> equalityComparer,
                                  in string error = string.Empty)
    {
      Exsistat(error: error);
      Assert.That.IsFalse(equalityComparer.Equals(prōductum, tendandum), error);
    }

    public sealed void Intersit(in Tuple<Hoc, Hoc> tendanda, in IComparer<Hoc> comparer,
                                in string error = string.Empty)
    {
      Exsistat(error: error);
      Assert.That.IsTrue(prōductum.IsBetween(tendanda, comparer, false), error);
    }

    public sealed void Extrāsit(in Tuple<Hoc, Hoc> tendanda, in IComparer<Hoc> comparer,
                                in string error = string.Empty)
    {
      Exsistat(error: error);
      Assert.That.IsFalse(prōductum.IsBetween(tendanda, comparer, false), error);
    }

    public sealed void Subsit(in Hoc tendandum, in IComparer<Hoc> comparer,
                              in string error = string.Empty)
    {
      Exsistat(error: error);
      Assert.That.IsTrue(comparer.Compare(prōductum, tendandum) < 0, error);
    }

    public sealed void Supersit(in Hoc tendandum, in IComparer<Hoc> comparer,
                                in string error = string.Empty)
    {
      Exsistat(error: error);
      Assert.That.IsTrue(comparer.Compare(prōductum, tendandum) > 0, error);
    }

    public sealed void IntersitAequāturve(in Tuple<Hoc, Hoc> tendanda, in IComparer<Hoc> comparer,
                                          in string error = string.Empty)
    {
      Exsistat(error: error);
      Assert.That.IsTrue(prōductum.IsBetween(tendanda, comparer, true), error);
    }

    public sealed void ExtrāsitAequāturve(in Tuple<Hoc, Hoc> tendanda, in IComparer<Hoc> comparer,
                                          in string error = string.Empty)
    {
      Exsistat(error: error);
      Assert.That.IsFalse(prōductum.IsBetween(tendanda, comparer, true), error);
    }

    public sealed void SubsitAequāturve(in Hoc tendandum, in IComparer<Hoc> comparer,
                                        in string error = string.Empty)
    {
      Exsistat(error: error);
      Assert.That.IsTrue(comparer.Compare(prōductum, tendandum) <= 0, error);
    }

    public sealed void SupersitAequāturve(in Hoc tendandum, in IComparer<Hoc> comparer,
                                          in string error = string.Empty)
    {
      Exsistat(error: error);
      Assert.That.IsTrue(comparer.Compare(prōductum, tendandum) >= 0, error);
    }

    public sealed void Aequētur(in Hoc tendandum,
                                in string error = string.Empty)
              where Hoc : IEquatable<Hoc>
    {
      Exsistat(error: error);
      Assert.That.AreEqual(prōductum, tendandum, error);
    }

    public sealed void Differātur(in Hoc tendandum,
                                  in string error = string.Empty)
              where Hoc : IEquatable<Hoc>
    {
      Exsistat(error: error);
      Assert.That.AreNotEqual(prōductum, tendandum, error);
    }

    public sealed void Intersit(in Tuple<Hoc, Hoc> tendanda,
                                in string error = string.Empty)
              where Hoc : IComparable<Hoc>
    {
      Exsistat(error: error);
      Assert.That.IsTrue(prōductum.IsBetween(tendanda, false), error);
    }

    public sealed void Extrāsit(in Tuple<Hoc, Hoc> tendanda,
                                in string error = string.Empty)
              where Hoc : IComparable<Hoc>
    {
      Exsistat(error: error);
      Assert.That.IsFalse(prōductum.IsBetween(tendanda, false), error);
    }

    public sealed void Subsit(in Hoc tendandum,
                              in string error = string.Empty)
              where Hoc : IComparable<Hoc>
    {
      Exsistat(error: error);
      Assert.That.IsTrue(prōductum < tendandum, error);
    }

    public sealed void Supersit(in Hoc tendandum,
                                in string error = string.Empty)
              where Hoc : IComparable<Hoc>
    {
      Exsistat(error: error);
      Assert.That.IsTrue(prōductum > tendandum, error);
    }

    public sealed void IntersitAequāturve(in Tuple<Hoc, Hoc> tendanda,
                                          in string error = string.Empty)
              where Hoc : IComparable<Hoc>
    {
      Exsistat(error: error);
      Assert.That.IsTrue(prōductum.IsBetween(tendanda, true), error);
    }

    public sealed void ExtrāsitAequāturve(in Tuple<Hoc, Hoc> tendanda,
                                          in string error = string.Empty)
              where Hoc : IComparable<Hoc>
    {
      Exsistat(error: error);
      Assert.That.IsFalse(prōductum.IsBetween(tendanda, true), error);
    }

    public sealed void SubsitAequāturve(in Hoc tendandum,
                                        in string error = string.Empty)
              where Hoc : IComparable<Hoc>
    {
      Exsistat(error: error);
      Assert.That.IsTrue(prōductum <= tendandum, error);
    }

    public sealed void SupersitAequāturve(in Hoc tendandum,
                                          in string error = string.Empty)
              where Hoc : IComparable<Hoc>
    {
      Exsistat(error: error);
      Assert.That.IsTrue(prōductum >= tendandum, error);
    }
  }
}
