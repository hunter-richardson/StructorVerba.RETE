using System;
using System.Threading.Tasks.Task;

using Miscella.Extensions;
using Praebeunda.Multiplex.Numerāmen;
using Pēnsōrēs.Numerāmina.PēnsorNumerāminibus.Versiō;
using Ēnumerātiōnēs.Numerium;
using Nūntiī.Nūntius;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs
{
  [AsyncOverloads]
  public sealed partial class ĪnflexorNumerāminibus : Īnflexor<Īnflectendum.Numerāmen, Multiplex.Numerāmen>
  {
    private readonly Lazy<ĪnflexorNumerāminibus> CardināliumSolōrum
               = new Lazy<ĪnflexorNumerāminibus>(() => new ĪnflexorNumerāminibus(Numerium.Cardināle));
    private readonly Lazy<ĪnflexorNumerāminibus> CardināliumŌrdināliumque
               = new Lazy<ĪnflexorNumerāminibus>(() => new ĪnflexorNumerāminibus(Numerium.Cardināle, Numerium.Ōrdināle));
    private readonly Lazy<ĪnflexorNumerāminibus> CardināliumAdverbiōrumque
               = new Lazy<ĪnflexorNumerāminibus>(() => new ĪnflexorNumerāminibus(Numerium.Cardināle, Numerium.Adverbium));
    private readonly Lazy<ĪnflexorNumerāminibus> CardināliumEtŌrdināliumEtAdverbiōrum
               = new Lazy<ĪnflexorNumerāminibus>(() => new ĪnflexorNumerāminibus(Numerium.Cardināle, Numerium.Ōrdināle, Numerium.Adverbium));
    private readonly Lazy<ĪnflexorNumerāminibus> CardināliumEtŌrdināliumEtDistribūtīvōrum
               = new Lazy<ĪnflexorNumerāminibus>(() => new ĪnflexorNumerāminibus(Numerium.Cardināle, Numerium.Ōrdināle, Numerium.Distribūtīvum));
    private readonly Lazy<ĪnflexorNumerāminibus> CardināliumEtŌrdināliumEtAdverbiōrumEtDistribūtīvōrum
               = new Lazy<ĪnflexorNumerāminibus>(() => new ĪnflexorNumerāminibus(Numerium.Cardināle, Numerium.Ōrdināle, Numerium.Adverbium, Numerium.Distribūtīvum));
    private readonly Lazy<ĪnflexorNumerāminibus> OmniumPraeterMultiplicātīva
               = new Lazy<ĪnflexorNumerāminibus>(() => new ĪnflexorNumerāminibus(Numerium.GetValues().Except(Numerium.Multiplicātīvum)));
    private readonly Lazy<ĪnflexorNumerāminibus> OmniumPraeterFrāctiōnēs
               = new Lazy<ĪnflexorNumerāminibus>(() => new ĪnflexorNumerāminibus(Numerium.GetValues().Except(Numerium.Frāctiōnāle)));
    private readonly Lazy<ĪnflexorNumerāminibus> Omnium
               = new Lazy<ĪnflexorNumerāminibus>(() => new ĪnflexorNumerāminibus(Numerium.GetValues()));


    public static readonly Func<PēnsorNumerāminibus.Versiō, Task<Lazy<ĪnflexorNumerāminibus>>> Relātor
            = async versiō => versiō switch
            {
              Versiō.Cardinālium_Solōrum => CardināliumSolōrum,
              Versiō.Cardinālium_Ōrdināliumque => CardināliumŌrdināliumque,
              Versiō.Cardinālium_Adverbiōrumque => CardināliumAdverbiōrumque,
              Versiō.Cardinālium_Et_Ōrdinālium_Et_Adverbiōrum => CardināliumEtŌrdināliumEtAdverbiōrum,
              Versiō.Cardinālium_Et_Ōrdinālium_Et_Distribūtīvōrum => CardināliumEtŌrdināliumEtDistribūtīvōrum,
              Versiō.Cardinālium_Et_Ōrdinālium_Et_Adverbiōrum_Et_Distribūtīvōrum => CardināliumEtŌrdināliumEtAdverbiōrumEtDistribūtīvōrum,
              Versiō.Omnium_Praeter_Multiplicātīva => OmniumPraeterMultiplicātīva,
              Versiō.Omnium_Praeter_Frāctiōnēs => OmniumPraeterFrāctiōnēs,
              Versiō.Omnium => Omnium,
              _ => new Lazy(null)
            };

    protected ĪnflexorNumerāminibus(in params Numerium illa)
                   : base(catēgoria: Ēnumerātiōnēs.Catēgoria.Numerāmen,
                          nūntius: new Lazy<Nūntius<ĪnflexorNumerāminibus<Hoc>>>(),
                          illa: illa) { }

    public sealed string Scrībam(in Hoc hoc, in Enum[] illa)
              => illa.FirstOf<Numerium>() switch
                  {
                    Numerium.Ōrdināle => numerāmen.Ōrdināle,
                    Numerium.Cardināle => numerāmen.Cardināle,
                    Numerium.Adverbium => numerāmen.Adverbium,
                    Numerium.Multiplicātīvum => numerāmen.Multiplicātīvum,
                    Numerium.Distribūtīvum => numerāmen.Distribūtīvum,
                    Numerium.Frāctiōnāle => numerāmen.Frāctiōnāle,
                    _ => numerāmen.Numerus
                  };
  }
}
