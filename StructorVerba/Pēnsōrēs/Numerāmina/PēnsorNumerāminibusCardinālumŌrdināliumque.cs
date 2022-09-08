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
          : base(Versiō.Cardinālium_Ōrdināliumque,
                 nameof(Īnflectendum.NumerāmenCardinālumŌrdināliumque.Numerus),
                 new Lazy<Nūntius<PēnsorNumerāminibusCardinālumŌrdināliumque>>(),
                 Īnflectendum.NumerāmenCardinālumŌrdināliumque.Lēctor) { }
  }
}
