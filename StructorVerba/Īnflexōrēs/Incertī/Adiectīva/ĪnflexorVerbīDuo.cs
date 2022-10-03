using System;

using Miscella;
using Nūntiī.Nūntius;
using Praebeunda.Multiplex.Adiectīvum;
using Praebeunda.Īnflectendum.AdiectvumAutPrīmumAutSecundumAutTertius;
using Ēnumerātiōnēs;
using Īnflexōrēs.Effectī.Adiectīva.ĪnflexorEffectusAdiectīvīsAutPrīmusAutSecundusAutTertius;

using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Īnflexōrēs.Incertī.Adiectīva
{
  [Lazy]
  public sealed partial class ĪnflexorVerbīDuo : ĪnflexorIncertus<Multiplex.Adiectīvum>
  {
    private readonly Lazy<ĪnflexorEffectusAdiectīvīsAutPrīmusAutSecundusAutTertius> Relātus
                        = ĪnflexorEffectusAdiectīvīsAutPrīmusAutSecundusAutTertius.Lazy;
    private ĪnflexorVerbīDuo()
        : base(catēgoria: Catēgoria.Adiectīvum, nūntius: new Lazy<Nūntius<ĪnflexorVerbīDuo>>(),
               illa: Ūtilitātēs.Combīnō(Genus.GetValues().Except(Gradus.Nūllum).ToHashSet(),
                                        Casus.GetValues().Except(Casus.Dērēctus).ToHashSet()))
    {
      Tabula.ForEach(illa =>
          {
            const Genus genus = illa.FirstOf<Genus>();
            const Casus casus = illa.FirstOf<Casus>();
            const string? suffixum = (genus, casus) switch
            {
              (Genus.Neutrum or Genus.Masculīnum, Casus.Nominātīvus or Casus.Vocātīvus) => "o",
              (Genus.Neutrum or Genus.Masculīnum, Casus.Datīvus or Casus.Ablātīvus or Casus.Locātīvus or Casus.Instrumentālis) => "ōbus",
              (Genus.Neutrum, Casus.Accūsātīvus) => "o",
              (Genus.Fēminīnum, Casus.Datīvus or Casus.Ablātīvus or Casus.Locātīvus or Casus.Instrumentālis) => "ābus",
              _ => await Relātus.Value.SuffixumAsync(Gradus.Positīvus, genus, Numerālis.Plūrālis, casus)
            };
            if (suffixum is not null)
            {
              FōrmamAsync("du".Concat(suffixum), genus, casus);
            }
          });
      Nūntius.PlūsGarriōAsync("Fīō");
    }
  }
}
