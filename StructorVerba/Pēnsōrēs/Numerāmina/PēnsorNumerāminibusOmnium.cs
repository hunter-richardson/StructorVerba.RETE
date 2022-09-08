using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;
using Īnflexōrēs.ĪnflexorNumerāmibus.Versiō;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Pēnsōrēs.Numerāmina
{
  public sealed class PēnsorNumerāminibusOmnium : PēnsorĪnflectendīs<Īnflectendum.NumerāmenOmnium, Multiplex.Numerāmen>
  {
    public static readonly Lazy<PēnsorNumerāminibusOmnium> Faciendum = new Lazy(() => Instance);

    private PēnsorNumerāminibusOmnium()
          : base(Versiō.Cardinālium_Omnium,
                 nameof(Īnflectendum.NumerāmenCardinālumOmnium.Numerus),
                 new Lazy<Nūntius<PēnsorNumerāminibusOmnium>>(),
                 Īnflectendum.NumerāmenCardinālumOmnium.Lēctor) { }
  }
}
