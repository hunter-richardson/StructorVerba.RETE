using System;
using System.Text.Json.JsonElement;
using System.Threading.Tasks.Task;

using Nūntiī.Nūntius;
using Praebeunda.Verbum;
using Praebeunda.Simplicibus;

namespace Pēnsōrēs
{
  public abstract class PēnsorVerbīs<Hoc> : Pēnsor<Hoc> where Hoc : Verbum<Hoc>
  {
    public static readonly Func<Ēnumerātiōnēs.Catēgoria, Lazy<PēnsorVerbīs>> RelātorSimplicibus =
            catēgoria => catēgoria switch
            {
              Ēnumerātiōnēs.Catēgoria.Coniūnctiō => PēnsorConiūnctiōnibus.Faciendum,
              Ēnumerātiōnēs.Catēgoria.Interiectiō => PēnsorInteriectiōnibus.Faciendum,
              Ēnumerātiōnēs.Catēgoria.Praepositiō => PēnsorPraepositiōnibus.Faciendum,
              _ => PēnsorLemmīs.Faciendum
            };

    protected PēnsorVerbīs(in Lazy<Nūntius<PēnsorVerbīs<Hoc>>> nūntius, in Func<JsonElement, Task<Hoc>> lēctor)
                           : base(nameof(Verbum.Scrīptum), Tabula.Verba, nūntius, lēctor)
    {
      Nūntius.PlūsGarriōAsync("Fīō");
    }
  }
}
