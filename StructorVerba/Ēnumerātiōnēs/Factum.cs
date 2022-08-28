using Miscella.Extensions;
namespace Ēnumerātiōnēs
{
  public enum Factum
  {
    Īnfīnītīvum, Gerundīvum, Supīnum, Nūllum
  }

  public static sealed class Facta
  {
    public static readonly Func<Factum, string> Scrīptor = valor => valor.ToString().ToLower();
    public static readonly Func<Enum, Factum> Iactor = valor => valor.Cast<Factum>(NŪLLUM);
  }
}
