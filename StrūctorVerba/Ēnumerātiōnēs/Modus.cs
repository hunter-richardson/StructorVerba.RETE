using Miscella.Extensions;
namespace Ēnumerātiōnēs
{
  public enum Modus
  {
    Indicātīvus, Subiūnctīvus, Īnfīnītīvus, Imperātīvus, Participālis, Nūllus
  }

  public static sealed class Modī
  {
    public static readonly Func<Modus, string> Scrīptor = valor => valor.ToString().ToLower();
    public static readonly Func<Enum, Modus> Iactor = valor => valor.Cast(Modus, NŪLLUS);
  }
}
