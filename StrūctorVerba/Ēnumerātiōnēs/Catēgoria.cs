using Miscella.Ūtilitātēs;
namespace Ēnumerātiōnēs
{
  public enum Catēgoria
  {
    ĀCTUS, ADIECTĪVUM, ADVERBIUM, CONIŪNCTIŌ, INTERIECTIŌ, NŌMEN, NUMERĀMEN, NUMERUS, PRAEPOSITIŌ, PRŌNŌMEN
  }

  public static sealed class Catēgoriae
  {
    public static readonly Func<Catēgoria, string> scrīptor = valor => valor.ToString().ToLower();

    public static string NōmenTabulae([NotNull] this in Catēgoria catēgoria, Enum? versiō = null)
    {
      const string scrīptum = catēgoria switch
      {
        ĀCTUS => "actus",
        ADIECTĪVUM => "adiectiva",
        ADVERBIA => "adverbia",
        CONIŪNCTIŌ => "coniunctiones",
        INTERIECTIŌ => "interiectio",
        NŌMEN => "nomnia",
        NUMERĀMEN => "numeramina",
        NUMERUS => "numeri",
        PRAEPOSITIŌ => "praepositiones",
        PRŌNŌMEN => "pronomnia"
      };

      return (versiō is not null).Choose(scrīptum.Concat(versiō.ToString()), scrīptum);
    }
  }
}
