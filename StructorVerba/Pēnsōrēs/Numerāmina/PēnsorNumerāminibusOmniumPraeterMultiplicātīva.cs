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
                 NūntiusPēnsōrīNumerāminibusOmniumPraeterMultiplicātīva.Faciendum,
                 Īnflectendum.NumerāmenOmniumPraeterMultiplicātīva.Lēctor) { }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīNumerāminibusOmniumPraeterMultiplicātīva : Nūntius<PēnsōrNumerāminibusOmniumPraeterMultiplicātīva>
    {
      public static readonly Lazy<NūntiusPēnsōrīNumerāminibusOmniumPraeterMultiplicātīva> Faciendum =
                         new Lazy<NūntiusPēnsōrīNumerāminibusOmniumPraeterMultiplicātīva>(() => Instance);
    }
  }
}
