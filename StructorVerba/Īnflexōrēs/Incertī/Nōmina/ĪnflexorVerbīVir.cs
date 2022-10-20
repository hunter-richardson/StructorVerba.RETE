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
  public sealed partial class ĪnflexorVerbīVir : ĪnflexorIncertus<Īnflectendum.Nōmen, Multiplex.Nōmen>
  {
    private readonly Lazy<ĪnflexorEffectusSecundusMasculīnusNōminibus> Relātus
                        = ĪnflexorEffectusSecundusMasculīnusNōminibus.Lazy;
    private ĪnflexorVerbīVir()
        : base(catēgoria: Catēgoria.Nōmen, nūntius: new Lazy<Nūntius<ĪnflexorVerbīVir>>(),
               illa: Ūtilitātēs.Combīnō(Casus.GetValues().Except(Casus.Dērēctus).ToHashSet(),
                                        Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet()))
    {
      Tabula.ForEach(illa =>
        {
          const Numerālis numerālis = illa.FirstOf<Numerālis>();
          const Casus casus = illa.FirstOf<Casus>();
          const string fōrma = (numerālis, casus) switch
          {
            (Casus.Nōminātīvus or Casus.Vocātīvus, Numerālis.Singulāris) => "vir",
            _ => "vir".Concat(await Relātus.Value.SuffixumAsync(numerālis, casus))
          };
          FōrmamAsync(fōrma, numerālis, casus);
        });

      Nūntius.PlūsGarriōAsync("Fīō");
    }
  }
}
