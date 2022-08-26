using Miscella.Extensions;
namespace Ēnumerātiōnēs
{
  public enum Numerālis
  {
    SINGULĀRIS, PLŪRĀLIS, NŪLLUS
  }

  public static sealed class Numerālēs
  {
    public static readonly Func<Numerālis, string> scrīptor = valor => valor.ToString().ToLower();
    public static readonly Func<Enum, Numerālis> iactor = valor => valor.cast(Numerālis, NŪLLUS);
  }
}
