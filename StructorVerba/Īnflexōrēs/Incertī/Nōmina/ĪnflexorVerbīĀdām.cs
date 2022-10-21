using Miscella;
using Praebeunda.Multiplex.Nōmen;
using Praebeunda.Īnflectendum.Nōmen;
using Ēnumerātiōnēs;
using Īnflexōrēs.Effectī.Nōmina.ĪnflexorEffectusPrīmusNōminibus;

using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Īnflexōrēs.Incertī.Nōmina
{
  [Lazy]
  public sealed partial class ĪnflexorVerbīĀdām : ĪnflexorIncertus<Īnflectendum.Nōmen, Multiplex.Nōmen>
  {
    private static readonly Lazy<ĪnflexorEffectusPrīmusNōminibus> Relātus = ĪnflexorEffectusPrīmusNōminibus.Lazy;

    private ĪnflexorVerbīĀdām()
        : base(catēgoria: Catēgoria.Nōmen, nūntius: new Lazy<Nūntius<ĪnflexorVerbīBalneum>>(),
               illa: Ūtilitātēs.Combīnō(Casus.GetValues().Except(Casus.Dērēctus).ToHashSet(),
                                        Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet()))
    {
      Tabula.ForEach(async illa => FōrmamAsync((illa.FirstOf<Casus>(), illa.FirstOf<Numerālis>()) switch
                                                {
                                                  (Casus.Nōminātīvus or Casus.Vocātīvus or Casus.Accūsātīvus, Numerālis.Singulāris) => "Ādām",
                                                  _ => "Ād".Concat(await Relātus.SuffixumAsync(illa))
                                                }, illa));
      Nūntius.PlūsGarriōAsync("Fīō");
    }
  }
}
