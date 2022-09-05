using System;

using Nūntiī.Nūntius;
using Miscella.Ūtilitātēs;
using Ēnumerātiōnēs;
using Pēnsōrēs.Īnflectenda.PēnsorĀctibus.Versiō;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

namespace Īnflexōrēs.Dēfectī.Āctūs.ImpersōnālēsSemidēpōnentēsImperfectī
{
  [AsyncOverloads]
  public abstract partial class ĪnflexorImpersōnālisSemidēpōnēnsImperfectusĀctibus : ĪnflexorDēfectusĀctibus
  {
    public static readonly Func<PēnsorĀctibus.Versiō, Task<Lazy<ĪnflexorImpersōnālisSemidēpōnēnsImperfectusĀctibus?>>> Relātor = async versiō => versiō switch
    {
      PēnsorĀctibus.Versiō.Prīmus_Impersōnālis_Semidēpōnēns_Imperfectus => ĪnflexorImpersōnālisSemidēpōnēnsImperfectusPrīmusĀctibus.Faciendum,
      PēnsorĀctibus.Versiō.Secundus_Impersōnālis_Semidēpōnēns_Imperfectus => ĪnflexorImpersōnālisSemidēpōnēnsImperfectusSecundusĀctibus.Faciendum,
      PēnsorĀctibus.Versiō.Tertius_Impersōnālis_Semidēpōnēns_Imperfectus => ĪnflexorImpersōnālisSemidēpōnēnsImperfectusTertiusĀctibus.Faciendum,
      _ => new Lazy(null),
    };

    protected ĪnflexorImpersōnālisSemidēpōnēnsImperfectusĀctibus(in Lazy<Nūntius<ĪnflexorImpersōnālisSemidēpōnēnsImperfectusĀctibus>> nūntius,
                                                                 in Lazy<ĪnflexorEffectusĀctibus> relātum)                     : base(nūntius, relātum) { }

    public sealed Enum[] Referō(in Enum[] illa)
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
