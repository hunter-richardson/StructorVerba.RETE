using Miscella.Extensions;
namespace Ēnumerātiōnēs
{
  public enum Tempus
  {
    PRAESĒNS, ĪNFECTUM, FUTŪRUM, PERFECTUM, PLŪSQUAMPERFECTUM, FUTŪRUM_EXĀCTUM, INTERMPORĀLE,
  }

  public static sealed class Tempora
  {
    public static readonly Func<Tempus, string> scrīptor = valor => valor.ToString().ToLower();
    public static readonly Func<Enum, Tempus> iactor = valor => valor.Cast(Tempus, INTEMPORĀLE);
  }
}
