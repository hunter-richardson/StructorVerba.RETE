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
using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Īnflexōrēs.Effectī.Nōmina
{
  [Lazy]
  [AsyncOverloads]
  public abstract partial class ĪnflexorEffectusSecundusVariusNōminibusCumLitterāE : ĪnflexorEffectusNōminibus
  {
    private readonly Lazy<ĪnflexorEffectusSecundusMasculīnusNōminibus> Relātus
                        = ĪnflexorEffectusSecundusMasculīnusNōminibus.Lazy;

    private ĪnflexorEffectusSecundusVariusNōminibusCumLitterāE()
        : base(new Lazy<Nūntius<ĪnflexorEffectusSecundusVariusNōminibusCumLitterāE>>(),
               (nōmen, illa) => nōmen.Nōminātīvum)
        => Nūntius.PlūsGarriōAsync("Fīō");

    public sealed string Singulāre(in Casus casus) => (casus is Casus.Nōminātīvus or Casus.Vocātīvus)
                                                          .Choose(string.Empty, await Relātus.Value.SingulāreAsync(casus));

    public sealed string Plūrāle(in Casus casus) => await Relātus.Value.PlūrāleAsync(casus);
  }
}
