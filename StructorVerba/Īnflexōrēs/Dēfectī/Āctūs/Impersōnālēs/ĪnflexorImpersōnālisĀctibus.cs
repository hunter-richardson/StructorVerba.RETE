using System;

using Nūntiī.Nūntius;
using Miscella.Ūtilitātēs;
using Ēnumerātiōnēs;
using Pēnsōrēs.Īnflectenda.PēnsorĀctibus.Versiō;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

namespace Īnflexōrēs.Dēfectī.Āctūs.Impersōnālēs
{
  [AsyncOverloads]
  public abstract partial class ĪnflexorImpersōnālisĀctibus : ĪnflexorDēfectusĀctibus
  {
    public static readonly Func<PēnsorĀctibus.Versiō, Task<Lazy<ĪnflexorImpersōnālisĀctibus?>>> Relātor = async versiō => versiō switch
    {
      PēnsorĀctibus.Versiō.Secundus_Impersōnālis => ĪnflexorImpersōnālisSecundusĀctibus.Faciendum,
      PēnsorĀctibus.Versiō.Tertius_Impersōnālis => ĪnflexorImpersōnālisTertiuĀctibus.Faciendum,
      _ => new Lazy(null),
    };

    protected ĪnflexorImpersōnālisĀctibus(in Lazy<Nūntius<ĪnflexorImpersōnālisĀctibus>> nūntius,
                                          in Lazy<ĪnflexorEffectusĀctibus> relātum)
                                                                                 : base(nūntius, relātum) { }

    public sealed Enum[] Referō(in Enum[] illa)
              => Ūtilitātēs.Seriēs(illa.FirstOf<Modus>(), illa.FirstOf<Vōx>(),
                                   illa.FirstOf<Tempus>(), Numerālis.Singulāris, Persōna.Prīma);
  }
}
