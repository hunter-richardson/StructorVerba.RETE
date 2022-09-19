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
          : base(versiō: Versiō.Omnium_Praeter_Frāctiōnēs,
                 quaerendī: nameof(Īnflectendum.NumerāmenOmniumPraeterFrāctiōnēs.Numerus),
                 nūntius: new Lazy<Nūntius<PēnsorNumerāminibusOmniumPraeterFrāctiōnēs>>(),
                 lēctor: Īnflectendum.NumerāmenOmniumPraeterFrāctiōnēs.Lēctor)
          => Nūntius.PlūsGarriōAsync("Fīō");
  }
}
