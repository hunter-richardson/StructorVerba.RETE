using System.Enum;

using Pēnsōrēs.Pēnsor;

namespace Ēnumerātiōnēs {
  public enum Numerium {
    Numerus, Ōrdināle, Cardināle, Adverbium, Multiplicātīvum, Distribūtīvum, Frāctiōnāle
  }

  public static sealed class Numeria
  {
    public static string Columna(this Numerium valor) => await Pēnsor.NōmenātorColumnae.Invoke(valor.ToString());
    public static string ToString(this Numerium valor) => Enum.GetName<Numerium>(valor).ToLower();
  }
}
