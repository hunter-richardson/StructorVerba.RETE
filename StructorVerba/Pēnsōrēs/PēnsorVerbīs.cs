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
    private static readonly Lazy<PēnsorVerbīs<Lemma>> Lemmīs
            = new Lazy(() => new PēnsorVerbīs<Lemma>(lēctor: Lemma.Lēctor));
    private static readonly Lazy<PēnsorVerbīs<Verbum>> Verbīs
            = new Lazy(() => new PēnsorVerbīs<Verbum>(lēctor: Verbum.Lēctor));

    public static readonly Func<Ēnumerātiōnēs.Catēgoria, Lazy<PēnsorVerbīs>> Relātor =
            catēgoria => catēgoria.Īnflexa().Choose(Lemmīs, Verbīs);

    protected PēnsorVerbīs(in Func<JsonElement, Task<Hoc>> lēctor)
                  : base(quaerendī: nameof(Verbum.Scrīptum), tabula: Tabula.Verba,
                         nūntius: new Lazy<Nūntius<PēnsorVerbīs>>(), lēctor: lēctor)
            => Nūntius.PlūsGarriōAsync("Fīō");
  }
}
