using System;

using Nūntiī.Nūntius;
using Miscella.Extensions;
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
  public sealed partial class ĪnflexorEffectusAdiectīvīsAutPrīmusAutSecundusAutTertiusCumLitterāE
            : ĪnflexorEffectusAdiectīvīs<Īnflectendum.AdiectīvumAutPrīmumAutSecundumAutTertium>
  {
    public static readonly Lazy<ĪnflexorEffectusAdiectīvīsAutPrīmusAutSecundusAutTertiusCumLitterāE> Faciendum
                     = new Lazy<ĪnflexorEffectusAdiectīvīsAutPrīmusAutSecundusAutTertiusCumLitterāE>(() => Instance);
    private ĪnflexorEffectusAdiectīvīsAutPrīmusAutSecundusAutTertiusCumLitterāE()
        : base(NūntiusĪnflexōrīEffectōAdiectīvīsAutPrīmōAutSecundōAutTertiōCumLitterāE.Faciendum,
               nameof(Īnflectendum.AdiectīvumAutPrīmumAutSecundumAutTertium.Positīvum),
               (adiectīvum, illa) => illa.FirstOf<Gradus>() switch
                {
                  Gradus.Positīvus => adiectīvum.Positīvum,
                  Gradus.Comparātīvus => adiectīvum.Comparātīvum.Chop(3),
                  Gradus.Superlātīvus => adiectīvum.Superlātīvum.Chop(2),
                  _ => string.Empty
                })
    { }
    public sealed Lazy<ĪnflexorEffectusNōminibus>? Relātum(in Gradus gradus, in Genus genus)
              => (gradus, genus) switch
              {
                (Gradus.Positīvus, Genus.Masculīnum) => ĪnflexorEffectusSecundusVariusNōminibusCumLitterāE.Faciendum,
                (Gradus.Superlātīvus, Genus.Masculīnum) => ĪnflexorEffectusSecundusMasculīnusNōminibus.Faciendum,
                (Gradus.Comparātīvus, Genus.Neutrum) => ĪnflexorEffectusTertiusNeuterNōminibus.Faciendum,
                (Gradus.Compatātīvus, _) => ĪnflexorEffectusTertiusNeuterNōminibus.Faciendum,
                (_, Genus.Neutrum) => ĪnflexorEffectusSecundusNeuterNōminibus.Faciendum,
                (_, Genus.Fēminīnum) => ĪnflexorEffectusPrīmusNōminibus.Faciendum,
                _ => null
              };

    [Singleton]
    private sealed partial class NūntiusĪnflexōrīEffectōAdiectīvīsAutPrīmōAutSecundōAutTertiōCumLitterāE
                : Nūntius<ĪnflexorEffectusAdiectīvīsAutPrīmusAutSecundusAutTertiusCumLitterāE>
    {
      public static readonly Lazy<NūntiusĪnflexōrīEffectōAdiectīvīsAutPrīmōAutSecundōAutTertiōCumLitterāE> Faciendum
                       = new Lazy<NūntiusĪnflexōrīEffectōAdiectīvīsAutPrīmōAutSecundōAutTertiōCumLitterāE>(() => Instance);
    }
  }
}
