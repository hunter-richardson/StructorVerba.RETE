using System;
using System.Threading.Tasks.Task;

using Miscella.Ūtilitātēs;
using Officīnae.OfficīnaPēnsābilium;
using Praebeunda.Multiplex.Adiectīvum;
using Praebeunda.Simplicia.Lemma;
using Praebeunda.Īnflectendum;
using Īnflexōrēs.Incertī;
using Īnflexōrēs.Incertī.Adiectīva;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Dictionāria
{
  [Singleton]
  public sealed partial class DictionāriumAdiectīvīs : Dictionārium<DictionāriumAdiectīvīs, Multiplex.Adiectīvum>
  {
    public static readonly Lazy<DictionāriumAdiectīvīs> Faciendum = new Lazy(() => Instance);

    private static readonly Lazy<OfficīnaPēnsābilium<Lemma>> Officīna = OfficīnaPēnsābilium.Offiīnātor.Invoke(null);
    private static readonly Func<string, Task<Lemma?>> Lemmātor = async scrīptum => Officīna.Value.Inventor.Invoke(scrīptum);

    protected readonly Lazy<ĪnflexorIncertus> Aliud = ĪnflexorVerbīAliud.Faciendum;
    protected readonly Lazy<ĪnflexorIncertus> Meum = ĪnflexorVerbīMeum.Faciendum;
    protected readonly Lazy<ĪnflexorIncertus> Multum = ĪnflexorVerbīMultum.Faciendum;
    protected readonly Lazy<ĪnflexorIncertus> Mīlle = ĪnflexorVerbīMīlle.Faciendum;
    protected readonly Lazy<ĪnflexorConiūnctus> Tertiumdecimum
       = new Lazy(() => new ĪnflexorConiūnctus(await Lemmātor.Invoke("tertium"),
                                               await Lemmātor.Invoke("decimum")));
    protected readonly Lazy<ĪnflexorConiūnctus> Quārtumdecimum
       = new Lazy(() => new ĪnflexorConiūnctus(await Lemmātor.Invoke("quārtum"),
                                               await Lemmātor.Invoke("decimum")));
    protected readonly Lazy<ĪnflexorConiūnctus> Quīntumdecimum
       = new Lazy(() => new ĪnflexorConiūnctus(await Lemmātor.Invoke("quīntum"),
                                               await Lemmātor.Invoke("decimum")));
    protected readonly Lazy<ĪnflexorConiūnctus> Sextumdecimum
       = new Lazy(() => new ĪnflexorConiūnctus(await Lemmātor.Invoke("sextum"),
                                               await Lemmātor.Invoke("decimum")));
    protected readonly Lazy<ĪnflexorConiūnctus> Septimumdecimum
       = new Lazy(() => new ĪnflexorConiūnctus(await Lemmātor.Invoke("septimum"),
                                               await Lemmātor.Invoke("decimum")));
    protected readonly Lazy<ĪnflexorConiūnctus> Octāvumdecimum
       = new Lazy(() => new ĪnflexorConiūnctus(await Lemmātor.Invoke("octāvum"),
                                               await Lemmātor.Invoke("decimum")));
    protected readonly Lazy<ĪnflexorConiūnctus> Nōnumdecimum
       = new Lazy(() => new ĪnflexorConiūnctus(await Lemmātor.Invoke("nōnum"),
                                               await Lemmātor.Invoke("decimum")));

    private DictionāriumNōminibus()
        : base(new Lazy<Nūntius<DictionāriumAdiectīvīs>>()) { }
  }
}
