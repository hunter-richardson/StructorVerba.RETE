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
    public static readonly Lazy<PēnsorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrum> Faciendum = new Lazy(() => Instance);
    private PēnsorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrum()
          : base(versiō: Versiō.Cardinālium_Et_Ōrdinālium_Et_Adverbiōrum,
                 quaerendī: nameof(Īnflectendum.NumerāmenCardinālumEtŌrdinālumEtAdverbiōrum.Numerus),
                 nūntius: new Lazy<Nūntius<PēnsorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrum>>(),
                 lēctor: Īnflectendum.NumerāmenCardinālumEtŌrdinālumEtAdverbiōrum.Lēctor)
          => Nūntius.PlūsGarriōAsync("Fīō");
  }
}
