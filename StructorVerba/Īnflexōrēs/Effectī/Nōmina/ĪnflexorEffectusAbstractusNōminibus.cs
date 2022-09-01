using System;

using Nūntiī.Nūntius;
using Praebeunda.Multiplex;
using Ēnumerātiōnēs;

namespace Īnflexōrēs.Effectī.Nōmina
{
  public abstract partial class ĪnflexorEffectusNōminibus<Hoc> : ĪnflexorEffectus<Hoc, Multiplex.Nōmen>
  {
    protected ĪnflexorEffectusNōminibus(in Enum versiō,
                                        in Lazy<Nūntius<ĪnflexorEffectusNōminibus<Hoc>>> nūntius,
                                        in string quaerendī, in Func<Hoc, Enum[], string> rādīcātor,
                                        in params IEnumerable<Enum[]> illa)
                                         : base(versiō, nūntius, quaerendī, rādīcātor, illa) { }
  }
}
