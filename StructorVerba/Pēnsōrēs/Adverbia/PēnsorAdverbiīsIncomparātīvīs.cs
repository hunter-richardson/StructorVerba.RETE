using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Pēnsōrēs.Adverbia
{
  [Singlton]
  public sealed class PēnsorAdverbiīsIncomparātīvīs : PēnsorAdverbiīs<Īnflectendum.AdverbiumIncomparātīvum>
  {
    public static readonly Lazy<PēnsorAdverbiīsExāctīs> Faciendum = new Lazy<PēnsorAdverbiīsExāctīs>(() => Instance);

    private PēnsorAdverbiīsIncomparātīvīs()
        : base(Īnflexōrēs.ĪnflexorAdverbiīs.Versiō.Incomparātīvum,
               nameof(Īnflectendum.AdverbiumIncomparātīvum.Scrīptum),
               NūntiusPēnsōrīAdverbiīsIncomparātīvīs.Faciendum,
               Īnflectendum.AdverbiumIncomparātīvum.Lēctor) {  }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīAdverbiīsIncomparātīvīs : Nūntius<PēnsorAdverbiīsIncomparātīvīs>
    {
      public static readonly Lazy<NūntiusPēnsōrīAdverbiīsIncomparātīvīs> Faciendum = new Lazy<NūntiusPēnsōrīAdverbiīsIncomparātīvīs>(() => Instance);
    }
  }
}
