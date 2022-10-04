using System;

using Nūntiī.Nūntius;
using Praebeunda.Īnflectendum.NumerāmenOmniumPraeterFrāctiōnēs;
using Praebeunda.Multiplex.Numerāmen;
using Ēnumerātiōnēs;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Īnflexōrēs.Numerāmina
{
  [Lazy]
  [AsyncOverloads]
  public sealed partial class ĪnflexorNumerāminibusOmniumPraeterFrāctiōnēs : ĪnflexorNumerāminibus
  {
    private ĪnflexorNumerāminibusOmniumPraeterFrāctiōnēs()
        : base(illa: Numerium.GetValues().Except(Numerium.Frāctiōnāle))
        => Nūntius.PlūsGarriōAsync("Fīō");
  }
}
