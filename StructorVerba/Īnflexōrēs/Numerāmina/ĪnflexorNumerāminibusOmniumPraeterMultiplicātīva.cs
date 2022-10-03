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
  public sealed partial class ĪnflexorNumerāminibusOmniumPraeterMultiplicātīva : ĪnflexorNumerāminibus<NumerāmenOmniumPraeterMultiplicātīva>
  {
    private ĪnflexorNumerāminibusOmniumPraeterMultiplicātīva()
        : base(nūntius: new Lazy<Nūntius<ĪnflexorNumerāminibusOmniumPraeterMultiplicātīva>>(),
               illa: Numerium.GetValues().Except(Numerium.Multiplicātīvum))
        => Nūntius.PlūsGarriōAsync("Fīō");

    public string Scrībam(in NumerāmenOmniumPraeterMultiplicātīva numerāmen, in Numerium numerium)
            => numerium switch
                {
                  Numerium.Ōrdināle => numerāmen.Ōrdināle,
                  Numerium.Cardināle => numerāmen.Cardināle,
                  Numerium.Adverbium => numerāmen.Adverbium,
                  Numerium.Distribūtīvum => numerāmen.Distribūtīvum,
                  Numerium.Frāctiōnāle => numerāmen.Frāctiōnāle,
                  _ => numerāmen.Numerus
                };
  }
}
