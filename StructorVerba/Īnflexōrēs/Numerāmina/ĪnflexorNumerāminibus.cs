using System;
using System.Threading.Tasks.Task;

using Miscella.Extensions;
using Praebeunda.Multiplex.Numerāmen;
using Pēnsōrēs.Numerāmina.PēnsorNumerāminibus.Versiō;
using Ēnumerātiōnēs.Numerium;
using Nūntiī.Nūntius;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Numerāmina
{
  [AsyncOverloads]
  public abstract partial class ĪnflexorNumerāminibus<Hoc> : Īnflexor<Hoc, Multiplex.Numerāmen>
  {
    public static readonly Func<PēnsorNumerāminibus.Versiō, Task<Lazy<ĪnflexorNumerāminibus>>> Relātor
            = async versiō => versiō switch
            {
              Versiō.Cardinālium_Solōrum =>
                               ĪnflexorNumerāminibusCardinālumSōlōrum.Lazy,
              Versiō.Cardinālium_Ōrdināliumque =>
                               ĪnflexorNumerāminibusCardinālumŌrdinālumque.Lazy,
              Versiō.Cardinālium_Et_Ōrdinālium_Et_Adverbiōrum =>
                               ĪnflexorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrum.Lazy,
              Versiō.Cardinālium_Et_Ōrdinālium_Et_Distribūtīvōrum =>
                               ĪnflexorNumerāminibusCardinālumEtŌrdinālumEtDistribūtīvōrum.Lazy,
              Versiō.Cardinālium_Et_Ōrdinālium_Et_Adverbiōrum_Et_Distribūtīvōrum =>
                               ĪnflexorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum.Lazy,
              Versiō.Omnium_Praeter_Multiplicātīva =>
                               ĪnflexorNumerāminibusOmniumPraeterMultiplicātīva.Lazy,
              Versiō.Omnium_Praeter_Frāctiōnēs =>
                               ĪnflexorNumerāminibusOmniumPraeterFrāctiōnēs.Lazy,
              Versiō.Omnium => ĪnflexorNumerāminibusOmnium.Lazy,
              _ => new Lazy(null)
            };

    protected ĪnflexorNumerāminibus(in Lazy<Nūntius<ĪnflexorNumerāminibus<Hoc>>> nūntius,
                                    in params Numerium illa)
                   : base(catēgoria: Ēnumerātiōnēs.Catēgoria.Numerāmen, nūntius: nūntius, illa: illa) { }

    public abstract string Scrībam(in Hoc hoc, in Numerium numerium);
    public string Scrībam(in Hoc hoc, in Enum[] illa) => await ScrībamAsync(hoc, illa.FirstOf<Numerium>());
  }
}
