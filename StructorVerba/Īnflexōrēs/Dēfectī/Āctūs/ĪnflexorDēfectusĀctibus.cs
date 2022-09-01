using System;
using System.Collections.Generic.IEnumerable;

using Nūntiī.Nūntius;
using Praebeunda.Multiplex;

namespace Īnflexōrēs.Dēfectī.Āctūs
{
  public abstract partial class ĪnflexorDēfectusĀctibus : ĪnflexorDēfectus<Hoc, Multiplex.Āctus>
  {
    protected ĪnflexorDēfectusĀctibus(in Lazy<Nūntius<ĪnflexorDēfectusĀctibus<Hoc>>> nūntius,
                                      in Lazy<ĪnflexorDēfectusĀctibus<Hoc>> relātus, in params IEnumerable<Enum[]> illa)
                                               : base(Ēnumerātiōnēs.Catēgoria.Āctus, nūntius, relātus, illa) { }
  }
}
