using System;

using Nūntiī.Nūntius;
using Īnflexōrēs.Effectī.Āctūs.ĪnflexorEffectusSecundusĀctibus;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Dēfectī.Āctibus.Impersōnālēs
{
  [Singleton]
  public sealed partial class ĪnflexorImpersōnālisSecundusĀctibus : ĪnflexorImpersōnālisĀctibus
  {
    public static readonly Lazy<ĪnflexorImpersōnālisSecundusĀctibus> Faciendum
                     = new Lazy<ĪnflexorImpersōnālisSecundusĀctibus>(() => Instance);
    private ĪnflexorImpersōnālisSecundusĀctibus()
    : base(NūntiusĪnflexōrīImpersōnālīSecundōĀctibus.Faciendum, ĪnflexorEffectusSecundusĀctibus.Faciendum) { }

    [Singleton]
    private sealed partial class NūntiusĪnflexōrīImpersōnālīSecundōĀctibus : Nūntius<ĪnflexorImpersōnālisSecundusĀctibus>
    {
      public static readonly Lazy<NūntiusĪnflexōrīImpersōnālīSecundōĀctibus> Faciendum
                       = new Lazy<NūntiusĪnflexōrīImpersōnālīSecundōĀctibus>(() => Instance);
    }
  }
}
