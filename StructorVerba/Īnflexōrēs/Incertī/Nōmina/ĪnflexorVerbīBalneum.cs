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
  public sealed partial class ĪnflexorVerbīBalneum : ĪnflexorIncertus<Īnflectendum.Nōmen, Multiplex.Nōmen>
  {
    public static readonly Lazy<ĪnflexorVerbīBalneum> Faciendum = new Lazy(() => Instance);
    private ĪnflexorVerbīIūgerum()
        : base(Catēgoria.Nōmen, new Lazy<Nūntius<ĪnflexorVerbīBalneum>>(),
               Ūtilitātēs.Combīnō(Casus.GetValues().Except(Casus.Dērēctus).ToHashSet(),
                                  Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet()))
    => Tabula.ForEach(illa =>
        {
          const Numerālis numerālis = illa.FirstOf<Numerālis>();
          const Casus casus = illa.FirstOf<Casus>();
          const ĪnflexorEffectusNōminibus? relātum = numerālis switch
          {
            Numerālis.Singulāris => ĪnflexorEffectusSecunumNeuterNōminibus.Faciendum,
            numerālis.Plūrālis => ĪnflexorEffectusPrīmusNōminibus.Faciendum,
            _ => null
          };
          FōrmamAsync("balne".Concat(await relātum?.Value.SuffixumAsync(numerālis, casus)), numerālis, casus);
        });
  }
}
