using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;
using Īnflexōrēs.ĪnflexorNumerāmibus.Versiō;

using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Pēnsōrēs.Numerāmina
{
  [Lazy]
  public sealed class PēnsorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrum
            : PēnsorĪnflectendīs<Īnflectendum.NumerāmenCardinālumEtŌrdinālumEtAdverbiōrum, Multiplex.Numerāmen>
  {
    private PēnsorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrum()
          : base(versiō: Versiō.Cardinālium_Et_Ōrdinālium_Et_Adverbiōrum,
                 quaerendī: nameof(Īnflectendum.NumerāmenCardinālumEtŌrdinālumEtAdverbiōrum.Numerus),
                 nūntius: new Lazy<Nūntius<PēnsorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrum>>(),
                 lēctor: Īnflectendum.NumerāmenCardinālumEtŌrdinālumEtAdverbiōrum.Lēctor)
          => Nūntius.PlūsGarriōAsync("Fīō");
  }
}
