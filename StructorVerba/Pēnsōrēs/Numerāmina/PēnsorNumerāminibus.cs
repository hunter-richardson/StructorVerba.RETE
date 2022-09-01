using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;
using Pēnsōrēs.Pēnsor.Tabula;
using Īnflexōrēs.ĪnflexorNumerāmibus.Versiō;

namespace Pēnsōrēs.Numerāmina
{
  public abstract class PēnsorNumerāminibus<Hoc> : PēnsorĪnflectendīs<Hoc, Multiplex.Numerāmen>
  {
    private static readonly Func<ĪnflexorNumerāmibus.Versiō, Tabula?> Tabulātor =
              versiō => versiō switch
            {
              Versiō.Cardinālium_Solōrum =>
                               Tabula.Numerāmina_Cardinālium_Solōrum,
              Versiō.Cardinālium_Ōrdināliumque =>
                               Tabula.Numerāmina_Cardinālium_Ōrdināliumque,
              Versiō.Cardinālium_Et_Ōrdinālium_Et_Adverbiōrum =>
                               Tabula.Numerāmina_Cardinālium_Et_Ōrdinālium_Et_Adverbiōrum,
              Versiō.Cardinālium_Et_Ōrdinālium_Et_Distribūtīvōrum =>
                               Tabula.Numerāmina_Cardinālium_Et_Ōrdinālium_Et_Distribūtīvōrum,
              Versiō.Cardinālium_Et_Ōrdinālium_Et_Adverbiōrum_Et_Distribūtīvōrum =>
                               Tabula.Numerāmina_Cardinālium_Et_Ōrdinālium_Et_Adverbiōrum_Et_Distribūtīvōrum,
              Versiō.Omnium_Praeter_Multiplicātīva =>
                               Tabula.Numerāmina_Omnium_Praeter_Multiplicātīva,
              Versiō.Omnium_Praeter_Frāctiōnēs =>
                               Tabula.Numerāmina_Omnium_Praeter_Frāctiōnēs,
              Versiō.Omnium => Tabula.Numerāmina_Omnium,
              _ => null
            };

    public static readonly Func<Ēnumerātiōnēs.Catēgoria, ĪnflexorNumerāmibus.Versiō, Lazy<PēnsorNumerāminibus?>> Relātor =
              versiō => versiō switch
            {
              Versiō.Cardinālium_Solōrum =>
                               PēnsorNumerāminibusCardinālumSōlōrum.Faciendum,
              Versiō.Cardinālium_Ōrdināliumque =>
                               PēnsorNumerāminibusCardinālumŌrdināliumque.Faciendum,
              Versiō.Cardinālium_Et_Ōrdinālium_Et_Adverbiōrum =>
                               PēnsorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrum.Faciendum,
              Versiō.Cardinālium_Et_Ōrdinālium_Et_Distribūtīvōrum =>
                               PēnsorNumerāminibusCardinālumEtŌrdinālumEtDistribūtīvōrum.Faciendum,
              Versiō.Cardinālium_Et_Ōrdinālium_Et_Adverbiōrum_Et_Distribūtīvōrum =>
                               PēnsorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum.Faciendum,
              Versiō.Omnium_Praeter_Multiplicātīva =>
                               PēnsorNumerāminibusOmniumPraeterMultiplicātīva.Faciendum,
              Versiō.Omnium_Praeter_Frāctiōnēs =>
                               PēnsorNumerāminibusOmniumPraeterFrāctiōnēs.Faciendum,
              Versiō.Omnium => PēnsorNumerāminibusOmnium.Faciendum,
              _ => new Lazy(null)
            };

    protected PēnsorNumerāminibus(in ĪnflexorNumerāmibus.Versiō versiō, in string quaerendī,
                                  in Lazy<Nūntius<PēnsorNumerāminibus<Hoc>>> nūntius,
                                  in Func<JsonElement, Task<Hoc>> lēctor)
                                     : base(versiō, quaerendī, Tabulātor.Invoke(versiō), nūntius, lēctor) { }
  }
}
