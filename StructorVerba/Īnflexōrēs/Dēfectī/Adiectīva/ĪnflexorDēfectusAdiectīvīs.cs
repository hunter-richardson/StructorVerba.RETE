using System;
using System.Collections.Generic.IEnumerable;

using Nūntiī.Nūntius;
using Praebeunda.Multiplex;
using Ēnumerātiōnēs.Catēgoria;
using Īnflexōrēs.Effectī.Adiectīva;

namespace Īnflexōrēs.Dēfectī.Adiectīva
{
  public abstract class ĪnflexorDēfectusAdiectīvīs : ĪnflexorDēfectus<Īnflectendum.Adiectīvum, Multiplex.Adiectīvum>
  {
    protected ĪnflexorDēfectusAdiectīvīs(in Lazy<Nūntius<ĪnflexorDēfectusAdiectīvīs>> nūntius,
                                         in Lazy<ĪnflexorEffectusAdiectīvīs> relātus)
                                              : base(catēgoria: Catēgoria.Adiectīvum, nūntius: nūntius, relātus: relātus) { }
  }
}
