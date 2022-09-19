using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;
using Īnflexōrēs.ĪnflexorNumerāmibus.Versiō;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Pēnsōrēs.Numerāmina
{
  public sealed class PēnsorNumerāminibusCardinālumŌrdināliumque : PēnsorĪnflectendīs<Īnflectendum.NumerāmenCardinālumŌrdināliumque, Multiplex.Numerāmen>
  {
    public static readonly Lazy<PēnsorNumerāminibusCardinālumŌrdināliumque> Faciendum = new Lazy(() => Instance);

    private PēnsorNumerāminibusCardinālumŌrdināliumque()
          : base(versiō: Versiō.Cardinālium_Ōrdināliumque,
                 quaerendī: nameof(Īnflectendum.NumerāmenCardinālumŌrdināliumque.Numerus),
                 nūntius: new Lazy<Nūntius<PēnsorNumerāminibusCardinālumŌrdināliumque>>(),
                 lēctor: Īnflectendum.NumerāmenCardinālumŌrdināliumque.Lēctor)
          => Nūntius.PlūsGarriōAsync("Fīō");
  }
}
