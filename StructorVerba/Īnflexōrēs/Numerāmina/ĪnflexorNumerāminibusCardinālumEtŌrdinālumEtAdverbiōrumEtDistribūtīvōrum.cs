using System;

using Nūntiī.Nūntius;
using Praebeunda.Īnflectendum.NumerāmenCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum;
using Praebeunda.Multiplex.Numerāmen;
using Ēnumerātiōnēs;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.LazyAttribute;
namespace Īnflexōrēs.Numerāmina
{
  [Lazy]
  [AsyncOverloads]
  public sealed partial class ĪnflexorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum : ĪnflexorNumerāminibus
  {
    private ĪnflexorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum()
        : base(Numerium.Numerus, Numerium.Cardināle, Numerium.Ōrdināle, Numerium.Adverbium, Numerium.Distribūtīvum)
        => Nūntius.PlūsGarriōAsync("Fīō");
  }
}
