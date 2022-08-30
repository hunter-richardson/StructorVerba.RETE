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
    public static readonly Func<Encliticum, string> Scrīptor = valor => valor.ToString().ToLower();
    public static readonly Func<Enum, Encliticum> Iactor = valor => valor.Cast<Encliticum>(default);
  }
}
