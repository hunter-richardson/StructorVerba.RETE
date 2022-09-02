using System;

using Miscella.Extensions;

namespace Ēnumerātiōnēs
{
  public enum Encliticum
  {
    Nōlēns, Interrogāns, Coniugāns, Ēligēns
  }

  public static sealed class Enclitica
  {
    public static string ToString(this Encliticum valor) => Enum.GetName<Encliticum>(valor).ToLower();
  }
}
