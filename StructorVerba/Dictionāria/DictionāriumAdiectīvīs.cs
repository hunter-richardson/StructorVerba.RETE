using System;
using System.Threading.Tasks.Task;

using Miscella.Ūtilitātēs;
using Officīnae.OfficīnaPēnsābilium;
using Praebeunda.Multiplex.Adiectīvum;
using Praebeunda.Simplicia.Lemma;
using Praebeunda.Īnflectendum;
using Īnflexōrēs.Exāctī.ĪnflexorExāctusAdiectīvīs;
using Īnflexōrēs.Incertī;
using Īnflexōrēs.Incertī.Adiectīva;

using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Dictionāria
{
  [Lazy]
  public sealed partial class DictionāriumAdiectīvīs : Dictionārium<DictionāriumAdiectīvīs, Multiplex.Adiectīvum>
  {
    private static readonly Lazy<OfficīnaPēnsābilium<Lemma>> Officīna = OfficīnaPēnsābilium.Officīnātor.Invoke(null);
    private static readonly Func<string, Task<Lemma?>> Lemmātor
        = async scrīptum => PēnsorVerbīs.Relātor.Invoke(true).Value
                                        .Pendam(quaerendum: scrīptum, catēgoria: Catēgoria.Adiectīvum);

    protected readonly Lazy<ĪnflexorIncertus> Aliud = ĪnflexorVerbīAliud.Lazy;
    protected readonly Lazy<ĪnflexorIncertus> Frūgī = ĪnflexorVerbīFrūgī.Lazy;
    protected readonly Lazy<ĪnflexorIncertus> Meum = ĪnflexorVerbīMeum.Lazy;
    protected readonly Lazy<ĪnflexorIncertus> Multum = ĪnflexorVerbīMultum.Lazy;
    protected readonly Lazy<ĪnflexorIncertus> Mīlle = ĪnflexorVerbīMīlle.Lazy;
    protected readonly Lazy<ĪnflexorIncertus> Nēquam = ĪnflexorVerbīNēquam.Lazy;
    protected readonly Lazy<ĪnflexorConiūnctus> Nōnumdecimum
        = new Lazy(() => new ĪnflexorConiūnctus(prīmum: await Lemmātor.Invoke("nōnum"),
                                                secundum: await Lemmātor.Invoke("decimum")));
    protected readonly Lazy<ĪnflexorConiūnctus> Octāvumdecimum
        = new Lazy(() => new ĪnflexorConiūnctus(prīmum: await Lemmātor.Invoke("octāvum"),
                                                secundum: await Lemmātor.Invoke("decimum")));
    protected readonly Lazy<ĪnflexorConiūnctus> Quārtumdecimum
        = new Lazy(() => new ĪnflexorConiūnctus(prīmum: await Lemmātor.Invoke("quārtum"),
                                                secundum: await Lemmātor.Invoke("decimum")));
    protected readonly Lazy<ĪnflexorConiūnctus> Quīntumdecimum
        = new Lazy(() => new ĪnflexorConiūnctus(prīmum: await Lemmātor.Invoke("quīntum"),
                                                secundum: await Lemmātor.Invoke("decimum")));
    protected readonly Lazy<ĪnflexorIncertus> Satis = ĪnflexorVerbīSatis.Lazy;
    protected readonly Lazy<ĪnflexorConiūnctus> Septimumdecimum
        = new Lazy(() => new ĪnflexorConiūnctus(prīmum: await Lemmātor.Invoke("septimum"),
                                                secundum: await Lemmātor.Invoke("decimum")));
    protected readonly Lazy<ĪnflexorConiūnctus> Sextumdecimum
        = new Lazy(() => new ĪnflexorConiūnctus(prīmum: await Lemmātor.Invoke("sextum"),
                                                secundum: await Lemmātor.Invoke("decimum")));
    protected readonly Lazy<ĪnflexorConiūnctus> Tertiumdecimum
        = new Lazy(() => new ĪnflexorConiūnctus(prīmum: await Lemmātor.Invoke("tertium"),
                                                secundum: await Lemmātor.Invoke("decimum")));
    protected readonly Lazy<ĪnflexorSuffīxus> Utrumcumque
        = new Lazy(() => new ĪnflexorSuffīxus(lemma: await Lemmātor.Invoke("utrum"),
                                              suffīxum: "cum".Concat(Encliticum.Coniugāns.ToString())));
    protected readonly Lazy<ĪnflexorSuffīxus> Utrumque
        = new Lazy(() => new ĪnflexorSuffīxus(lemma: await Lemmātor.Invoke("utrum"),
                                              suffīxum: Encliticum.Coniugāns.ToString()));
    protected readonly Lazy<ĪnflexorSuffīxus> Utrumvīs
        = new Lazy(() => new ĪnflexorSuffīxus(lemma: await Lemmātor.Invoke("utrum"), suffīxum: "vīs"));

    private DictionāriumNōminibus()
        : base(new Lazy<Nūntius<DictionāriumAdiectīvīs>>())
        => Nūntius.PlūsGarriōAsync("Fīō");
  }
}
