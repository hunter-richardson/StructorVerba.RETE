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
  public sealed partial class ĪnflexorEffectusTertiusNeuterNōminibusCumAblātīvōVariō : ĪnflexorEffectusNōminibus
  {
    public static readonly Lazy<ĪnflexorEffectusTertiusNeuterNōminibusCumAblātīvōVariō> Faciendum
                     = new Lazy<ĪnflexorEffectusTertiusNeuterNōminibusCumAblātīvōVariō>(() => Instance);
    private readonly ĪnflexorEffectusTertiusNeuterNōminibus Relātum = ĪnflexorEffectusTertiusNeuterNōminibus.Faciendum.Value;
    private ĪnflexorEffectusTertiusNeuterNōminibusCumAblātīvōVariō()
        : base(new Lazy<Nūntius<ĪnflexorEffectusTertiusNeuterNōminibusCumAblātīvōVariō>>(() => new Nūntius<ĪnflexorEffectusTertiusNeuterNōminibusCumAblātīvōVariō>()),
               (nōmen, illa) => (illa.FirstOf<Numerālis>(), illa.FirstOf<Casus>()) switch
                                {
                                  (Numerālis.Singulāris, Casus.Nominātīvus or Casus.Accusātīvus or Casus.Vocātīvus) => nōmen.Nominātīvum,
                                  _ => nōmen.Genitīvum.Chop(2)
                                }) { }

    public sealed string Singulāre(in Casus casus)
              => (casus is Casus.Ablātīvus or Casus.Locātīvus or Casus.Instrumentālis)
                        .Choose("ī", await Relātum.SingulāreAsync(casus));

    public sealed string Plūrāle(in Casus casus) => await Relātum.PlūrāleAsync(casus);
  }
}
