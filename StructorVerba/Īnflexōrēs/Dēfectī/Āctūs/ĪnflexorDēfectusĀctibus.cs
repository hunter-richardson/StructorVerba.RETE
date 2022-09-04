using System;
using System.Collections.Generic.IEnumerable;

using Nūntiī.Nūntius;
using Praebeunda.Multiplex;
using Īnflexōrēs.Effectī.Adiectīva;

namespace Īnflexōrēs.Dēfectī.Āctūs
{
  public abstract class ĪnflexorDēfectusĀctibus : ĪnflexorDēfectus<Hoc, Multiplex.Āctus>
  {
    protected ĪnflexorDēfectusĀctibus(in Lazy<Nūntius<ĪnflexorDēfectusĀctibus<Hoc>>> nūntius,
                                      in Lazy<ĪnflexorEffectusĀctibus<Hoc>> relātus, in params IEnumerable<Enum[]> illa)
                                               : base(Ēnumerātiōnēs.Catēgoria.Āctus, nūntius, relātus, illa) { }
  }
}
