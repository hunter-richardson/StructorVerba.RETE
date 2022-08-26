using Miscella.Ūtilitātēs;
namespace Ēnumerātiōnēs
{
  public enum Catēgoria
  {
    Āctus, Adiectīvum, Adverbium, Coniūnctiō, Interiectiō, Nōmen, Numerāmen, Numerus, Praepositiō, Prōnōmen
  }

  public static sealed class Catēgoriae
  {
    public static readonly Func<Catēgoria, string> Scrīptor = valor => valor.ToString().ToLower();

    public static string NōmenTabulae([NotNull] this in Catēgoria catēgoria, Enum? versiō = null)
    {
      const string scrīptum = catēgoria switch
      {
        ĀCTUS       => "actus",
        ADIECTĪVUM  => "adiectiva",
        ADVERBIA    => "adverbia",
        CONIŪNCTIŌ  => "coniunctiones",
        INTERIECTIŌ => "interiectio",
        NŌMEN       => "nomnia",
        NUMERĀMEN   => "numeramina",
        NUMERUS     => "numeri",
        PRAEPOSITIŌ => "praepositiones",
        PRŌNŌMEN    => "pronomnia"
      };

      return (versiō is not null).Choose(scrīptum.Concat(versiō.ToString()), scrīptum);
    }
  }
}
