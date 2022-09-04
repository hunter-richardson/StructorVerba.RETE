using System;
using System.Collections.Generic.IEnumerable;

using Miscella;
using Praebeunda.Īnflecendum;
using Pēnsōrēs.Nōmina.PēnsorNōminibus.Versiō;
using Īnflexōrēs.Effectī.Nōmina.ĪnflexorEffectusNōminibus;
using Ēnumerātiōnēs;

namespace Īnflexōrēs.Dēfectī.Nōmina
{
  public abstract class ĪnflexorSingulārisNōminibus : ĪnflexorDēfectusNōminibus<Īnflectendum.Nōmen>
  {
    public static readonly Func<PēnsorNōminibus.Versiō, Task<Lazy<ĪnflexorSingulārisNōminibus?>>> Relātor = async versiō => versiō switch
    {
      PēnsorNōminibus.Versiō.Nōmen_Prīmum_Singulāris => null,
      PēnsorNōminibus.Versiō.Nōmen_Secundum_Masculīnum_Singulāris => null,
      PēnsorNōminibus.Versiō.Nōmen_Tertium_Singulāris => null,
      _ => new Lazy(null),
    };

    protected ĪnflexorSingulārisNōminibus(in Lazy<Nūntius<ĪnflexorSingulārisNōminibus>> nūntius,
                                          in Lazy<ĪnflexorEffectusNōminibus> relātus)
                                                                                 : base(nūntius, relātus) { }

    protected sealed Enum[] Referō(in Enum[] illa)
          => Ūtilitātēs.Seriēs(Numerālis.Singulāris, illa.FirstOf<Casus>());
  }
}
