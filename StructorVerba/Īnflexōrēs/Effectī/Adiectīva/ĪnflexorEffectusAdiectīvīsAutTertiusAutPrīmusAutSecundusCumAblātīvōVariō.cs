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
  public sealed partial class ĪnflexorEffectusAdiectīvīsAutTertiusAutPrīmusAutSecundusCumAblātīvōVariō
            : ĪnflexorEffectusAdiectīvīs<Īnflectendum.AdiectīvumAutPrīmumAutSecundumAutTertium>
  {
    public static readonly Lazy<ĪnflexorEffectusAdiectīvīsAutTertiusAutPrīmusAutSecundusCumAblātīvōVariō> Faciendum
                     = new Lazy<ĪnflexorEffectusAdiectīvīsAutTertiusAutPrīmusAutSecundusCumAblātīvōVariō>(() => Instance);
    private ĪnflexorEffectusAdiectīvīsAutTertiusAutPrīmusAutSecundusCumAblātīvōVariō()
        : base(Versiō.Aut_Tertius_Aut_Prīmus_Aut_Secundus_Cum_Ablātīvō_Variō,
               NūntiusĪnflexōrīEffectōAdiectīvīsAutTertiōAutPrīmōAutSecundōCumAblātīvōVariō.Faciendum,
               (adiectīvum, illa) => (illa.FirstOf<Gradus>(), illa.FirstOf<Genus>(), illa.FirstOf<Numerālis>(), illa.FirstOf<Casus>()) switch
                                      {
                                        (Gradus.Positīvus, Genus.Masculīnum, Numerālis.Singulāris, Casus.Nominātīvus or Casus.Vocātīvus) => adiectīvum.Positīvum,
                                        (Gradus.Superlātīvus, _, _, _) => adiectīvum.Superlātīvum.Chop(2),
                                        (_, _, _, _) => adiectīvum.Comparātīvum.Chop(3),
                                      }) {  }

    public sealed Lazy<ĪnflexorEffectusNōminibus>? Relātum(in Gradus gradus, in Genus genus)
              => (gradus, genus) switch
              {
                (Gradus.Superlātīvus, Genus.Neutrum) => ĪnflexorEffectusSecundusNeuterNōminibus.Faciendum,
                (Gradus.Superlātīvus, Genus.Masculīnum) => ĪnflexorEffectusSecundusMasculīnusNōminibus.Faciendum,
                (Gradus.Superlātīvus, Genus.Fēminīnum) => ĪnflexorEffectusPrīmusNōminibus.Faciendum,
                (_, Genus.Neutrum) => ĪnflexorEffectusTertiusNeuterNōminibusCumAblātīvōVariō.Faciendum,
                (_, _) => ĪnflexorEffectusTertiusNeuterNōminibusCumAblātīvōVariō.Faciendum,
                _ => null
              };

    [Singleton]
    private sealed partial class NūntiusĪnflexōrīEffectōAdiectīvīsAutTertiōAutPrīmōAutSecundōCumAblātīvōVariō
                : Nūntius<ĪnflexorEffectusAdiectīvīsAutTertiusAutPrīmusAutSecundusCumAblātīvōVariō>
    {
      public static readonly Lazy<NūntiusĪnflexōrīEffectōAdiectīvīsAutTertiōAutPrīmōAutSecundōCumAblātīvōVariō> Faciendum
                       = new Lazy<NūntiusĪnflexōrīEffectōAdiectīvīsAutTertiōAutPrīmōAutSecundōCumAblātīvōVariō>(() => Instance);
    }
  }
}
