using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks.Task;

using Miscella.Extensions;

using RomanNumerals.RomanNumeral;

namespace Praebeunda.Simplicia
{
  [GenerateBuilder]
  public sealed class Numerus : Verbum<Numerus>
  {
    public static readonly Func<int, Task<Numerus>> Generātor
        = async numerus => numerus.IsBetween(Mininum.Item1, Maximum.Item1)
                                  .Choose(Builder.WithMinūtal(numerus).Build(), null);

    public static readonly (int, string) Mininum = (1, "I");
    public static readonly (int, string) Maximum = (3999, "MMMCMXCIX");

    private Numerus([Range(Mininum.Item1, Maximum.Item1)] in int minūtal)
          : base(minūtal, Ēnumerātiōnēs.Catēgoria.Numerus, RomanNumeral.ToRomanNumeral(minūtal)) { }

    public static Numerus operator +(in Numerus prīmus, in Numerus secundus)
              => new Numerus(minūtal: prīmus.Minūtal + secundus.Minūtal);
    public static Numerus operator -(in Numerus prīmus, in Numerus secundus)
              => new Numerus(minūtal: prīmus.Minūtal - secundus.Minūtal);
    public static Numerus operator /(in Numerus prīmus, in Numerus secundus)
              => new Numerus(minūtal: prīmus.Minūtal / secundus.Minūtal);
    public static Numerus operator *(in Numerus prīmus, in Numerus secundus)
              => new Numerus(minūtal: prīmus.Minūtal * secundus.Minūtal);
    public static Numerus operator %(in Numerus prīmus, in Numerus secundus)
              => new Numerus(minūtal: prīmus.Minūtal % secundus.Minūtal);
    public static Numerus operator ++(in Numerus numerus) => new Numerus(minūtal: ++numerus.Minūtal);
    public static Numerus operator --(in Numerus numerus) => new Numerus(minūtal: --numerus.Minūtal);
    public sealed override int CompareTo(Numerus aliud) => Minūtal.CompareTo(aliud.Minūtal);
    public virtual string ToString() => this.ToString().ToUpperInvariant();
  }
}
