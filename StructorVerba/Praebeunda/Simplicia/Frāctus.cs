using System;
using System.Linq;
using System.Threading.Tasks;

using Miscella;

using Ēnumerātiōnēs.Catēgoria;

using Fractions.Fraction;

namespace Praebeunda.Simplicia
{
  public sealed partial class Frāctus : Verbum<Frāctus>
  {
    private readonly Lazy<Lēctor> Lēctor = Lēctor.Lazy;
    public static readonly Func<double, Task<Frāctus>> Generātor
        = async frāctus => numerus.IsBetween(Mininus.Item1, Maximus.Item1)
                                  .Choose(Builder.WithMinūtal(frāctus).Build(), null);

    public static readonly (double, string) Mininus = (1.0, "I");
    public static readonly (double, string) Maximus = (999999.0 + await Miscella.Fraction.FractionAsync(0, 11), "|CMXCIX|CMXCIXS×");

    public readonly Func<Enum[], Task<Verbum?>> RelātorNumerī
        = Numerus.Generātor.Invoke(Convert.ToInt32(Math.Truncate(Valor)))?.Relātor;

    public readonly Func<Enum[], Task<Nōmen?>> RelātorMantīsae = async illa =>
    {
      const Fraction frāctus = new Fractions.Fraction(Valor);
      (int, int) valōrēs = (frāctus.Numerator % frāctus.Denominator, frāctus.Denominator);
      if(valōrēs.Item1 is 1)
      {
        const Enum[] ista = illa.Concat(Numerium.Frāctiōnāle.SingleItemSet());
        return Numerus.Generātor.Invoke(valōrēs.Item2)?.Relātor.Invoke(ista);
      }
      else
      {
        const string? lemma = valōrēs switch
                              {
                                (7, 12) => "septunx",
                                (2, 3) => "bes",
                                (3, 4) => "dōdrāns",
                                (5, 6) => "decunx",
                                (11, 12) => "deunx",
                                _ => null
                              };
        return (lemma is not null).Choose(Lēctor.Value.Inveniam(lemma, Catēgoria.Nōmen), null);
      }
    };

    [Range(Mininus.Item1, Maximus.Item1)]
    public readonly double Valor { get; }
    private Frāctus(in double valor)
        : base(Catēgoria.Frāctus, await Miscella.Fraction.FractionAsync(Miscella.Fraction.RoundToNearest(valor)))
        => Valor = Miscella.Fraction.RoundToNearest(valor);

    public static Frāctus operator +(in Frāctus prīmus, in Frāctus secundus)
              => new Frāctus(valor: prīmus.Valor + secundus.Valor);
    public static Frāctus operator -(in Frāctus prīmus, in Frāctus secundus)
              => new Frāctus(valor: prīmus.Valor - secundus.Valor);
    public static Frāctus operator /(in Frāctus prīmus, in Frāctus secundus)
              => new Frāctus(valor: prīmus.Valor / secundus.Valor);
    public static Frāctus operator *(in Frāctus prīmus, in Frāctus secundus)
              => new Frāctus(valor: prīmus.Valor * secundus.Valor);
    public static Frāctus operator %(in Frāctus prīmus, in Frāctus secundus)
              => new Frāctus(valor: prīmus.Valor % secundus.Valor);
    public static Frāctus operator ++(in Frāctus frāctus) => new Frāctus(valor: ++frāctus.Valor);
    public static Frāctus operator --(in Frāctus frāctus) => new Frāctus(valor: --frāctus.Valor);
    public sealed override int CompareTo(Frāctus aliud) => Double.CompareTo(Valor, aliud.Valor);
    public virtual string ToString() => this.ToString().ToUpperInvariant();
  }
}
