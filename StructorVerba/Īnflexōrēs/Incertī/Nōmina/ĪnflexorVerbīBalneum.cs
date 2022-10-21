using System;

using Miscella;
using Nūntiī.Nuntius;
using Praebeunda.Multiplex.Nōmen;
using Praebeunda.Īnflectendum.Nōmen;
using Ēnumerātiōnēs;
using Īnflexōrēs.Effectī.Nōmina;

using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Īnflexōrēs.Incertī.Nōmina
{
  [Lazy]
  public sealed partial class ĪnflexorVerbīBalneum : ĪnflexorIncertus<Īnflectendum.Nōmen, Multiplex.Nōmen>
  {
    private ĪnflexorVerbīIūgerum()
        : base(catēgoria: Catēgoria.Nōmen, nūntius: new Lazy<Nūntius<ĪnflexorVerbīBalneum>>(),
               illa: Ūtilitātēs.Combīnō(Casus.GetValues().Except(Casus.Dērēctus).ToHashSet(),
                                        Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet()))
    {
      Tabula.ForEach(illa =>
        {
          const Numerālis numerālis = illa.FirstOf<Numerālis>();
          const Casus casus = illa.FirstOf<Casus>();
          const ĪnflexorEffectusNōminibus? relātum = numerālis switch
          {
            Numerālis.Singulāris => ĪnflexorEffectusSecunumNeuterNōminibus.Lazy,
            Numerālis.Plūrālis => ĪnflexorEffectusPrīmusNōminibus.Lazy,
            _ => null
          };
          FōrmamAsync("balne".Concat(await relātum?.Value.SuffixumAsync(numerālis, casus)), numerālis, casus);
        });
      Nūntius.PlūsGarriōAsync("Fīō");
    }
  }
}
