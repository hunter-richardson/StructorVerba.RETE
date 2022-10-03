using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;
using Īnflexōrēs.ĪnflexorNumerāmibus.Versiō;

using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Pēnsōrēs.Numerāmina
{
  [Lazy]
  public sealed class PēnsorNumerāminibusOmniumPraeterMultiplicātīva : PēnsorĪnflectendīs<Īnflectendum.NumerāmenOmniumPraeterMultiplicātīva, Multiplex.Numerāmen>
  {
    private PēnsorNumerāminibusOmniumPraeterMultiplicātīva()
          : base(versiō: Versiō.Omnium_Praeter_Multiplicātīva,
                 quaerendī: nameof(Īnflectendum.NumerāmenOmniumPraeterMultiplicātīva.Numerus),
                 nūntius: new Lazy<Nūntius<PēnsorNumerāminibusOmniumPraeterMultiplicātīva>>(),
                 lēctor: Īnflectendum.NumerāmenOmniumPraeterMultiplicātīva.Lēctor)
          => Nūntius.PlūsGarriōAsync("Fīō");
  }
}
