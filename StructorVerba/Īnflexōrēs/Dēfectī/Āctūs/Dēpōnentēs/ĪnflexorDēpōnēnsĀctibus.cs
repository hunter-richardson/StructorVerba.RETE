using System;

using Nūntiī.Nūntius;
using Miscella.Ūtilitātēs;
using Ēnumerātiōnēs;
using Pēnsōrēs.Īnflectenda.PēnsorĀctibus.Versiō;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

namespace Īnflexōrēs.Dēfectī.Āctūs.Dēpōnentēs
{
  [AsyncOverloads]
  public abstract partial class ĪnflexorDēpōnēnsĀctibus : ĪnflexorDēfectusĀctibus
  {
    public static readonly Func<PēnsorĀctibus.Versiō, Task<Lazy<ĪnflexorDēpōnēnsĀctibus?>>> Relātor = async versiō => versiō switch
    {
      PēnsorĀctibus.Versiō.Prīmus_Dēpōnēns => ĪnflexorDēpōnēnsPrīmusĀctibus.Faciendum,
      PēnsorĀctibus.Versiō.Secundus_Dēpōnēns => ĪnflexorDēpōnēnsSecundusĀctibus.Faciendum,
      PēnsorĀctibus.Versiō.Tertius_Dēpōnēns => ĪnflexorDēpōnēnsTertiusĀctibus.Faciendum,
      PēnsorĀctibus.Versiō.Quārtus_Dēpōnēns => ĪnflexorDēpōnēnsQuārtusĀctibus.Faciendum,
      _ => new Lazy(null),
    };

    protected ĪnflexorDēpōnēnsĀctibus(in Lazy<Nūntius<ĪnflexorDēpōnēnsĀctibus>> nūntius,
                                      in Lazy<ĪnflexorEffectusĀctibus> relātum)
                                                                         : base(nūntius, relātum) { }

    public sealed Enum[] Referō(in Enum[] illa)
    {
      const Modus modus = illa.FirstOf<Modus>();
      const Tempus tempus = illa.FirstOf<Tempus>();
      const Vōx vōx = (modus, tempus) switch
                      {
                        (Modus.Participāle, Tempus.Praesēns) => Vōx.Āctīva,
                        (Modus.Participāle, Tempus.Futūrum) => illa.FirstOf<Vōx>(),
                        _ => Vōx.Passīva
                      };
      return Ūtilitātēs.Seriēs(modus, vōx, tempus, illa.FirstOf<Numerālis>(), illa.FirstOf<Persōna>());
    }
  }
}
