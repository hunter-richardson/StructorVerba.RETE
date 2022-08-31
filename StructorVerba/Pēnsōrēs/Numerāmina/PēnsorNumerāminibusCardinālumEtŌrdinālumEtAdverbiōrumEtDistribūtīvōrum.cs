using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;
using Īnflexōrēs.ĪnflexorNumerāmibus.Versiō;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Pēnsōrēs.Numerāmina
{
  [Singleton]
  public sealed class PēnsorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum
            : PēnsorĪnflectendīs<Īnflectendum.NumerāmenCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum, Multiplex.Numerāmen>
  {
    public static readonly Lazy<PēnsorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum> Faciendum =
                       new Lazy<PēnsorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum>(() => Instance);
    private PēnsorNumerāminibusCardinālumSōlōrum()
          : base(Versiō.Cardinālium_Et_Ōrdinālium_Et_Adverbiōrum_Et_Distribūtīvōrum,
                 nameof(Īnflectendum.NumerāmenCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum.Numerus),
                 NūntiusPēnsōrīNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum.Faciendum,
                 Īnflectendum.NumerāmenCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum.Lēctor) {  }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum
               : Nūntius<PēnsorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum>
    {
      public static readonly Lazy<NūntiusPēnsōrīNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum> Faciendum =
                         new Lazy<NūntiusPēnsōrīNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum>(() => Instance);
    }
  }
}
