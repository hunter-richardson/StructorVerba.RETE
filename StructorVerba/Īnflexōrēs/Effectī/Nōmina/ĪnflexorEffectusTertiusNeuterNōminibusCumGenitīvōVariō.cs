using System;

using Nūntiī.Nūntius;
using Miscella.Extensions;
using Ēnumerātiōnēs;
using Īnflexōrēs.Effectī.Nōmina.ĪnflexorEffectusNōminibus.Versiō;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Īnflexōrēs.Effectī.Nōmina
{
  [Lazy]
  [AsyncOverloads]
  public sealed partial class ĪnflexorEffectusTertiusNeuterNōminibusCumGenitīvōVariō : ĪnflexorEffectusNōminibus
  {
    private readonly Lazy<ĪnflexorEffectusTertiusNeuterNōminibus> Relātum = ĪnflexorEffectusTertiusNeuterNōminibus.Lazy;
    private ĪnflexorEffectusTertiusNeuterNōminibusCumGenitīvōVariō()
        : base(new Lazy<Nūntius<ĪnflexorEffectusTertiusNeuterNōminibusCumGenitīvōVariō>>(),
               (nōmen, illa) => (illa.FirstOf<Numerālis>(), illa.FirstOf<Casus>()) switch
                                {
                                  (Numerālis.Singulāris, Casus.Nōminātīvus or Casus.Accūsātīvus or Casus.Vocātīvus) => nōmen.Nōminātīvum,
                                  _ => nōmen.Genitīvum.Chop(2)
                                })
        => Nūntius.PlūsGarriōAsync("Fīō");

    public sealed string Singulāre(in Casus casus) => await Relātum.Value.SingulāreAync(Casus);

    public sealed string Plūrāle(in Casus casus) => (casus is Casus.Genitīvus)
                                                        .Choose("ium", Relātum.Value.PlūrāleAsync(casus));
  }
}
