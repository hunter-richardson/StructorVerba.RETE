using Miscella.Extensions;
namespace Ēnumerātiōnēs
{
  public enum Encliticum
  {
    Interrogāns, Coniugāns, Ēligēns, Nōlēns,
  }

  public static sealed class Enclitica
  {
    public static readonly Func<Encliticum, string> Scrīptor = valor => valor.ToString().ToLower();
    public static readonly Func<Enum, Encliticum> Iactor = valor => valor.Cast(Encliticum, NŌLĒNS);
  }
}
