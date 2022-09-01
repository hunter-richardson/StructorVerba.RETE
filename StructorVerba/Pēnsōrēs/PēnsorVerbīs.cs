using System;
using System.Text.Json.JsonElement;
using System.Threading.Tasks.Task;

using Nūntiī.Nūntius;
using Praebeunda;
using Praebeunda.Simplicibus;

namespace Pēnsōrēs
{
  public abstract partial class PēnsorVerbīs<Hoc> : Pēnsor<Hoc> where Hoc : Verbum<Hoc>
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

  public sealed partial class PēnsorVerbīs : PēnsorVerbīs<Verbum>
  {
    private PēnsorVerbīs()
        : base(nameof(Verbum.Scrīptum), Tabula.Verba,
                      NūntiusPēnsōrīVerbīs.Faciendum, Verbum.Lēctor) {  }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīVerbīs : Nūntius<PēnsōrVerbīs>
    {
      public static readonly Lazy<NūntiusPēnsōrīVerbīs> Faciendum = new Lazy<NūntiusPēnsōrīVerbīs>(() => Instance);
    }
  }
}
