using System;

using Nūntiī.Nūntius;
using Praebeunda.Īnflectendum.NumerāmenCardinālumEtŌrdinālumEtAdverbiōrum;
using Praebeunda.Multiplex.Numerāmen;
using Ēnumerātiōnēs;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.LazyAttribute;
namespace Īnflexōrēs.Numerāmina
{
  [Lazy]
  [AsyncOverloads]
  public sealed partial class ĪnflexorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrum : ĪnflexorNumerāminibus
  {
    private ĪnflexorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrum()
        : base(Numerium.Numerus, Numerium.Cardināle, Numerium.Ōrdināle, Numerium.Adverbium)
        => Nūntius.PlūsGarriōAsync("Fīō");
  }
}
