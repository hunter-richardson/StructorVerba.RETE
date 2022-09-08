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
  public sealed partial class ĪnflexorEffectusTertiusNeuterNōminibus : ĪnflexorEffectusNōminibus
  {
    public static readonly Lazy<ĪnflexorEffectusTertiusNeuterNōminibus> Faciendum = new Lazy(() => Instance);
    private readonly ĪnflexorEffectusTertiusNōminibus Relātum = ĪnflexorEffectusTertiusNōminibus.Faciendum.Value;
    private ĪnflexorEffectusTertiusNeuterNōminibus()
        : base(new Lazy<Nūntius<ĪnflexorEffectusTertiusNeuterNōminibus>>(),
               (nōmen, illa) => (illa.FirstOf<Numerālis>(), illa.FirstOf<Casus>()) switch
                                {
                                  (Numerālis.Singulāris, Casus.Nōminātīvus or Casus.Accūsātīvus or Casus.Vocātīvus) => nōmen.Nōminātīvum,
                                  _ => nōmen.Genitīvum.Chop(2)
                                }) { }

    public sealed string Singulāre(in Casus casus)
              => (casus is Casus.Nōminātīvus or Casus.Accūsātīvus or Casus.Vocātīvus)
                      .Choose(string.Empty, await Relātum.SingulāreAsync(casus));

    public sealed string Plūrāle(in Casus casus)
              => (casus is Casus.Nōminātīvus or Casus.Accūsātīvus or Casus.Vocātīvus)
                      .Choose("a", await Relātum.PlūrāleAsync(casus));
  }
}
