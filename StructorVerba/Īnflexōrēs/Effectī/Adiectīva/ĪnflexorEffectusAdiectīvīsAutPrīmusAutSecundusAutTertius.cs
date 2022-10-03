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
  public sealed partial class ĪnflexorEffectusAdiectīvīsAutPrīmusAutSecundusAutTertius
            : ĪnflexorEffectusAdiectīvīs<Īnflectendum.AdiectīvumAutPrīmumAutSecundumAutTertium>
  {
    private ĪnflexorEffectusAdiectīvīsAutPrīmusAutSecundusAutTertius()
        : base(new Lazy<Nūntius<ĪnflexorEffectusAdiectīvīsAutPrīmusAutSecundusAutTertius>>(),
               nameof(Īnflectendum.AdiectīvumAutPrīmumAutSecundumAutTertium.Positīvum),
               (adiectīvum, illa) => illa.FirstOf<Gradus>() switch
                                      {
                                        Gradus.Positīvus => adiectīvum.Positīvum.Chop(2),
                                        Gradus.Comparātīvus => adiectīvum.Comparātīvum.Chop(3),
                                        Gradus.Superlātīvus => adiectīvum.Superlātīvum.Chop(2),
                                        _ => string.Empty
                                      })
        => Nūntius.PlūsGarriōAsync("Fīō");

    public sealed Lazy<ĪnflexorEffectusNōminibus>? Relātum(in Gradus gradus, in Genus genus)
              => (gradus, genus) switch
                  {
                    (Gradus.Comparātīvus, Genus.Neutrum) => ĪnflexorEffectusTertiusNeuterNōminibus.Lazy,
                    (Gradus.Compatātīvus, _) => ĪnflexorEffectusTertiusNeuterNōminibus.Lazy,
                    (_, Genus.Neutrum) => ĪnflexorEffectusSecundusNeuterNōminibus.Lazy,
                    (_, Genus.Masculīnum) => ĪnflexorEffectusSecundusMasculīnusNōminibus.Lazy,
                    (_, Genus.Fēminīnum) => ĪnflexorEffectusPrīmusNōminibus.Lazy,
                    _ => null
                  };
  }
}
