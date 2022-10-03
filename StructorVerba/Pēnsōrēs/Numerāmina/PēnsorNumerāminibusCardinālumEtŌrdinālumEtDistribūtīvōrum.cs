using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;
using Īnflexōrēs.ĪnflexorNumerāmibus.Versiō;

using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Pēnsōrēs.Numerāmina
{
  [Lazy]
  public sealed class PēnsorNumerāminibusCardinālumEtŌrdinālumEtDistribūtīvōrum
            : PēnsorĪnflectendīs<Īnflectendum.NumerāmenCardinālumEtŌrdinālumEtDistribūtīvōrum, Multiplex.Numerāmen>
  {
    private PēnsorNumerāminibusCardinālumEtŌrdinālumEtDistribūtīvōrum()
          : base(versiō: Versiō.Cardinālium_Et_Ōrdinālium_Et_Distribūtīvōrum,
                 quaerendī: nameof(Īnflectendum.NumerāmenCardinālumEtŌrdinālumEtDistribūtīvōrum.Numerus),
                 nūntius: new Lazy<Nūntius<PēnsorNumerāminibusCardinālumEtŌrdinālumEtDistribūtīvōrum>>(),
                 lēctor: Īnflectendum.NumerāmenCardinālumEtŌrdinālumEtDistribūtīvōrum.Lēctor)
          => Nūntius.PlūsGarriōAsync("Fīō");
  }
}
