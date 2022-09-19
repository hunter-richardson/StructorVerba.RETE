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
  public sealed partial class ĪnflexorVerbīFrūgī : ĪnflexorIncertus<Multiplex.Adiectīvum>
  {
    public static readonly Lazy<ĪnflexorVerbīFrūgī> Faciendum = new Lazy(() => Instance);

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
