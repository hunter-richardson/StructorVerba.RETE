using System;
using Miscella.Extensions;
namespace Ēnumerātiōnēs
{
  public enum Factum
  {
    Nūllum, Īnfīnītīvum, Gerundīvum, Supīnum
  }

  public static sealed class Facta
  {
    public static readonly Func<Factum, string> Scrīptor = valor => valor.ToString().ToLower();
    public static readonly Func<Enum, Factum> Iactor = valor => valor.Cast<Factum>(default);
  }
}
