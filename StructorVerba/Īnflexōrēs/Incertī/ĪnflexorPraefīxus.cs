using System;
using System.Collections.Generic.IEnumerable;
using System.Threading.Tasks.Task;

using Nūntiī.Nūntius;
using Miscella.Extensions;
using Praebeunda.Lemma;

namespace Īnflexōrēs.Incertī
{
  public sealed partial class ĪnflexorPraefīxus<Hoc> : ĪnflexorRescrīptus<Hoc>
  {
    private static readonly Func<string, string, string> Rescrīptor
        = (scrīptum, praefīxum) => praefīxum.Concat(scrīptum);

    public ĪnflexorPraefīxus(in Lazy<Īnflexor<Hoc>> relātus,
                             in string praefīxum = string.Empty)
        : base(relātus: relātus,
               rescrīptor: scrīptum => Rescrīptor.Invoke(scrīptum, praefīxum),
               nūntius: new Lazy<Nūntius<ĪnflexorSuffīxus>>()) {  }

    public ĪnflexorPraefīxus(in Lemma lemma, in string praefīxum = string.Empty)
        : base(lemma: lemma,
               rescrīptor: scrīptum => Rescrīptor.Invoke(scrīptum, praefīxum),
               nūntius: new Lazy<Nūntius<ĪnflexorPraefīxus>>()) {  }
  }
}
