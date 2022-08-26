using Miscella.Extensions;
namespace Ēnumerātiōnēs {
  public enum Persōna {
    PRĪMA, SECUNDA, TERTIA, NŪLLA
  }

  public static sealed class Persōnae {
    public static readonly Func<Persōna, string> scrīptor = valor => valor.ToString().ToLower();
    public static readonly Func<Enum, Persōna> iactor = valor => valor.cast(Persōna, NŪLLA);
  }
}
