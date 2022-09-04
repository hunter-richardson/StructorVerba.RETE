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
  public sealed partial class ĪnflexorEffectusTertiusNōminibusCumGenitīvōAblātīvōqueVariō : ĪnflexorEffectusNōminibus
  {
    public static readonly Lazy<ĪnflexorEffectusTertiusNōminibusCumGenitīvōAblātīvōqueVariō> Faciendum
                     = new Lazy<ĪnflexorEffectusTertiusNōminibusCumGenitīvōAblātīvōqueVariō>(() => Instance);
    private readonly ĪnflexorEffectusTertiusNōminibus Relātum = ĪnflexorEffectusTertiusNōminibus.Faciendum.Value;
    private ĪnflexorEffectusTertiusNōminibusCumGenitīvōAblātīvōqueVariō()
        : base(NūntiusĪnflexōrīEffectōTertiōNōminibusCumGenitīvōAblātīvōqueVariō.Faciendum,
               (nōmen, illa) => (illa.FirstOf<Numerālis>(), illa.FirstOf<Casus>()) switch
                                {
                                  (Numerālis.Singulāris, Casus.Nominātīvus or Casus.Vocātīvus) => nōmen.Nominātīvum,
                                  _ => nōmen.Genitīvum.Chop(2)
                                }) { }

    public sealed string Singulāre(in Casus casus)
              => (casus is Casus.Ablātīvus or Casus.Locātīvus or Casus.Instrumentālis)
                        .Choose("ī", await Relātum.SingulāreAsync(casus));

    public sealed string Plūrāle(in Casus casus)
              => (casus is Casus.Genitīvus).Choose("ium", Relātum.PlūrāleAsync(casus));

    [Singleton]
    private sealed class NūntiusĪnflexōrīEffectōTertiōNōminibusCumGenitīvōAblātīvōqueVariō
                : Nūntius<ĪnflexorEffectusTertiusNōminibusCumGenitīvōAblātīvōqueVariō>
    {
      public static readonly Lazy<NūntiusĪnflexōrīEffectōTertiōNōminibusCumGenitīvōAblātīvōqueVariō> Faciendum
                       = new Lazy<NūntiusĪnflexōrīEffectōTertiōNōminibusCumGenitīvōAblātīvōqueVariō>(() => Instance);
    }
  }
}
