using System;

using Nūntiī.Nūntius;
using Miscella.Ūtilitātēs;
using Īnflexōrēs.Effectī.Āctūs.ĪnflexorEffectusSecundusĀctibus;
using Ēnumerātiōnēs;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

namespace Īnflexōrēs.Dēfectī.Āctūs.Dēpōnentēs
{
  [AsyncOverloads]
  public abstract partial class ĪnflexorDēpōnēnsSecundusĀctibus : ĪnflexorDēfectusĀctibus
  {
    protected ĪnflexorDēpōnēnsSecundusĀctibus()
          : base(NūntiusĪnflexōrīDēpōnenteSecundōĀctibus.Faciendum, ĪnflexorEffectusSecundusĀctibus.Faciendum) { }

    [Singleton]
    private sealed class NūntiusĪnflexōrīDēpōnenteSecundōĀctibus : Nūntius<ĪnflexorDēpōnēnsSecundusĀctibus>
    {
      public static readonly Lazy<NūntiusĪnflexōrīDēpōnenteSecundōĀctibus> Faciendum
                       = new Lazy<NūntiusĪnflexōrīDēpōnenteSecundōĀctibus>(() => Instance);
    }
  }
}
