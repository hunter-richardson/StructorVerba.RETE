using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;
using Īnflexōrēs.ĪnflexorNumerāmibus.Versiō;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Pēnsōrēs.Numerāmina
{
  public sealed class PēnsorNumerāminibusCardinālumSōlōrum : PēnsorĪnflectendīs<Īnflectendum.NumerāmenCardinālumSōlōrum, Multiplex.Numerāmen>
  {
    public static readonly Lazy<PēnsorNumerāminibusCardinālumSōlōrum> Faciendum = new Lazy(() => Instance);

    private PēnsorNumerāminibusCardinālumSōlōrum()
          : base(versiō: Versiō.Cardinālium_Sōlōrum,
                 quaerendī: nameof(Īnflectendum.NumerāmenCardinālumSōlōrum.Numerus),
                 nūntius: new Lazy<Nūntius<PēnsorNumerāminibusCardinālumSōlōrum>>(),
                 lēctor: Īnflectendum.NumerāmenCardinālumSōlōrum.Lēctor)
          => Nūntius.PlūsGarriōAsync("Fīō");
  }
}
