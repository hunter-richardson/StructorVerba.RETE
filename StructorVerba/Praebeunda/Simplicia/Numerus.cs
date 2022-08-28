namespace Praebeunda.Simplicia
{
  public sealed class Numerus : Verbum<Numerus>
  {
    public static readonly Supplier<Strūctor> Strūctor => () => new Strūctor();

    private Numerus([Range(RomanNumeral.MinValue, RomanNumeral.MaxValue)] in int nmrs)
                   : base(nmrs, Catēgoria.Numerus, RomanNumeral.ToRomanNumeral(nmrs)) { }
    private Numerus([StringLength(15, MinimumLength = 2)] in string scrīptum)
                   : base(0, Catēgoria.Numerus, scrīptum)
    {
      if (!RomanNumeral.TryParse(scrīptum, out Minūtal))
      {
        throw new ArgumentationOutOfRangeException(nameof(scrīptum), scrīptum,
                                                   $"Parametrum {nameof(scrīptum)} tractum exspectātum nōn īnest. Valōribus classis {typeof(Numerus)} interiacendu'st valōrēs I et MMMCMXCIX.");
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

    [BuilderFor(typeof(Numerus))]
    private sealed partial class Strūctor { }
  }
}
