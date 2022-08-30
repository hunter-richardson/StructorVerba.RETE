using System;

using Miscella.Extensions;

namespace Ēnumerātiōnēs
{
  public enum Tempus
  {
    Intemporāle, Praesēns, Īnfectum, Futūrum, Perfectum, Plūsquamperfectum, FutūrumExāctum
  }

  public static sealed class Tempora
  {
    public static readonly Func<Tempus, string> Scrīptor =
              valor => Tempus.FutūrumExāctum.equals(valor).choose("futūrum exāctum", valor.ToString().ToLower());

    public static readonly Func<Enum, Tempus> Iactor = valor => valor.Cast<Tempus>(default);
  }
}
