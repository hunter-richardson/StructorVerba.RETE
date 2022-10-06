using System.Enum;

using Pēnsōrēs.Pēnsor;

namespace Ēnumerātiōnēs
{
  public enum Factum
  {
    Nūllum, Īnfīnītīvum, Gerundīvum, Supīnum
  }

  public static sealed class Facta
  {
    public static string Columna(this Factum valor) => await Pēnsor.NōmenātorColumnae.Invoke(valor.ToString());
    public static string ToString(this Factum valor) => Enum.GetName<Factum>(valor).ToLower();
  }
}
