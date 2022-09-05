using System;

using Nūntiī.Nūntius;
using Īnflexōrēs.Effectī.Āctūs.ĪnflexorEffectusTertiusĀctibus;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Dēfectī.Āctibus.Impersōnālēs
{
  [Singleton]
  public sealed partial class ĪnflexorImpersōnālisTertiusĀctibus : ĪnflexorImpersōnālisĀctibus
  {
    public static readonly Lazy<ĪnflexorImpersōnālisTertiusĀctibus> Faciendum
                     = new Lazy<ĪnflexorImpersōnālisTertiusĀctibus>(() => Instance);
    private ĪnflexorImpersōnālisTertiusĀctibus()
          : base(NūntiusĪnflexōrīImpersōnālīTertiōĀctibus.Faciendum, ĪnflexorEffectusTertiusĀctibus.Faciendum) { }

    [Singleton]
    private sealed partial class NūntiusĪnflexōrīImpersōnālīTertiōĀctibus : Nūntius<ĪnflexorImpersōnālisTertiusĀctibus>
    {
      public static readonly Lazy<NūntiusĪnflexōrīImpersōnālīTertiōĀctibus> Faciendum
                       = new Lazy<NūntiusĪnflexōrīImpersōnālīTertiōĀctibus>(() => Instance);
    }
  }
}
