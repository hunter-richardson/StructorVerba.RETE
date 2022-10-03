using System;
using System.Threading.Tasks.Task;

using Praebeunda.Interfecta.Pēnsābile;
using Praebeunda.Simplicia;
using Pēnsōrēs.PēnsorVerbīs;
using Ēnumerātiōnēs.Catēgoria;

namespace Officīnae
{
  public sealed class OfficīnaPēnsābilium<Hoc> where Hoc : Pēnsābile<Hoc>
  {
    private static readonly Lazy<OfficīnaPēnsābilium<Coniūntiō>> Coniūnctor
                = new Lazy(() => OfficīnaPēnsābilium<Coniūntiō>(catēgoria: Catēgoria.Coniūnctiō));
    private static readonly Lazy<OfficīnaPēnsābilium<Interiectiō>> Interiector
                = new Lazy(() => OfficīnaPēnsābilium<Interiectiō>(catēgoria: Catēgoria.Interiectiō));
    private static readonly Lazy<OfficīnaPēnsābilium<Praepositiō>> Praepositor
                = new Lazy(() => OfficīnaPēnsābilium<Praepositiō>(catēgoria: Catēgoria.Praepositiō));
    private static readonly Lazy<OfficīnaPēnsābilium<Lemma>> Lemmātor
                = new Lazy(() => OfficīnaPēnsābilium<Lemma>(catēgoria: null));

    private readonly Nūntius nūntius = new Nūntius<OfficīnaPēnsābilium>();

    private readonly Catēgoria Catēgoria { get; }
    public static readonly Func<Catēgoria, Lazy<OfficīnaPēnsābilium?>> Officīnātor
               = catēgoria => catēgoria switch
                              {
                                Catēgoria.Coniūnctiō => Āctor,
                                Catēgoria.Interiectiō => Adiectīvātor,
                                Catēgoria.Praepositiō => Nōminātor,
                                Catēgoria.Prōnōmen => new Lazy(null),
                                _ => Lemmātor
                              };

    private readonly PēnsorVerbīs Pēnsor { get; }
    public readonly Func<Task<IEnumerable<string>>> Omnia = Pēnsor.Omnia;
    public readonly Func<string, Task<Hoc?>> Inventor = verbum => Pēnsor.PendemAsync(quaerendum: verbum);
    public readonly Func<string, Catēgoria, Task<Hoc?>> InventorCatēgoriae
        = (verbum, catēgoria) => Pēnsor.PendemAsync(quaerendum: verbum, catēgoria: catēgoria);
    public readonly Func<Task<Hoc?>> FortisInventor = () => Pēnsor.ForsPendatAsync();
    public readonly Func<Task<Hoc?>> FortisInventorCatēgoriae
        = () => (Catēgoria is not null).Choose(Pēnsor.ForsPendatAsync(catēgoria: Catēgoria), null);
    private OfficīnaPēnsābilium(in Catēgoria? catēgoria)
    {
      Catēgoria = catēgoria;
      Pēnsor = PēnsorVerbīs.Relātor.Invoke(Catēgoria).Value;
      Nūntius.PlūsGarriōAsync("Fīō");
    }
  }
}
