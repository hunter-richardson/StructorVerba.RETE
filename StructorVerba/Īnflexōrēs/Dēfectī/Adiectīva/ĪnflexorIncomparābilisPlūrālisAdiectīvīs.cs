using System;
using System.Collections.Generic.IEnumerable;

using Miscella;
using Nūntiī.Nūntius;
using Praebeunda.Īnflecendum;
using Īnflexōrēs.Effectī.Adiectīva.ĪnflexorEffectusAdiectīvīsAutPrīmusAutSecundusAutTertius;
using Ēnumerātiōnēs;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Īnflexōrēs.Dēfectī.Adiectīva
{
  [Singleton]
  [AsyncOverloads]
  public abstract class ĪnflexorIncomparābilisPlūrālisAdiectīvīsAutPrīmusAutSecundus : ĪnflexorDēfectusAdiectīvīs<Īnflecendum.Adiectīvum>
  {
    private ĪnflexorIncomparābilisPlūrālisAdiectīvīsAutPrīmusAutSecundus()
          : base(nūntius: new Lazy<Nūntius<ĪnflexorIncomparābilisPlūrālisAdiectīvīsAutPrīmusAutSecundus>>(),
                 relātus: ĪnflexorEffectusAdiectīvīsAutPrīmusAutSecundusAutTertius.Lazy)
          => Nūntius.PlūsGarriōAsync("Fīō");

    protected sealed Enum[] Referō(in Enum[] illa)
         => Ūtilitātēs.Seriēs(Gradus.Positīvus, illa.FirstOf<Genus>(), Numerālis.Plūrālis, illa.FirstOf<Casus>());
  }
}
