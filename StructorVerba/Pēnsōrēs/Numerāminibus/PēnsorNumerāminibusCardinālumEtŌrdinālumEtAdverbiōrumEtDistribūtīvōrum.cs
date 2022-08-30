using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;

namespace Pēnsōrēs.Numerāminibus
{
  public sealed class PēnsorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum
            : PēnsorĪnflectendīs<Īnflectendum.NumerāmenCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum, Multiplex.Numerāmen>
  {
    private static Dictionary<Enum, PēnsorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum> Reservātī
             = new Dictionary<Enum, PēnsorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum>();

    public static Func<Enum, PēnsorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum> Faciendum = valor =>
    {
      if (Reservātī.ContainsKey(valor))
      {
        return Reservātī.Item[valor];
      }
      else
      {
        const PēnsorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum hoc
        = new PēnsorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum(valor);
        Reservātī.Add(valor, hoc);
        return hoc;
      }
    };

    private PēnsorNumerāminibusCardinālumSōlōrum(in Enum versiō)
                                                  : base(versiō, Ēnumerātiōnēs.Catēgoria.Numerāmen,
                                                         NūntiusPēnsōrīNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum.Instance,
                                                         nameof(Īnflectendum.NumerāmenCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum.Numerus),
                                                         Īnflectendum.NumerāmenCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum.Lēctor) {  }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum
               : Nūntius<PēnsorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum> {  }
  }
}
