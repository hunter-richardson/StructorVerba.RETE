using System;

using Nūntiī.Nūntius;
using Īnflexōrēs.Effectī.Āctibus.ĪnflexorEffectusPrīmusĀctibus;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Dēfectī.Āctūs.Semidēpōnentēs
{
  [Singleton]
  public sealed partial class ĪnflexorSemidēpōnēnsPrīmusĀctibus : ĪnflexorSemidēpōnēnsĀctibus
  {
    public static readonly Lazy<ĪnflexorSemidēpōnēnsPrīmusĀctibus> Faciendum
                     = new Lazy<ĪnflexorSemidēpōnēnsPrīmusĀctibus>(() => Instance);
    private ĪnflexorSemidēpōnēsPrīmusĀctibus()
        : base(NūntiusĪnflexōrīSemidēpōnentīPrīmōĀctibus.Faciendum, ĪnflexorEffectusPrīmusĀctibus.Faciendum) { }

    [Singleton]
    private sealed partial class NūntiusĪnflexōrīSemidēpōnentīPrīmōĀctibus : Nūntius<ĪnflexorSemidēpōnēnsPrīmusĀctibus>
    {
      public static readonly Lazy<NūntiusĪnflexōrīSemidēpōnentīPrīmōĀctibus> Faciendum
                       = new Lazy<NūntiusĪnflexōrīSemidēpōnentīPrīmōĀctibus>(() => Instance);
    }
  }
}
