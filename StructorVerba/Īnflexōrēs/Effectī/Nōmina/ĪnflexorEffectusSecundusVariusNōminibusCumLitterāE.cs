using System;
using System.Linq;
using System.Threading.Tasks.Task;

using Nūntiī.Nūntius;
using Miscella;
using Praebeunda.Multiplex;
using Praebeunda.Īnflectendum;
using Ēnumerātiōnēs;
using Īnflexōrēs.Effectī.Nōmina.NōminaGraeca;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

namespace Īnflexōrēs.Effectī.Nōmina
{
  [AsyncOverloads]
  public abstract partial class ĪnflexorEffectusSecundusVariusNōminibusCumLitterāE : ĪnflexorEffectusNōminibus
  {
    public static readonly Lazy<ĪnflexorEffectusSecundusVariusNōminibusCumLitterāE> Faciendum
                     = new Lazy<ĪnflexorEffectusSecundusVariusNōminibusCumLitterāE>(() => Instance);
    private readonly ĪnflexorEffectusSecundusMasculīnusNōminibus Relātum = ĪnflexorEffectusSecundusMasculīnusNōminibus.Faciendum.Value;

    private ĪnflexorEffectusSecundusVariusNōminibusCumLitterāE()
        : base(NūntiusĪnflexōrīEffectōSecundōVariōNōminibusCumLitterāE.Faciendum,
               (nōmen, illa) => nōmen.Nominātīvum) { }

    public sealed string Singulāre(in Casus casus) => (casus is Casus.Nominātīvus or Casus.Vocātīvus)
                                                          .Choose(string.Empty, await Relātum.SingulāreAsync(casus));

    public sealed string Plūrāle(in Casus casus) => await Relātum.PlūrāleAsync(casus);

    [Singleton]
    private sealed class NūntiusĪnflexōrīEffectōSecundōVariōNōminibusCumLitterāE : Nūntius<ĪnflexorEffectusSecundusVariusNōminibusCumLitterāE>
    {
      public static readonly Lazy<NūntiusĪnflexōrīEffectōSecundōVariōNōminibusCumLitterāE> Faciendum
                       = new Lazy<NūntiusĪnflexōrīEffectōSecundōVariōNōminibusCumLitterāE>(() => Instance);
    }
  }
}
