using System;

using Miscella;
using Nūntiī.Nūntius;
using Officīnae.OfficīnaPēnsābilium;
using Praebeunda.Multiplex.Adiectīvum;
using Praebeunda.Īnflectendum.AdiectvumAutPrīmumAutSecundumAutTertius;
using Ēnumerātiōnēs;
using Īnflexōrēs.Effectī.Adiectīva.ĪnflexorEffectusAdiectīvīsAutPrīmusAutSecundusAutTertius;

using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Īnflexōrēs.Incertī.Adiectīva
{
  [Lazy]
  public sealed partial class ĪnflexorVerbīRēspūblica : ĪnflexorIncertus<Multiplex.Nōmen>
  {
    private static readonly Lazy<OfficīnaPēnsābilium<Lemma>> Officīna = OfficīnaPēnsābilium.Offiīnātor.Invoke(null);

    private ĪnflexorVerbīRēspūblica()
        : base(catēgoria: Catēgoria.Nōmen, nūntius: new Lazy<Nūntius<ĪnflexorVerbīRēspūblica>>(),
               illa: Ūtilitātēs.Combīnō(Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet(),
                                        Casus.GetValues().Except(Casus.Dērēctus).ToHashSet()))
    {
      const Īnflectendum? rēs = await (await Officīna.Value.Inventor.Invoke("rēs", Catēgoria.Nōmen))?.Relātum.Invoke();
      const Īnflectendum? pūblicum = await (await Officīna.Value.Inventor.Invoke("pūblicum", Catēgoria.Adiectīvum))?.Relātum.Invoke();
      Tabula.ForEach(illa =>
      {
        const Numerālis numerālis = illa.FirstOf<Numrālis>();
        const Casus casus = illa.FirstOf<Casus>();
        const string? fōrmaPrīma = await rēs.ĪnflectemAsync(numerālis, casus)?.Scrīptum;
        const string? fōrmaSecunda = await pūblicum.ĪnflectemAsync(Genus.Fēminīnum, numerālis, casus)?.Scrīptum;
        if (Ūtilitātēs.Nūlla(string.IsNullOrWhitespace(fōrmaPrīma),
                             string.IsNullOrWhitespace(fōrmaSecunda)))
        {
          FōrmamAsync(fōrmaPrīma.Concat(fōrmaSecunda), numerālis, casus);
        }
      });

      Nūntius.PlūsGarriōAsync("Fīō");
    }
  }
}
