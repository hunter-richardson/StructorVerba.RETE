using System;

using Nūntiī.Nūntius;
using Īnflexōrēs.Effectī.Āctūs.ĪnflexorEffectusTertiusĀctibus;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Dēfectī.ImpersōnālēsSemidēpōnentēsImperfectī.Āctibus
{
  [Singleton]
  public sealed partial class ĪnflexorImpersōnālisSemidēpōnēnsImperfectusTertiusĀctibus : ĪnflexorImpersōnālisSemidēpōnēsImperfectusĀctibus
  {
    public static readonly Lazy<ĪnflexorImpersōnālisSemidēpōnēnsImperfectusTertiusĀctibus> Faciendum
                     = new Lazy<ĪnflexorImpersōnālisSemidēpōnēnsImperfectusTertiusĀctibus>(() => Instance);
    private ĪnflexorImperdōnālisSemidēpōnēsImperfectusTertiusĀctibus()
        : base(NūntiusĪnflexōrīImpersōnālīSemidēpōnentīImperfectōTertiōĀctibus.Faciendum, ĪnflexorEffectusTertiusĀctibus.Faciendum) { }

    [Singleton]
    private sealed partial class NūntiusĪnflexōrīImpersōnālīSemidēpōnentīImperfectōTertiōĀctibus : Nūntius<ĪnflexorImpersōnālisSemidēpōnēnsImperfectusTertiusĀctibus>
    {
      public static readonly Lazy<ĪnflexorImpersōnālisSemidēpōnēnsImperfectusTertiusĀctibus> Faciendum
                       = new Lazy<ĪnflexorImpersōnālisSemidēpōnēnsImperfectusTertiusĀctibus>(() => Instance);
    }
  }
}
