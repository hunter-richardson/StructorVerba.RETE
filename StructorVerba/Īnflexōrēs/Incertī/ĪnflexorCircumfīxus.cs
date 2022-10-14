using System;
using System.Collections.Generic.IEnumerable;
using System.Threading.Tasks.Task;

using Nūntiī.Nūntius;
using Miscella.Extensions;

namespace Īnflexōrēs.Incertī
{
  public sealed partial class ĪnflexorCircumfīxus<Hoc> : ĪnflexorRescrīptus<Hoc>
  {
    private static readonly Func<string, string, string, string> Rescrīptor
        = (scrīptum, praefīxum, suffīxum) => praefīxum.Concat(scrīptum.Concat(suffīxum));

    public ĪnflexorCircumfīxus(in Lazy<Īnflexor<Hoc>> relātus,
                               in string praefīxum = string.Empty,
                               in string suffīxum = string.Empty)
                                      : base(relātus: relātus,
                                             rescrīptor: scrīptum => Rescrīptor.Invoke(scrīptum, praefīxum, suffīxum),
                                             nūntius: new Lazy<Nūntius<ĪnflexorCircumfīxus>>()) {  }

    public ĪnflexorCircumfīxus(in Lemma lemma,
                               in string praefīxum = string.Empty,
                               in string suffīxum = string.Empty)
                          : base(lemma: lemma,
                                 rescrīptor: scrīptum => Rescrīptor.Invoke(scrīptum, praefīxum, suffīxum),
                                 nūntius: new Lazy<Nūntius<ĪnflexorCircumfīxus>>()) {  }
  }
}
