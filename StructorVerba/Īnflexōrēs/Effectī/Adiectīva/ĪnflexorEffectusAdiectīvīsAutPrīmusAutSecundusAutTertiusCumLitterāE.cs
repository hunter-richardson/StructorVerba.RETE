using System;

using Nūntiī.Nūntius;
using Miscella.Extensions;
using Praebeunda.Īnflectendum.AdiectīvumAutPrīmumAutSecundumAutTertium;
using Īnflexōrēs.Effectī.Adiectīva.ĪnflexorEffectusAdiectīvīs.Versiō;
using Īnflexōrēs.Effectī.Nōmina;
using Ēnumerātiōnēs;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Īnflexōrēs.Effectī.Adiectīva
{
  [Lazy]
  [AsyncOverloads]
  public sealed partial class ĪnflexorEffectusAdiectīvīsAutPrīmusAutSecundusAutTertiusCumLitterāE : ĪnflexorEffectusAdiectīvīs
  {
    private ĪnflexorEffectusAdiectīvīsAutPrīmusAutSecundusAutTertiusCumLitterāE()
        : base(new Lazy<Nūntius<ĪnflexorEffectusAdiectīvīsAutPrīmusAutSecundusAutTertiusCumLitterāE>>(),
               (adiectīvum, illa) => illa.FirstOf<Gradus>() switch
                {
                  Gradus.Positīvus => adiectīvum.Positīvum,
                  Gradus.Comparātīvus => adiectīvum.Comparātīvum.Chop(3),
                  Gradus.Superlātīvus => adiectīvum.Superlātīvum.Chop(2),
                  _ => string.Empty
                })
        => Nūntius.PlūsGarriōAsync("Fīō");

    public sealed Lazy<ĪnflexorEffectusNōminibus>? Relātum(in Gradus gradus, in Genus genus)
              => (gradus, genus) switch
              {
                (Gradus.Positīvus, Genus.Masculīnum) => ĪnflexorEffectusSecundusVariusNōminibusCumLitterāE.Lazy,
                (Gradus.Superlātīvus, Genus.Masculīnum) => ĪnflexorEffectusSecundusMasculīnusNōminibus.Lazy,
                (Gradus.Comparātīvus, Genus.Neutrum) => ĪnflexorEffectusTertiusNeuterNōminibus.Lazy,
                (Gradus.Compatātīvus, _) => ĪnflexorEffectusTertiusNeuterNōminibus.Lazy,
                (_, Genus.Neutrum) => ĪnflexorEffectusSecundusNeuterNōminibus.Lazy,
                (_, Genus.Fēminīnum) => ĪnflexorEffectusPrīmusNōminibus.Lazy,
                _ => null
              };
  }
}
