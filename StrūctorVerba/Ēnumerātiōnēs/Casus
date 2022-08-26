using Miscella.Extensions;
namespace Ēnumerātiōnēs {
  public enum Casus {
    DĒRĒCTUS, NOMINĀTĪVUS, GENITĪVUS, DATĪVUS, ACCUSĀTĪVUS, ABLĀTĪVUS, VOCĀTĪVUS, LOCĀTĪVUS, INSTRUMENTĀLIS
  }

  public static sealed class Casūs {
    public static readonly Func<Casus, string> scrīptor = valor => valor.ToString().ToLower();
    public static readonly Func<Enum, Casus> iactor = valor => valor.cast(Casus, DĒRĒCTUS);
  }
}
