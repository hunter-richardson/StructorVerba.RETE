using Miscella.Extensions;
namespace Ēnumerātiōnēs
{
  public enum Modus
  {
    INDICĀTĪVUS, SUBIŪNCTĪVUS, ĪNFĪNĪTĪVUS, IMPERĀTĪVUS, PARTICIPĀLIS, NŪLLUS
  }

  public static sealed class Modī
  {
    public static readonly Func<Modus, string> scrīptor = valor => valor.ToString().ToLower();
    public static readonly Func<Enum, Modus> iactor = valor => valor.cast(Modus, NŪLLUS);
  }
}
