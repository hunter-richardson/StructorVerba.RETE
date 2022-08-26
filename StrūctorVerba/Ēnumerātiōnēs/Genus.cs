using Miscella.Extensions;
namespace Ēnumerātiōnēs
{
  public enum Genus
  {
    NEUTRUM, MASCULĪNUM, FEMINĪNUM, NŪLLUM
  }

  public static sealed class Genera
  {
    public static readonly Func<Genus, string> scrīptor = valor => valor.ToString().ToLower();
    public static readonly Func<Enum, Genus> iactor = valor => valor.cast(Genus, NŪLLUM);
  }
}
