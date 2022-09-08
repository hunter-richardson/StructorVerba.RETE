using System;
using System.Text.Json.JsonElement;
using System.Threading.Tasks.Task;

using Nūntiī.Nūntius;
using Praebeunda.Verbum;
using Praebeunda.Simplicibus;

namespace Pēnsōrēs
{
  public sealed class PēnsorVerbīs<Hoc> : Pēnsor<Hoc> where Hoc : Verbum<Hoc>
  {
    private static readonly Lazy<PēnsorVerbīs<Coniūnctiō>> Coniūnctiōnibus
            = new Lazy(() => new PēnsorVerbīs<Coniūnctiō>(Coniūnctiō.Lēctor));
    private static readonly Lazy<PēnsorVerbīs<Interiectiō>> Interiectiōnibus
            = new Lazy(() => new PēnsorVerbīs<Interiectiō>(Interiectiō.Lēctor));
    private static readonly Lazy<PēnsorVerbīs<Praepositiō>> Coniūnctiōnibus
            = new Lazy(() => new PēnsorVerbīs<Praepositiō>(Praepositiō.Lēctor));
    private static readonly Lazy<PēnsorVerbīs<Lemma>> Lemmīs
            = new Lazy(() => new PēnsorVerbīs<Lemma>(Lemma.Lēctor));
    private static readonly Lazy<PēnsorVerbīs<Verbum>> Verbīs
            = new Lazy(() => new PēnsorVerbīs<Verbum>(Verbum.Lēctor));

    public static readonly Func<Ēnumerātiōnēs.Catēgoria, Lazy<PēnsorVerbīs>> RelātorSimplicibus =
            catēgoria => catēgoria switch
                          {
                            Ēnumerātiōnēs.Catēgoria.Coniūnctiō => Coniūnctiōnibus,
                            Ēnumerātiōnēs.Catēgoria.Interiectiō => Interiectiōnibus,
                            Ēnumerātiōnēs.Catēgoria.Praepositiō => Praepositiōnibus,
                            _ => PēnsorLemmīs.Faciendum
                          };

    protected PēnsorVerbīs(in Func<JsonElement, Task<Hoc>> lēctor)
                  : base(nameof(Verbum.Scrīptum), Tabula.Verba,
                         new Lazy<Nūntius<PēnsorVerbīs>>(), lēctor)
            => Nūntius.PlūsGarriōAsync("Fīō");
  }
}
