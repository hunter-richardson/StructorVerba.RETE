using System;

using Miscella.Extensions;

namespace Ēnumerātiōnēs
{
  public enum Persōna
  {
    Nūlla, Prīma, Secunda, Tertia
  }

  public static sealed class Persōnae
  {
    public static string ToString(this Persōna valor) => Enum.GetName<Persōna>(valor).ToLower();
  }
}
