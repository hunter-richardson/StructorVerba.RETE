using System;
using System.Collections.Generic.IEnumerable;

using Nūntiī.Nūntius;
using Praebeunda.Multiplex;
using Ēnumerātiōnēs.Catēgoria;
using Īnflexōrēs.Effectī.Āctūs.ĪnflexorEffectusĀctibus;

namespace Īnflexōrēs.Dēfectī.Āctūs
{
  public abstract class ĪnflexorDēfectusĀctibus : ĪnflexorDēfectus<Īnflectendum.Āctus, Multiplex.Āctus>
  {
    protected ĪnflexorDēfectusĀctibus(in Lazy<Nūntius<ĪnflexorDēfectusĀctibus>> nūntius,
                                      in Lazy<ĪnflexorEffectusĀctibus> relātus)
                                               : base(Catēgoria.Āctus, nūntius, relātus) { }
  }
}
