using System;
using System.Collections.Generic.IEnumerable;

using Miscella;
using Praebeunda.Īnflecendum;
using Pēnsōrēs.Nōmina.PēnsorNōminibus.Versiō;
using Īnflexōrēs.Effectī.Nōmina;
using Ēnumerātiōnēs;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttritbue;
using Lombok.NET.PropertyGenerators.SingletonAttritbue;

namespace Īnflexōrēs.Dēfectī.Nōmina
{
  [AsyncOverloads]
  public sealed class ĪnflexorSingulārisNōminibus : ĪnflexorDēfectusNōminibus<Īnflectendum.Nōmen>
  {
    private static readonly Lazy<ĪnflexorSingulārisNōminibus> Prīmus
            = new Lazy(() => new ĪnflexorSingulārisNōminibus(relātus: ĪnflexorEffectusPrīmusNōminibus.Lazy));
    private static readonly Lazy<ĪnflexorSingulārisNōminibus> SecundusMasculīnus
            = new Lazy(() => new ĪnflexorSingulārisNōminibus(relātus: ĪnflexorEffectusSecundusMasculīnusNōminibus.Lazy));
    private static readonly Lazy<ĪnflexorSingulārisNōminibus> Tertius
            = new Lazy(() => new ĪnflexorSingulārisNōminibus(relātus: ĪnflexorEffectusTertiusNōminibus.Lazy));
    public static readonly Func<PēnsorNōminibus.Versiō, Task<Lazy<ĪnflexorSingulārisNōminibus?>>> Relātor
        = async versiō => versiō switch
                          {
                            PēnsorNōminibus.Versiō.Nōmen_Prīmum_Singulāris => Prīmus,
                            PēnsorNōminibus.Versiō.Nōmen_Secundum_Masculīnum_Singulāris => SecundusMasculīnus,
                            PēnsorNōminibus.Versiō.Nōmen_Tertium_Singulāris => Tertius,
                            _ => new Lazy(null),
                          };

    private ĪnflexorSingulārisNōminibus(in Lazy<ĪnflexorEffectusNōminibus> relātus)
        : base(nūntius: new Lazy<Nūntius<ĪnflexorSingulārisNōminibus>>(), relātus: relātus)
        => Nūntius.PlūsGarriōAsync("Fīō");

    protected Enum[] Referō(in Enum[] illa)
          => Ūtilitātēs.Seriēs(Numerālis.Singulāris, illa.FirstOf<Casus>());
  }
}
