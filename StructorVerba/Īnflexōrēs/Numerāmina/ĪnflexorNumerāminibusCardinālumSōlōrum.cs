using System;

using Nūntiī.Nūntius;
using Praebeunda.Īnflectendum.NumerāmenCardinālumSōlōrum;
using Praebeunda.Multiplex.Numerāmen;
using Ēnumerātiōnēs;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Īnflexōrēs.Numerāmina
{
  [Lazy]
  [AsyncOverloads]
  public sealed partial class ĪnflexorNumerāminibusCardinālumSōlōrum : ĪnflexorNumerāminibus<NumerāmenCardinālumSōlōrum>
  {
    private ĪnflexorNumerāminibusCardinālumSōlōrum()
        : base(new Lazy<Nūntius<ĪnflexorNumerāminibusCardinālumSōlōrum>>(),
               Numerium.Numerus, Numerium.Cardināle)
        => Nūntius.PlūsGarriōAsync("Fīō");

    public string Scrībam(in NumerāminibusCardinālumŌrdinālumque numerāmen, in Numerium numerium)
            => Numerium.Cardināle.Equals(numerium).Choose(numerāmen.Cardināle, numerāmen.Numerus);
  }
}
