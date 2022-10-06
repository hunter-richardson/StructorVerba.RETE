using System.Enum;

namespace Ēnumerātiōnēs
{
  public enum Vōx
  {
    Nūlla, Āctīva, Passīva
  }

  public static sealed class Vōcēs
  {
    public static string ToString(this Vōx valor) => Enum.GetName<Vōx>(valor).ToLower();
  }
}
