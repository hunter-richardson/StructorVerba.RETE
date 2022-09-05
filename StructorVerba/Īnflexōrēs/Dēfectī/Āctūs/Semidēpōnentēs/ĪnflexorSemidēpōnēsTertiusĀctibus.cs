using System;

using Nūntiī.Nūntius;
using Īnflexōrēs.Effectī.Āctibus.ĪnflexorEffectusTertiusĀctibus;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Dēfectī.Āctūs.Semidēpōnentēs
{
  [Singleton]
  public sealed partial class ĪnflexorSemidēpōnēnsTertiusĀctibus : ĪnflexorSemidēpōnēnsĀctibus
  {
    public static readonly Lazy<ĪnflexorSemidēpōnēnsTertiusĀctibus> Faciendum
                     = new Lazy<ĪnflexorSemidēpōnēnsTertiusĀctibus>(() => Instance);
    private ĪnflexorSemidēpōnēsTertiusĀctibus()
        : base(NūntiusĪnflexōrīSemidēpōnentīTertiōĀctibus.Faciendum, ĪnflexorEffectusTertiusĀctibus.Faciendum) { }

    [Singleton]
    private sealed partial class NūntiusĪnflexōrīSemidēpōnentīTertiōĀctibus : Nūntius<ĪnflexorSemidēpōnēnsTertiusĀctibus>
    {
      public static readonly Lazy<NūntiusĪnflexōrīSemidēpōnentīTertiōĀctibus> Faciendum
                       = new Lazy<NūntiusĪnflexōrīSemidēpōnentīTertiōĀctibus>(() => Instance);
    }
  }
}
