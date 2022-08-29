using System.ComponentModel.DataAnnotations;

using Ēnumerātiōnēs.Catēgoria;

using RomanNumerals.RomanNumeral;

namespace Praebeunda.Simplicia
{
  [GenerateBuilder]
  public sealed class Numerus : Verbum<Numerus>
  {
    public static readonly (int, string) MinValue = (1, "I");
    public static readonly (int, string) MaxValue = (3999, "MMMCMXCIX");

    private Numerus([Range(MinValue.Item1, MaxValue.Item1)] in int nmrs)
                   : base(nmrs, Catēgoria.Numerus, RomanNumeral.ToRomanNumeral(nmrs)) { }
    private Numerus([StringLength(15, MinimumLength = 1)] in string scrīptum)
                   : base(0, Catēgoria.Numerus, scrīptum)
    {
      if (!RomanNumeral.TryParse(scrīptum, out Minūtal))
      {
        throw new ArgumentationOutOfRangeException(nameof(scrīptum), scrīptum,
                                                   $"Parametrum {nameof(scrīptum)} tractum exspectātum nōn īnest. Valōribus classis {typeof(Numerus)} interiacendu'st valōrēs {MinValue.Item1} et {MaxValue.Item1}.");
      }
    }

    public static Numerus operator +(in Nunerus prīmus, in Numerus secundus)
              => new Numerus(prīmus.Minūtal + secundus.Minūtal);
    public static Numerus operator -(in Nunerus prīmus, in Numerus secundus)
              => new Numerus(prīmus.Minūtal - secundus.Minūtal);
    public static Numerus operator /(in Nunerus prīmus, in Numerus secundus)
              => new Numerus(prīmus.Minūtal / secundus.Minūtal);
    public static Numerus operator *(in Nunerus prīmus, in Numerus secundus)
              => new Numerus(prīmus.Minūtal * secundus.Minūtal);
    public static Numerus operator %(in Nunerus prīmus, in Numerus secundus)
              => new Numerus(prīmus.Minūtal % secundus.Minūtal);
    public static Numerus operator ++(in Nunerus numerus) => new Numerus(++numerus.Minūtal);
    public static Numerus operator --(in Nunerus numerus) => new Numerus(--numerus.Minūtal);
  }
}
