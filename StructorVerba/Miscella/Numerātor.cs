using System;
using System.Threading.Tasks.Task;

using Nūntiī.Nūntius;
using Praebeunda.Simplicia.Numerus;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.SingletonAttribute;
using RomanNumerals.RomanNumeral;

namespace Miscella
{
  [Singleton]
  [AsyncOverloads]
  public sealed partial class Numerātor
  {
    public static readonly Lazy<Numerātor> Faciendum = new Lazy(() => Instance);

    private readonly Lazy<Nūntius> Nūntius = new Lazy<Nūntius<Numerātor>>();
    private readonly Func<string, Task<int?>> Lēctor = async verbum =>
    {
      int? numerus = null;
      if (!RomanNumeral.TryParse(verbum, out numerus))
      {
        Int32.TryParse(verbum, out numerus);
      }
      return numerus?.IsBetween(Numerus.Minimum.Item1, Numerus.Maximum.Item1)
                     .Choose(numerus, null);
    };

    public readonly Predicate<string> Numerābile = verbum => await Lēctor.Invoke(verbum) is not null;
    public readonly Func<Task<Numerus?>> FortisGenerātor = Generātor.Invoke(IEnumerable.Range(Numerus.Mininum.Item1, Numerus.Maximum.Item1).Random());
    public readonly Func<string, Task<Numerus?>> Generātor = async verbum =>
    {
      const int? numerus = await Lēctor.Invoke(verbum);
      return (numerus is not null)
                .Choose(Numerus.Generātor.Invoke(numerus), null);
    };

    private Numerātor() => Nūntius.PlūsGarriōAsync("Fīō");
  }
}
