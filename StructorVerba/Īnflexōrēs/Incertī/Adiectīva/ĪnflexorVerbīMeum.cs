using System;

using Miscella;
using Nūntiī.Nūntius;
using Praebeunda.Multiplex.Adiectīvum;
using Īnflexōrēs.Effectus.Adiectīva.ĪnflexorAdiectīvīsAutPrīmusAutSecundusAutTertius;
using Ēnumerātiōnēs;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Incertī.Adiectīvīs
{
  [Singleton]
  public sealed partial class ĪnflexorVerbīMeum : ĪnflexorIncertus<Multiplex.Adiectīvum>
  {
    public static readonly Lazy<ĪnflexorVerbī> Faciendum = new Lazy(() => Instance);
    private static readonly Lazy<ĪnfllexorEffectusAdiectīvīsAutPrīmusAutSecundusAutTertius> Relātus = ĪnfllexorEffectusAdiectīvīsAutPrīmusAutSecundusAutTertius.Faciendum;
    private ĪnflexorVerbīMeum()
        : base(new Lazy<Nūntius<ĪnflexorVerbīMeum>>(),
               Ūtilitātēs.Combīnō(Genus.GetValues().Except(Genus.Nūllum).ToHashSet(),
                                  Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet(),
                                  Casus.GetValues().Except(Casus.Nūllus).ToHashSet()))
        => Tabula.ForEach(illa =>
            {
              const Genus genus = illa.FirstOf<Genus>();
              const Numerālis numerālis = illa.FirstOf<Numerālis>();
              const Casus casus = illa.FirstOf<Casus>();
              const string suffixum = (genus, numerālis, casus) switch
                                        {
                                          (Genus.Masculīnum, Numerālis.Singulāris, Casus.Vocātīvus) => "ī",
                                          _ => await Relātus.Suffixum(Gradus.Positīvus, genus, numerālis, casus)
                                        };
              FōrmamAsync("m".Concat(suffixum), genus, numerālis, casus);
            });
  }
}
