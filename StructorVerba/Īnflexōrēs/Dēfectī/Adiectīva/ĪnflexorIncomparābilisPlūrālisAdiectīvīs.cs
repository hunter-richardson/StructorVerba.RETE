using System;
using System.Collections.Generic.IEnumerable;

using Miscella;
using Nūntiī.Nūntius;
using Praebeunda.Īnflecendum;
using Īnflexōrēs.Effectī.Adiectīva.ĪnflexorEffectusAdiectīvīsAutPrīmusAutSecundusAutTertius;
using Ēnumerātiōnēs;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Dēfectī.Adiectīva
{
  [Singleton]
  [AsyncOverloads]
  public abstract class ĪnflexorIncomparābilisPlūrālisAdiectīvīsAutPrīmusAutSecundus : ĪnflexorDēfectusAdiectīvīs<Īnflectendum.Adiectīva>
  {
    public static readonly Lazy<ĪnflexorIncomparābilisPlūrālisAdiectīvīsAutPrīmusAutSecundus> Faciendum
                     = new Lazy<ĪnflexorIncomparābilisPlūrālisAdiectīvīsAutPrīmusAutSecundus>(() => Instance);
    private ĪnflexorIncomparābilisPlūrālisAdiectīvīsAutPrīmusAutSecundus()
          : base(new Lazy<Nūntius<ĪnflexorIncomparābilisPlūrālisAdiectīvīsAutPrīmusAutSecundus>>(() => new Nūntius<ĪnflexorIncomparābilisPlūrālisAdiectīvīsAutPrīmusAutSecundus>()),
                 ĪnflexorEffectusAdiectīvīsAutPrīmusAutSecundusAutTertius.Faciendum) { }

    protected sealed Enum[] Referō(in Enum[] illa)
         => Ūtilitātēs.Seriēs(Gradus.Positīvus, illa.FirstOf<Genus>(), Numerālis.Plūrālis, illa.FirstOf<Casus>());
  }
}
