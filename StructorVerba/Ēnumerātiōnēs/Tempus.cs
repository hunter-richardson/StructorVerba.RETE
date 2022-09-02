using System;

using Miscella.Extensions;

namespace Ēnumerātiōnēs
{
  public enum Tempus
  {
    Intemporāle, Praesēns, Īnfectum, Futūrum, Perfectum, Plūsquamperfectum, Futūrum_Exāctum
  }

  public static sealed class Tempora
  {
    public static string ToString(this Tempus valor) => Enum.GetName<Tempus>(valor).ToLower().Replace('_', ' ');
  }
}
