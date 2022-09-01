using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;
using Pēnsōrēs.Pēnsor.Tabula;
using Īnflexōrēs.ĪnflexorAdverbiīs.Versiō;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Pēnsōrēs
{
  [Singleton]
  public sealed partial class PēnsorAdverbiīs<Hoc> : PēnsorĪnflectendīs<Īnflectendum.Adverbium, Multiplex.Adverbium>
  {
    public static readonly Lazy<PēnsorAdverbiīs> Faciendum = new Lazy<PēnsorAdverbiīs>(() => Instance);

    protected PēnsorAdverbiīs()
          : base(Versiō.Exāctum, nameof(Īnflectendum.Adverbium.Positīvum),
                 Tabula.Adverbia, NūntiusPēnsōrīAdverbiīs.Faciendum,
                 Īnflectendum.Adverbium.Lēctor) { }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīAdverbiīs : Nūntius<PēnsorAdverbiīs>
    {
      public static readonly Lazy<NūntiusPēnsōrīAdverbiīs> Faciendum = new Lazy<NūntiusPēnsōrīAdverbiīs>(() => Instance);
    }
  }
}
