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
  public sealed partial class ĪnflexorNumerāminibusOmniumPraeterFrāctiōnēs : ĪnflexorNumerāminibus<NumerāmenOmniumPraeterFrāctiōnēs>
  {
    private ĪnflexorNumerāminibusOmniumPraeterFrāctiōnēs()
        : base(nūntius: new Lazy<Nūntius<ĪnflexorNumerāminibusOmniumPraeterFrāctiōnēs>>(),
               illa: Numerium.GetValues().Except(Numerium.Frāctiōnāle))
        => Nūntius.PlūsGarriōAsync("Fīō");
    public string Scrībam(in NumerāmenOmniumPraeterFrāctiōnēs numerāmen, in Numerium numerium)
            => numerium switch
                {
                  Numerium.Numerus => numerāmen.Numerus,
                  Numerium.Ōrdināle => numerāmen.Ōrdināle,
                  Numerium.Cardināle => numerāmen.Cardināle,
                  Numerium.Adverbium => numerāmen.Adverbium,
                  Numerium.Multiplicātīvum => numerāmen.Multiplicātīvum,
                  Numerium.Distribūtīvum => numerāmen.Distribūtīvum,
                  _ => numerāmen.Numerus
                };
  }
}
