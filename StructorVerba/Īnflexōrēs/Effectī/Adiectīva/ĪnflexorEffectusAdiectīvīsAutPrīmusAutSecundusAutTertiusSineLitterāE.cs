using System;

using Nūntiī.Nūntius;
using Miscella;
using Praebeunda.Īnflectendum.AdiectīvumAutPrīmumAutSecundumAutTertium;
using Īnflexōrēs.Effectī.Adiectīva.ĪnflexorEffectusAdiectīvīs.Versiō;
using Īnflexōrēs.Effectī.Nōmina;
using Ēnumerātiōnēs;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Effectī.Adiectīva
{
  [Singleton]
  [AsyncOverloads]
  public sealed partial class ĪnflexorEffectusAdiectīvīsAutPrīmusAutSecundusAutTertiusSineLitterāE
            : ĪnflexorEffectusAdiectīvīs<Īnflectendum.AdiectīvumAutPrīmumAutSecundumAutTertium>
  {
    public static readonly Lazy<ĪnflexorEffectusAdiectīvīsAutPrīmusAutSecundusAutTertiusSineLitterāE> Faciendum
                     = new Lazy<ĪnflexorEffectusAdiectīvīsAutPrīmusAutSecundusAutTertiusSineLitterāE>(() => Instance);
    private ĪnflexorEffectusAdiectīvīsAutPrīmusAutSecundusAutTertiusSineLitterāE()
        : base(new Lazy<Nūntius<ĪnflexorEffectusAdiectīvīsAutPrīmusAutSecundusAutTertiusSineLitterāE>>(() => new Nūntius<ĪnflexorEffectusAdiectīvīsAutPrīmusAutSecundusAutTertiusSineLitterāE>()),
               nameof(Īnflectendum.AdiectīvumAutPrīmumAutSecundumAutTertium.Positīvum),
               (adiectīvum, illa) => illa.FirstOf<Gradus>() switch
                {
                  Gradus.Positīvus => adiectīvum.Positīvum.Chop(2),
                  Gradus.Comparātīvus => adiectīvum.Comparātīvum.Chop(3),
                  Gradus.Superlātīvus => adiectīvum.Superlātīvum.Chop(2),
                  _ => string.Empty
                }) { }
    public sealed Lazy<ĪnflexorEffectusNōminibus>? Relātum(in Gradus gradus, in Genus genus)
              => (gradus, genus) switch
              {
                (Gradus.Positīvus, Genus.Masculīnum) => ĪnflexorEffectusSecundusVariusNōminibusSineLitterāE.Faciendum,
                (Gradus.Superlātīvus, Genus.Masculīnum) => ĪnflexorEffectusSecundusMasculīnusNōminibus.Faciendum,
                (Gradus.Comparātīvus, Genus.Neutrum) => ĪnflexorEffectusTertiusNeuterNōminibus.Faciendum,
                (Gradus.Compatātīvus, _) => ĪnflexorEffectusTertiusNeuterNōminibus.Faciendum,
                (_, Genus.Neutrum) => ĪnflexorEffectusSecundusNeuterNōminibus.Faciendum,
                (_, Genus.Fēminīnum) => ĪnflexorEffectusPrīmusNōminibus.Faciendum,
                _ => null
              };

    public sealed string Īnfīxum(in Gradus gradus, in Genus genus, in Numerālis numerālis, in Casus casus)
              => (Ūtilitātēs.Omnēs(gradus is Gradus.Positīvus, genus is Genus.Masculīnum,
                                   numerālis is Numerālis.Singulāris, casus is Casus.Nominātīvus or Casus.Vocātīvus))
                            .Choose("r".Concat(await base.ĪnfixumAsync(gradus, genus, numerālis, casus)),
                                               await base.ĪnfixumAsync(gradus, genus, numerālis, casus));
  }
}
