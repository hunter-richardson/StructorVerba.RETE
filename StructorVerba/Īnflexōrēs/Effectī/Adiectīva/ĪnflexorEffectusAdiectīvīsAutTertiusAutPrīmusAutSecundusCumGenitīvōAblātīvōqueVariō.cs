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
  public sealed partial class ĪnflexorEffectusAdiectīvīsAutTertiusAutPrīmusAutSecundusCumGenitīvōAblātīvōqueVariō
            : ĪnflexorEffectusAdiectīvīs<Īnflectendum.AdiectīvumAutPrīmumAutSecundumAutTertium>
  {
    public static readonly Lazy<ĪnflexorEffectusAdiectīvīsAutTertiusAutPrīmusAutSecundusCumGenitīvōAblātīvōqueVariō> Faciendum
                     = new Lazy<ĪnflexorEffectusAdiectīvīsAutTertiusAutPrīmusAutSecundusCumGenitīvōAblātīvōqueVariō>(() => Instance);
    private ĪnflexorEffectusAdiectīvīsAutTertiusAutPrīmusAutSecundusCumGenitīvōAblātīvōqueVariō()
        : base(Versiō.Aut_Tertius_Aut_Prīmus_Aut_Secundus_Cum_Genitīvō_Ablātīvōque_Variō,
               NūntiusĪnflexōrīEffectōAdiectīvīsAutTertiōAutPrīmōAutSecundōCumGenitīvōAblātīvōqueVariō.Faciendum,
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
                (_, Genus.Neutrum) => ĪnflexorEffectusTertiusNeuterNōminibusCumGenitīvōAblātīvōqueVariō.Faciendum,
                (_, _) => ĪnflexorEffectusTertiusNeuterNōminibusCumGenitīvōAblātīvōqueVariō.Faciendum,
                _ => null
              };

    [Singleton]
    private sealed partial class NūntiusĪnflexōrīEffectōAdiectīvīsAutTertiōAutPrīmōAutSecundōCumGenitīvōAblātīvōqueVariō
                : Nūntius<ĪnflexorEffectusAdiectīvīsAutTertiusAutPrīmusAutSecundusCumGenitīvōAblātīvōqueVariō>
    {
      public static readonly Lazy<NūntiusĪnflexōrīEffectōAdiectīvīsAutTertiōAutPrīmōAutSecundōCumGenitīvōAblātīvōqueVariō> Faciendum
                       = new Lazy<NūntiusĪnflexōrīEffectōAdiectīvīsAutTertiōAutPrīmōAutSecundōCumGenitīvōAblātīvōqueVariō>(() => Instance);
    }
  }
}
