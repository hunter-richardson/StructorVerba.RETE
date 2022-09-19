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
    public static readonly Lazy<ĪnflexorEffectusQuīntusNōminibus> Faciendum = new Lazy(() => Instance);
    private ĪnflexorEffectusQuīntusNōminibus()
        : base(new Lazy<Nūntius<ĪnflexorEffectusQuīntusNōminibus>>(),
               (nōmen, illa) => nōmen.Nōminātīvum.Chop(2))
        => Nūntius.PlūsGarriōAsync("Fīō");

    public sealed string Singulāre(in Casus casus) => casus switch
    {
      Casus.Nōminātīvus or Casus.Vocātīvus => "ēs",
      Casus.Genitīvus => "eī",
      Casus.Datīvus => "uī",
      Casus.Accūsātīvus => "em",
      _ => "ē"
    };

    public sealed string Plūrāle(in Casus casus) => casus switch
    {
      Casus.Nōminātīvus or Casus.Accūsātīvus or Casus.Vocātīvus => "ēs",
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
