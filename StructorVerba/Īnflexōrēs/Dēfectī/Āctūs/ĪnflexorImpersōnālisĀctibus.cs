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
  public sealed partial class ĪnflexorImpersōnālisĀctibus : ĪnflexorDēfectusĀctibus
  {
    private static readonly Lazy<ĪnflexorImpersōnālisĀctibus> Secundus
            = new Lazy(() => new ĪnflexorImpersōnālisĀctibus(relātus: ĪnflexorEffectusSecundusĀctibus.Lazy));
    private static readonly Lazy<ĪnflexorImpersōnālisĀctibus> Tertius
            = new Lazy(() => new ĪnflexorImpersōnālisĀctibus(relātus: ĪnflexorEffectusTertiusĀctibus.Lazy));

    public static readonly Func<PēnsorĀctibus.Versiō, Task<Lazy<ĪnflexorImpersōnālisĀctibus?>>> Relātor
              = async versiō => versiō switch
                                {
                                  PēnsorĀctibus.Versiō.Āctus_Secundus_Impersōnālis => Secundus,
                                  PēnsorĀctibus.Versiō.Āctus_Tertius_Impersōnālis => Tertius,
                                  _ => new Lazy(null),
                                };

    private ĪnflexorImpersōnālisĀctibus(in Lazy<ĪnflexorEffectusĀctibus> relātus)
        : base(nūntius: new Lazy<Nūntius<ĪnflexorImpersōnālisĀctibus>>(), relātus: relātus)
        => Nūntius.PlūsGarriōAsync("Fīō");

    public Enum[] Referō(in Enum[] illa)
              => Ūtilitātēs.Seriēs(illa.FirstOf<Modus>(), illa.FirstOf<Vōx>(),
                                   illa.FirstOf<Tempus>(), Numerālis.Singulāris, Persōna.Prīma);
  }
}
