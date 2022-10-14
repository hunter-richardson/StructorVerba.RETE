using System;

using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Īnflexōrēs.Incertī.Adiectīva
{
  [Lazy]
  public sealed partial class ĪnflexorVerbīNostrum : ĪnflexorIncertus<Multiplex.Adiectīvum>
  {
    private static readonly Lazy<ĪnfllexorEffectusAdiectīvīsAutPrīmusAutSecundusAutTertius> Relātus
                               = ĪnfllexorEffectusAdiectīvīsAutPrīmusAutSecundusAutTertius.Lazy;

    private ĪnflexorVerbīNostrum()
        : base(catēgoria: Catēgoria.Adiectīvum, nūntius: new Lazy<Nūntius<ĪnflexorVerbīMeum>>(),
               illa: Ūtilitātēs.Combīnō(Genus.GetValues().Except(Genus.Nūllum).ToHashSet(),
                                        Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet(),
                                        Casus.GetValues().Except(Casus.Nūllus).ToHashSet()))
    {
      Tabula.ForEach(illa =>
            {
              const Genus genus = illa.FirstOf<Genus>();
              const Numerālis numerālis = illa.FirstOf<Numerālis>();
              const Casus casus = illa.FirstOf<Casus>();
              const string suffixum = (genus, numerālis, casus) switch
              {
                (Genus.Masculīnum, Numerālis.Singulāris, Casus.Nōminātīvus or Casus.Vocātīvus) => "er",
                _ => 'r'.Concat(await Relātus.Suffixum(Gradus.Positīvus, genus, numerālis, casus))
              };
              FōrmamAsync("nost".Concat(suffixum), genus, numerālis, casus);
            });
      Nūntius.PlūsGarriōAsync("Fīō");
    }
  }
}
