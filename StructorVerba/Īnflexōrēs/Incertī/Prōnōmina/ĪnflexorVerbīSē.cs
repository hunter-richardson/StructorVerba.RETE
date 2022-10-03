using System;

using Miscella.Extensions;
using Nūntiī.Nūntius;
using Praebeunda.Multiplex.Prōnōmen;
using Ēnumerātiōnēs;

using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Īnflexōrēs.Incertī.Prōmōmina
{
  [Lazy]
  public sealed partial class ĪnflexorVerbīSē : ĪnflexorIncertus<Multiplex.Prōnōmen>
  {
    private readonly Lazy<ĪnflexorRescrīptus> Relātus
     = new Lazy(() => new ĪnflexorRescrīptus(relātus: ĪnflexorVerbīTū.Lazy,
                                             rescrīptor: scrīptum => scrīptum.ReplaceStart("t", "s")));

    private ĪnfexorVerbīSē()
          : base(catēgoria: Catēgoria.Prōnōmen, nūntius: new Lazy<Nūntius<ĪnflexorVerbīSē>>(),
                 illa: Casus.GetValues().Except(Casus.Dērēctus, Casus.Nōminātīvus, Casus.Vocātīvus).ToHashSet())
    {
      Tabula.ForEach(async illa =>
              {
                const Casus casus = illa.FirstOf<Casus>();
                const string fōrma = casus switch
                {
                  Casus.Dērēctus or Casus.Nōminātīvus or Casus.Vocātivus => string.Empty,
                  _ => await Relātus.Value.ScrībamAsync(Numerālis.Singulāris, casus)
                };
                FōrmamAsync(fōrma, casus);
              });

      Nūntius.PlūsGarriōAsync("Fīō");
    }
  }
}
