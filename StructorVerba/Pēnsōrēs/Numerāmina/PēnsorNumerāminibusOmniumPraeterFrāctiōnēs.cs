using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;
using Īnflexōrēs.ĪnflexorNumerāmibus.Versiō;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Pēnsōrēs.Numerāmina
{
  public sealed class PēnsorNumerāminibusOmniumPraeterFrāctiōnēs : PēnsorĪnflectendīs<Īnflectendum.NumerāmenOmniumPraeterFrāctiōnēs, Multiplex.Numerāmen>
  {
    public static readonly Lazy<PēnsorNumerāminibusOmniumPraeterFrāctiōnēs> Faciendum = new Lazy(() => Instance);

    private PēnsorNumerāminibusOmniumPraeterFrāctiōnēs()
          : base(Versiō.Omnium_Praeter_Frāctiōnēs,
                 nameof(Īnflectendum.NumerāmenOmniumPraeterFrāctiōnēs.Numerus),
                 new Lazy<Nūntius<PēnsorNumerāminibusOmniumPraeterFrāctiōnēs>>(),
                 Īnflectendum.NumerāmenOmniumPraeterFrāctiōnēs.Lēctor) { }
  }
}
