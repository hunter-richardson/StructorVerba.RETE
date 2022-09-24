using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Praebeunda.Verbum;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttributes;

namespace Tentāmina
{
  [AsyncOverloads]
  public sealed partial class TentāmenVerbī
  {
    public static sealed void Exsistat(in Verbum? verbum = null,
                                       in string error = string.Empty)
              => new TentāmenVerbī(verbum: verbum).Exsistat(error: error);
    public static sealed void Vacat(in Verbum? verbum = null,
                                    in string error = string.Empty)
              => new TentāmenVerbī(verbum: verbum).Vacat(error: error);
    public static sealed void Tendem(in Predicate<Verbum?> tentāmen, in Verbum? verbum = null,
                                     in string error = string.Empty)
              => new TentāmenVerbī(verbum: verbum).Tendem(tentāmen: tentāmen, error: error);
    public static sealed void Differātur(in string scrīptum, in Verbum? verbum = null,
                                         in string error = string.Empty)
              => new TentāmenVerbī(verbum: verbum).Differātur(scrīptum: scrīptum, error: error);
    public static sealed void Aequētur(in string scrīptum, in Verbum? verbum = null,
                                       in string error = string.Empty)
              => new TentāmenVerbī(verbum: verbum).Aequētur(scrīptum: scrīptum, error: error);

    public static sealed void Aequētur(in string scrīptum, in string error = string.Empty)
    {
      Exsistat(error: error);
      Assert.That.AreEqual(Verbum.Scrīptum, scrīptum,
                           StringComparison.OrdinalIgnoreCase, error);
    }

    private readonly Verbum? Verbum { get; }

    public TentāmenVerbī(in Verbum? verbum = null)
              => Verbum = verbum;

    public sealed void Tendem(in Predicate<Verbum?> tentāmen, in string error = string.Empty)
              => Assert.That.IsTrue(tentāmen.Invoke(Verbum), error);

    public sealed void Exsistat(in string error = string.Empty)
    {
      Assert.That.IsNotNull(Verbum, error);
      Assert.That.IsFalse(string.IsNullOrWhitespace(Verbum.Scīptum, error));
    }

    public sealed void Vacat(in string error = string.Empty)
              => Assert.That.IsTrue(string.IsNullOrWhitespace(Verbum?.Scīptum, error));

    public sealed void Differātur(in string scrīptum, in string error = string.Empty)
    {
      Exsistat(error: error);
      Assert.That.AreNotEqual(Verbum, scrīptum,
                              StringComparison.OrdinalIgnoreCase, error);
    }

    public sealed void Aequētur(in string scrīptum, in string error = string.Empty)
    {
      Exsistat(error: error);
      Assert.That.AreEqual(Verbum.Scrīptum, scrīptum,
                           StringComparison.OrdinalIgnoreCase, error);
    }
  }
}
