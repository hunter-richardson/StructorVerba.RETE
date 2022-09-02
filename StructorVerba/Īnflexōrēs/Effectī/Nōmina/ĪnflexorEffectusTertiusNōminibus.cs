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
  public sealed partial class ĪnflexorEffectusTertiusNōminibus : ĪnflexorEffectusNōminibus
  {
    public static readonly Lazy<ĪnflexorEffectusTertiusNōminibus> Faciendum
                     = new Lazy<ĪnflexorEffectusTertiusNōminibus>(() => Instance);
    private ĪnflexorEffectusTertiusNōminibus()
        : base(Versiō.Nōmen_Tertium, NūntiusĪnflexōrīEffectōTertiōNōminibus.Faciendum,
               (nōmen, illa) => (illa.FirstOf<Numerālis>, illa.FirstOf<Casus>()) switch
                                {
                                  (Numerālis.Singulāris, Casus.Nominātīvus or Casus.Vocātīvus) => nōmen.Nominātīvum,
                                  _ => nōmen.Genitīvum.Chop(2)
                                }) { }

    public sealed string Singulāre(in Casus casus) => casus switch
    {
      Casus.Nominātīvus or Casus.Vocātīvus => string.Empty,
      Casus.Genitīvus => "is",
      Casus.Datīvus => "ī",
      Casus.Accusātīvus => "em",
      _ => "e"
    };

    public sealed string Plūrāle(in Casus casus) => casus switch
    {
      Casus.Nominātīvus or Casus.Accusātīvus or Casus.Vocātīvus => "ēs",
      Casus.Genitīvus => "um",
      _ => "ibus"
    };

    [Singleton]
    private sealed class NūntiusĪnflexōrīEffectōTertiōNōminibus : Nūntius<ĪnflexorEffectusTertiusNōminibus>
    {
      public static readonly Lazy<NūntiusĪnflexōrīEffectōTertiōNōminibus> Faciendum
                       = new Lazy<NūntiusĪnflexōrīEffectōTertiōNōminibus>(() => Instance);
    }
  }
}
