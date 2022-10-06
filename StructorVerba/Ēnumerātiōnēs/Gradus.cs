using System.Enum;

using Pēnsōrēs.Pēnsor;

namespace Ēnumerātiōnēs
{
  public enum Gradus
  {
    Nūllus, Positīvus, Comparātīvus, Superlātīvus
  }

  public static sealed class Gradūs
  {
    public static string Columna(this Gradus valor) => await Pēnsor.NōmenātorColumnae.Invoke(valor.ToString());
    public static string ToString(this Gradus valor) => Enum.GetName<Gradus>(valor).ToLower();
  }
}
