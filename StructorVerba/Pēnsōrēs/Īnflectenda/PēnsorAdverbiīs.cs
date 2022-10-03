using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;
using Pēnsōrēs.Pēnsor.Tabula;

using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Pēnsōrēs.Īnflectenda
{
  [Lazy]
  public sealed partial class PēnsorAdverbiīs : PēnsorĪnflectendīs<Īnflectendum.Adverbium, Multiplex.Adverbium>
  {
    public enum Versiō
    { Exāctum }

    protected PēnsorAdverbiīs()
          : base(versiō: Versiō.Exāctum, quaerendī: nameof(Īnflectendum.Adverbium.Positīvum),
                 tabula: Tabula.Adverbia, nūntius: new Lazy<Nūntius<PēnsorAdverbiīs>>(),
                 lēctor: Īnflectendum.Adverbium.Lēctor)
          => Nūntius.PlūsGarriōAsync("Fīō");
  }
}
