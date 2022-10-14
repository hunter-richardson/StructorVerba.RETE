using System;
using System.Collections.Generic.IEnumerable;
using System.Threading.Tasks.Task;

using Nūntiī.Nūntius;
using Miscella.Extensions;

namespace Īnflexōrēs.Incertī
{
  public sealed partial class ĪnflexorSuffīxus<Hoc> : ĪnflexorRescrīptus<Hoc>
  {
    private static readonly Func<string, string, string> Rescrīptor
        = (scrīptum, suffīxum) => scrīptum.Concat(suffīxum);

    public ĪnflexorSuffīxus(in Lazy<Īnflexor<Hoc>> relātus,
                            in string suffīxum = string.Empty)
        : base(relātus: relātus,
               rescrīptor: scrīptum => Rescrīptor.Invoke(scrīptum, suffīxum),
               nūntius: new Lazy<Nūntius<ĪnflexorSuffīxus>>()) {  }

    public ĪnflexorSuffīxus(in Lemma lemma, in string suffīxum = string.Empty)
        : base(lemma: lemma,
               rescrīptor: scrīptum => Rescrīptor.Invoke(scrīptum, suffīxum),
               nūntius: new Lazy<Nūntius<ĪnflexorSuffīxus>>()) {  }
  }
}
