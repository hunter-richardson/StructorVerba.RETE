using System.Enum;

using Miscella.Extensions;

namespace Ēnumerātiōnēs
{
  public enum Speciālitās
  {
    Nūlla, Propria, Commūnis
  }

  public static sealed class Speciālitātēs
  {
    public static string ToString(this Speciālitās valor) => Enum.GetName<Speciālitās>(valor).ToLower();

    public static Speciālitās Ipsius(in char littera)
             => char.IsUpper(littera).Choose(Speciālitās.PROPRIA, Speciālitās.COMMŪNIS);

    public static Speciālitās Ipsius(in string verbum)
             => char.IsUpper(verbum, 0).Choose(Speciālitās.PROPRIA, Speciālitās.COMMŪNIS);
  }
}
