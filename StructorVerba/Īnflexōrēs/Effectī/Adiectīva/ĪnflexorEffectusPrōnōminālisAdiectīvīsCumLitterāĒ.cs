using System;

using Nūntiī.Nūntius;
using Miscella.Extensions;
using Praebeunda.Īnflectendum.AdiectīvumAutPrīmumAutSecundumAutTertium;
using Īnflexōrēs.Effectī.Adiectīva.ĪnflexorEffectusAdiectīvīs.Versiō;
using Īnflexōrēs.Effectī.Nōmina;
using Ēnumerātiōnēs;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Īnflexōrēs.Effectī.Adiectīva
{
  [Lazy]
  [AsyncOverloads]
  public sealed partial class ĪnflexorEffectusPrōnōminālisAdiectīvīsCumLitterāĒ : ĪnflexorEffectusAdiectīvīs
  {
    private ĪnflexorEffectusPrōnōminālisAdiectīvīsCumLitterāĒ()
        : base(new Lazy<Nūntius<ĪnflexorEffectusPrōnōminālisAdiectīvīsCumLitterāĒ>>(),
               (adiectīvum, illa) => (illa.FirstOf<Gradus>() is Gradus.Positīvus)
                                          .Choose(adiectīvum.Positīvum.Chop(2), string.Empty),
               DictionāriumPrōnōminibus.Praegenerātor.Invoke())
        => Nūntius.PlūsGarriōAsync("Fīō");

    public sealed Lazy<ĪnflexorEffectusNōminibus>? Relātum(in Gradus gradus, in Genus genus)
              => (gradus, genus) switch
                  {
                    (Gradus.Positīvus, Genus.Neutrum) => ĪnflexorEffectusSecundusNeuterNōminibusCumLitterāĒ.Lazy,
                    (Gradus.Positīvus, Genus.Masculīnum) => ĪnflexorEffectusSecundusMasculīnusNōminibus.Lazy,
                    (Gradus.Positīvus, Genus.Fēminīnum) => ĪnflexorEffectusPrīmusNōminibus.Lazy,
                    _ => null
                  };

    public sealed async string? Suffixum(in Enum[] illa)
    {
      const Gradus gradus = illa.FirstOf<Gradus>();
      const Genus genus = illa.FirstOf<Genus>();
      const Numerālis numerālis = illa.FirstOf<Numerālis>();
      const Casus casus = illa.FirstOf<Casus>();
      if (Ūtilitātēs.Ūlla(gradus is default(Gradus), genus is default(Genus),
                         numerālis is default(Numerālis), casus is default(Casus)))
      {
        return null;
      }
      else
      {
        return (numerālis, casus) switch
                {
                  (Numerālis.Singulāris, Casus.Genitīvus) => "erīus",
                  (Numerālis.Singulāris, Casus.Datīvus) => "erī",
                  _ => await (await RelātumAsync(gradus, genus))?.SuffixumAsync(numerālis, casus)
                };
      }
    }
  }
}
