using System;

using Nūntiī.Nūntius;
using Praebeunda.Īnflectendum.NumerāmenCardinālumEtŌrdinālumEtDistribūtīvōrum;
using Praebeunda.Multiplex.Numerāmen;
using Ēnumerātiōnēs;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.LazyAttribute;
namespace Īnflexōrēs.Numerāmina
{
  [Lazy]
  [AsyncOverloads]
  public sealed partial class ĪnflexorNumerāminibusCardinālumEtŌrdinālumEtDistribūtīvōrum
            : ĪnflexorNumerāminibus<NumerāmenCardinālumEtŌrdinālumEtDistribūtīvōrum>
  {
    private ĪnflexorNumerāminibusCardinālumEtŌrdinālumEtDistribūtīvōrum()
        : base(new Lazy<Nūntius<ĪnflexorNumerāminibusCardinālumEtŌrdinālumEtDistribūtīvōrum>>(),
               Numerium.Numerus, Numerium.Cardināle, Numerium.Ōrdināle, Numerium.Adverbium)
        => Nūntius.PlūsGarriōAsync("Fīō");

    public string Scrībam(in NumerāmenCardinālumEtŌrdinālumEtDistribūtīvōrum numerāmen, in Numerium numerium)
            => numerium switch
                {
                  Numerium.Ōrdināle => numerāmen.Ōrdināle,
                  Numerium.Cardināle => numerāmen.Cardināle,
                  Numerium.Distribūtīvum => numerāmen.Distribūtīvum,
                  _ => numerāmen.Numerus
                };
  }
}
