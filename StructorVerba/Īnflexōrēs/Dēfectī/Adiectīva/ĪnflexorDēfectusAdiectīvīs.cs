using System;
using System.Collections.Generic.IEnumerable;

using Nūntiī.Nūntius;
using Praebeunda.Multiplex;

namespace Īnflexōrēs.Dēfectī.Adiectīva
{
  public abstract partial class ĪnflexorDēfectusAdiectīvīs : ĪnflexorDēfectus<Hoc, Multiplex.Adiectīvum>
  {
    protected ĪnflexorDēfectusAdiectīvīs(in Lazy<Nūntius<ĪnflexorDēfectusAdiectīvīs<Hoc>>> nūntius,
                                         in Lazy<ĪnflexorDēfectusAdiectīvīs<Hoc>> relātus, in params IEnumerable<Enum[]> illa)
                                                : base(Ēnumerātiōnēs.Catēgoria.Adiectīvum, nūntius, relātus, illa) { }
  }
}
