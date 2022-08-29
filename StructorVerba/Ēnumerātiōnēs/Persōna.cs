using System;

using Miscella.Extensions;

namespace Ēnumerātiōnēs
{
  public enum Persōna
  {
    Prīma, Secunda, Tertia, Nūlla
  }

  public static sealed class Persōnae
  {
    public static readonly Func<Persōna, string> Scrīptor = valor => valor.ToString().ToLower();
    public static readonly Func<Enum, Persōna> Iactor = valor => valor.Cast<Persōna>(Persōna.NŪLLA);
  }
}
