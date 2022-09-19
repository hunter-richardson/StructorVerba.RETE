using System;
using System.ComponentModel.Design;
using System.Collections.Generic.HashSet;

using Miscella;
using Nūntiī.Nuntius;
using Pēnsōrēs.Īnflectenda.PēnsorAdiectīvīs.Versiō;
using Praebeunda.Multiplex.Adiectivum;
using Praebeunda.Īnflectendum.AdiectīvumAutPrīmumAutSecundumAutTertium;
using Ēnumerātiōnēs;
using Īnflexōrēs.Effectī.Adiectīva;

using Lombok.NET.MethodGenerators.SingletonAttribute;

namespace Īnflexōrēs.Incertī.Adiectīva
{
  [Singleton]
  public sealed partial class ĪnflexorVerbīMultum : ĪnflexorIncertus<Īnflectendum.AdiectīvumAutPrīmumAutSecundumAutTertium, Multiplex.Adiectivum>
  {
    public static readonly Lazy<ĪnflexorVerbīMultum> Faciendum = new Lazy(() => Instance);

    private ĪnflexorVerbīMultum()
          : base(Catēgoria.Adiectīvum, new Lazy<Nūntius<ĪnflexorVerbīMultum>>(),
                 Ūtilitātēs.Combīnō(Gradus.GetValues().Except(Gradus.Nūllus, Gradus.Comparātīvus).ToHashSet(),
                                    Genus.GetValues().Except(Genus.Nūllum).ToHashSet(),
                                    new HashSet<Casus>() { Casus.Nominātīvus, Casus.Genitīvus, Casus.Accusātīvus, Casus.Vocātīvus },
                                    Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet()),
                 Ūtilitātēs.Combīnō(Gradus.GetValues().Except(Gradus.Nūllus, Gradus.Comparātīvus).ToHashSet(),
                                    Genus.GetValues().Except(Genus.Nūllum).ToHashSet(),
                                    new HashSet<Casus>() { Casus.Datīvus, Casus.Ablātīvus, Casus.Locātīvus, Casus.Instrumentālis },
                                    Numerālis.Singulāris.SinglItemSet()),
                 Ūtilitātēs.Combīnō(Gradus.GetValues().Except(Gradus.Nūllus, Gradus.Comparātīvus).ToHashSet(),
                                    new HashSet<Casus>() { Casus.Datīvus, Casus.Ablātīvus, Casus.Locātīvus, Casus.Instrumentālis },
                                    Numerālis.Plūrālis.SingleItemSet()),
                 Ūtilitātēs.Combīnō(Gradus.Comparātīvus.SinglItemSet(), Numerālis.Plūrālis.SingleItemSet(),
                                    Genus.GetValues().Except(Genus.Nūllum).ToHashSet(),
                                    new HashSet<Casus>() { Casus.Nominātīvus, Casus.Accusātīvus, Casus.Vocātīvus }),
                 Ūtilitātēs.Combīnō(Gradus.Comparātīvus.SinglItemSet(), Numerālis.Plūrālis.SingleItemSet(),
                                    new HashSet<Casus>() { Casus.Genitīvus, Casus.Datīvus, Casus.Ablātīvus, Casus.Locātīvus, Casus.Instrumentālis }),
                 Ūtilitātēs.Combīnō(Gradus.Comparātīvus.SinglItemSet(), Numerālis.Singulāris.SingleItemSet(),
                                    Casus.GetValues().Except(Casus.Dērēctus, Casus.Datīvus).ToHashSet()))
    {
      Tabula.ForEach(async illa =>
              {
                const Gradus gradus = illa.FirstOf<Gradus>();
                const Genus genus = illa.FirstOf<Genus>();
                const Numerālis numerālis = illa.FirstOf<Numerālis>();
                const Casus casus = illa.FirstOf<Casus>();
                const Lazy<ĪnflexorEffectusAdiectīvīs> īnflexor = gradus switch
                {
                  Gradus.Comparātīvus => ĪnflexorEffectusAdiectīvīsAutTertiusAutPrīmusAutSecundusCumGenitīvōVariō.Faciendum,
                  _ => ĪnflexorEffectusAdiectīvīsAutPrīmusAutSecundusAutTertius.Faciendum,
                };
                const string? fōrma = (gradus, casus) switch
                {
                  (Gradus.Comparātīvus, Casus.Nominātīvus or Casus.Accusātīvus, Casus.Vocātīvus) => "plūs",
                  (Gradus.Comparātīvus, _) => "plūr".Concat(await suffixum.Value.SuffixumAsync(Gradus.Positīvus, genus, numerālis, casus)),
                  (Gradus.Positīvus, _) => "mult".Concat(await suffixum.Value.SuffixumAsync(Gradus.Positīvus, genus, numerālis, casus)),
                  (Gradus.Superlātīvus, _) => "plūrim".Concat(await suffixum.Value.SuffixumAsync(Gradus.Positīvus, genus, numerālis, casus)),
                  _ => null
                };
                if (fōrma is not null)
                {
                  FōrmamAsync(forma, gradus, genus, numerālis, casus);
                }
              });
      Nūntius.PlūsGarriōAsync("Fīō");
    }
  }
}
