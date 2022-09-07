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
  public sealed partial class ĪnflexorSemidēpōnēnsĀctibus : ĪnflexorDēfectusĀctibus
  {
    private static readonly Lazy<ĪnflexorSemidēpōnēnsĀctibus> Prīmus
                      = new Lazy<ĪnflexorSemidēpōnēnsĀctibus>(() => new ĪnflexorSemidēpōnēnsĀctibus(ĪnflexorEffectusPrīmusĀctibus.Faciendum));
    private static readonly Lazy<ĪnflexorSemidēpōnēnsĀctibus> Secundus
                      = new Lazy<ĪnflexorSemidēpōnēnsĀctibus>(() => new ĪnflexorSemidēpōnēnsĀctibus(ĪnflexorEffectusSecundusĀctibus.Faciendum));
    private static readonly Lazy<ĪnflexorSemidēpōnēnsĀctibus> Tertius
                      = new Lazy<ĪnflexorSemidēpōnēnsĀctibus>(() => new ĪnflexorSemidēpōnēnsĀctibus(ĪnflexorEffectusTertiusĀctibus.Faciendum));

    public static readonly Func<PēnsorĀctibus.Versiō, Task<Lazy<ĪnflexorDēfectusĀctibus?>>> Relātor
              = async versiō => versiō switch
                                {
                                  PēnsorĀctibus.Versiō.Prīmus_Semidēpōnēns => Prīmus,
                                  PēnsorĀctibus.Versiō.Secundus_Semidēpōnēns => Secundus,
                                  PēnsorĀctibus.Versiō.Tertius_Semidēpōnēns => Tertius,
                                  _ => new Lazy(null),
                                };

    private ĪnflexorSemidēpōnēnsĀctibus(in Lazy<ĪnflexorEffectusĀctibus> relātum)
        : base(new Lazy<Nūntius<ĪnflexorSemidēpōnēnsĀctibus>>(() => new Nūntius<ĪnflexorSemidēpōnēnsĀctibus>()), relātum) { }

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
      return Ūtilitātēs.Seriēs(modus, vōx, tempus, illa.FirstOf<Numerālis>(), illa.FirstOf<Persōna>());
    }
  }
}
