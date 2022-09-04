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
    private ĪnflexorIncomparābilisPlūrālisAdiectīvīs()
          : base(NūntiusĪnflexōrīPlūrāleAdiectīvīsAutPrīmīsAutSecundīs.Faciendum, ĪnflexorEffectusAdiectīvīsAutPrīmusAutSecundusAutTertius.Faciendum) { }

    protected sealed Enum[] Referō(in Enum[] illa)
         => Ūtilitātēs.Seriēs(Gradus.Positīvus, illa.FirstOf<Genus>(), Numerālis.Plūrālis, illa.FirstOf<Casus>());

    [Singleton]
    private sealed class NūntiusĪnflexōrīPlūrāleAdiectīvīsAutPrīmīsAutSecundīs : Nūntius<ĪnflexorIncomparābilisPlūrālisAdiectīvīsAutPrīmusAutSecundus>
    {
      public static readonly Lazy<NūntiusĪnflexōrīPlūrāleAdiectīvīsAutPrīmīsAutSecundīs> Faciendum
                       = new Lazy<NūntiusĪnflexōrīPlūrāleAdiectīvīsAutPrīmīsAutSecundīs>(() => Instance);
    }
  }
}
