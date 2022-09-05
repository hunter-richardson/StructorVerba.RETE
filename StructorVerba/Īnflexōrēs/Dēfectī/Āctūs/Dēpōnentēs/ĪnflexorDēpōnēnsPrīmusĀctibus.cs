using System;

using Nūntiī.Nūntius;
using Miscella.Ūtilitātēs;
using Īnflexōrēs.Effectī.Āctūs.ĪnflexorEffectusPrīmusĀctibus;
using Ēnumerātiōnēs;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

namespace Īnflexōrēs.Dēfectī.Āctūs.Dēpōnentēs
{
  [AsyncOverloads]
  public abstract partial class ĪnflexorDēpōnēnsPrīmusĀctibus : ĪnflexorDēfectusĀctibus
  {
    protected ĪnflexorDēpōnēnsPrīmusĀctibus()
          : base(NūntiusĪnflexōrīDēpōnentePrīmōĀctibus.Faciendum, ĪnflexorEffectusPrīmusĀctibus.Faciendum) { }

    [Singleton]
    private sealed class NūntiusĪnflexōrīDēpōnentePrīmōĀctibus : Nūntius<ĪnflexorDēpōnēnsPrīmusĀctibus>
    {
      public static readonly Lazy<NūntiusĪnflexōrīDēpōnentePrīmōĀctibus> Faciendum
                       = new Lazy<NūntiusĪnflexōrīDēpōnentePrīmōĀctibus>(() => Instance);
    }
  }
}
