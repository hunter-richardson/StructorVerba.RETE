using System;
using System.Linq;
using System.Threading.Tasks.Task;

using Nūntiī.Nūntius;
using Praebeunda.Simplicia.Numerus;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.LazyAttribute;
using RomanNumerals.RomanNumeral;

namespace Miscella
{
  [Lazy]
  [AsyncOverloads]
  public sealed partial class Numerātor
  {
    private readonly Lazy<Nūntius> Nūntius = new Lazy<Nūntius<Numerātor>>();
    private readonly Func<string, Task<double?>> Lēctor = async verbum =>
    {
      int? numerus = null;
      if (!Numeral.TryParse(verbum, out numerus))
      {
        Int32.TryParse(verbum, out numerus);
      }
      return numerus?.IsBetween(Numerus.Minimus.Item1, Numerus.Maximus.Item1)
                     .Choose(numerus, null);
    };

    public readonly Predicate<string> Numerābile = verbum => await Lēctor.Invoke(verbum) is not null;
    public readonly Func<Task<Numerus?>> FortisGenerātor
        = Numerus.Generātor.Invoke(Enumerable.Range(Numerus.Mininus.Item1, Numerus.Maximus.Item1).Random());
    public readonly Func<string, Task<Frāctus?>> Generātor = async verbum =>
    {
      const double? numerus = await Lēctor.Invoke(verbum);
      return (numerus is not null)
                .Choose(Frāctus.Generātor.Invoke(numerus), null);
    };

    private Numerātor() => Nūntius.PlūsGarriōAsync("Fīō");
  }
}
