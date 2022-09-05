using System;

using Nūntiī.Nūntius;
using Īnflexōrēs.Effectī.Āctibus.ĪnflexorEffectusSecundusĀctibus;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Dēfectī.Āctūs.Semidēpōnentēs
{
  [Singleton]
  public sealed partial class ĪnflexorSemidēpōnēnsSecundusĀctibus : ĪnflexorSemidēpōnēnsĀctibus
  {
    public static readonly Lazy<ĪnflexorSemidēpōnēnsSecundusĀctibus> Faciendum
                     = new Lazy<ĪnflexorSemidēpōnēnsSecundusĀctibus>(() => Instance);
    private ĪnflexorSemidēpōnēsSecundusĀctibus()
        : base(NūntiusĪnflexōrīSemidēpōnentīSecundōĀctibus.Faciendum, ĪnflexorEffectusSecundusĀctibus.Faciendum) { }

    [Singleton]
    private sealed partial class NūntiusĪnflexōrīSemidēpōnentīSecundōĀctibus : Nūntius<ĪnflexorSemidēpōnēnsSecundusĀctibus>
    {
      public static readonly Lazy<NūntiusĪnflexōrīSemidēpōnentīSecundōĀctibus> Faciendum
                       = new Lazy<NūntiusĪnflexōrīSemidēpōnentīSecundōĀctibus>(() => Instance);
    }
  }
}
