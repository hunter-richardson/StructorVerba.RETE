using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;
using Pēnsōrēs.Pēnsor.Tabula;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Pēnsōrēs.Īnflectenda
{
  [Singleton]
  public sealed partial class PēnsorAdverbiīs : PēnsorĪnflectendīs<Īnflectendum.Adverbium, Multiplex.Adverbium>
  {
    public enum Versiō
    { Exāctum }

    public static readonly Lazy<PēnsorAdverbiīs> Faciendum = new Lazy(() => Instance);

    protected PēnsorAdverbiīs()
          : base(Versiō.Exāctum, nameof(Īnflectendum.Adverbium.Positīvum),
                 Tabula.Adverbia, new Lazy<Nūntius<PēnsorAdverbiīs>>(),
                 Īnflectendum.Adverbium.Lēctor) { }
  }
}
