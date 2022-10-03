using System;

using Miscella;
using Nūntiī.Nuntius;
using Praebeunda.Multiplex.Nōmen;
using Praebeunda.Īnflectendum.Nōmen;
using Ēnumerātiōnēs;
using Īnflexōrēs.Effectī.Nōmen;

using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Īnflexōrēs.Incertī.Nōmina
{
  [Lazy]
  public sealed partial class ĪnflexorVerbīIūgerum : ĪnflexorIncertus<Īnflectendum.Nōmen, Multiplex.Nōmen>
  {
    private ĪnflexorVerbīIūgerum()
        : base(catēgoria: Catēgoria.Nōmen, nūntius: new Lazy<Nūntius<ĪnflexorVerbīIūgerum>>(),
               illa: Ūtilitātēs.Combīnō(Casus.GetValues().Except(Casus.Dērēctus).ToHashSet(),
                                        Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet()))
    {
      Tabula.ForEach(illa =>
        {
          const Numerālis numerālis = illa.FirstOf<Numerālis>();
          const Casus casus = illa.FirstOf<Casus>();
          const ĪnflexorEffectusNōminibus relātus = (numerālis, casus) switch
          {
            (Casus.Ablātīvus or Casus.Locātīvus or Casus.Instrumentālis, Numerālis.Plūrālis) => ĪnflexorEffectusTertiusNōminibus.Lazy,
            _ => ĪnflexorEffectusSecundusNeuterNōminibus.Lazy
          };
          FōrmamAsync("iūger".Concat(await relātus.Value.SuffixumAsync(numerālis, casus)), numerālis, casus);
        });

      Nūntius.PlūsGarriōAsync("Fīō");
    }
  }
}
