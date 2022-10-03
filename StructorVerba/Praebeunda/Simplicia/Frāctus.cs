using Miscella;

using Ēnumerātiōnēs.Catēgoria;

namespace Praebeunda.Simplicia
{
  public sealed partial class Frāctus : Verbum<Frāctus>
  {
    public static readonly Func<int, Task<Frāctus>> Generātor
        = async numerus => numerus.IsBetween(Mininum.Item1, Maximum.Item1)
                                  .Choose(Builder.WithMinūtal(numerus).Build(), null);

    public static readonly (double, string) Mininum = (1.0, "I");
    public static readonly (double, string) Maximum = (999999.0 + (11.0 / 12.0), "|CMXCIX|CMXCIXS×");

    [Range(Mininum.Item1, Maximum.Item1)]
    public readonly double Valor { get; }
    private Frāctus(in double valor)
        : base(Catēgoria.Frāctus, await Fraction.FractionAsync(valor))
        => Valor = valor;

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
    public sealed override int CompareTo(Frāctus aliud) => Valor.CompareTo(aliud.Valor);
    public virtual string ToString() => this.ToString().ToUpperInvariant();
  }
}
