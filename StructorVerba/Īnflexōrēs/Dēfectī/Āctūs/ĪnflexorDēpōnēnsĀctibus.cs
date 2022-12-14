using System;

using Nūntiī.Nūntius;
using Miscella.Ūtilitātēs;
using Ēnumerātiōnēs;
using Pēnsōrēs.Īnflectenda.PēnsorĀctibus.Versiō;
using Īnflexōrēs.Effectī.Āctūs;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

namespace Īnflexōrēs.Dēfectī.Āctūs
{
  [AsyncOverloads]
  public sealed partial class ĪnflexorDēpōnēnsĀctibus : ĪnflexorDēfectusĀctibus
  {
    private static readonly Lazy<ĪnflexorDēpōnēnsĀctibus> Prīmus
            = new Lazy(() => new ĪnflexorDēpōnēnsĀctibus(relātus: ĪnflexorEffectusPrīmusĀctibus.Lazy));
    private static readonly Lazy<ĪnflexorDēpōnēnsĀctibus> Secundus
            = new Lazy(() => new ĪnflexorDēpōnēnsĀctibus(relātus: ĪnflexorEffectusSecundusĀctibus.Lazy));
    private static readonly Lazy<ĪnflexorDēpōnēnsĀctibus> Tertius
            = new Lazy(() => new ĪnflexorDēpōnēnsĀctibus(relātus: ĪnflexorEffectusTertiusĀctibus.Lazy));
    private static readonly Lazy<ĪnflexorDēpōnēnsĀctibus> Quārtus
            = new Lazy(() => new ĪnflexorDēpōnēnsĀctibus(relātus: ĪnflexorEffectusQuārtusĀctibus.Lazy));

    public static readonly Func<PēnsorĀctibus.Versiō, Task<Lazy<ĪnflexorDēpōnēnsĀctibus?>>> Relātor
              = async versiō => versiō switch
                                {
                                  PēnsorĀctibus.Versiō.Āctus_Prīmus_Dēpōnēns => Prīmus,
                                  PēnsorĀctibus.Versiō.Āctus_Secundus_Dēpōnēns => Secundus,
                                  PēnsorĀctibus.Versiō.Āctus_Tertius_Dēpōnēns => Tertius,
                                  PēnsorĀctibus.Versiō.Āctus_Quārtus_Dēpōnēns => Quārtus,
                                  _ => new Lazy(null),
                                };

    private ĪnflexorDēpōnēnsĀctibus(in Lazy<ĪnflexorEffectusĀctibus> relātus)
        : base(nūntius: new Lazy<Nūntius<ĪnflexorDēpōnēnsĀctibus>>(), relātus: relātus)
        => Nūntius.PlūsGarriōAsync("Fīō");

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
