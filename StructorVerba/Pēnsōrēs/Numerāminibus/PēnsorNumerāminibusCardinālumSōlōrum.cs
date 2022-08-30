using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;

namespace Pēnsōrēs.Numerāminibus
{
  public sealed class PēnsorNumerāminibusCardinālumSōlōrum : PēnsorĪnflectendīs<Īnflectendum.NumerāmenCardinālumSōlōrum, Multiplex.Numerāmen>
  {
    private static Dictionary<Enum, PēnsorNumerāminibusCardinālumSōlōrum> Reservātī = new Dictionary<Enum, PēnsorNumerāminibusCardinālumSōlōrum>();

    public static Func<Enum, PēnsorNumerāminibusCardinālumSōlōrum> Faciendum = valor =>
    {
      if (Reservātī.ContainsKey(valor))
      {
        return Reservātī.Item[valor];
      }
      else
      {
        const PēnsorNumerāminibusCardinālumSōlōrum hoc = new PēnsorNumerāminibusCardinālumSōlōrum(valor);
        Reservātī.Add(valor, hoc);
        return hoc;
      }
    };

    private PēnsorNumerāminibusCardinālumSōlōrum(in Enum versiō)
                                                  : base(versiō, Ēnumerātiōnēs.Catēgoria.Numerāmen,
                                                         NūntiusPēnsōrīNumerāminibusCardinālumSōlōrum.Instance,
                                                         nameof(Īnflectendum.NumerāmenCardinālumSōlōrum.Numerus),
                                                         Īnflectendum.NumerāmenCardinālumSōlōrum.Lēctor) {  }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīNumerāminibusCardinālumSōlōrum : Nūntius<PēnsōrNumerāminibusCardinālumSōlōrum> {  }
  }
}
