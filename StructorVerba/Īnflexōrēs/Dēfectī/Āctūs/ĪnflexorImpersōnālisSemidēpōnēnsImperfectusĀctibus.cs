using System;

using Nūntiī.Nūntius;
using Miscella.Ūtilitātēs;
using Ēnumerātiōnēs;
using Pēnsōrēs.Īnflectenda.PēnsorĀctibus.Versiō;
using Īnflexōrēs.Effectī.Āctūs;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.SingletonAttritbue;


namespace Īnflexōrēs.Dēfectī.Āctūs
{
  [AsyncOverloads]
  public sealed partial class ĪnflexorImpersōnālisSemidēpōnēnsImperfectusĀctibus : ĪnflexorDēfectusĀctibus
  {
    private static readonly Lazy<ĪnflexorImpersōnālisSemidēpōnēnsImperfectusĀctibus> Prīmus
                      = new Lazy<ĪnflexorImpersōnālisSemidēpōnēnsImperfectusĀctibus>(() => new ĪnflexorImpersōnālisSemidēpōnēnsImperfectusĀctibus(ĪnflexorEffectusPrīmusĀctibus.Faciendum));
    private static readonly Lazy<ĪnflexorImpersōnālisSemidēpōnēnsImperfectusĀctibus> Secundus
                      = new Lazy<ĪnflexorImpersōnālisSemidēpōnēnsImperfectusĀctibus>(() => new ĪnflexorImpersōnālisSemidēpōnēnsImperfectusĀctibus(ĪnflexorEffectusSecundusĀctibus.Faciendum));
    private static readonly Lazy<ĪnflexorImpersōnālisSemidēpōnēnsImperfectusĀctibus> Tertius
                      = new Lazy<ĪnflexorImpersōnālisSemidēpōnēnsImperfectusĀctibus>(() => new ĪnflexorImpersōnālisSemidēpōnēnsImperfectusĀctibus(ĪnflexorEffectusTertiusĀctibus.Faciendum));

    public static readonly Func<PēnsorĀctibus.Versiō, Task<Lazy<ĪnflexorImpersōnālisSemidēpōnēnsImperfectusĀctibus?>>> Relātor = async versiō => versiō switch
    {
      PēnsorĀctibus.Versiō.Prīmus_Impersōnālis_Semidēpōnēns_Imperfectus => Prīmus,
      PēnsorĀctibus.Versiō.Secundus_Impersōnālis_Semidēpōnēns_Imperfectus => Secundus,
      PēnsorĀctibus.Versiō.Tertius_Impersōnālis_Semidēpōnēns_Imperfectus => Tertius,
      _ => new Lazy(null),
    };

    private ĪnflexorImpersōnālisSemidēpōnēnsImperfectusĀctibus(in Lazy<ĪnflexorEffectusĀctibus> relātum)
        : base(new Lazy<Nūntius<ĪnflexorImpersōnālisSemidēpōnēnsImperfectusĀctibus>>(() => new Nūntius<ĪnflexorImpersōnālisSemidēpōnēnsImperfectusĀctibus>()), relātum) { }

    public Enum[] Referō(in Enum[] illa)
    {
      const Modus modus = illa.FirstOf<Modus>();
      Tempus tempus = illa.FirstOf<Tempus>();
      const Vōx vōx = (modus, tempus) switch
                      {
                        (Modus.Participāle, Tempus.Perfectum) => Vōx.Passīva,
                        (Modus.Participāle, Tempus.Futūrum) => illa.FirstOf<Vōx>(),
                        _ => Vōx.Āctīva
                      };
      tempus = (modus, tempus) switch
                {
                  (Modus.Participāle, _) => tempus,
                  (_, Tempus.Perfectum) => Tempus.Praesēns,
                  (_, Tempus.PlūsquamPercectum) => Tempus.Infectum,
                  (_, Tempus.Futūrum_Exāctum) => Tenpus.Futūrum,
                  _ => tempus
                };
      return Ūtilitātēs.Seriēs(modus, vōx, tempus, Numerālis.Singulāris, Persōna.Prīma);
    }
  }
}
