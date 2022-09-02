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
  public sealed partial class ĪnflexorEffectusTertiusNeuterNōminibusCumGenitīvōVariō : ĪnflexorEffectusNōminibus
  {
    public static readonly Lazy<ĪnflexorEffectusTertiusNeuterNōminibusCumGenitīvōVariō> Faciendum
                     = new Lazy<ĪnflexorEffectusTertiusNeuterNōminibusCumGenitīvōVariō>(() => Instance);
    private readonly ĪnflexorEffectusTertiusNeuterNōminibus Relātum = ĪnflexorEffectusTertiusNeuterNōminibus.Faciendum.Value;
    private ĪnflexorEffectusTertiusNeuterNōminibusCumGenitīvōVariō()
        : base(Versiō.Nōmen_Tertium_Neutrum_Cum_Genitīvō_Variō,
               NūntiusĪnflexōrīEffectōTertiōNeutrōNōminibusCumGenitīvōVariō.Faciendum,
               (nōmen, illa) => (illa.FirstOf<Numerālis>(), illa.FirstOf<Casus>()) switch
                                {
                                  (Numerālis.Singulāris, Casus.Nominātīvus or Casus.Vocātīvus) => nōmen.Nominātīvum,
                                  _ => nōmen.Genitīvum.Chop(2)
                                }) { }

    public sealed string Singulāre(in Casus casus) => await Relātum.SingulāreAync(Casus);

    public sealed string Plūrāle(in Casus casus) => (casus is Casus.Genitīvus)
                                                        .Choose("ium", Relātum.PlūrāleAsync(casus));

    [Singleton]
    private sealed class NūntiusĪnflexōrīEffectōTertiōNeutrōNōminibusCumGenitīvōVariō : Nūntius<ĪnflexorEffectusTertiusNeuterNōminibusCumGenitīvōVariō>
    {
      public static readonly Lazy<NūntiusĪnflexōrīEffectōTertiōNeutrōNōminibusCumGenitīvōVariō> Faciendum
                       = new Lazy<NūntiusĪnflexōrīEffectōTertiōNeutrōNōminibusCumGenitīvōVariō>(() => Instance);
    }
  }
}
