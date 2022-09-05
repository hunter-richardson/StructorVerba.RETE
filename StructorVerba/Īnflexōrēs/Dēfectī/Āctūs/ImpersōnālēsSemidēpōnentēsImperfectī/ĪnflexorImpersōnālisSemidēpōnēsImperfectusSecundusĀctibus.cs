using System;

using Nūntiī.Nūntius;
using Īnflexōrēs.Effectī.Āctibus.ĪnflexorEffectusSecundusĀctibus;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Dēfectī.Āctūs.ImpersōnālēsSemidēpōnentēsImperfectī
{
  [Singleton]
  public sealed partial class ĪnflexorImpersōnālisSemidēpōnēnsImperfectusSecundusĀctibus : ĪnflexorImpersōnālisSemidēpōnēnsImperfectusĀctibus
  {
    public static readonly Lazy<ĪnflexorImpersōnālisSemidēpōnēnsImperfectusSecundusĀctibus> Faciendum
                     = new Lazy<ĪnflexorImpersōnālisSemidēpōnēnsImperfectusSecundusĀctibus>(() => Instance);
    private ĪnflexorImperdōnālisSemidēpōnēsImperfectusSecundusĀctibus()
        : base(NūntiusĪnflexōrīImpersōnālīSemidēpōnentīImperfectōSecundōĀctibus.Faciendum, ĪnflexorEffectusSecundusĀctibus.Faciendum) { }

    [Singleton]
    private sealed partial class NūntiusĪnflexōrīImpersōnālīSemidēpōnentīImperfectōSecundōĀctibus : Nūntius<ĪnflexorImpersōnālisSemidēpōnēnsImperfectusSecundusĀctibus>
    {
      public static readonly Lazy<NūntiusĪnflexōrīImpersōnālīSemidēpōnentīImperfectōSecundōĀctibus> Faciendum
                       = new Lazy<NūntiusĪnflexōrīImpersōnālīSemidēpōnentīImperfectōSecundōĀctibus>(() => Instance);
    }
  }
}
