using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;
using Īnflexōrēs.ĪnflexorNumerāmibus.Versiō;

using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Pēnsōrēs.Numerāmina
{
  [Lazy]
  public sealed class PēnsorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum
            : PēnsorĪnflectendīs<Īnflectendum.NumerāmenCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum, Multiplex.Numerāmen>
  {
    private PēnsorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum()
          : base(versiō: Versiō.Cardinālium_Et_Ōrdinālium_Et_Adverbiōrum_Et_Distribūtīvōrum,
                 quaerendī: nameof(Īnflectendum.NumerāmenCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum.Numerus),
                 nūntius: new Lazy<Nūntius<PēnsorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum>>(),
                 lēctor: Īnflectendum.NumerāmenCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum.Lēctor)
          => Nūntius.PlūsGarriōAsync("Fīō");
  }
}
