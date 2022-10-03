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
  public sealed partial class ĪnflexorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrum : ĪnflexorNumerāminibus<NumerāmenCardinālumEtŌrdinālumEtAdverbiōrum>
  {
    private ĪnflexorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrum()
        : base(new Lazy<Nūntius<ĪnflexorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrum>>(),
               Numerium.Numerus, Numerium.Cardināle, Numerium.Ōrdināle, Numerium.Adverbium)
        => Nūntius.PlūsGarriōAsync("Fīō");

    public string Scrībam(in NumerāmenCardinālumEtŌrdinālumEtAdverbiōrum numerāmen, in Numerium numerium)
            => numerium switch
                {
                  Numerium.Ōrdināle => numerāmen.Ōrdināle,
                  Numerium.Cardināle => numerāmen.Cardināle,
                  Numerium.Adverbium => numerāmen.Adverbium,
                  _ => numerāmen.Numerus
                };
  }
}
