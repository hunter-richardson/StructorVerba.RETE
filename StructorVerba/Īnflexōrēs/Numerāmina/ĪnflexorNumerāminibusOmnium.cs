using System;

using Nūntiī.Nūntius;
using Praebeunda.Īnflectendum.NumerāmenOmnium;
using Praebeunda.Multiplex.Numerāmen;
using Ēnumerātiōnēs;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Īnflexōrēs.Numerāmina
{
  [Lazy]
  [AsyncOverloads]
  public sealed partial class ĪnflexorNumerāminibusOmnium : ĪnflexorNumerāminibus
  {
    private ĪnflexorNumerāminibusOmnium()
        : base(illa: Numerium.GetValues())
        => Nūntius.PlūsGarriōAsync("Fīō");
  }
}
