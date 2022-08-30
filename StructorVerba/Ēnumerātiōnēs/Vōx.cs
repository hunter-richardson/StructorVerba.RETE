using System;

using Miscella.Extensions;

namespace Ēnumerātiōnēs
{
  public enum Vōx
  {
    Nūlla, Āctīva, Passīva
  }

  public static sealed class Vōcēs
  {
    public static readonly Func<Vōx, string> Scrīptor = valor => valor.ToString().ToLower();
    public static readonly Func<Enum, Vōx> Iactor = valor => valor.Cast<Vōx>(default);
  }
}
