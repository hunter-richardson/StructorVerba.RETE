using System;
using System.Text.Json.JsonElement;

using Miscella.Extensions;

namespace Ēnumerātiōnēs
{
  public enum Prīncipāle
  {
    Nominātīvus, Genitīvus, Neutrum, Masculīnum, Feminīnum, Positīvus, Comparātīvus, Superlātīvus, Īnfīnītīvum, Gerundīvum, Supīnum
  }

  public static sealed class Prīncipālēs
  {
    public static readonly Func<Prīncipāle, string> Scrīptor = valor => valor.ToString().ToLower();
    public static readonly Func<JsonElement, Prīncipāle> Dēfīnītor =
             lēctum => (from valor in Enum.GetValues(Prīncipāle)
                        where Scrīptor.Invoke(valor).Equals(lēctum.GetString())
                        select valor).First().Cast<Prīncipāle>();
  }
}
