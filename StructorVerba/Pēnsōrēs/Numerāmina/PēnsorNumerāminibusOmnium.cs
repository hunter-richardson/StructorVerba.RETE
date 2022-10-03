using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;
using Īnflexōrēs.ĪnflexorNumerāmibus.Versiō;

using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Pēnsōrēs.Numerāmina
{
  [Lazy]
  public sealed class PēnsorNumerāminibusOmnium : PēnsorĪnflectendīs<Īnflectendum.NumerāmenOmnium, Multiplex.Numerāmen>
  {
    private PēnsorNumerāminibusOmnium()
          : base(versiō: Versiō.Cardinālium_Omnium,
                 quaerendī: nameof(Īnflectendum.NumerāmenCardinālumOmnium.Numerus),
                 nūntius: new Lazy<Nūntius<PēnsorNumerāminibusOmnium>>(),
                 lēctor: Īnflectendum.NumerāmenCardinālumOmnium.Lēctor)
          => Nūntius.PlūsGarriōAsync("Fīō");
  }
}
