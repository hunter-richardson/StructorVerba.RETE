using Miscella.Extensions;
namespace Ēnumerātiōnēs
{
  public enum Speciālitās
  {
    PROPRIA, COMMŪNIS, NŪLLA
  }

  public static sealed class Speciālitātēs
  {
    public static readonly Func<Speciālitās, string> scrīptor = valor => valor.ToString().ToLower();
    public static Speciālitās Ipsius([NotNull] in char littera)
    {
      return char.IsUpper(littera).Choose(PROPRIA, COMMŪNIS);
    }

    public static Speciālitās Ipsius([NotNull] in string verbum)
    {
      return char.IsUpper(verbum, 0).Choose(PROPRIA, COMMŪNIS);
    }
  }
}
