using System;
using System.Collections.Generic.IEnumerable;

using Nūntiī.Nūntius;
using Praebeunda.Multiplex;
using Ēnumerātiōnēs.Catēgoria;
using Īnflexōrēs.Effectī.Nōmina.ĪnflexorEffectusNōminibus;

namespace Īnflexōrēs.Dēfectī.Nōmina
{
  public abstract class ĪnflexorDēfectusNōminibus : ĪnflexorDēfectus<Īnflectendum.Nōmen, Multiplex.Nōmen>
  {
    protected ĪnflexorDēfectusNōminibus(in Lazy<Nūntius<ĪnflexorDēfectusNōminibus>> nūntius,
                                        in Lazy<ĪnflexorEffectusNōminibus> relātus)
                                                 : base(catēgoria: Catēgoria.Nōmen, nūntius: nūntius, relātus: relātus) {  }
  }
}
