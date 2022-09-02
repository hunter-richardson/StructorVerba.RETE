using System;

using Nūntiī.Nūntius;
using Praebeunda.Multiplex;
using Ēnumerātiōnēs;
using Īnfexōrēs.Effectī.Nōmina.NōminaFacta.ĪnflexorEffectusNōminibusFactīs.Versiō;

namespace Īnflexōrēs.Effectī.Nōmina
{
  public abstract partial class ĪnflexorEffectusNōminibus<Hoc> : ĪnflexorEffectus<Hoc, Multiplex.Nōmen>
  {
    public static readonly Func<Enum, Task<Lazy<ĪnflexorEffectusNōminibus<Hoc>?>>> Versor = async versiō => versiō.GetType() switch
    {
      ĪnflexorEffectusNōminibus.Versiō => ĪnflexorEffectusNōminibus.Relātor.Invoke(versiō),
      ĪnflexorEffectusNōminibusFactīs.Versiō => ĪnflexorEffectusNōminibusFactīs.Relātor.Invoke(versiō)
    };

    protected ĪnflexorEffectusNōminibus(in Enum versiō,
                                        in Lazy<Nūntius<ĪnflexorEffectusNōminibus<Hoc>>> nūntius,
                                        in string quaerendī, in Func<Hoc, Enum[], string> rādīcātor,
                                        in params IEnumerable<Enum[]> illa)
                                         : base(versiō, nūntius, quaerendī, rādīcātor, illa) { }
  }
}
