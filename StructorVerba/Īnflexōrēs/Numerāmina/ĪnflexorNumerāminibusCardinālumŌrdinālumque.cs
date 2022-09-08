using System;

using Nūntiī.Nūntius;
using Praebeunda.Īnflectendum.NumerāmenCardinālumŌrdinālumque;
using Ēnumerātiōnēs;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Numerāmina
{
  [Singleton]
  [AsyncOverloads]
  public sealed partial class ĪnflexorNumerāminibusCardinālumŌrdinālumque : ĪnflexorNumerāminibus<NumerāminibusCardinālumŌrdinālumque>
  {
    public static readonly Lazy<ĪnflexorNumerāminibusCardinālumŌrdinālumque> Faciendum = new Lazy(() => Instance);

    protected ĪnflexorNumerāminibusCardinālumŌrdinālumque()
          : base(new Lazy<Nūntius<ĪnflexorNumerāminibusCardinālumŌrdinālumque>>(),
                 Numerium.Numerus, Numerium.Cardināle, Numerium.Ōrdināle) { }
    public string Scrībam(in NumerāminibusCardinālumŌrdinālumque numerāmen, in Numerium numerium)
            => numerium switch
                {
                  Numerium.Ōrdināle => numerāmen.Ōrdināle,
                  Numerium.Cardināle => numerāmen.Cardināle,
                  _ => numerāmen.Numerus
                };
  }
}
