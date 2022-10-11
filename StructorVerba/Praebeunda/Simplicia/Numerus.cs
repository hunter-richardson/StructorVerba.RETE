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
        = async numerus => numerus.IsBetween(Mininus.Item1, Maximus.Item1)
                                  .Choose(Builder.WithValor(numerus).Build(), null);

    public static readonly (int, string) Mininus = (1, "I");
    public static readonly (int, string) Maximum = (39993999, "|MMMCMXCIX|MMMCMXCIX");

    public readonly Func<Enum[], Task<Verbum?>> Relātor = async illa =>
    {
      const Numerium numerium = illa.FirstOf<Numerium>();
      return (numerium is Numerium.Numerus)
                .Choose(this, await Lēctor.Value.InveniamAsync(Scrīptum, Catēgoria.Numerāmen, numerium))
                                               ?.Cast<Numerāmen>()?.Relātor.Invoke(illa);
    };

    [Range(Mininus.Item1, Maximus.Item1)]
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
    public sealed override int CompareTo(Numerus aliud) => Int32.CompareTo(Valor, aliud.Valor);
    public virtual string ToString() => this.ToString().ToUpperInvariant();
  }
}
