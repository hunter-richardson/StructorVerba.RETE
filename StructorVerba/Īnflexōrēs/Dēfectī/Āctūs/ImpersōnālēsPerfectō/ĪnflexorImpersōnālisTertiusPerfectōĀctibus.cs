using System;

using Nūntiī.Nūntius;
using Īnflexōrēs.Effectī.Āctūs.ĪnflexorEffectusTertiusĀctibus;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Dēfectī.Āctibus.ImpersōnālēsPerfectō
{
  [Singleton]
  public sealed partial class ĪnflexorImpersōnālisTertiusPerfectōĀctibus : ĪnflexorImpersōnālisPerfectōĀctibus
  {
    public static readonly Lazy<ĪnflexorImpersōnālisTertiusPerfectōĀctibus> Faciendum
                     = new Lazy<ĪnflexorImpersōnālisTertiusPerfectōĀctibus>(() => Instance);
    private ĪnflexorImpersōnālisTertiusPerfectōĀctibus()
          : base(NūntiusĪnflexōrīImpersōnālīTertiōPerfectōĀctibus.Faciendum, ĪnflexorEffectusTertiusĀctibus.Faciendum) { }

    [Singleton]
    private sealed partial class NūntiusĪnflexōrīImpersōnālīTertiōPerfectōĀctibus : Nūntius<ĪnflexorImpersōnālisTertiusPerfectōĀctibus>
    {
      public static readonly Lazy<NūntiusĪnflexōrīImpersōnālīTertiōPerfectōĀctibus> Faciendum
                       = new Lazy<NūntiusĪnflexōrīImpersōnālīTertiōPerfectōĀctibus>(() => Instance);
    }
  }
}
