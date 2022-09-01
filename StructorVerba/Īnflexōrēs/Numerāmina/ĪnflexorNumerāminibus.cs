using System;
using System.Threading.Tasks.Task;

using Praebeunda.Multiplex.Numerāmen;
using Ēnumerātiōnēs;
using Nūntiī.Nūntius;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Numerāmina
{
  [AsyncOverloads]
  public abstract partial class ĪnflexorNumerāminibus<Hoc> : Īnflexor<Hoc, Multiplex.Numerāmen>
  {
    public enum Versiō
    {
      Cardinālium_Solōrum, Cardinālium_Ōrdināliumque, Cardinālium_Et_Ōrdinālium_Et_Adverbiōrum,
      Cardinālium_Et_Ōrdinālium_Et_Distribūtīvōrum, Cardinālium_Et_Ōrdinālium_Et_Adverbiōrum_Et_Distribūtīvōrum,
      Omnium_Praeter_Multiplicātīva, Omnium_Praeter_Frāctiōnēs, Omnium
    }

    public static readonly Func<Versiō, Task<Lazy<ĪnflexorNumerāminibus>>> Relātor
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
                                    in params Enum illa)
                                       : base(Ēnumerātiōnēs.Catēgoria.Numerāmen, nūntius, illa) { }

    public abstract string Scrībam(in Hoc hoc, in Numerium numerium);
    public string Scrībam(in Hoc hoc, in Enum[] illa)
    {
      return await ScrībamAsync(hoc, Numeria.Iactor.Invoke(from illud in illa
                                                           where illud is Numerium
                                                           select illud).First());
    }
  }
}
