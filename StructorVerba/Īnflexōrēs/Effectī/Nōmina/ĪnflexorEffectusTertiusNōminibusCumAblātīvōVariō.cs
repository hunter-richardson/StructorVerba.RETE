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
    public static readonly Lazy<ĪnflexorEffectusTertiusNōminibusCumAblātīvōVariō> Faciendum = new Lazy(() => Instance);
    private readonly ĪnflexorEffectusTertiusNōminibus Relātum = ĪnflexorEffectusTertiusNōminibus.Faciendum.Value;
    private ĪnflexorEffectusTertiusNōminibusCumAblātīvōVariō()
        : base(new Lazy<Nūntius<ĪnflexorEffectusTertiusNōminibusCumAblātīvōVariō>>(),
               (nōmen, illa) => (illa.FirstOf<Numerālis>(), illa.FirstOf<Casus>()) switch
                                {
                                  (Numerālis.Singulāris, Casus.Nōminātīvus or Casus.Vocātīvus) => nōmen.Nōminātīvum,
                                  _ => nōmen.Genitīvum.Chop(2)
                                }) { }

    public sealed string Singulāre(in Casus casus)
              => (casus is Casus.Ablātīvus or Casus.Locātīvus or Casus.Instrumentālis)
                      .Choose("ī", await Relātum.SingulāreAsync(casus));

    public sealed string Plūrāle(in Casus casus) => await Relātum.PlūrāleAsync(casus);
  }
}
