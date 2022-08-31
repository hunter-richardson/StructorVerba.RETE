using System;

using Nūntiī.Nūntius;
using Praebeunda;
using Praebeunda.Īnflectendum;
using Ēnumerātiōnēs.Gradus;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Adverbia
{
  [Singleton]
  [AsyncOverloads]
  public sealed partial class ĪnflexorAdverbiīsExāctīs : ĪnflexorAdverbiīs<AdverbiumExāctum>
  {
    public static readonly Lazy<ĪnflexorAdverbiīsExāctīs> Faciendum = new Lazy<ĪnflexorAdverbiīsExāctīs>(() => Instance);
    private ĪnflexorAdverbiīsExāctīs()
        : base(NūntiusĪnflexōrīAdverbiīsAdverbiumExāctīs.Faciendum,
               Gradus.GetValues().Except(Gradus.Nūllus))
    { }

    public string Scrībam(in AdverbiumEffectum adverbium, in Gradus gradus)
    {
      return gradus switch
      {
        Positīvus => adverbium.Positīvus,
        Comparātīvus => adverbium.Comparātīvus,
        Superlātīvus => adverbium.Superlātīvus,
        _ => string.Empty
      };
    }

    [Singleton]
    private sealed partial class NūntiusĪnflexōrīAdverbiīsAdverbiumExāctīs : Nūntius<ĪnflexorAdverbiīsExāctīs>
    {
      public static readonly Lazy<NūntiusĪnflexōrīAdverbiīsAdverbiumExāctīs> Faciendum =
                         new Lazy<NūntiusĪnflexōrīAdverbiīsAdverbiumExāctīs>(() => Instance);
    }
  }
}
