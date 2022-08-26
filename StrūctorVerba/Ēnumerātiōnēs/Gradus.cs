using Miscella.Extensions;
namespace Ēnumerātiōnēs
{
  public enum Gradus
  {
    POSITĪVUS, COMPARĀTĪVUS, SUPERLĀTĪVUS, NŪLLUS
  }

  public static sealed class Gradūs
  {
    public static readonly Func<Gradus, string> scrīptor = valor => valor.ToString().ToLower();
    public static readonly Func<Enum, Gradus> iactor = valor => valor.cast(Gradus, NŪLLUS);
  }
}
