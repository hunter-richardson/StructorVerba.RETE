using System;

using Nūntiī.Nūntius;
using Praebeunda.Īnflectendum.NumerāmenOmniumPraeterMultiplicātīva;
using Praebeunda.Multiplex.Numerāmen;
using Ēnumerātiōnēs;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Īnflexōrēs.Numerāmina
{
  [Lazy]
  [AsyncOverloads]
  public sealed partial class ĪnflexorNumerāminibusOmniumPraeterMultiplicātīva : ĪnflexorNumerāminibus
  {
    private ĪnflexorNumerāminibusOmniumPraeterMultiplicātīva()
        : base(illa: Numerium.GetValues().Except(Numerium.Multiplicātīvum))
        => Nūntius.PlūsGarriōAsync("Fīō");
  }
}
