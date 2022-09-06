using System;

using Nūntiī.Nūntius;
using Īnflexōrēs.Effectī.Āctibus.ĪnflexorEffectusSecundusĀctibus;
using Īnflexōrēs.Effectī.Āctūs;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Dēfectī.Āctūs
{
  [AsyncOverloads]
  public sealed partial class ĪnflexorImpersōnālisSemidēpōnēnsĀctibus : ĪnflexorDēfectusĀctibus
  {
    private static readonly Lazy<ĪnflexorImpersōnālisSemidēpōnēnsĀctibus> Prīmus
                      = new Lazy<ĪnflexorImpersōnālisSemidēpōnēnsĀctibus>(() => new ĪnflexorImpersōnālisSemidēpōnēnsĀctibus(ĪnflexorEffectusPrīmusĀctibus.Faciendum));
    private static readonly Lazy<ĪnflexorImpersōnālisSemidēpōnēnsĀctibus> Secundus
                      = new Lazy<ĪnflexorImpersōnālisSemidēpōnēnsĀctibus>(() => new ĪnflexorImpersōnālisSemidēpōnēnsĀctibus(ĪnflexorEffectusSecundusĀctibus.Faciendum));
    private static readonly Lazy<ĪnflexorImpersōnālisSemidēpōnēnsĀctibus> Tertius
                      = new Lazy<ĪnflexorImpersōnālisSemidēpōnēnsĀctibus>(() => new ĪnflexorImpersōnālisSemidēpōnēnsĀctibus(ĪnflexorEffectusTertiusĀctibus.Faciendum));
    public static readonly Func<PēnsorĀctibus.Versiō, Task<Lazy<ĪnflexorImpersōnālisSemidēpōnēnsĀctibus?>>> Relātor
              = async versiō => versiō switch
                                {
                                  PēnsorĀctibus.Versiō.Prīmus_Impersōnālis_Semidēpōnēns => Prīmus,
                                  PēnsorĀctibus.Versiō.Secundus_Impersōnālis_Semidēpōnēns => Secundus,
                                  PēnsorĀctibus.Versiō.Tertius_Impersōnālis_Semidēpōnēns => Tertius,
                                  _ => new Lazy(null),
                                };

    private ĪnflexorImpersōnālisSemidēpōnēsĀctibus(in Lazy<ĪnflexorEffectusĀctibus> relātum)
                 : base(NūntiusĪnflexōrīImpersōnālisSemidēpōnentīĀctibus.Faciendum, relātum) { }

    public Enum[] Referō(in Enum[] illa)
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
    private sealed partial class NūntiusĪnflexōrīImpersōnālisSemidēpōnentīĀctibus : Nūntius<ĪnflexorImpersōnālisSemidēpōnēnsĀctibus>
    {
      public static readonly Lazy<NūntiusĪnflexōrīImpersōnālisSemidēpōnentīĀctibus> Faciendum
                       = new Lazy<NūntiusĪnflexōrīImpersōnālisSemidēpōnentīĀctibus>(() => Instance);
    }
  }
}
