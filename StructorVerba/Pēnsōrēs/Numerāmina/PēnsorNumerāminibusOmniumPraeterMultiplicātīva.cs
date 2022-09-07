using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;
using Īnflexōrēs.ĪnflexorNumerāmibus.Versiō;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Pēnsōrēs.Numerāmina
{
  public sealed class PēnsorNumerāminibusOmniumPraeterMultiplicātīva : PēnsorĪnflectendīs<Īnflectendum.NumerāmenOmniumPraeterMultiplicātīva, Multiplex.Numerāmen>
  {
    public static readonly Lazy<PēnsorNumerāminibusOmniumPraeterMultiplicātīva> Faciendum = new Lazy<PēnsorNumerāminibusOmniumPraeterMultiplicātīva>(() => Instance);

    private PēnsorNumerāminibusOmniumPraeterMultiplicātīva()
          : base(Versiō.Omnium_Praeter_Multiplicātīva,
                 nameof(Īnflectendum.NumerāmenOmniumPraeterMultiplicātīva.Numerus),
                 new Lazy<Nūntius<PēnsorNumerāminibusOmniumPraeterMultiplicātīva>>(() => new Nūntius<PēnsorNumerāminibusOmniumPraeterMultiplicātīva>()),
                 Īnflectendum.NumerāmenOmniumPraeterMultiplicātīva.Lēctor) { }
  }
}
