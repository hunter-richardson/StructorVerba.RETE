using System;

using Miscella.Extensions;

namespace Ēnumerātiōnēs
{
  public enum Numerālis
  {
    Singulāris, Plūrālis, Nūllus
  }

  public static sealed class Numerālēs
  {
    public static readonly Func<Numerālis, string> Scrīptor = valor => valor.ToString().ToLower();
    public static readonly Func<Enum, Numerālis> Iactor = valor => valor.Cast<Numerālis>(Numerālis.Nūllus);
  }
}
