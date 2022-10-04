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
            = new Lazy(() => new ĪnflexorImpersōnālisSemidēpōnēnsĀctibus(relātus: ĪnflexorEffectusPrīmusĀctibus.Lazy));
    private static readonly Lazy<ĪnflexorImpersōnālisSemidēpōnēnsĀctibus> Secundus
            = new Lazy(() => new ĪnflexorImpersōnālisSemidēpōnēnsĀctibus(relātus: ĪnflexorEffectusSecundusĀctibus.Lazy));
    private static readonly Lazy<ĪnflexorImpersōnālisSemidēpōnēnsĀctibus> Tertius
            = new Lazy(() => new ĪnflexorImpersōnālisSemidēpōnēnsĀctibus(relātus: ĪnflexorEffectusTertiusĀctibus.Lazy));
    public static readonly Func<PēnsorĀctibus.Versiō, Task<Lazy<ĪnflexorImpersōnālisSemidēpōnēnsĀctibus?>>> Relātor
              = async versiō => versiō switch
                                {
                                  PēnsorĀctibus.Versiō.Āctus_Prīmus_Impersōnālis_Semidēpōnēns => Prīmus,
                                  PēnsorĀctibus.Versiō.Āctus_Secundus_Impersōnālis_Semidēpōnēns => Secundus,
                                  PēnsorĀctibus.Versiō.Āctus_Tertius_Impersōnālis_Semidēpōnēns => Tertius,
                                  _ => new Lazy(null),
                                };

    private ĪnflexorImpersōnālisSemidēpōnēsĀctibus(in Lazy<ĪnflexorEffectusĀctibus> relātus)
        : base(nūntius: new Lazy<Nūntius<ĪnflexorImpersōnālisSemidēpōnēnsĀctibus>>(), relātus: relātus)
        => Nūntius.PlūsGarriōAsync("Fīō");

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
  }
}
