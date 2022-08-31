using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;
using Īnflexōrēs.ĪnflexorNumerāmibus.Versiō;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Pēnsōrēs.Numerāmina
{
  public sealed class PēnsorNumerāminibusCardinālumSōlōrum : PēnsorĪnflectendīs<Īnflectendum.NumerāmenCardinālumSōlōrum, Multiplex.Numerāmen>
  {
    public static readonly Lazy<PēnsorNumerāminibusCardinālumSōlōrum> Faciendum =
                       new Lazy<PēnsorNumerāminibusCardinālumSōlōrum>(() => Instance);

    private PēnsorNumerāminibusCardinālumSōlōrum()
          : base(Versiō.Cardinālium_Sōlōrum,
                 nameof(Īnflectendum.NumerāmenCardinālumSōlōrum.Numerus),
                 NūntiusPēnsōrīNumerāminibusCardinālumSōlōrum.Faciendum,
                 Īnflectendum.NumerāmenCardinālumSōlōrum.Lēctor) { }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīNumerāminibusCardinālumSōlōrum : Nūntius<PēnsōrNumerāminibusCardinālumSōlōrum>
    {
      public static readonly Lazy<NūntiusPēnsōrīNumerāminibusCardinālumSōlōrum> Faciendum = new Lazy<NūntiusPēnsōrīNumerāminibusCardinālumSōlōrum>(() => Instance);
    }
  }
}
