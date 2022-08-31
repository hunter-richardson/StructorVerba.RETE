using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;
using Īnflexōrēs.ĪnflexorNumerāmibus.Versiō;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Pēnsōrēs.Numerāmina
{
  public sealed class PēnsorNumerāminibusOmnium : PēnsorĪnflectendīs<Īnflectendum.NumerāmenOmnium, Multiplex.Numerāmen>
  {
    public static readonly Lazy<PēnsorNumerāminibusOmnium> Faciendum = new Lazy<PēnsorNumerāminibusOmnium>(() => Instance);

    private PēnsorNumerāminibusOmnium()
          : base(Versiō.Cardinālium_Omnium,
                 nameof(Īnflectendum.NumerāmenCardinālumOmnium.Numerus),
                 NūntiusPēnsōrīNumerāminibusCardinālumOmnium.Faciendum,
                 Īnflectendum.NumerāmenCardinālumOmnium.Lēctor) { }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīNumerāminibusOmnium : Nūntius<PēnsōrNumerāminibusOmnium>
    {
      public static readonly Lazy<NūntiusPēnsōrīNumerāminibusOmnium> Faciendum = new Lazy<NūntiusPēnsōrīNumerāminibusOmnium>(() => Instance);
    }
  }
}
