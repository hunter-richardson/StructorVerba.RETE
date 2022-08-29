using System;

using Miscella.Extensions;

namespace Ēnumerātiōnēs
{
  public enum Genus
  {
    Neutrum, Masculīnum, Feminīnum, Nūllum
  }

  public static sealed class Genera
  {
    public static readonly Func<Genus, string> Scrīptor = valor => valor.ToString().ToLower();
    public static readonly Funcc<Enum, Genus> Iactor = valor => valor.Cast<Genus>(Genus.Nūllum);
  }
}
