using System;

using Nūntiī.Nūntius;
using Īnflexōrēs.Effectī.Āctūs.ĪnflexorEffectusSecundusĀctibus;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Dēfectī.Āctibus.ImpersōnālēsPerfectō
{
  [Singleton]
  public sealed partial class ĪnflexorImpersōnālisSecundusPerfectōĀctibus : ĪnflexorImpersōnālisPerfectōĀctibus
  {
    public static readonly Lazy<ĪnflexorImpersōnālisSecundusPerfectōĀctibus> Faciendum
                     = new Lazy<ĪnflexorImpersōnālisSecundusPerfectōĀctibus>(() => Instance);
    private ĪnflexorImpersōnālisSecundusPerfectōĀctibus()
    : base(NūntiusĪnflexōrīImpersōnālīSecundōPerfectōĀctibus.Faciendum, ĪnflexorEffectusSecundusĀctibus.Faciendum) { }

    [Singleton]
    private sealed partial class NūntiusĪnflexōrīImpersōnālīSecundōPerfectōĀctibus : Nūntius<ĪnflexorImpersōnālisSecundusPerfectōĀctibus>
    {
      public static readonly Lazy<NūntiusĪnflexōrīImpersōnālīSecundōPerfectōĀctibus> Faciendum
                       = new Lazy<NūntiusĪnflexōrīImpersōnālīSecundōPerfectōĀctibus>(() => Instance);
    }
  }
}
