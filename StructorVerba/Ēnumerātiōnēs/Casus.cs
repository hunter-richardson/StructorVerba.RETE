using System;

using Miscella.Extensions;

namespace Ēnumerātiōnēs {
  public enum Casus {
    Dērēctus, Nominātīvus, Genitīvus, Datīvus, Accusātīvus, Ablātīvus, Vocātīvus, Locātīvus, Instrumentālis
  }

  public static sealed class Casūs {
    public static readonly Func<Casus, string> Scrīptor = valor => valor.ToString().ToLower();
    public static readonly Func<Enum, Casus> Iactor = valor => valor.Cast<Casus>(Casus.Dērēctus);
  }
}
