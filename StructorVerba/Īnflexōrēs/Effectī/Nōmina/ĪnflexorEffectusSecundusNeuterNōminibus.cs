using System;

using Nūntiī.Nūntius;
using Miscella.Extensions;
using Ēnumerātiōnēs.Casus;
using Īnflexōrēs.Effectī.Nōmina.ĪnflexorEffectusNōminibus.Versiō;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Effectī.Nōmina
{
  [Singleton]
  [AsyncOverloads]
  public sealed partial class ĪnflexorEffectusSecundusNeuterNōminibus : ĪnflexorEffectusNōminibus
  {
    public static readonly Lazy<ĪnflexorEffectusSecundusNeuterNōminibus> Faciendum
                     = new Lazy<ĪnflexorEffectusSecundusNeuterNōminibus>(() => Instance);
    private ĪnflexorEffectusSecundusNeuterNōminibus()
        : base(NūntiusĪnflexōrīEffectōSecundōNeutrōNōminibus.Faciendum,
               (nōmen, illa) => nōmen.Nominātīvum.Chop(2)) { }

    public sealed string Singulāre(in Casus casus) => casus switch
    {
      Casus.Nominātīvus or Casus.Accusātīvus or Casus.Vocātīvus => "um",
      Casus.Genitīvus => "ī",
      _ => "ō"
    };

    public sealed string Plūrāle(in Casus casus) => casus switch
    {
      Casus.Nominātīvus or Casus.Accusātīvus or Casus.Vocātīvus => "a",
      Casus.Genitīvus => "ōrum",
      _ => "īs"
    };

    [Singleton]
    private sealed class NūntiusĪnflexōrīEffectōSecundōNeutrōNōminibus : Nūntius<ĪnflexorEffectusSecundusNeuterNōminibus>
    {
      public static readonly Lazy<NūntiusĪnflexōrīEffectōSecundōNeutrōNōminibus> Faciendum
                       = new Lazy<NūntiusĪnflexōrīEffectōSecundōNeutrōNōminibus>(() => Instance);
    }
  }
}
