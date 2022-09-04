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
  public sealed partial class ĪnflexorEffectusTertiusNōminibusCumAblātīvōVariō : ĪnflexorEffectusNōminibus
  {
    public static readonly Lazy<ĪnflexorEffectusTertiusNōminibusCumAblātīvōVariō> Faciendum
                     = new Lazy<ĪnflexorEffectusTertiusNōminibusCumAblātīvōVariō>(() => Instance);
    private readonly ĪnflexorEffectusTertiusNōminibus Relātum = ĪnflexorEffectusTertiusNōminibus.Faciendum.Value;
    private ĪnflexorEffectusTertiusNōminibusCumAblātīvōVariō()
        : base(NūntiusĪnflexōrīEffectōTertiōNōminibusCumAblātīvōVariō.Faciendum,
               (nōmen, illa) => (illa.FirstOf<Numerālis>(), illa.FirstOf<Casus>()) switch
                                {
                                  (Numerālis.Singulāris, Casus.Nominātīvus or Casus.Vocātīvus) => nōmen.Nominātīvum,
                                  _ => nōmen.Genitīvum.Chop(2)
                                }) { }

    public sealed string Singulāre(in Casus casus)
              => (casus is Casus.Ablātīvus or Casus.Locātīvus or Casus.Instrumentālis)
                      .Choose("ī", await Relātum.SingulāreAsync(casus));

    public sealed string Plūrāle(in Casus casus) => await Relātum.PlūrāleAsync(casus);

    [Singleton]
    private sealed class NūntiusĪnflexōrīEffectōTertiōNōminibusCumAblātīvōVariō : Nūntius<ĪnflexorEffectusTertiusNōminibusCumablātīvōVariō>
    {
      public static readonly Lazy<NūntiusĪnflexōrīEffectōTertiōNōminibusCumAblātīvōVariō> Faciendum
                       = new Lazy<NūntiusĪnflexōrīEffectōTertiōNōminibusCumAblātīvōVariō>(() => Instance);
    }
  }
}
