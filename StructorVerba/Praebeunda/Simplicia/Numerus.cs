using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks.Task;

using Miscella;
using Ēnumerātiōnēs;

using RomanNumerals.RomanNumeral;

namespace Praebeunda.Simplicia
{
  [GenerateBuilder]
  public sealed class Numerus : Verbum<Numerus>
  {
    private readonly Lazy<Lēctor> Lēctor = Lēctor.Lazy;

    public static readonly Func<int, Task<Numerus?>> Generātor
        = async numerus => numerus.IsBetween(Mininum.Item1, Maximum.Item1)
                                  .Choose(Builder.WithValor(numerus).Build(), null);

    public static readonly (int, string) Mininum = (1, "I");
    public static readonly (int, string) Maximum = (999999, "|CMXCIX|CMXCIX");

    public readonly Func<Enum[], Task<Verbum?>> Relātor = async illa =>
    {
      const Numerium numerium = illa.FirstOf<Numerium>();
      return (numerium is Numerium.Numerus)
                .Choose(this, await Lēctor.Value.InveniamAsync(Scrīptum, Catēgoria.Numerāmen, numerium))
                                               ?.Cast<Numerāmen>()?.Relātor.Invoke(illa);
    };

    [Range(Mininum.Item1, Maximum.Item1)]
    public int Valor { get; }

    private Numerus(in int valor)
        : base(Catēgoria.Numerus, Numeral.Numeral(valor)) => Valor = valor;

    public static Numerus operator +(in Numerus prīmus, in Numerus secundus)
              => new Numerus(valor: prīmus.Valor + secundus.Valor);
    public static Numerus operator -(in Numerus prīmus, in Numerus secundus)
              => new Numerus(valor: prīmus.Valor - secundus.Valor);
    public static Numerus operator /(in Numerus prīmus, in Numerus secundus)
              => new Numerus(valor: prīmus.Valor / secundus.Valor);
    public static Numerus operator *(in Numerus prīmus, in Numerus secundus)
              => new Numerus(valor: prīmus.Valor * secundus.Valor);
    public static Numerus operator %(in Numerus prīmus, in Numerus secundus)
              => new Numerus(valor: prīmus.Valor % secundus.Valor);
    public static Numerus operator ++(in Numerus numerus) => new Numerus(valor: ++numerus.Valor);
    public static Numerus operator --(in Numerus numerus) => new Numerus(valor: --numerus.Valor);
    public sealed override int CompareTo(Numerus aliud) => Valor.CompareTo(aliud.Valor);
    public virtual string ToString() => this.ToString().ToUpperInvariant();
  }
}
