using System;
using System.Linq;
using System.Threading.Tasks.Task;

using Nūntiī.Nūntius;
using Miscella;
using Praebeunda.Multiplex;
using Praebeunda.Īnflectendum;
using Pēnsōrēs.Nōmina.PēnsorNōminibus.Versio;
using Ēnumerātiōnēs;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

namespace Īnflexōrēs.Effectī.Nōmina
{
  [AsyncOverloads]
  public abstract partial class ĪnflexorEffectusNōminibus : ĪnflexorEffectusNōminibus<Īnflectendum.Nōmen>
  {
    public static readonly Func<PēnsorNōminibus.Versiō, Task<Lazy<ĪnflexorEffectusNōminibus?>>> Relātor = async versiō => versiō switch
    {
      PēnsorNōminibus.Versiō.Nōmen_Prīmum => ĪnflexorEffectusPrīmusNōminibus.Faciendum,
      PēnsorNōminibus.Versiō.Nōmen_Secundum_Masculīnum => ĪnflexorEffectusSecundusMasculīnusNōminibus.Faciendum,
      PēnsorNōminibus.Versiō.Nōmen_Secundum_Neutrum => ĪnflexorEffectusSecundusNeuterNōminibus.Faciendum,
      PēnsorNōminibus.Versiō.Nōmen_Secundum_Varium_Cum_Litterā_E => ĪnflexorEffectusSecundusVariusNōminibusCumLitterāE.Faciendum,
      PēnsorNōminibus.Versiō.Nōmen_Secundum_Varium_Sine_Litterā_E => ĪnflexorEffectusSecundusVariusNōminibusSineLitterāE.Faciendum,
      PēnsorNōminibus.Versiō.Nōmen_Tertium => ĪnflexorEffectusTertiusNōminibus.Faciendum,
      PēnsorNōminibus.Versiō.Nōmen_Tertium_Neutrum => ĪnflexorEffectusTertiusNeuterNōminibus.Faciendum,
      PēnsorNōminibus.Versiō.Nōmen_Tertium_Cum_Genitīvō_Variō => ĪnflexorEffectusTertiusNōminibusCumGenitīvōVariō.Faciendum,
      PēnsorNōminibus.Versiō.Nōmen_Tertium_Cum_Ablātīvō_Variō => ĪnflexorEffectusTertiusNōminibusCumAblātīvōVariō.Faciendum,
      PēnsorNōminibus.Versiō.Nōmen_Tertium_Cum_Genitīvō_Ablātīvōque_Variō => ĪnflexorEffectusTertiusNōminibusCumGenitīvōAblātīvōqueVariō.Faciendum,
      PēnsorNōminibus.Versiō.Nōmen_Tertium_Neutrum_Cum_Genitīvō_Variō => ĪnflexorEffectusTertiusNeuterNōminibusCumGenitīvōVariō.Faciendum,
      PēnsorNōminibus.Versiō.Nōmen_Tertium_Neutrum_Cum_Ablātīvō_Variō => ĪnflexorEffectusTertiusNeuterNōminibusCumAblātīvōVariō.Faciendum,
      PēnsorNōminibus.Versiō.Nōmen_Tertium_Neutrum_Cum_Genitīvō_Ablātīvōque_Variō => ĪnflexorEffectusTertiusNeuterNōminibusCumGenitīvōAblātīvōqueVariō.Faciendum,
      PēnsorNōminibus.Versiō.Nōmen_Quārtum => ĪnflexorEffectusQuārtusNōminibus.Faciendum,
      PēnsorNōminibus.Versiō.Nōmen_Quārtum_Varium => ĪnflexorEffectusQuārtusVariusNōminibus.Faciendum,
      PēnsorNōminibus.Versiō.Nōmen_Quīntum => ĪnflexorEffectusQuīntusNōminibus.Faciendum,
      _ => new Lazy(null),
    };

    protected ĪnflexorEffectusNōminibus(in Lazy<Nūntius<ĪnflexorEffectusNōminibus>> nūntius,
                                        in Func<Īnflectendum.Nōmen, Enum[], string> rādīcātor)
                                                           : base(versiō, nūntius, nameof(Īnflectendum.Nōmen.Nōminātīvum), rādīcātor,
                                                                  Ūtilitātēs.Combīnō(Casus.GetValues().Except(Casus.Dērēctus).ToHashSet(),
                                                                                     Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet())) { }

    public abstract string Singulāre(in Casus casus);
    public abstract string Plūrāle(in Casus casus);

    public sealed string? Suffixum(in Enum[] illa)
              => await(illa.FirstOf<Numerālis>(), illa.FirstOf<Casus>()) switch
              {
                var īnscītum when Ūtilitātēs.Ūlla(default(Numerālis).Equals(numerālis), default(Casus).Equals(casus))
                                        => Task.FromResult<string?>(null),
                (Numerālis.Singulāris, _) => SingulāreAsync(casus),
                (Numerālis.Plūrālis, _) => PlūrāleAsync(casus)
              };
  }
}
