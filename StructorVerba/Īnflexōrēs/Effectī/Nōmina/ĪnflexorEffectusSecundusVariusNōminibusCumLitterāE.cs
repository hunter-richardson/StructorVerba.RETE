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
    public static readonly Lazy<ĪnflexorEffectusSecundusVariusNōminibusCumLitterāE> Faciendum = new Lazy(() => Instance);
    private readonly ĪnflexorEffectusSecundusMasculīnusNōminibus Relātus = ĪnflexorEffectusSecundusMasculīnusNōminibus.Faciendum.Value;

    private ĪnflexorEffectusSecundusVariusNōminibusCumLitterāE()
        : base(new Lazy<Nūntius<ĪnflexorEffectusSecundusVariusNōminibusCumLitterāE>>(),
               (nōmen, illa) => nōmen.Nōminātīvum) { }

    public sealed string Singulāre(in Casus casus) => (casus is Casus.Nōminātīvus or Casus.Vocātīvus)
                                                          .Choose(string.Empty, await Relātus.SingulāreAsync(casus));

    public sealed string Plūrāle(in Casus casus) => await Relātus.PlūrāleAsync(casus);
  }
}
