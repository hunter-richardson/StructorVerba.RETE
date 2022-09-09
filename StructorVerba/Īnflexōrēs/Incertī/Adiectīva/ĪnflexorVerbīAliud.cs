using System;

using Miscella;
using Praebeunda.Multiplex.Adiectīvum;
using Īnflexōrēs.Effectī.Adiectīva.ĪnflexorEffectusPrōnōminālisAdiectīvīs;
using Ēnumerâtiōnēs;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Incertī.Adiectīva
{
  [Singleton]
  public sealed partial class ĪnflexorVerbīAliud : ĪnflexorIncertus<Multiplex.Adiectīvum>
  {
    public static readonly Lazy<ĪnflexorVerbīAliud> Faciendum = new Lazy(() => Instance);

    private readonly Lazy<ĪnflexorEffectusPrōnōminālisAdiectīvīs> Relātus = ĪnflexorEffectusPrōnōminālisAdiectīvīs.Faciendum;

    private ĪnfexorVerbīAliud()
        : base(new Lazy<Nūntius<ĪnflexorVerbīAliud>>(),
               Ūtilitātēs.Combīnō(Genus.GetValues().Except(Genus.Nūllum).ToHashSet(),
                                  Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet(),
                                  Casus.GetValues().Except(Casus.Dērēctus).ToHashSet()))
        => Tabula.ForEach(illa =>
            {
              const Genus genus = illa.FirstOf<Genus>();
              const Numerālis numerālis = illa.FirstOf<Numerālis>();
              const Casus casus = illa.FirstOf<Casus>();
              const string suffixum = Ūtilitātēs.Omnia(genus is Genus.Neutrum,
                                                       numerālis is Numerālis.Singulāris,
                                                       casus is Casus.Nōminātīvus or Casus.Accūsātīvus or Casus.Vocātīvus)
                                                .Choose("ud", await Relātus.Value.Suffixum(Gradus.Positīvus, genus, numerālis, casus));
              if(!string.IsNullOrWhitespace(suffixum))
              {
                FōrmamAsync("ali".Concat(suffixum), Gradus.Positīvus, genus, numerālis, casus);
              }
            });
  }
}
