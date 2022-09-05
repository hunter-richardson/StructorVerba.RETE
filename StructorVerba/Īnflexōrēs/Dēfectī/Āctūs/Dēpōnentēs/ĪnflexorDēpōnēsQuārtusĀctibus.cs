using System;

using Nūntiī.Nūntius;
using Īnflexōrēs.Effectī.Āctibus.ĪnflexorEffectusQuārtusĀctibus;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Dēfectī.Āctūs.Dēpōnentēs
{
  [Singleton]
  public sealed partial class ĪnflexorDēpōnēnsQuārtusĀctibus : ĪnflexorDēpōnēsĀctibus
  {
    public static readonly Lazy<ĪnflexorDēpōnēnsQuārtusĀctibus> Faciendum
                     = new Lazy<ĪnflexorDēpōnēnsQuārtusĀctibus>(() => Instance);
    private ĪnflexorDēpōnēnsQuārtusĀctibus()
        : base(NūntiusĪnflexōrīDēpōnentīQuārtōĀctibus.Faciendum, ĪnflexorEffectusQuārtusĀctibus.Faciendum) { }

    [Singleton]
    private sealed partial class NūntiusĪnflexōrīDēpōnentīQuārtōĀctibus : Nūntius<ĪnflexorDēpōnēnsQuārtusĀctibus>
    {
      public static readonly Lazy<NūntiusĪnflexōrīDēpōnentīQuārtōĀctibus> Faciendum
                       = new Lazy<NūntiusĪnflexōrīDēpōnentīQuārtōĀctibus>(() => Instance);
    }
  }
}
