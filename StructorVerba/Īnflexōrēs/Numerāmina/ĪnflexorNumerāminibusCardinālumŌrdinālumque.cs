
using Praebeunda.Īnflectendum.NumerāmenCardinālumŌrdinālumque;
using Ēnumerātiōnēs;
using Nūntiī.Nūntius;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Numerāmina
{
  [Singleton]
  [AsyncOverloads]
  public sealed partial class ĪnflexorNumerāminibusCardinālumŌrdinālumque : ĪnflexorNumerāminibus<NumerāminibusCardinālumŌrdinālumque>
  {
    public static readonly Lazy<ĪnflexorNumerāminibusCardinālumŌrdinālumque> Faciendum = new Lazy<ĪnflexorNumerāminibusCardinālumŌrdinālumque>(() => Instance);

    protected ĪnflexorNumerāminibusOmniumPraeterMultiplicātīva()
          : base(Ēnumerātiōnēs.Catēgoria.Numerāmen, NūntiusĪnflexōrīNumerāminibusCardinālumSōlōrum.Faciendum,
                 Numerium.Numerus, Numerium.Cardināle, Numerium.Ōrdināle) { }
    public string Scrībam(in NumerāminibusCardinālumŌrdinālumque numerāmen, in Numerium numerium)
            => numerium switch
            {
              Numerium.Ōrdināle => numerāmen.Ōrdināle,
              Numerium.Cardināle => numerāmen.Cardināle,
              _ => numerāmen.Numerus
            };

    [Singleton]
    private sealed partial class NūntiusĪnflexōrīNumerāminibusCardinālumŌrdinālumque : Nūntius<ĪnflexorNumerāminibusCardinālumŌrdinālumque>
    {
      public static readonly Lazy<NūntiusĪnflexōrīNumerāminibusCardinālumŌrdinālumque> Faciendum =
                         new Lazy<NūntiusĪnflexōrīNumerāminibusCardinālumŌrdinālumque>(() => Instance);
    }
  }
}
