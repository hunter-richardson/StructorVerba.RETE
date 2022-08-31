using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;
using Īnflexōrēs.ĪnflexorNumerāmibus.Versiō;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Pēnsōrēs.Numerāmina
{
  public sealed class PēnsorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrum
            : PēnsorĪnflectendīs<Īnflectendum.NumerāmenCardinālumEtŌrdinālumEtAdverbiōrum, Multiplex.Numerāmen>
  {
    public static readonly Lazy<PēnsorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrum> Faciendum =
                       new Lazy<PēnsorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrum>(() => Instance);
    private PēnsorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrum()
          : base(Versiō.Cardinālium_Et_Ōrdinālium_Et_Adverbiōrum,
                 nameof(Īnflectendum.NumerāmenCardinālumEtŌrdinālumEtAdverbiōrum.Numerus),
                 NūntiusPēnsōrīNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrum.Faciendum,
                 Īnflectendum.NumerāmenCardinālumEtŌrdinālumEtAdverbiōrum.Lēctor) { }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrum
                : Nūntius<PēnsōrNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrum>
    {
      public static readonly Lazy<NūntiusPēnsōrīNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrum> Faciendum =
                         new Lazy<NūntiusPēnsōrīNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrum>(() => Instance);
    }
  }
}
