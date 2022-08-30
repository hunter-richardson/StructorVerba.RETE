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
    public static readonly Func<Gradus, string> Scrīptor = valor => valor.ToString().ToLower();
    public static readonly Func<Enum, Gradus> Iactor = valor => valor.Cast<Gradus>(default);
  }
}
