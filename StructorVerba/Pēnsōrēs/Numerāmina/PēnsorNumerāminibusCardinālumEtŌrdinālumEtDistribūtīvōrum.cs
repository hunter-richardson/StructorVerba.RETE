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
    public static readonly Lazy<PēnsorNumerāminibusCardinālumEtŌrdinālumEtDistribūtīvōrum> Faciendum =
                       new Lazy<PēnsorNumerāminibusCardinālumEtŌrdinālumEtDistribūtīvōrum>(() => Instance);
    private PēnsorNumerāminibusCardinālumEtŌrdinālumEtDistribūtīvōrum()
          : base(Versiō.Cardinālium_Et_Ōrdinālium_Et_Distribūtīvōrum,
                 nameof(Īnflectendum.NumerāmenCardinālumEtŌrdinālumEtDistribūtīvōrum.Numerus),
                 NūntiusPēnsōrīNumerāminibusCardinālumEtŌrdinālumEtDistribūtīvōrum.Faciendum,
                 Īnflectendum.NumerāmenCardinālumEtŌrdinālumEtDistribūtīvōrum.Lēctor) { }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīNumerāminibusCardinālumEtŌrdinālumEtDistribūtīvōrum
                : Nūntius<PēnsōrNumerāminibusCardinālumEtŌrdinālumEtDistribūtīvōrum>
    {
      public static readonly Lazy<NūntiusPēnsōrīNumerāminibusCardinālumEtŌrdinālumEtDistribūtīvōrum> Faciendum =
                         new Lazy<NūntiusPēnsōrīNumerāminibusCardinālumEtŌrdinālumEtDistribūtīvōrum>(() => Instance);
    }
  }
}
