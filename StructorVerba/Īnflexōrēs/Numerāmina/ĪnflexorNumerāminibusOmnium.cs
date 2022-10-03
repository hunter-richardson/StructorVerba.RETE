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
  public sealed partial class ĪnflexorNumerāminibusOmnium : ĪnflexorNumerāminibus<NumerāmenOmnium>
  {
    private ĪnflexorNumerāminibusOmnium()
        : base(nūntius: new Lazy<Nūntius<ĪnflexorNumerāminibusOmnium>>(), illa: Numerium.GetValues())
        => Nūntius.PlūsGarriōAsync("Fīō");

    public string Scrībam(in NumerāmenOmnium numerāmen, in Numerium numerium)
            => numerium switch
                {
                  Numerium.Ōrdināle => numerāmen.Ōrdināle,
                  Numerium.Cardināle => numerāmen.Cardināle,
                  Numerium.Adverbium => numerāmen.Adverbium,
                  Numerium.Multiplicātīvum => numerāmen.Multiplicātīvum,
                  Numerium.Distribūtīvum => numerāmen.Distribūtīvum,
                  Numerium.Frāctiōnāle => numerāmen.Frāctiōnāle,
                  _ => numerāmen.Numerus
                };
  }
}
