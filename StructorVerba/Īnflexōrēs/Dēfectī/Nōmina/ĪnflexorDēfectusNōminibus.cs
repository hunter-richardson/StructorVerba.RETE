using System;
using System.Collections.Generic.IEnumerable;

using Nūntiī.Nūntius;
using Praebeunda.Multiplex;
using Īnflexōrēs.Effectī.Nōmina;

namespace Īnflexōrēs.Dēfectī.Nōmina
{
  public abstract partial class ĪnflexorDēfectusNōminibus : ĪnflexorDēfectus<Hoc, Multiplex.Nōmen>
  {
    protected ĪnflexorDēfectusNōminibus(in Lazy<Nūntius<ĪnflexorDēfectusNōminibus<Hoc>>> nūntius,
                                        in Lazy<ĪnflexorEffectusNōminibus<Hoc>> relātus, in params IEnumerable<Enum[]> illa)
                                                   : base(Ēnumerātiōnēs.Catēgoria.Nōmen, nūntius, relātus, illa) {  }
  }
}
