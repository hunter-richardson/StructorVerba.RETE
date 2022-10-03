using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;
using Īnflexōrēs.ĪnflexorNumerāmibus.Versiō;

using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Pēnsōrēs.Numerāmina
{
  [Lazy]
  public sealed class PēnsorNumerāminibusOmniumPraeterFrāctiōnēs : PēnsorĪnflectendīs<Īnflectendum.NumerāmenOmniumPraeterFrāctiōnēs, Multiplex.Numerāmen>
  {
    private PēnsorNumerāminibusOmniumPraeterFrāctiōnēs()
          : base(versiō: Versiō.Omnium_Praeter_Frāctiōnēs,
                 quaerendī: nameof(Īnflectendum.NumerāmenOmniumPraeterFrāctiōnēs.Numerus),
                 nūntius: new Lazy<Nūntius<PēnsorNumerāminibusOmniumPraeterFrāctiōnēs>>(),
                 lēctor: Īnflectendum.NumerāmenOmniumPraeterFrāctiōnēs.Lēctor)
          => Nūntius.PlūsGarriōAsync("Fīō");
  }
}
