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
  public sealed partial class ĪnflexorEffectusQuīntusNōminibus : ĪnflexorEffectusNōminibus
  {
    public static readonly Lazy<ĪnflexorEffectusQuīntusNōminibus> Faciendum
                     = new Lazy<ĪnflexorEffectusQuīntusNōminibus>(() => Instance);
    private ĪnflexorEffectusQuīntusNōminibus()
        : base(Versiō.Nōmen_Quīntum, NūntiusĪnflexōrīEffectōQuīntōNōminibus.Faciendum,
               (nōmen, illa) => nōmen.Nominātīvum.Chop(2)) { }

    public sealed string Singulāre(in Casus casus) => casus switch
    {
      Casus.Nominātīvus or Casus.Vocātīvus => "ēs",
      Casus.Genitīvus => "eī",
      Casus.Datīvus => "uī",
      Casus.Accusātīvus => "em",
      _ => "ē"
    };

    public sealed string Plūrāle(in Casus casus) => casus switch
    {
      Casus.Nominātīvus or Casus.Accusātīvus or Casus.Vocātīvus => "ēs",
      Casus.Genitīvus => "ērum",
      _ => "ēbus"
    };

    [Singleton]
    private sealed class NūntiusĪnflexōrīEffectōQuīntōNōminibus : Nūntius<NūntiusĪnflexōrīEffectōQuīntōNōminibus>
    {
      public static readonly Lazy<NūntiusĪnflexōrīEffectōQuīntōNōminibus> Faciendum
                       = new Lazy<NūntiusĪnflexōrīEffectōQuīntōNōminibus>(() => Instance);
    }
  }
}
