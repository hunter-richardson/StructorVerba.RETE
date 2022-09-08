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
  public sealed partial class ĪnflexorDēpōnēnsĀctibus : ĪnflexorDēfectusĀctibus
  {
    private static readonly Lazy<ĪnflexorDēpōnēnsĀctibus> Prīmus
            = new Lazy(() => new ĪnflexorDēpōnēnsĀctibus(ĪnflexorEffectusPrīmusĀctibus.Faciendum));
    private static readonly Lazy<ĪnflexorDēpōnēnsĀctibus> Secundus
            = new Lazy(() => new ĪnflexorDēpōnēnsĀctibus(ĪnflexorEffectusSecundusĀctibus.Faciendum));
    private static readonly Lazy<ĪnflexorDēpōnēnsĀctibus> Tertius
            = new Lazy(() => new ĪnflexorDēpōnēnsĀctibus(ĪnflexorEffectusTertiusĀctibus.Faciendum));
    private static readonly Lazy<ĪnflexorDēpōnēnsĀctibus> Quārtus
            = new Lazy(() => new ĪnflexorDēpōnēnsĀctibus(ĪnflexorEffectusQuārtusĀctibus.Faciendum));

    public static readonly Func<PēnsorĀctibus.Versiō, Task<Lazy<ĪnflexorDēpōnēnsĀctibus?>>> Relātor
              = async versiō => versiō switch
                                {
                                  PēnsorĀctibus.Versiō.Prīmus_Dēpōnēns => Prīmus,
                                  PēnsorĀctibus.Versiō.Secundus_Dēpōnēns => Secundus,
                                  PēnsorĀctibus.Versiō.Tertius_Dēpōnēns => Tertius,
                                  PēnsorĀctibus.Versiō.Quārtus_Dēpōnēns => Quārtus,
                                  _ => new Lazy(null),
                                };

    private ĪnflexorDēpōnēnsĀctibus(in Lazy<ĪnflexorEffectusĀctibus> relātum)
        : base(new Lazy<Nūntius<ĪnflexorDēpōnēnsĀctibus>>(), relātum) { }

    public Enum[] Referō(in Enum[] illa)
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
