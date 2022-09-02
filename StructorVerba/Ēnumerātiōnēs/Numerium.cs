using System;

using Miscella.Extensions;

namespace Ēnumerātiōnēs {
  public enum Numerium {
    Numerus, Ōrdināle, Cardināle, Adverbium, Multiplicātīvum, Distribūtīvum, Frāctiōnāle
  }

  public static sealed class Numeria
  {
    public static string ToString(this Numerium valor) => Enum.GetName<Numerium>(valor).ToLower();
  }
}
