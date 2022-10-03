using System;
using System.Text.Json.JsonElement;

using Miscella;

namespace Ēnumerātiōnēs
{
  public enum Catēgoria
  {
    Āctus, Adiectīvum, Adverbium, Coniūnctiō, Frāctus, Interiectiō, Nōmen, Numerāmen, Numerus, Praepositiō, Prōnōmen
  }

  public static sealed class Catēgoriae
  {
    public static string Columna() => await Pēnsor.NōmenātorColumnae.Invoke(typeof(Catēgoria).Name);
    public static string ToString(this Catēgoria valor) => Enum.GetName<Catēgoria>(valor).ToLower();
    public static readonly Func<JsonElement, Catēgoria> Dēfīnītor = lēctum =>
             (from valor in Enum.GetValues(Catēgoria)
              where valor.ToString().Equals(lēctum.GetString(), StringComparison.OrdinalIgnoreCase)
              select valor).First().Cast<Catēgoria>();

    public static Boolean Īnflexa(this in Catēgoria catēgoria)
              => !catēgoria.IsAmong(Catēgoria.Coniūnctiō, Catēgoria.Frāctus, Catēgoria.Interiectiō, Catēgoria.Numerus, Catēgoria.Praepositiō);

    public static Boolean Pensābilis(this in Catēgoria catēgoria)
              => !catēgoria.IsAmong(Catēgoria.Frāctus, Catēgoria.Numerus);
  }
}
