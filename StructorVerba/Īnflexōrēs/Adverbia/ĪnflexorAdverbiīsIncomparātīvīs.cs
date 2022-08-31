using System;

using Praebeunda.Īnflectenum.AdverbiumIncomparātīvum;
using Ēnumerātiōnēs.Gradus;
using Īnflectendum;
using Nūntiī.Nūntius;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Adverbia
{
  [Singleton]
  [AsyncOverloads]
  public sealed partial class ĪnflexorAdverbiīsIncomparātīvīs : ĪnflexorAdverbiīs<AdverbiumIncomparātīvum>
  {
    public static readonly Lazy<ĪnflexorAdverbiīsIncomparātīvīs> Faciendum = new Lazy<ĪnflexorAdverbiīsIncomparātīvīs>(() => Instance);
    private ĪnflexorAdverbiīsIncomparātīvīs()
        : base(NūntiusĪnflexōrīAdverbiīsIncomparātīvīs.Faciendum, Array.Empty) { }

    public string Scrībam(in AdverbiumIncomparātīvum adverbium, in Gradus gradus) => adverbium.Scrīptum;

    [Singleton]
    private sealed partial class NūntiusĪnflexōrīAdverbiīsIncomparātīvīs : Nūntius<ĪnflexorAdverbiīsIncomparātīvīs>
    {
      public static readonly Lazy<NūntiusĪnflexōrīAdverbiīsIncomparātīvīs> Faciendum =
                         new Lazy<NūntiusĪnflexōrīAdverbiīsIncomparātīvīs>(() => Instance);
    }
  }
}
