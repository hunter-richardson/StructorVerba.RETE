using System;

using Miscella.Extensions;

namespace Ēnumerātiōnēs {
  public enum Casus {
    Dērēctus, Nominātīvus, Genitīvus, Datīvus, Accusātīvus, Ablātīvus, Vocātīvus, Locātīvus, Instrumentālis
  }

  public static sealed class Casūs {
    public static string ToString(this Casus valor) => Enum.GetName<Casus>(valor).ToLower();
  }
}
