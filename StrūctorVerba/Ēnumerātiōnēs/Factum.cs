using Miscella.Extensions;
namespace Ēnumerātiōnēs
{
  public enum Factum
  {
    ĪNFĪNĪTĪVUM, GERUNDĪVUM, SUPĪNUM, NŪLLUM
  }

  public static sealed class Facta
  {
    public static readonly Func<Factum, string> scrīptor = valor => valor.ToString().ToLower();
    public static readonly Func<Enum, Factum> iactor = valor => valor.cast(Factum, NŪLLUM);
  }
}
