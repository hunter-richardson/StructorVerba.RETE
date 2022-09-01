using System;
using System.Collections.Generic.Dictionary;

using Nūntiī.Nūntius;
using Praebeunda.Multiplex;

namespace Pēnsōrēs.Nōmina
{
  public abstract class PēnsorNōminibus<Hoc> : PēnsorĪnflectendīs<Hoc, Multiplex.Nōmen>
  {
    private PēnsorNōminibus(in Enum versiō, in string quaerendī,
                            in Lazy<Nūntius<PēnsorĪnflectendīs<Hoc>>> nūntius,
                            in Func<JsonElement, Task<Hoc>> lēctor)
                             : base(versiō, Ēnumerātiōnēs.Catēgoria.Nōmen, quaerendī, nūntius, lēctor) { }
  }
}
