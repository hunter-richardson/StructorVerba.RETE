using System;

using Miscella.Extensions;

namespace Ēnumerātiōnēs {
  public enum Numerium {
    Numerus, Ōrdināle, Cardināle, Adverbium, Multiplicātīvum, Distribūtīvum, Frāctiōnāle
  }

  public static sealed class Numeria
  {
    public static readonly Func<Numerium, string> Scrīptor = valor => valor.ToString().ToLower();
    public static readonly Func<Enum, Numerium> Iactor = valor => valor.Cast<Numerium>(Numerium.Numerus);
  }
}
