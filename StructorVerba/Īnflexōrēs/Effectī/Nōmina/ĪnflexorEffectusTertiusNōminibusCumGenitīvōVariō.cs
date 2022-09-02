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
  public sealed partial class ĪnflexorEffectusTertiusNōminibusCumGenitīvōVariō : ĪnflexorEffectusNōminibus
  {
    public static readonly Lazy<ĪnflexorEffectusTertiusNōminibusCumGenitīvōVariō> Faciendum
                     = new Lazy<ĪnflexorEffectusTertiusNōminibusCumGenitīvōVariō>(() => Instance);
    private readonly ĪnflexorEffectusTertiusNōminibus Relātum = ĪnflexorEffectusTertiusNōminibus.Faciendum.Value;
    private ĪnflexorEffectusTertiusNōminibusCumGenitīvōVariō()
        : base(Versiō.Nōmen_Tertium_Cum_Genitīvō_Variō,
               NūntiusĪnflexōrīEffectōTertiōNōminibusCumGenitīvōVariō.Faciendum,
               (nōmen, illa) => (illa.FirstOf<Numerālis>(), illa.FirstOf<Casus>()) switch
                                {
                                  (Numerālis.Singulāris, Casus.Nominātīvus or Casus.Vocātīvus) => nōmen.Nominātīvum,
                                  _ => nōmen.Genitīvum.Chop(2)
                                }) { }

    public sealed string Singulāre(in Casus casus) => await Relātum.SingulāreAync(Casus);

    public sealed string Plūrāle(in Casus casus) => (casus is Casus.Genitīvus)
                                                        .Choose("ium", await Relātum.PlūrāleAsync(casus));

    [Singleton]
    private sealed class NūntiusĪnflexōrīEffectōTertiōNōminibusCumGenitīvōVariō : Nūntius<ĪnflexorEffectusTertiusNōminibusCumGenitīvōVariō>
    {
      public static readonly Lazy<NūntiusĪnflexōrīEffectōTertiōNōminibusCumGenitīvōVariō> Faciendum
                       = new Lazy<NūntiusĪnflexōrīEffectōTertiōNōminibusCumGenitīvōVariō>(() => Instance);
    }
  }
}
