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
      double? frāctus = null;
      if (!Fraction.TryParse(verbum, out numerus))
      {
        Double.TryParse(verbum, out numerus);
      }
      return frāctus?.IsBetween(Frāctus.Minimus.Item1, Frāctus.Maximus.Item1)
                     .Choose(numerus, null);
    };

    public readonly Predicate<string> Numerābile = verbum => await Lēctor.Invoke(verbum) is not null;
    public readonly Func<Task<Frāctus?>> FortisGenerātor
        = Frāctus.Generātor.Invoke(Enumerable.Range(Numerus.Mininus.Item1, Numerus.Maximus.Item1).Random().Cast<double>() - new Random().NextDouble());
    public readonly Func<string, Task<Frāctus?>> Generātor = async verbum =>
    {
      const int? numerus = await Lēctor.Invoke(verbum);
      return (numerus is not null)
                .Choose(Frāctus.Generātor.Invoke(numerus), null);
    };

    private Frāctor() => Nūntius.PlūsGarriōAsync("Fīō");
  }
}
