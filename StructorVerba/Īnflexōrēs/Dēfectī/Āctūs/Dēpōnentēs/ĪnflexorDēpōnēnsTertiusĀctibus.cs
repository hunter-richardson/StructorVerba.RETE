using System;

using Nūntiī.Nūntius;
using Miscella.Ūtilitātēs;
using Īnflexōrēs.Effectī.Āctūs.ĪnflexorEffectusTertiusĀctibus;
using Ēnumerātiōnēs;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

namespace Īnflexōrēs.Dēfectī.Āctūs.Dēpōnentēs
{
  [AsyncOverloads]
  public abstract partial class ĪnflexorDēpōnēnsTertiusĀctibus : ĪnflexorDēfectusĀctibus
  {
    protected ĪnflexorDēpōnēnsTertiusĀctibus()
          : base(ĪnflexorDēpōnēnsTertiusĀctibus.Faciendum, ĪnflexorEffectusTertiusĀctibus.Faciendum) { }

    [Singleton]
    private sealed class NūntiusĪnflexōrīDēpōnenteSecundōĀctibus : Nūntius<ĪnflexorDēpōnēnsTertiusĀctibus>
    {
      public static readonly Lazy<ĪnflexorDēpōnēnsTertiusĀctibus> Faciendum
                       = new Lazy<ĪnflexorDēpōnēnsTertiusĀctibus>(() => Instance);
    }
  }
}
