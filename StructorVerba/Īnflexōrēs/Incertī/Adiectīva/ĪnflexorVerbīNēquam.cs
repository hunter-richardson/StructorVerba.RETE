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
  public sealed partial class ĪnflexorVerbīNēquam : ĪnflexorIncertus<Multiplex.Adiectīvum>
  {
    private ĪnflexorVerbīNēquam()
        : base(catēgoria: Catēgoria.Adiectīvum, nūntius: new Lazy<Nūntius<ĪnflexorVerbīNēquam>>(),
               illa: Gradus.GetValues().Except(Gradus.Nūllus).ToHashSet())
    {
      FōrmamAsync("nēquam", Gradus.Positīvus);
      FōrmamAsync("nēquior", Gradus.Comparātīvus);
      FōrmamAsync("nēquissimus", Gradus.Superlātīvus);
      Nūntius.PlūsGarriōAsync("Fīō");
    }
  }
}
