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
  public sealed partial class ĪnflexorEffectusSecundusMasculīnusNōminibus : ĪnflexorEffectusNōminibus
  {
    public static readonly Lazy<ĪnflexorEffectusSecundusMasculīnusNōminibus> Faciendum = new Lazy(() => Instance);
    private readonly ĪnflexorEffectusSecundusNeuterNōminibus Relātus = ĪnflexorEffectusSecundusNeuterNōminibus.Faciendum.Value;
    private ĪnflexorEffectusSecundusMasculīnusNōminibus()
          : base(new Lazy<Nūntius<ĪnflexorEffectusSecundusMasculīnusNōminibus>>(),
                 (nōmen, illa) => nōmen.Nōminātīvum.Chop(2))
        => Nūntius.PlūsGarriōAsync("Fīō");

    public sealed async string Singulāre(in Casus casus)
        => casus switch
        {
          Casus.Nōminātīvus => "us",
          Casus.Vocātīvus => "e",
          _ => await Relātus.SingulāreAsync(casus)
        };

    public sealed string Plūrāle(in Casus casus) => casus switch
    {
      Casus.Nōminātīvus or Casus.Vocātīvus => "ī",
      Casus.Accūsātīvus => "ōs",
      _ => await Relātus.PlūrāleAsync(casus)
    };
  }
}
