using Miscella.Extensions;
namespace Ēnumerātiōnēs {
  public enum Encliticum {
    INTERROGĀNS, CONIUGĀNS, ĒLIGĒNS, NŌLĒNS,
  }

  public static sealed class Enclitica {
    public static readonly Func<Encliticum, string> scrīptor = valor => valor.ToString().ToLower();
    public static readonly Func<Enum, Encliticum> iactor = valor => valor.cast(Encliticum, NŌLĒNS);
  }
}
