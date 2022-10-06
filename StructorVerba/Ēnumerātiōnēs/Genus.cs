using System.Enum;

using Pēnsōrēs.Pēnsor;

namespace Ēnumerātiōnēs
{
  public enum Genus
  {
    Nūllum, Neutrum, Masculīnum, Fēminīnum
  }

  public static sealed class Genera
  {
    public static string Columna(this Genus valor) => await Pēnsor.NōmenātorColumnae.Invoke(valor.ToString());
    public static string ToString(this Genus valor) => Enum.GetName<Genus>(valor).ToLower();
  }
}
