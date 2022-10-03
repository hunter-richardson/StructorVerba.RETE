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
  public sealed partial class ĪnflexorEffectusSecundusMasculīnusNōminibus : ĪnflexorEffectusNōminibus
  {
    private readonly Lazy<ĪnflexorEffectusSecundusNeuterNōminibus> Relātus = ĪnflexorEffectusSecundusNeuterNōminibus.Lazy;
    private ĪnflexorEffectusSecundusMasculīnusNōminibus()
          : base(new Lazy<Nūntius<ĪnflexorEffectusSecundusMasculīnusNōminibus>>(),
                 (nōmen, illa) => nōmen.Nōminātīvum.Chop(2))
        => Nūntius.PlūsGarriōAsync("Fīō");

    public sealed async string Singulāre(in Casus casus)
        => casus switch
        {
          Casus.Nōminātīvus => "us",
          Casus.Vocātīvus => "e",
          _ => await Relātus.Value.SingulāreAsync(casus)
        };

    public sealed string Plūrāle(in Casus casus) => casus switch
    {
      Casus.Nōminātīvus or Casus.Vocātīvus => "ī",
      Casus.Accūsātīvus => "ōs",
      _ => await Relātus.Value.PlūrāleAsync(casus)
    };
  }
}
