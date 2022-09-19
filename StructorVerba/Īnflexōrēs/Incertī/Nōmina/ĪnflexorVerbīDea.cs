using System;

using Miscella.Ūtilitātēs;
using Praebeunda.Multiplex.Nōmen;
using Praebeunda.Īnflendum.Nōmen;
using Ēnumerātiōnēs;
using Īnflexōrēs.Effectī.Nōmina.ĪnflexorEffectusPrīmusNōminibus;

using Lombok.NET.MethodGenerators.SingletonAttribute;

namespace Īnflexōrēs.Incertī.Nōmina
{
  [Singleton]
  public sealed partial class ĪnflexorVerbīDea : ĪnflexorIncertus<Īnflectendum.Nōmen, Multiplex.Nōmen>
  {
    public static readonly Lazy<ĪnflexorVerbīDea> Faciendum = new Lazy(() => Instance);

    private readonly ĪnflexorEffectusPrīmusNōminibus Relātum = ĪnflexorEffectusPrīmusNōminibus.Faciendum.Value;
    private ĪnflexorVerbīDea()
          : base(catēgoria: Catēgoria.Nōmen, nūntius: new Lazy<Nūntius<ĪnflexorVerbīDea>>(),
                 illa: Ūtilitātēs.Combīnō(Casus.GetValues().Except(Casus.Dērēctus).ToHashSet(),
                                          Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet()))
    {
      Ūtilitātēs.Seriēs(Casus.Datīvus, Casus.Ablātīvus, Casus.Locātīvus, Casus.Instrumentālis)
                .ForEach(valor => FōrmamAsync("deābus", valor, Numerālis.Plūrālis));

      Tabula.Except(illa => Fōrmae.Keys.Contains(illa))
            .ForEach(illa => FōrmamAsync(fōrma: "de".Concat(await Relātum.SuffixumAsync(illa: illa), illa: illa)));
      Nūntius.PlūsGarriōAsync("Fīō");
    }
  }
}
