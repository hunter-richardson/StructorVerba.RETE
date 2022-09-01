using System;
using System.Linq;
using System.Threading.Tasks.Task;

using Nūntiī.Nūntius;
using Miscella;
using Praebeunda.Multiplex;
using Praebeunda.Īnflectendum;
using Ēnumerātiōnēs;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

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
