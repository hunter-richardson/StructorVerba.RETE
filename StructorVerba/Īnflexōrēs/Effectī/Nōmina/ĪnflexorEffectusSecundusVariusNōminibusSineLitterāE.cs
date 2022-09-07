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
  public abstract partial class ĪnflexorEffectusSecundusVariusNōminibusSineLitterāE : ĪnflexorEffectusNōminibus
  {
    public static readonly Lazy<ĪnflexorEffectusSecundusVariusNōminibusSineLitterāE> Faciendum
                     = new Lazy<ĪnflexorEffectusSecundusVariusNōminibusSineLitterāE>(() => Instance);
    private readonly ĪnflexorEffectusSecundusMasculīnusNōminibus Relātum = ĪnflexorEffectusSecundusMasculīnusNōminibus.Faciendum.Value;

    private ĪnflexorEffectusSecundusVariusNōminibusSineLitterāE()
        : base(new Lazy<Nūntius<ĪnflexorEffectusSecundusVariusNōminibusSineLitterāE>>(() => new Nūntius<ĪnflexorEffectusSecundusVariusNōminibusSineLitterāE>()),
               (nōmen, illa) => (illa.FirstOf<Numerālis>, illa.FirstOf<Casus>()) switch
                                {
                                  (Numerālis.Singulāris, Casus.Nominātīvus or Casus.Vocātīvus) => nōmen.Nominātīvum,
                                  _ => nōmen.Genitīvum.Chop(2)
                                }) { }

    public sealed string Singulāre(in Casus casus) => (casus is Casus.Nominātīvus or Casus.Vocātīvus)
                                                          .Choose(string.Empty, "r".Concat(await Relātum.SingulāreAsync(casus)));

    public sealed string Plūrāle(in Casus casus) => await Relātum.PlūrāleAsync(casus);
  }
}
