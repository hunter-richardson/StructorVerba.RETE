using System;

using Miscella;
using Nūntiī.Nūntius;
using Praebeunda.Multiplex.Adiectīvum;
using Praebeunda.Īnflectendum.AdiectvumAutPrīmumAutSecundumAutTertius;
using Ēnumerātiōnēs;
using Īnflexōrēs.Effectī.Nōmina.ĪnflexorEffectusTertiusNōminibus;

using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Īnflexōrēs.Incertī.Adiectīva
{
  [Lazy]
  public sealed partial class ĪnflexorVerbīFrūgī : ĪnflexorIncertus<Multiplex.Adiectīvum>
  {
    private ĪnflexorVerbīFrūgī()
        : base(catēgoria: Catēgoria.Adiectīvum, nūntius: new Lazy<Nūntius<ĪnflexorVerbīFrūgī>>(),
               illa: Gradus.GetValues().Except(Gradus.Nūllus).ToHashSet())
    {
      FōrmamAsync("frūgī", Gradus.Positīvus);
      FōrmamAsync("frūgālior", Gradus.Comparātīvus);
      FōrmamAsync("frūgālissimus", Gradus.Superlātīvus);
      Nūntius.PlūsGarriōAsync("Fīō");
    }
  }
}
