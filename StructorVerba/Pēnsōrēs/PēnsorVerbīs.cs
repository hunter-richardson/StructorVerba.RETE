using System;
using System.Text.Json.JsonElement;

using Nūntiī.Nūntius;
using Praebeunda;
using Praebeunda.Simplicia;

namespace Pēnsōrēs
{
  public abstract partial class PēnsorVerbīs<Hoc> : Pēnsor<Hoc> where Hoc : Verbum<Hoc>
  {
    public static readonly Func<Ēnumerātiōnēs.Catēgoria, PēnsorVerbīs> RelātorSimplicibus =
            catēgoria => catēgoria switch
            {
              Ēnumerātiōnēs.Catēgoria.Coniūnctiō  => PēnsorConiūnctiōnibus.Instance,
              Ēnumerātiōnēs.Catēgoria.Interiectiō => PēnsorInteriectiōnibus.Instance,
              Ēnumerātiōnēs.Catēgoria.Praepositiō => PēnsorPraepositiōnibus.Instance,
              _                                   => PēnsorLemmīs.Instance
            };

    protected PēnsorVerbīs(in Func<Nūntius<Pēnsor<Hoc>>> nūntius, in Func<JsonElement, Hoc> lēctor)
                           : base(nameof(Verbum.Scrīptum), Tabula.Verba, nūntius, lēctor)
    {
      Nūntius.PlūsGarriōAsync("Fīō");
    }
  }
}
