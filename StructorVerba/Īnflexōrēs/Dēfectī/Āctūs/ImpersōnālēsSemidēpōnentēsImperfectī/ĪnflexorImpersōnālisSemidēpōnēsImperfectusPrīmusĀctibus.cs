using System;

using Nūntiī.Nūntius;
using Īnflexōrēs.Effectī.Āctibus.ĪnflexorEffectusPrīmusĀctibus;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Dēfectī.Āctūs.ImpersōnālēsSemidēpōnentēsImperfectī
{
  [Singleton]
  public sealed partial class ĪnflexorImpersōnālisSemidēpōnēnsImperfectusPrīmusĀctibus : ĪnflexorImpersōnālisSemidēpōnēnsImperfectusĀctibus
  {
    public static readonly Lazy<ĪnflexorImpersōnālisSemidēpōnēnsImperfectusPrīmusĀctibus> Faciendum
                     = new Lazy<ĪnflexorImpersōnālisSemidēpōnēnsImperfectusPrīmusĀctibus>(() => Instance);
    private ĪnflexorImperdōnālisSemidēpōnēsImperfectusPrīmusĀctibus()
        : base(NūntiusĪnflexōrīImpersōnālīSemidēpōnentīImperfectōPrīmōĀctibus.Faciendum, ĪnflexorEffectusPrīmusĀctibus.Faciendum) { }

    [Singleton]
    private sealed partial class NūntiusĪnflexōrīImpersōnālīSemidēpōnentīImperfectōPrīmōĀctibus : Nūntius<ĪnflexorImpersōnālisSemidēpōnēnsImperfectusPrīmusĀctibus>
    {
      public static readonly Lazy<NūntiusĪnflexōrīImpersōnālīSemidēpōnentīImperfectōPrīmōĀctibus> Faciendum
                       = new Lazy<NūntiusĪnflexōrīImpersōnālīSemidēpōnentīImperfectōPrīmōĀctibus>(() => Instance);
    }
  }
}
