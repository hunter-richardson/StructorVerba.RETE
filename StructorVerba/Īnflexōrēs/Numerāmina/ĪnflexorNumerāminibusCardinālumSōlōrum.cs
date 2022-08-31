using System;
using Praebeunda.Īnflectendum.NumerāmenCardinālumSōlōrum;
using Praebeunda.Multiplex.Numerāmen;
using Ēnumerātiōnēs;
using Nūntiī.Nūntius;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Numerāmina
{
  [Singleton]
  [AsyncOverloads]
  public sealed partial class ĪnflexorNumerāminibusCardinālumSōlōrum : ĪnflexorNumerāminibus<NumerāmenCardinālumSōlōrum>
  {
    public static readonly Lazy<ĪnflexorNumerāminibusCardinālumSōlōrum> Faciendum = new Lazy<ĪnflexorNumerāminibusCardinālumSōlōrum>(() => Instance);
    protected ĪnflexorNumerāminibusOmniumPraeterMultiplicātīva()
          : base(Ēnumerātiōnēs.Catēgoria.Numerāmen, NūntiusĪnflexōrīNumerāminibusCardinālumSōlōrum.Faciendum,
                 Numerium.Numerus, Numerium.Cardināle) { }

    public string Scrībam(in NumerāminibusCardinālumŌrdinālumque numerāmen, in Numerium numerium)
            => Numerium.Cardināle.Equals(numerium).Choose(numerāmen.Cardināle, numerāmen.Numerus);

    [Singleton]
    private sealed partial class NūntiusĪnflexōrīNumerāminibusCardinālumSōlōrum : Nūntius<ĪnflexorNumerāminibusCardinālumSōlōrum>
    {
      public static readonly Lazy<NūntiusĪnflexōrīNumerāminibusCardinālumSōlōrum> Faciendum =
                         new Lazy<NūntiusĪnflexōrīNumerāminibusCardinālumSōlōrum>(() => Instance);
    }
  }
}
