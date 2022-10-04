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
  public sealed partial class ĪnflexorNumerāminibusCardinālumŌrdinālumque : ĪnflexorNumerāminibus
  {
    private ĪnflexorNumerāminibusCardinālumŌrdinālumque()
        : base(Numerium.Numerus, Numerium.Cardināle, Numerium.Ōrdināle)
        => Nūntius.PlūsGarriōAsync("Fīō");
  }
}
