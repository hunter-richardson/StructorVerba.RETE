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
          : base(versiō: Versiō.Cardinālium_Omnium,
                 quaerendī: nameof(Īnflectendum.NumerāmenCardinālumOmnium.Numerus),
                 nūntius: new Lazy<Nūntius<PēnsorNumerāminibusOmnium>>(),
                 lēctor: Īnflectendum.NumerāmenCardinālumOmnium.Lēctor)
          => Nūntius.PlūsGarriōAsync("Fīō");
  }
}
