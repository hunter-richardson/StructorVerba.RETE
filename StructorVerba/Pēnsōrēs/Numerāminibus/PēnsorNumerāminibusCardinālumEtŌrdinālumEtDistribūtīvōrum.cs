using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;

namespace Pēnsōrēs.Numerāminibus
{
  public sealed class PēnsorNumerāminibusCardinālumEtŌrdinālumEtDistribūtīvōrum
            : PēnsorĪnflectendīs<Īnflectendum.NumerāmenCardinālumEtŌrdinālumEtDistribūtīvōrum, Multiplex.Numerāmen>
  {
    private static Dictionary<Enum, PēnsorNumerāminibusCardinālumEtŌrdinālumEtDistribūtīvōrum> Reservātī
             = new Dictionary<Enum, PēnsorNumerāminibusCardinālumEtŌrdinālumEtDistribūtīvōrum>();

    public static Func<Enum, PēnsorNumerāminibusCardinālumEtŌrdinālumEtDistribūtīvōrum> Faciendum = valor =>
    {
      if (Reservātī.ContainsKey(valor))
      {
        return Reservātī.Item[valor];
      }
      else
      {
        const PēnsorNumerāminibusCardinālumEtŌrdinālumEtDistribūtīvōrum hoc = new PēnsorNumerāminibusCardinālumEtŌrdinālumEtDistribūtīvōrum(valor);
        Reservātī.Add(valor, hoc);
        return hoc;
      }
    };

    private PēnsorNumerāminibusCardinālumEtŌrdinālumEtDistribūtīvōrum(in Enum versiō)
                                                                       : base(versiō, Ēnumerātiōnēs.Catēgoria.Numerāmen,
                                                                              NūntiusPēnsōrīNumerāminibusCardinālumEtŌrdinālumEtDistribūtīvōrum.Instance,
                                                                              nameof(Īnflectendum.NumerāmenCardinālumEtŌrdinālumEtDistribūtīvōrum.Numerus),
                                                                              Īnflectendum.NumerāmenCardinālumEtŌrdinālumEtDistribūtīvōrum.Lēctor) {  }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīNumerāminibusCardinālumEtŌrdinālumEtDistribūtīvōrum
                : Nūntius<PēnsōrNumerāminibusCardinālumEtŌrdinālumEtDistribūtīvōrum> {  }
  }
}
