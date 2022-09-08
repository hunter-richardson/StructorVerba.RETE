using System;

using Miscella;
using Nūntiī.Nūntius;
using Officīnae.OfficīnaPēnsābilium;
using Praebeunda.Multiplex.Adiectīvum;
using Praebeunda.Īnflectendum.AdiectvumAutPrīmumAutSecundumAutTertius;
using Ēnumerātiōnēs;
using Īnflexōrēs.Effectī.Adiectīva.ĪnflexorEffectusAdiectīvīsAutPrīmusAutSecundusAutTertius;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Incertī.Adiectīva
{
  [Singleton]
  public sealed partial class ĪnflexorVerbīRēspūblica : ĪnflexorIncertus<Multiplex.Nōmen>
  {
    public static readonly Lazy<ĪnflexorVerbīRēspūblica> Faciendum = new Lazy(() => Instance);
    private static readonly Lazy<OfficīnaPēnsābilium<Lemma>> Officīna = OfficīnaPēnsābilium.Offiīnātor.Invoke(null);
    private ĪnflexorVerbīRēspūblica()
        : base(Catēgoria.Nōmen, new Lazy<Nūntius<ĪnflexorVerbīRēspūblica>>(),
               Ūtilitātēs.Combīnō(Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet(),
                                  Casus.GetValues().Except(Casus.Dērēctus).ToHashSet()))
    {
      const Īnflectendum? rēs = await (await Officīna.Value.Inventor.Invoke("rēs"))?.Relātum.Invoke();
      const Īnflectendum? pūblicum = await (await Officīna.Value.Inventor.Invoke("pūblicum"))?.Relātum.Invoke();
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
    }
  }
}
