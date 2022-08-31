using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Pēnsōrēs.Adverbia
{
  [Singleton]
  public sealed class PēnsorAdverbiīsExāctīs : PēnsorAdverbiīs<Īnflectendum.AdverbiumExāctum>
  {
    public static readonly Lazy<PēnsorAdverbiīsExāctīs> Faciendum = new Lazy<PēnsorAdverbiīsExāctīs>(() => Instance);

    private PēnsorAdverbiīsExāctīs()
          : base(Īnflexōrēs.ĪnflexorAdverbiīs.Versiō.Exāctum,
                 nameof(Īnflectendum.AdverbiumEffectum.Positīvum),
                 NūntiusPēnsōrīAdverbiīsExāctīs.Faciendum,
                 Īnflectendum.AdverbiumEffectum.Lēctor) {  }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīAdverbiīsExāctīs : Nūntius<PēnsorAdverbiīsExāctīs>
    {
      public static readonly Lazy<NūntiusPēnsōrīAdverbiīsExāctīs> Faciendum = new Lazy<NūntiusPēnsōrīAdverbiīsExāctīs>(() => Instance);
    }
  }
}
