using System.Enum;

using Pēnsōrēs.Pēnsor;

namespace Ēnumerātiōnēs
{
  public enum Casus
  {
    Dērēctus, Nōminātīvus, Genitīvus, Datīvus, Accūsātīvus, Ablātīvus, Vocātīvus, Locātīvus, Instrumentālis
  }

  public static sealed class Casūs
  {
    public static string Columna(this Casus valor) => await Pēnsor.NōmenātorColumnae.Invoke(valor.ToString());
    public static string ToString(this Casus valor) => Enum.GetName<Casus>(valor).ToLower();
  }
}
