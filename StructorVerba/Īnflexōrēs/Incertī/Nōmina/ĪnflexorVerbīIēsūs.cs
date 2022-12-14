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
  public sealed partial class ĪnflexorVerbīIēsūs : ĪnflexorIncertus<Īnflectendum.Nōmen, Multiplex.Nōmen>
  {
    private readonly Lazy<ĪnflexorEffectusQuārtusNōminibus> Relātus = ĪnflexorEffectusQuārtusNōminibus.Lazy;
    private ĪnflexorVerbīIēsūs()
        : base(catēgoria: Catēgoria.Nōmen, nūntius: new Lazy<Nūntius<ĪnflexorVerbīIēsūs>>(),
               illa: Casus.GetValues().Except(Casus.Dērēctus))
    {
      Tabula.ForEach(illa =>
        {
          const Casus casus = illa.FirstOf<Casus>() switch
          {
            Casus.Nōminātīvus or Casus.Genitīvus => Casus.Genitīvus,
            Casus.Accūsātīvus => Casus.Accūsātīvus,
            _ => Casus.Ablātīvus
          };
          FōrmamAsync(await Relātus.SuffixumAsync(casus, Numerālis.Singulāris), illa.FirstOf<Casus>());
        });

      Nūntius.PlūsGarriōAsync("Fīō");
    }
  }
}
