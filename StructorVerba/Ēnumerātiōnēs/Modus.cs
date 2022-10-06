using System.Enum;

using Pēnsōrēs.Pēnsor;

namespace Ēnumerātiōnēs
{
  public enum Modus
  {
    Nūllus, Indicātīvus, Subiūnctīvus, Īnfīnītīvus, Imperātīvus, Participālis
  }

  public static sealed class Modī
  {
    public static string ToString(this Modus valor) => Enum.GetName<Modus>(valor).ToLower();
  }
}
