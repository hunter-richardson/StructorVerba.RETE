using System;
using System.Threading.Tasks.Task;

using Praebeunda.Interfecta.Pēnsābile;
using Praebeunda.Simplicia;
using Pēnsōrēs.PēnsorVerbīs;
using Ēnumerātiōnēs.Catēgoria;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Officīnae
{
  public sealed class OfficīnaPēnsābilium<Hoc> where Hoc : Pēnsābile<Hoc>
  {
    private static readonly Lazy<OfficīnaPēnsābilium<Coniūntiō>> Coniūnctor
                = new Lazy(() => OfficīnaPēnsābilium<Coniūntiō>(Catēgoria.Coniūnctiō));
    private static readonly Lazy<OfficīnaPēnsābilium<Interiectiō>> Interiector
                = new Lazy(() => OfficīnaPēnsābilium<Interiectiō>(Catēgoria.Interiectiō));
    private static readonly Lazy<OfficīnaPēnsābilium<Praepositiō>> Praepositor
                = new Lazy(() => OfficīnaPēnsābilium<Praepositiō>(Catēgoria.Praepositiō));
    private static readonly Lazy<OfficīnaPēnsābilium<Lemma>> Lemmātor
                = new Lazy(() => OfficīnaPēnsābilium<Lemma>(null));

    private readonly Nūntius nūntius = new Nūntius<OfficīnaPēnsābilium>();
    public static readonly Func<Catēgoria, Lazy<OfficīnaPēnsābilium>> Officīnātor
               = catēgoria => catēgoria switch
                              {
                                Catēgoria.Coniūnctiō => Āctor,
                                Catēgoria.Interiectiō => Adiectīvātor,
                                Catēgoria.Praepositiō => Nōminātor,
                                _ => Lemmātor
                              };

    private readonly PēnsorVerbīs Pēnsor { get; }
    public readonly Func<string, Task<Hoc?>> Inventor = Pēnsor.PēnsorVerbālis;
    public readonly Func<Task<Hoc?>> FortisInventor = Pēnsor.FortisPēnsor;
    private OfficīnaPēnsābilium(in Catēgoria? catēgoria)
          => Pēnsor = PēnsorVerbīs.RelātorSimicibus.Invoke(catēgoria).Value;
  }
}
