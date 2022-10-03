using System;

using Nūntiī.Nūntius;
using Miscella.Extensions;
using Ēnumerātiōnēs.Casus;
using Īnflexōrēs.Effectī.Nōmina.ĪnflexorEffectusNōminibus.Versiō;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Īnflexōrēs.Effectī.Nōmina
{
  [Lazy]
  [AsyncOverloads]
  public sealed partial class ĪnflexorEffectusQuīntusNōminibus : ĪnflexorEffectusNōminibus
  {
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
  }
}
