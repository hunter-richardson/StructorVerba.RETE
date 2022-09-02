using System;
using System.Text.Json.JsonElement;

using Miscella.Extensions;

namespace Ēnumerātiōnēs
{
  public enum Prīncipāle
  {
    Nominātīvus, Genitīvus, Neutrum, Masculīnum, Fēminīnum, Positīvus, Comparātīvus, Superlātīvus, Īnfīnītīvum, Gerundīvum, Supīnum
  }

  public static sealed class Prīncipālēs
  {
    public static string ToString(this Prīncipāle valor) => Enum.GetName<Prīncipāle>(valor).ToLower();
    public static readonly Func<JsonElement, Prīncipāle?> Dēfīnītor =
             lēctum => (from valor in Enum.GetValues(Prīncipāle)
                        where valor.ToString().Equals(lēctum.GetString(), StringComparison.OrdinalIgnoreCase)
                        select valor).First().Cast<Prīncipāle>(null);
  }
}
