using System;
using System.Collections.Generic.IEnumerable;

using Miscella;
using Praebeunda.Īnflecendum;
using Īnflexōrēs.Effectī.Nōmina.ĪnflexorEffectusPrīmusNōminibus;
using Ēnumerātiōnēs;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Īnflexōrēs.Dēfectī.Nōmina
{
  [Lazy]
  [AsyncOverloads]
  public sealed class ĪnflexorPrīmusPlūrālisNōminibus : ĪnflexorDēfectusNōminibus<Īnflectendum.Nōmen>
  {
    private ĪnflexorPrīmusPlūrālisNōminibus()
          : base(nūntius: new Lazy<Nūntius<ĪnflexorPrīmusPlūrālisNōminibus>>(),
                 relātus: ĪnflexorEffectusPrīmusNōminibus.Lazy)
          => Nūntius.PlūsGarriōAsync("Fīō");

    protected sealed Enum[] Referō(in Enum[] illa)
         => Ūtilitātēs.Seriēs(Numerālis.Plūrālis, illa.FirstOf<Casus>());
  }
}
