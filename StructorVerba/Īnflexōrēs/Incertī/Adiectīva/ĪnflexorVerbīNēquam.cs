using System;

using Miscella;
using Nūntiī.Nūntius;
using Praebeunda.Multiplex.Adiectīvum;
using Praebeunda.Īnflectendum.AdiectvumAutPrīmumAutSecundumAutTertius;
using Ēnumerātiōnēs;
using Īnflexōrēs.Effectī.Nōmina.ĪnflexorEffectusTertiusNōminibus;

namespace Īnflexōrēs.Incertī.Adiectīva
{
  [Singleton]
  public sealed partial class ĪnflexorVerbīNēquam : ĪnflexorIncertus<Multiplex.Adiectīvum>
  {
    public static readonly Lazy<ĪnflexorVerbīNēquam> Faciendum = new Lazy(() => Instance);

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
