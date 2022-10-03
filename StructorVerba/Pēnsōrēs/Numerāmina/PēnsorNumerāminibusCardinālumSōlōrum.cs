using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;
using Īnflexōrēs.ĪnflexorNumerāmibus.Versiō;

using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Pēnsōrēs.Numerāmina
{
  [Lazy]
  public sealed class PēnsorNumerāminibusCardinālumSōlōrum : PēnsorĪnflectendīs<Īnflectendum.NumerāmenCardinālumSōlōrum, Multiplex.Numerāmen>
  {
    private PēnsorNumerāminibusCardinālumSōlōrum()
          : base(versiō: Versiō.Cardinālium_Sōlōrum,
                 quaerendī: nameof(Īnflectendum.NumerāmenCardinālumSōlōrum.Numerus),
                 nūntius: new Lazy<Nūntius<PēnsorNumerāminibusCardinālumSōlōrum>>(),
                 lēctor: Īnflectendum.NumerāmenCardinālumSōlōrum.Lēctor)
          => Nūntius.PlūsGarriōAsync("Fīō");
  }
}
