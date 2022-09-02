using System;

using Miscella.Extensions;

namespace Ēnumerātiōnēs
{
  public enum Genus
  {
    Nūllum, Neutrum, Masculīnum, Fēminīnum
  }

  public static sealed class Genera
  {
    public static string ToString(this Genus valor) => Enum.GetName<Genus>(valor).ToLower();
  }
}
