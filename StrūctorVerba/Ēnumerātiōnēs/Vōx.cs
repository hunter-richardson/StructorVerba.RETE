using Miscella.Extensions;
namespace Ēnumerātiōnēs
{
  public enum Vōx
  {
    ĀCTĪVA, PASSĪVA, NŪLLA
  }

  public static sealed class Vōcēs
  {
    public static readonly Func<Vōx, string> Scrīptor = valor => valor.ToString().ToLower();
    public static readonly Func<Enum, Vōx> Iactor = valor => valor.Cast(Vōx, NŪLLA);
  }
}
