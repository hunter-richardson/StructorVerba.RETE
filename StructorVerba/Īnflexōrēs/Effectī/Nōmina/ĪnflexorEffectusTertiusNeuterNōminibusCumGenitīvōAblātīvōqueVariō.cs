using System;

using Nūntiī.Nūntius;
using Miscella.Extensions;
using Ēnumerātiōnēs;
using Īnflexōrēs.Effectī.Nōmina.ĪnflexorEffectusNōminibus.Versiō;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Effectī.Nōmina
{
  [Singleton]
  [AsyncOverloads]
  public sealed partial class ĪnflexorEffectusTertiusNeuterNōminibusCumGenitīvōAblātīvōqueVariō : ĪnflexorEffectusNōminibus
  {
    public static readonly Lazy<ĪnflexorEffectusTertiusNeuterNōminibusCumGenitīvōAblātīvōqueVariō> Faciendum
                     = new Lazy<ĪnflexorEffectusTertiusNeuterNōminibusCumGenitīvōAblātīvōqueVariō>(() => Instance);
    private readonly ĪnflexorEffectusTertiusNeuterNōminibus Relātum = ĪnflexorEffectusTertiusNeuterNōminibus.Faciendum.Value;
    private ĪnflexorEffectusTertiusNeuterNōminibusCumGenitīvōAblātīvōqueVariō()
        : base(Versiō.Nōmen_Tertium_Neutrum_Cum_Genitīvō_Ablātīvōque_Variō,
               NūntiusĪnflexōrīEffectōTertiōNeutrōNōminibusCumGenitīvōAblātīvōqueVariō.Faciendum,
               (nōmen, illa) => (illa.FirstOf<Numerālis>(), illa.FirstOf<Casus>()) switch
                                {
                                  (Numerālis.Singulāris, Casus.Nominātīvus or Casus.Vocātīvus) => nōmen.Nominātīvum,
                                  _ => nōmen.Genitīvum.Chop(2)
                                }) { }

    public sealed string Singulāre(in Casus casus)
              => (casus is Casus.Ablātīvus or Casus.Locātīvus or Casus.Instrumentālis)
                        .Choose("ī", await Relātum.SingulāreAsync(casus));

    public sealed string Plūrāle(in Casus casus) => (casus is Casus.Genitīvus).Choose("ium", Relātum.PlūrāleAsync(casus));

    [Singleton]
    private sealed class NūntiusĪnflexōrīEffectōTertiōNeutrōNōminibusCumGenitīvōAblātīvōqueVariō
                : Nūntius<ĪnflexorEffectusTertiusNeuterNōminibusCumGenitīvōAblātīvōqueVariō>
    {
      public static readonly Lazy<NūntiusĪnflexōrīEffectōTertiōNeutrōNōminibusCumGenitīvōAblātīvōqueVariō> Faciendum
                       = new Lazy<NūntiusĪnflexōrīEffectōTertiōNeutrōNōminibusCumGenitīvōAblātīvōqueVariō>(() => Instance);
    }
  }
}
