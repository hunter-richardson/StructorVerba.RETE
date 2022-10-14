using System;
using System.Collections.Generic.IEnumerable;

using Nūntiī.Nūntius;
using Praebeunda;
using Ēnumerātiōnēs.Catēgoria;
using Īnflexōrēs.Effectī.Adiectīva;

namespace Īnflexōrēs.Dēfectī.Adiectīva
{
  public abstract class ĪnflexorDēfectusAdiectīvīs<Hoc> : ĪnflexorDēfectus<Hoc, Multiplex.Adiectīvum>
      where Hoc : Īnflectendum<Hoc, Multiplex.Adiectīvum>
  {
    protected ĪnflexorDēfectusAdiectīvīs(in Lazy<Nūntius<ĪnflexorDēfectusAdiectīvīs>> nūntius,
                                         in Lazy<ĪnflexorEffectusAdiectīvīs> relātus)
                                              : base(catēgoria: Catēgoria.Adiectīvum, nūntius: nūntius, relātus: relātus) { }
  }
}
