using System;

using Nūntiī.Nūntius;
using Miscella.Extensions;
using Praebeunda.Īnflectendum.AdiectīvumAutPrīmumAutSecundumAutTertium;
using Īnflexōrēs.Effectī.Nōmina;
using Ēnumerātiōnēs;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Īnflexōrēs.Effectī.Adiectīva
{
  [Lazy]
  [AsyncOverloads]
  public sealed partial class ĪnflexorEffectusAdiectīvīsAutTertiusAutPrīmusAutSecundusCumNominātīvōGenitīvōqueVariō : ĪnflexorEffectusAdiectīvīs
  {
    private static readonly Lazy<ĪnflexorEffectusAdiectīvīsAutTertiusAutPrīmusAutSecundusCumGenitīvōVariō> Relātum
                               = ĪnflexorEffectusAdiectīvīsAutTertiusAutPrīmusAutSecundusCumGenitīvōVariō.Lazy;

    private ĪnflexorEffectusAdiectīvīsAutTertiusAutPrīmusAutSecundusCumNominātīvōGenitīvōqueVariō()
          : base(new Lazy<Nūntius<ĪnflexorEffectusAdiectīvīsAutTertiusAutPrīmusAutSecundusCumNominātīvōGenitīvōqueVariō>>(),
                 Relātum.Rādīcātor)
          => Nūntius.PlūsGarriōAsync("Fīō");

    public Lazy<ĪnflexorEffectusNōminibus>? Relātum(in Gradus gradus, in Genus genus) => Relātum;

    public override string? Suffixum(in Enum[] illa)
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
      else if (Ūtilitātēs.Ūlla(gradus is Gradus.Positīvus, numerālis is Numerālis.Singulāris,
                               casus is Casus.Nominātīvus or Casus.Vocātīvus))
      {
        return genus switch
                {
                  Neutrum => "e",
                  Masculīnum => string.Empty,
                  Fēminīnum => "is",
                  _ => null
                };
      }
      else
      {
        if (relātum is not null)
        {
          const string īnfixum = await ĪnfīxumAsync(gradus, genus, numerālis, casus),
                      suffixum = await Relātum.Value.SuffixumAsync(numerālis, casus);
          return (suffixum is not null).Choose((īnfixum)?.Concat(suffixum), null);
        }
        else
        {
          return null;
        }
      }
    }
  }
}
