using System;
using System.Collections.Generic.IEnumerable;

using Nūntiī.Nūntius;
using Praebeunda.Multiplex;
using Īnflexōrēs.Effectī.Adiectīva;

namespace Īnflexōrēs.Dēfectī.Adiectīva
{
  public abstract class ĪnflexorDēfectusAdiectīvīs : ĪnflexorDēfectus<Hoc, Multiplex.Adiectīvum>
  {
    protected ĪnflexorDēfectusAdiectīvīs(in Lazy<Nūntius<ĪnflexorDēfectusAdiectīvīs<Hoc>>> nūntius,
                                         in Lazy<ĪnflexorEffectusAdiectīvīs<Hoc>> relātus, in params IEnumerable<Enum[]> illa)
                                                : base(Ēnumerātiōnēs.Catēgoria.Adiectīvum, nūntius, relātus, illa) { }
  }
}
