using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;
using Īnflexōrēs.ĪnflexorNumerāmibus.Versiō;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Pēnsōrēs.Numerāmina
{
  public sealed class PēnsorNumerāminibusCardinālumEtŌrdinālumEtDistribūtīvōrum
            : PēnsorĪnflectendīs<Īnflectendum.NumerāmenCardinālumEtŌrdinālumEtDistribūtīvōrum, Multiplex.Numerāmen>
  {
    public static readonly Lazy<PēnsorNumerāminibusCardinālumEtŌrdinālumEtDistribūtīvōrum> Faciendum = new Lazy(() => Instance);
    private PēnsorNumerāminibusCardinālumEtŌrdinālumEtDistribūtīvōrum()
          : base(versiō: Versiō.Cardinālium_Et_Ōrdinālium_Et_Distribūtīvōrum,
                 quaerendī: nameof(Īnflectendum.NumerāmenCardinālumEtŌrdinālumEtDistribūtīvōrum.Numerus),
                 nūntius: new Lazy<Nūntius<PēnsorNumerāminibusCardinālumEtŌrdinālumEtDistribūtīvōrum>>(),
                 lēctor: Īnflectendum.NumerāmenCardinālumEtŌrdinālumEtDistribūtīvōrum.Lēctor)
          => Nūntius.PlūsGarriōAsync("Fīō");
  }
}
