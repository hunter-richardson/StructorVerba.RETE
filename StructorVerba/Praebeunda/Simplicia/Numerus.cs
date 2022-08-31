using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks.Task;

using RomanNumerals.RomanNumeral;

namespace Praebeunda.Simplicia
{
  [GenerateBuilder]
  public sealed class Numerus : Verbum<Numerus>
  {
    public static readonly Func<int, Task<Numerus>> GenerātorNumericus = async numerus => Builder.WithMinūtal(numerus).Build();
    public static readonly Func<string, Task<Numerus>> GenerātorVerbālis = async scrīptum => Builder.WithScrīptum(scrīptum).Build();

    public static readonly (int, string) MinValue = (1, "I");
    public static readonly (int, string) MaxValue = (3999, "MMMCMXCIX");

    private Numerus([Range(MinValue.Item1, MaxValue.Item1)] in int numerus)
                   : base(numerus, Ēnumerātiōnēs.Catēgoria.Numerus, RomanNumeral.ToRomanNumeral(nmrs)) { }
    private Numerus([StringLength(15, MinimumLength = 1)] in string scrīptum)
                   : base(0, Ēnumerātiōnēs.Catēgoria.Numerus, scrīptum)
    {
      if (!RomanNumeral.TryParse(scrīptum, out Minūtal))
      {
        throw new ArgumentationOutOfRangeException(nameof(scrīptum), scrīptum,
                                                   $"Parametrum {nameof(scrīptum)} tractum exspectātum nōn īnest. Valōribus classis {typeof(Numerus)} interiacendu'st valōrēs {MinValue.Item2} et {MaxValue.Item2}.");
      }
    }

    public static Numerus operator +(in Numerus prīmus, in Numerus secundus)
              => new Numerus(prīmus.Minūtal + secundus.Minūtal);
    public static Numerus operator -(in Numerus prīmus, in Numerus secundus)
              => new Numerus(prīmus.Minūtal - secundus.Minūtal);
    public static Numerus operator /(in Numerus prīmus, in Numerus secundus)
              => new Numerus(prīmus.Minūtal / secundus.Minūtal);
    public static Numerus operator *(in Numerus prīmus, in Numerus secundus)
              => new Numerus(prīmus.Minūtal * secundus.Minūtal);
    public static Numerus operator %(in Numerus prīmus, in Numerus secundus)
              => new Numerus(prīmus.Minūtal % secundus.Minūtal);
    public static Numerus operator ++(in Numerus numerus) => new Numerus(++numerus.Minūtal);
    public static Numerus operator --(in Numerus numerus) => new Numerus(--numerus.Minūtal);
    public sealed override int CompareTo(Numerus aliud) => Minūtal.CompareTo(aliud.Minūtal);
  }
}
