using System;

using Nūntiī.Nūntius;
using Īnflexōrēs.Effectī.Āctibus.ĪnflexorEffectusSecundusĀctibus;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Dēfectī.Āctūs
{
  [Singleton]
  public sealed partial class ĪnflexorImpersōnālisSemidēpōnēnsSecundusĀctibus : ĪnflexorDēfectusĀctibus
  {
    public static readonly Lazy<ĪnflexorImpersōnālisSemidēpōnēnsSecundusĀctibus> Faciendum
                     = new Lazy<ĪnflexorImpersōnālisSemidēpōnēnsSecundusĀctibus>(() => Instance);
    private ĪnflexorImpersōnālisSemidēpōnēsSecundusĀctibus()
          : base(NūntiusĪnflexōrīImpersōnālisSemidēpōnentīSecundōĀctibus.Faciendum, ĪnflexorEffectusSecundusĀctibus.Faciendum) { }

    public sealed Enum[] Referō(in Enum[] illa)
    {
      const Modus modus = illa.FirstOf<Modus>();
      const Tempus tempus = illa.FirstOf<Tempus>();
      const Vōx vōx = (modus, tempus) switch
                      {
                        (Modus.Participāle, Tempus.Perfectum) => Vōx.Passīva,
                        (Modus.Participāle, Tempus.Futūrum) => illa.FirstOf<Vōx>(),
                        _ => Vōx.Āctīva
                      };
      return Ūtilitātēs.Seriēs(modus, vōx, tempus, Numerālis.Singulāris, Persōna.Prīma);
    }

    [Singleton]
    private sealed partial class NūntiusĪnflexōrīImpersōnālisSemidēpōnentīSecundōĀctibus : Nūntius<ĪnflexorImpersōnālisSemidēpōnēnsSecundusĀctibus>
    {
      public static readonly Lazy<NūntiusĪnflexōrīImpersōnālisSemidēpōnentīSecundōĀctibus> Faciendum
                       = new Lazy<NūntiusĪnflexōrīImpersōnālisSemidēpōnentīSecundōĀctibus>(() => Instance);
    }
  }
}
