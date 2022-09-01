
using Praebeunda.Multiplex;

namespace Pēnsōrēs.Āctūs
{
  public abstract partial class PēnsorĀctibus<Hoc> : Pēnsor<Hoc, Multiplex.Āctus>
  {
    private PēnsorĀctibus(in Enum versiō, in string quaerendī, in Tabula tabula,
                          in Lazy<Nūntius<PēnsorĀctibus<Hoc>>> nūntius,
                          in Func<JsonElement, Task<Hoc>> lēctor)
                           : base(versiō, quaerendī, tabula, nūntius, lēctor) { }
  }
}
