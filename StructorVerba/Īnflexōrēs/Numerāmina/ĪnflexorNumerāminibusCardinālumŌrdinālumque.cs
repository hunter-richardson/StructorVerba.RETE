using System;

using Nūntiī.Nūntius;
using Praebeunda.Īnflectendum.NumerāmenCardinālumŌrdinālumque;
using Ēnumerātiōnēs;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Īnflexōrēs.Numerāmina
{
  [Lazy]
  [AsyncOverloads]
  public sealed partial class ĪnflexorNumerāminibusCardinālumŌrdinālumque : ĪnflexorNumerāminibus<NumerāminibusCardinālumŌrdinālumque>
  {
    private ĪnflexorNumerāminibusCardinālumŌrdinālumque()
        : base(new Lazy<Nūntius<ĪnflexorNumerāminibusCardinālumŌrdinālumque>>(),
               Numerium.Numerus, Numerium.Cardināle, Numerium.Ōrdināle)
        => Nūntius.PlūsGarriōAsync("Fīō");
    public string Scrībam(in NumerāminibusCardinālumŌrdinālumque numerāmen, in Numerium numerium)
            => numerium switch
                {
                  Numerium.Ōrdināle => numerāmen.Ōrdināle,
                  Numerium.Cardināle => numerāmen.Cardināle,
                  _ => numerāmen.Numerus
                };
  }
}
