using System;

using Miscella.Extensions;

namespace Ēnumerātiōnēs
{
  public enum Numerālis
  {
    Nūllus, Singulāris, Plūrālis
  }

  public static sealed class Numerālēs
  {
    public static string ToString(this Numerālis valor) => Enum.GetName<Numerālis>(valor).ToLower();
  }
}
