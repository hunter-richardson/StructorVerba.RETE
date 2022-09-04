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
                               ĪnflexorNumerāminibusCardinālumSōlōrum.Faciendum,
              Versiō.Cardinālium_Ōrdināliumque =>
                               ĪnflexorNumerāminibusCardinālumŌrdinālumque.Faciendum,
              Versiō.Cardinālium_Et_Ōrdinālium_Et_Adverbiōrum =>
                               ĪnflexorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrum.Faciendum,
              Versiō.Cardinālium_Et_Ōrdinālium_Et_Distribūtīvōrum =>
                               ĪnflexorNumerāminibusCardinālumEtŌrdinālumEtDistribūtīvōrum.Faciendum,
              Versiō.Cardinālium_Et_Ōrdinālium_Et_Adverbiōrum_Et_Distribūtīvōrum =>
                               ĪnflexorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum.Faciendum,
              Versiō.Omnium_Praeter_Multiplicātīva =>
                               ĪnflexorNumerāminibusOmniumPraeterMultiplicātīva.Faciendum,
              Versiō.Omnium_Praeter_Frāctiōnēs =>
                               ĪnflexorNumerāminibusOmniumPraeterFrāctiōnēs.Faciendum,
              Versiō.Omnium => ĪnflexorNumerāminibusOmnium.Faciendum,
              _ => new Lazy(null)
            };

    protected ĪnflexorNumerāminibus(in Lazy<Nūntius<ĪnflexorNumerāminibus<Hoc>>> nūntius,
                                    in params Numerium illa)
                                       : base(Ēnumerātiōnēs.Catēgoria.Numerāmen, nūntius, illa) { }

    public abstract string Scrībam(in Hoc hoc, in Numerium numerium);
    public string Scrībam(in Hoc hoc, in Enum[] illa) => await ScrībamAsync(hoc, illa.FirstOf<Numerium>());
  }
}
