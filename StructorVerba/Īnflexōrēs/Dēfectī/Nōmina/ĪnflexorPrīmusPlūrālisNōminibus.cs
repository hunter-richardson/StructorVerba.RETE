using System;
using System.Collections.Generic.IEnumerable;

using Miscella;
using Praebeunda.Īnflecendum;
using Īnflexōrēs.Effectī.Nōmina.ĪnflexorEffectusPrīmusNōminibus;
using Ēnumerātiōnēs;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Dēfectī.Nōmina
{
  [Singleton]
  [AsyncOverloads]
  public abstract class ĪnflexorPrīmusPlūrālisNōminibus : ĪnflexorDēfectusNōminibus<Īnflectendum.Nōmen>
  {
    public static readonly Lazy<ĪnflexorPrīmusPlūrālisNōminibus> Faciendum
                     = new Lazy<ĪnflexorPrīmusPlūrālisNōminibus>(() => Instance);
    protected ĪnflexorPrīmusPlūrālisNōminibus()
          : base(new Lazy<Nūntius<ĪnflexorPrīmusPlūrālisNōminibus>>(() => new Nūntius<ĪnflexorPrīmusPlūrālisNōminibus>()),
                 ĪnflexorEffectusPrīmusNōminibus.Faciendum) { }

    protected sealed Enum[] Referō(in Enum[] illa)
         => Ūtilitātēs.Seriēs(Numerālis.Plūrālis, illa.FirstOf<Casus>());
  }
}
