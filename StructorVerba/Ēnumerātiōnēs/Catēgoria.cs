using System;
using System.Text.Json.JsonElement;

using Miscella;

namespace Ēnumerātiōnēs
{
  public enum Catēgoria
  {
    Āctus, Adiectīvum, Adverbium, Coniūnctiō, Interiectiō, Nōmen, Numerāmen, Numerus, Praepositiō, Prōnōmen
  }

  public static sealed class Catēgoriae
  {
    public static readonly Func<Catēgoria, string> Scrīptor = valor => valor.ToString().ToLower();
    public static readonly Func<JsonElement, Catēgoria> Dēfīnītor = lēctum =>
             (from valor in Enum.GetValues(Catēgoria)
              where Scrīptor.Invoke(valor).Equals(lēctum.GetString())
              select valor).First().Cast<Catēgoria>();

    public static string NōmenTabulae(this in Catēgoria catēgoria, Enum? versiō = null)
    {
      const string scrīptum = catēgoria switch
      {
        Catēgoria.Āctus       => "actus",
        Catēgoria.Adiectīvum  => "adiectiva",
        Catēgoria.Adverbium   => "adverbia",
        Catēgoria.Coniūnctiō  => "coniunctiones",
        Catēgoria.Interiectiō => "interiectio",
        Catēgoria.Nōmen       => "nomnia",
        Catēgoria.Numerāmen   => "numeramina",
        Catēgoria.Numerus     => "numeri",
        Catēgoria.Praepositiō => "praepositiones",
        Catēgoria.Prōnōmen    => "pronomnia"
      };

      return (versiō is not null).Choose(scrīptum.Concat(versiō.ToString()), scrīptum);
    }

    public static Boolean Īnflexa(this in Catēgoria catēgoria)
              => !catēgoria.IsAmong(Catēgoria.Coniūnctiō, Catēgoria.Interiectiō, Catēgoria.Numerus, Catēgoria.Praepositiō);

    public static Boolean Pensābilis(this in Catēgoria catēgoria)
              => !Catēgoria.Numerus.Equals(catēgoria);
  }
}
