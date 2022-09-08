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
            = new Lazy(() => new ĪnflexorImpersōnālisĀctibus(ĪnflexorEffectusSecundusĀctibus.Faciendum));
    private static readonly Lazy<ĪnflexorImpersōnālisĀctibus> Tertius
            = new Lazy(() => new ĪnflexorImpersōnālisĀctibus(ĪnflexorEffectusTertiusĀctibus.Faciendum));

    public static readonly Func<PēnsorĀctibus.Versiō, Task<Lazy<ĪnflexorImpersōnālisĀctibus?>>> Relātor
              = async versiō => versiō switch
                                {
                                  PēnsorĀctibus.Versiō.Secundus_Impersōnālis => Secundus,
                                  PēnsorĀctibus.Versiō.Tertius_Impersōnālis => Tertius,
                                  _ => new Lazy(null),
                                };

    private ĪnflexorImpersōnālisĀctibus(in Lazy<ĪnflexorEffectusĀctibus> relātum)
        : base(new Lazy<Nūntius<ĪnflexorImpersōnālisĀctibus>>(), relātum) { }

    public Enum[] Referō(in Enum[] illa)
              => Ūtilitātēs.Seriēs(illa.FirstOf<Modus>(), illa.FirstOf<Vōx>(),
                                   illa.FirstOf<Tempus>(), Numerālis.Singulāris, Persōna.Prīma);
  }
}
