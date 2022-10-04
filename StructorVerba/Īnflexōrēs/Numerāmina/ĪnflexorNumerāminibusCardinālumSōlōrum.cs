using System;

using Nūntiī.Nūntius;
using Praebeunda.Īnflectendum.NumerāmenCardinālumSōlōrum;
using Praebeunda.Multiplex.Numerāmen;
using Ēnumerātiōnēs;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Īnflexōrēs.Numerāmina
{
  [Lazy]
  [AsyncOverloads]
  public sealed partial class ĪnflexorNumerāminibusCardinālumSōlōrum : ĪnflexorNumerāminibus
  {
    private ĪnflexorNumerāminibusCardinālumSōlōrum()
        : base(Numerium.Numerus, Numerium.Cardināle)
        => Nūntius.PlūsGarriōAsync("Fīō");
  }
}
