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
  public sealed class ĪnflexorPrīmusPlūrālisNōminibus : ĪnflexorDēfectusNōminibus<Īnflectendum.Nōmen>
  {
    public static readonly Lazy<ĪnflexorPrīmusPlūrālisNōminibus> Faciendum = new Lazy(() => Instance);
    private ĪnflexorPrīmusPlūrālisNōminibus()
          : base(nūntius: new Lazy<Nūntius<ĪnflexorPrīmusPlūrālisNōminibus>>(),
                 relātus: ĪnflexorEffectusPrīmusNōminibus.Faciendum)
          => Nūntius.PlūsGarriōAsync("Fīō");

    protected sealed Enum[] Referō(in Enum[] illa)
         => Ūtilitātēs.Seriēs(Numerālis.Plūrālis, illa.FirstOf<Casus>());
  }
}
