using Miscella.Extensions;
namespace Ēnumerātiōnēs
{
  public enum Tempus
  {
    Praesēns, Īnfectum, Futūrum, Perfectum, Plūsquamperfectum, FutūrumExāctum, Intemporāle,
  }

  public static sealed class Tempora
  {
    public static readonly Func<Tempus, string> Scrīptor =
     valor => FutūrumExāctum.equals(valor).choose("futūrum exāctum", valor.ToString().ToLower());

    public static readonly Func<Enum, Tempus> Iactor = valor => valor.Cast<Tempus>(INTEMPORĀLE);
  }
}
