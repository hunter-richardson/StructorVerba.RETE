using System;

using Nūntiī.Nūntius;
using Miscella;
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
  public sealed partial class ĪnflexorEffectusAdiectīvīsAutPrīmusAutSecundusAutTertiusSineLitterāE : ĪnflexorEffectusAdiectīvīs
  {
    private ĪnflexorEffectusAdiectīvīsAutPrīmusAutSecundusAutTertiusSineLitterāE()
        : base(new Lazy<Nūntius<ĪnflexorEffectusAdiectīvīsAutPrīmusAutSecundusAutTertiusSineLitterāE>>(),
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
                (Gradus.Positīvus, Genus.Masculīnum) => ĪnflexorEffectusSecundusVariusNōminibusSineLitterāE.Lazy,
                (Gradus.Superlātīvus, Genus.Masculīnum) => ĪnflexorEffectusSecundusMasculīnusNōminibus.Lazy,
                (Gradus.Comparātīvus, Genus.Neutrum) => ĪnflexorEffectusTertiusNeuterNōminibus.Lazy,
                (Gradus.Compatātīvus, _) => ĪnflexorEffectusTertiusNeuterNōminibus.Lazy,
                (_, Genus.Neutrum) => ĪnflexorEffectusSecundusNeuterNōminibus.Lazy,
                (_, Genus.Fēminīnum) => ĪnflexorEffectusPrīmusNōminibus.Lazy,
                _ => null
              };

    public sealed string Īnfīxum(in Gradus gradus, in Genus genus, in Numerālis numerālis, in Casus casus)
              => (Ūtilitātēs.Omnēs(gradus is Gradus.Positīvus, genus is Genus.Masculīnum,
                                   numerālis is Numerālis.Singulāris, casus is Casus.Nominātīvus or Casus.Vocātīvus))
                            .Choose("r".Concat(await base.ĪnfixumAsync(gradus, genus, numerālis, casus)),
                                               await base.ĪnfixumAsync(gradus, genus, numerālis, casus));
  }
}
