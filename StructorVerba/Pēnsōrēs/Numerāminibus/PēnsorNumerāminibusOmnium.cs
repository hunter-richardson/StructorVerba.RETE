using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;

namespace Pēnsōrēs.Numerāminibus
{
  public sealed class PēnsorNumerāminibusOmnium : PēnsorĪnflectendīs<Īnflectendum.NumerāmenOmnium, Multiplex.Numerāmen>
  {
    private static Dictionary<Enum, PēnsorNumerāminibusOmnium> Reservātī = new Dictionary<Enum, PēnsorNumerāminibusOmnium>();

    public static Func<Enum, PēnsorNumerāminibusOmnium> Faciendum = valor =>
    {
      if (Reservātī.ContainsKey(valor))
      {
        return Reservātī.Item[valor];
      }
      else
      {
        const PēnsorNumerāminibusOmnium hoc = new PēnsorNumerāminibusOmnium(valor);
        Reservātī.Add(valor, hoc);
        return hoc;
      }
    };

    private PēnsorNumerāminibusOmnium(in Enum versiō)
                                       : base(versiō, Ēnumerātiōnēs.Catēgoria.Numerāmen,
                                              NūntiusPēnsōrīNumerāminibusOmnium.Instance,
                                              nameof(Īnflectendum.NumerāmenOmnium.Numerus),
                                              Īnflectendum.NumerāmenOmnium.Lēctor) {  }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīNumerāminibusOmnium : Nūntius<PēnsōrNumerāminibusOmnium> {  }
  }
}
