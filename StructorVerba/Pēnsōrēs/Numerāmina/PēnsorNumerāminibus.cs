using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;
using Pēnsōrēs.Pēnsor.Tabula;

namespace Pēnsōrēs.Numerāmina
{
  public abstract class PēnsorNumerāminibus<Hoc> : PēnsorĪnflectendīs<Hoc, Multiplex.Numerāmen>
  {
    public enum Versiō
    {
      Cardinālium_Solōrum, Cardinālium_Ōrdināliumque, Cardinālium_Et_Ōrdinālium_Et_Adverbiōrum,
      Cardinālium_Et_Ōrdinālium_Et_Distribūtīvōrum, Cardinālium_Et_Ōrdinālium_Et_Adverbiōrum_Et_Distribūtīvōrum,
      Omnium_Praeter_Multiplicātīva, Omnium_Praeter_Frāctiōnēs, Omnium
    }

    public static sealed class Versiōnēs
    {
      public static string ToString(this in Versiō valor) => Enum.GetName<Versiō>(valor).ToLower();
    }

    private static readonly Func<Versiō, Tabula?> Tabulātor =
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
                               PēnsorNumerāminibusCardinālumSōlōrum.Lazy,
              Versiō.Cardinālium_Ōrdināliumque =>
                               PēnsorNumerāminibusCardinālumŌrdināliumque.Lazy,
              Versiō.Cardinālium_Et_Ōrdinālium_Et_Adverbiōrum =>
                               PēnsorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrum.Lazy,
              Versiō.Cardinālium_Et_Ōrdinālium_Et_Distribūtīvōrum =>
                               PēnsorNumerāminibusCardinālumEtŌrdinālumEtDistribūtīvōrum.Lazy,
              Versiō.Cardinālium_Et_Ōrdinālium_Et_Adverbiōrum_Et_Distribūtīvōrum =>
                               PēnsorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum.Lazy,
              Versiō.Omnium_Praeter_Multiplicātīva =>
                               PēnsorNumerāminibusOmniumPraeterMultiplicātīva.Lazy,
              Versiō.Omnium_Praeter_Frāctiōnēs =>
                               PēnsorNumerāminibusOmniumPraeterFrāctiōnēs.Lazy,
              Versiō.Omnium => PēnsorNumerāminibusOmnium.Lazy,
              _ => new Lazy(null)
            };

    protected PēnsorNumerāminibus(in ĪnflexorNumerāmibus.Versiō versiō, in string quaerendī,
                                  in Lazy<Nūntius<PēnsorNumerāminibus<Hoc>>> nūntius,
                                  in Func<JsonElement, Task<Hoc>> lēctor)
                                     : base(versiō: versiō, quaerendī: quaerendī,
                                            tabula: Tabulātor.Invoke(versiō),
                                            nūntius: nūntius, lēctor: lēctor) { }
  }
}
