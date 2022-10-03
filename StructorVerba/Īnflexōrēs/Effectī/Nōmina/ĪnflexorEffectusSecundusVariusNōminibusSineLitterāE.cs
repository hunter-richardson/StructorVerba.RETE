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
  public abstract partial class ĪnflexorEffectusSecundusVariusNōminibusSineLitterāE : ĪnflexorEffectusNōminibus
  {
    private readonly Lazy<ĪnflexorEffectusSecundusMasculīnusNōminibus> Relātus
                        = ĪnflexorEffectusSecundusMasculīnusNōminibus.Lazy;

    private ĪnflexorEffectusSecundusVariusNōminibusSineLitterāE()
        : base(new Lazy<Nūntius<ĪnflexorEffectusSecundusVariusNōminibusSineLitterāE>>(),
               (nōmen, illa) => (illa.FirstOf<Numerālis>, illa.FirstOf<Casus>()) switch
                                {
                                  (Numerālis.Singulāris, Casus.Nōminātīvus or Casus.Vocātīvus) => nōmen.Nōminātīvum,
                                  _ => nōmen.Genitīvum.Chop(2)
                                })
        => Nūntius.PlūsGarriōAsync("Fīō");

    public sealed string Singulāre(in Casus casus) => (casus is Casus.Nōminātīvus or Casus.Vocātīvus)
                                                          .Choose(string.Empty, "r".Concat(await Relātus.Value.SingulāreAsync(casus)));

    public sealed string Plūrāle(in Casus casus) => await Relātus.Value.PlūrāleAsync(casus);
  }
}
