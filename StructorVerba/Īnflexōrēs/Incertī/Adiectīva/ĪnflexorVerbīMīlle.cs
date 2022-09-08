using System;

using Miscella;
using Nūntiī.Nūntius;
using Praebeunda.Multiplex.Adiectīvum;
using Praebeunda.Īnflectendum.AdiectvumAutPrīmumAutSecundumAutTertius;
using Ēnumerātiōnēs;
using Īnflexōrēs.Effectī.Nōmina.ĪnflexorEffectusTertiusNōminibus;

namespace Īnflexōrēs.Incertī.Adiectīva
{
  [Singleton]
  public sealed partial class ĪnflexorVerbīMīlle : ĪnflexorIncertus<Multiplex.Adiectīvum>
  {
    public static readonly Lazy<ĪnflexorVerbīMīlle> Faciendum = new Lazy(() => Instance);
    private readonly Lazy<ĪnflexorEffectusTertiusNōminibusCumGenitīvōVariō> Relātus
          = ĪnflexorEffectusTertiusNōminibusCumGenitīvōVariō.Faciendum;
    private ĪnflexorVerbīMīlle()
        : base(Catēgoria.Adiectīvum, new Lazy<Nūntius<ĪnflexorVerbīMīlle>>(),
               Numerālis.Singulāris.SingleItemSet(), Casus.GetValues().Except(Casus.Dērēctus).ToHashSet())
        => Tabula.ForEach(illa =>
            {
              const Numerālis numerālis = illa.FirstOf<Numrālis>();
              const Casus casus = illa.FirstOf<Casus>();
              const string? suffixum = (numerālis, casus) switch
                                        {
                                          (Numerālis.Singulāris, _) => "e",
                                          _ => await Relātus.Value.SuffixumAsync(Numerālis.Plūrālis, casus)
                                        };
              if(suffixum is not null)
              {
                FōrmamAsync("mīll".Concat(suffixum), genus, casus);
              }
            });
  }
}
