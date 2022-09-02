using System;

using Miscella.Extensions;

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
