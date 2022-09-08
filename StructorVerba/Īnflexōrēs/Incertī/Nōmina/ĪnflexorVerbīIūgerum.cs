using System;

using Miscella;
using Nūntiī.Nuntius;
using Praebeunda.Multiplex.Nōmen;
using Praebeunda.Īnflectendum.Nōmen;
using Ēnumerātiōnēs;
using Īnflexōrēs.Effectī.Nōmen;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Incertī.Nōmina
{
  [Singleton]
  public sealed partial class ĪnflexorVerbīIūgerum : ĪnflexorIncertus<Īnflectendum.Nōmen, Multiplex.Nōmen>
  {
    public static readonly Lazy<ĪnflexorVerbīIūgerum> Faciendum = new Lazy(() => Instance);
    private ĪnflexorVerbīIūgerum()
        : base(Catēgoria.Nōmen, new Lazy<Nūntius<ĪnflexorVerbīIūgerum>>(),
               Ūtilitātēs.Combīnō(Casus.GetValues().Except(Casus.Dērēctus).ToHashSet(),
                                  Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet()))
    => Tabula.ForEach(illa =>
        {
          const Numerālis numerālis = illa.FirstOf<Numerālis>();
          const Casus casus = illa.FirstOf<Casus>();
          const ĪnflexorEffectusNōminibus relātus = (numerālis, casus) switch
          {
            (Casus.Ablātīvus or Casus.Locātīvus or Casus.Instrumentālis, Numerālis.Plūrālis) => ĪnflexorEffectusTertiusNōminibus.Faciendum,
            _ => ĪnflexorEffectusSecundusNeuterNōminibus.Faciendum
          };
          FōrmamAsync("iūger".Concat(await relātus.Value.SuffixumAsync(numerālis, casus)), numerālis, casus);
        });
  }
}
