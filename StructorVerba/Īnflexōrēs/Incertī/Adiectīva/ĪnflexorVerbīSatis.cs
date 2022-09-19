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
  public sealed partial class ĪnflexorVerbīSatis : ĪnflexorIncertus<Multiplex.Adiectīvum>
  {
    public static readonly Lazy<ĪnflexorVerbīSatis> Faciendum = new Lazy(() => Instance);

    private ĪnflexorVerbīSatis()
        : base(catēgoria: Catēgoria.Adiectīvum, nūntius: new Lazy<Nūntius<ĪnflexorVerbīSatis>>(),
               illa: Gradus.GetValues().Except(Gradus.Nūllus, Gradus.Superlātīvus).ToHashSet())
    {
      FōrmamAsync("satis", Gradus.Positīvus);
      FōrmamAsync("satius", Gradus.Comparātīvus);
      Nūntius.PlūsGarriōAsync("Fīō");
    }
  }
}
