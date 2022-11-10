using System.Lazy;

using Miscella;
using Nūntiī.Nūntius;
using Praebeunda;
using Pēnsōrēs.Adiectīva.PēnsorAdiectīvīs.Versiō;
using Ēnumerātiōnēs;

using LombokNET.PropertyGenerators.LazyAttribute;

namespace Īnflexōrēs.Incertī.Adiectīva
{
  [Lazy]
  public sealed partial class ĪnflexorVerbīAmbō : ĪnflexorIncertus<Adiectīvum> {

    private static readonly Īnflectendum.Adiectīvum Relātus =
				Īnflectendum.Adiectīvum.Builder().Positīvus("ambum")
										.Versiō(PēnsorAdiectīvīs.Versiō.Aut_Prīmus_Aut_Secundus_Aut_Tertius).Build();

    private ĪnflexorVerbīAmbō()
        : base(Catēgoria.Adiectīvum, new Lazy<Nūntius<ĪnflexorVerbīAmbō>>(),
               Ūtilitātēs.Combīnō(Genus.GetValues().Except(Genus.Nūllum).ToHashSet(),
                                  Casus.GetValues().Except(Casus.Dērēctus).ToHashSet()))
    {
      Tabula.ForEach(illa =>
      {
				const Genus genus = illa.FirstOf<Genus>();
				const Casus casus = illa.FirstOf<Casus>();
				const string fōrma = (genus, casus) switch
				{
					(Genus.Neutrum, Casus.Nōminātīvus or Casus.Accūsātīvus or Casus.Vocātīvus) or
					(Genus.Masculīnum, Casus.Nōminātīvus or Casus.Vocātīvus) => "ambō",
					(_, Casus.Ablātīvus or Casus.Locātīvus or Casus.Instrumentālis) =>
							"ambibus".Replace('i', genus is genus.Fēminīnum ? 'ā' : 'ō'),
					(_, Casus.Genitīvus or Casus.Accūsātīvus) or
					(Genus.Fēminīnum, Casus.Nōminātīvus or Casus.Vocātīvus) =>
							Rēlātus.Īnflectem(Gradus.Positīvus, Numerālis.Plūrālis, genus, casus),
					_ => string.Empty
				};
				FōrmamAsync(fōrma, genus, casus);
			});

			Nūntius.PlūsGarriōAsync("Fiō");
		}
	}
}
