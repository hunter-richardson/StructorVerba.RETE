using System;

using Miscella.Extensions;

namespace Ēnumerātiōnēs
{
  public enum Speciālitās
  {
    Nūlla, Propria, Commūnis
  }

  public static sealed class Speciālitātēs
  {
    public static readonly Func<Speciālitās, string> Scrīptor = valor => valor.ToString().ToLower();

    public static Speciālitās Ipsius(in char littera)
             => char.IsUpper(littera).Choose(Speciālitās.PROPRIA, Speciālitās.COMMŪNIS);

    public static Speciālitās Ipsius(in string verbum)
             => char.IsUpper(verbum, 0).Choose(Speciālitās.PROPRIA, Speciālitās.COMMŪNIS);
  }
}
