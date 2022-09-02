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
    public static readonly Lazy<ĪnflexorEffectusSecundusMasculīnusNōminibus> Faciendum
                     = new Lazy<ĪnflexorEffectusSecundusMasculīnusNōminibus>(() => Instance);
    private readonly ĪnflexorEffectusSecundusNeuterNōminibus Relātum = ĪnflexorEffectusSecundusNeuterNōminibus.Faciendum.Value;
    private ĪnflexorEffectusSecundusMasculīnusNōminibus()
          : base(Versiō.Nōmen_Secundum_Masculīnum,
                 NūntiusĪnflexōrīEffectōSecundōMasculīnōNōminibus.Faciendum,
                 (nōmen, illa) => nōmen.Nominātīvum.Chop(2)) { }

    public sealed string Singulāre(in Casus casus) => (casus is Casus.Nominātīvus or Casus.Vocātīvus)
                                                          .Choose("us", await Relātum.SingulāreAsync(casus));

    public sealed string Plūrāle(in Casus casus) => casus switch
    {
      Casus.Nominātīvus or Casus.Vocātīvus => "ī",
      Casus.Accusātīvus => "ōs",
      _ => await Relātum.PlūrāleAsync(casus)
    };

    [Singleton]
    private sealed class NūntiusĪnflexōrīEffectōSecundōMasculīnōNōminibus : Nūntius<ĪnflexorEffectusSecundusMasculīnusNōminibus>
    {
      public static readonly Lazy<NūntiusĪnflexōrīEffectōSecundōMasculīnōNōminibus> Faciendum
                       = new Lazy<NūntiusĪnflexōrīEffectōSecundōMasculīnōNōminibus>(() => Instance);
    }
  }
}
