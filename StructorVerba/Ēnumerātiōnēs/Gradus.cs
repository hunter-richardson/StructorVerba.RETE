using System;

using Miscella.Extensions;

namespace Ēnumerātiōnēs
{
  public enum Gradus
  {
    Nūllus, Positīvus, Comparātīvus, Superlātīvus
  }

  public static sealed class Gradūs
  {
    public static string ToString(this Gradus valor) => Enum.GetName<Gradus>(valor).ToLower();
  }
}
