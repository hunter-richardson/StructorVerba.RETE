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
  public sealed partial class ĪnflexorEffectusAdiectīvīsAutTertiusAutPrīmusAutSecundusCumGenitīvōVariō
            : ĪnflexorEffectusAdiectīvīs<Īnflectendum.AdiectīvumAutPrīmumAutSecundumAutTertium>
  {
    private ĪnflexorEffectusAdiectīvīsAutTertiusAutPrīmusAutSecundusCumGenitīvōVariō()
        : base(new Lazy<Nūntius<ĪnflexorEffectusAdiectīvīsAutTertiusAutPrīmusAutSecundusCumGenitīvōVariō>>(),
               (adiectīvum, illa) => (illa.FirstOf<Gradus>(), illa.FirstOf<Genus>(), illa.FirstOf<Numerālis>(), illa.FirstOf<Casus>()) switch
                                      {
                                        (Gradus.Positīvus, Genus.Masculīnum, Numerālis.Singulāris, Casus.Nominātīvus or Casus.Vocātīvus) => adiectīvum.Positīvum,
                                        (Gradus.Superlātīvus, _, _, _) => adiectīvum.Superlātīvum.Chop(2),
                                        (_, _, _, _) => adiectīvum.Comparātīvum.Chop(3),
                                      })
        => Nūntius.PlūsGarriōAsync("Fīō");

    public sealed Lazy<ĪnflexorEffectusNōminibus>? Relātum(in Gradus gradus, in Genus genus)
              => (gradus, genus) switch
              {
                (Gradus.Superlātīvus, Genus.Neutrum) => ĪnflexorEffectusSecundusNeuterNōminibus.Lazy,
                (Gradus.Superlātīvus, Genus.Masculīnum) => ĪnflexorEffectusSecundusMasculīnusNōminibus.Lazy,
                (Gradus.Superlātīvus, Genus.Fēminīnum) => ĪnflexorEffectusPrīmusNōminibus.Lazy,
                (_, Genus.Neutrum) => ĪnflexorEffectusTertiusNeuterNōminibusCumGenitīvōVariō.Lazy,
                (_, _) => ĪnflexorEffectusTertiusNeuterNōminibusCumGenitīvōVariō.Lazy,
                _ => null
              };
  }
}
