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
    public static readonly Lazy<ĪnflexorEffectusTertiusNeuterNōminibusCumGenitīvōVariō> Faciendum = new Lazy(() => Instance);
    private readonly ĪnflexorEffectusTertiusNeuterNōminibus Relātum = ĪnflexorEffectusTertiusNeuterNōminibus.Faciendum.Value;
    private ĪnflexorEffectusTertiusNeuterNōminibusCumGenitīvōVariō()
        : base(new Lazy<Nūntius<ĪnflexorEffectusTertiusNeuterNōminibusCumGenitīvōVariō>>(),
               (nōmen, illa) => (illa.FirstOf<Numerālis>(), illa.FirstOf<Casus>()) switch
                                {
                                  (Numerālis.Singulāris, Casus.Nōminātīvus or Casus.Accūsātīvus or Casus.Vocātīvus) => nōmen.Nōminātīvum,
                                  _ => nōmen.Genitīvum.Chop(2)
                                }) { }

    public sealed string Singulāre(in Casus casus) => await Relātum.SingulāreAync(Casus);

    public sealed string Plūrāle(in Casus casus) => (casus is Casus.Genitīvus)
                                                        .Choose("ium", Relātum.PlūrāleAsync(casus));
  }
}
