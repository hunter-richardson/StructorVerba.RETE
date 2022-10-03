using System;

using Miscella.Ūtilitātēs;
using Praebeunda.Multiplex.Nōmen;
using Praebeunda.Īnflendum.Nōmen;
using Ēnumerātiōnēs;
using Īnflexōrēs.Effectī.Nōmina.ĪnflexorEffectusPrīmusNōminibus;

using Lombok.NET.MethodGenerators.LazyAttribute;

namespace Īnflexōrēs.Incertī.Nōmina
{
  [Lazy]
  public sealed partial class ĪnflexorVerbīDea : ĪnflexorIncertus<Īnflectendum.Nōmen, Multiplex.Nōmen>
  {
    private readonly Lazy<ĪnflexorEffectusPrīmusNōminibus> Relātum = ĪnflexorEffectusPrīmusNōminibus.Lazy;
    private ĪnflexorVerbīDea()
          : base(catēgoria: Catēgoria.Nōmen, nūntius: new Lazy<Nūntius<ĪnflexorVerbīDea>>(),
                 illa: Ūtilitātēs.Combīnō(Casus.GetValues().Except(Casus.Dērēctus).ToHashSet(),
                                          Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet()))
    {
      Ūtilitātēs.Seriēs(Casus.Datīvus, Casus.Ablātīvus, Casus.Locātīvus, Casus.Instrumentālis)
                .ForEach(valor => FōrmamAsync("deābus", valor, Numerālis.Plūrālis));

      Tabula.Except(illa => Fōrmae.Keys.Contains(illa))
            .ForEach(illa => FōrmamAsync(fōrma: "de".Concat(await Relātum.Value.SuffixumAsync(illa: illa), illa: illa)));
      Nūntius.PlūsGarriōAsync("Fīō");
    }
  }
}
