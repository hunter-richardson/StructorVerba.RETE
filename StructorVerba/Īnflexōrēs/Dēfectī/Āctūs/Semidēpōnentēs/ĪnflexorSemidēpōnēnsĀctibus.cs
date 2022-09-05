using System;

using Nūntiī.Nūntius;
using Miscella.Ūtilitātēs;
using Ēnumerātiōnēs;
using Pēnsōrēs.Īnflectenda.PēnsorĀctibus.Versiō;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

namespace Īnflexōrēs.Dēfectī.Āctūs.Semidēpōnentēs
{
  [AsyncOverloads]
  public abstract partial class ĪnflexorSemidēpōnēnsĀctibus : ĪnflexorDēfectusĀctibus
  {
    public static readonly Func<PēnsorĀctibus.Versiō, Task<Lazy<ĪnflexorDēfectusĀctibus?>>> Relātor = async versiō => versiō switch
    {
      PēnsorĀctibus.Versiō.Prīmus_Semidēpōnēns => ĪnflexorSemidēpōnēnsPrīmusĀctibus.Faciendum,
      PēnsorĀctibus.Versiō.Secundus_Semidēpōnēns => ĪnflexorSemidēpōnēnsSecundusĀctibus.Faciendum,
      PēnsorĀctibus.Versiō.Tertius_Semidēpōnēns => ĪnflexorSemidēpōnēnsTertiusĀctibus.Faciendum,
      _ => new Lazy(null),
    };

    protected ĪnflexorSemidēpōnēnsĀctibus(in Lazy<Nūntius<ĪnflexorSemidēpōnēnsĀctibus>> nūntius,
                                          in Lazy<ĪnflexorEffectusĀctibus> relātum)
                                                                                 : base(nūntius, relātum) { }

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
      return Ūtilitātēs.Seriēs(modus, vōx, tempus, illa.FirstOf<Numerālis>(), illa.FirstOf<Persōna>());
    }
  }
}
