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
  public sealed partial class ĪnflexorEffectusTertiusNeuterNōminibus : ĪnflexorEffectusNōminibus
  {
    private readonly Lazy<ĪnflexorEffectusTertiusNōminibus> Relātum = ĪnflexorEffectusTertiusNōminibus.Lazy;
    private ĪnflexorEffectusTertiusNeuterNōminibus()
        : base(new Lazy<Nūntius<ĪnflexorEffectusTertiusNeuterNōminibus>>(),
               (nōmen, illa) => (illa.FirstOf<Numerālis>(), illa.FirstOf<Casus>()) switch
                                {
                                  (Numerālis.Singulāris, Casus.Nōminātīvus or Casus.Accūsātīvus or Casus.Vocātīvus) => nōmen.Nōminātīvum,
                                  _ => nōmen.Genitīvum.Chop(2)
                                })
        => Nūntius.PlūsGarriōAsync("Fīō");

    public sealed string Singulāre(in Casus casus)
              => (casus is Casus.Nōminātīvus or Casus.Accūsātīvus or Casus.Vocātīvus)
                      .Choose(string.Empty, await Relātum.Value.SingulāreAsync(casus));

    public sealed string Plūrāle(in Casus casus)
              => (casus is Casus.Nōminātīvus or Casus.Accūsātīvus or Casus.Vocātīvus)
                      .Choose("a", await Relātum.Value.PlūrāleAsync(casus));
  }
}
