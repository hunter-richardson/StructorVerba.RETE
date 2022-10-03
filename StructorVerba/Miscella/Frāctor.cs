using System;
using System.Linq;

using Praebeunda.Simplicia;

using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Miscella
{
  [Lazy]
  public sealed partial class Frāctor
  {
    private readonly Lazy<Nūntius> Nūntius = new Lazy<Nūntius<Frāctor>>();
    private readonly Func<string, Task<double?>> Lēctor = async verbum =>
    {
      int? numerus = null;
      if (!Fraction.TryParse(verbum, out numerus))
      {
        Double.TryParse(verbum, out numerus);
      }
      return numerus?.IsBetween(Numerus.Minimum.Item1, Numerus.Maximum.Item1)
                     .Choose(numerus, null);
    };

    public readonly Predicate<string> Numerābile = verbum => await Lēctor.Invoke(verbum) is not null;
    public readonly Func<Task<Frāctus?>> FortisGenerātor
        = Frāctus.Generātor.Invoke(Enumerable.Range(Numerus.Mininum.Item1, Numerus.Maximum.Item1).Random().Cast<double>() - new Random().NextDouble());
    public readonly Func<string, Task<Frāctus?>> Generātor = async verbum =>
    {
      const int? numerus = await Lēctor.Invoke(verbum);
      return (numerus is not null)
                .Choose(Frāctus.Generātor.Invoke(numerus), null);
    };

    private Frāctor() => Nūntius.PlūsGarriōAsync("Fīō");
  }
}
