using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;
using Īnflexōrēs.ĪnflexorNumerāmibus.Versiō;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Pēnsōrēs.Numerāmina
{
  public sealed class PēnsorNumerāminibusOmniumPraeterFrāctiōnēs : PēnsorĪnflectendīs<Īnflectendum.NumerāmenOmniumPraeterFrāctiōnēs, Multiplex.Numerāmen>
  {
    public static readonly Lazy<PēnsorNumerāminibusOmniumPraeterFrāctiōnēs> Faciendum = new Lazy<PēnsorNumerāminibusOmniumPraeterFrāctiōnēs>(() => Instance);

    private PēnsorNumerāminibusOmniumPraeterFrāctiōnēs()
          : base(Versiō.Omnium_Praeter_Frāctiōnēs,
                 nameof(Īnflectendum.NumerāmenOmniumPraeterFrāctiōnēs.Numerus),
                 NūntiusPēnsōrīNumerāminibusOmniumPraeterFrāctiōnēs.Faciendum,
                 Īnflectendum.NumerāmenOmniumPraeterFrāctiōnēs.Lēctor) { }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīNumerāminibusOmniumPraeterFrāctiōnēs : Nūntius<PēnsōrNumerāminibusOmniumPraeterFrāctiōnēs>
    {
      public static readonly Lazy<NūntiusPēnsōrīNumerāminibusOmniumPraeterFrāctiōnēs> Faciendum =
                         new Lazy<NūntiusPēnsōrīNumerāminibusOmniumPraeterFrāctiōnēs>(() => Instance);
    }
  }
}
