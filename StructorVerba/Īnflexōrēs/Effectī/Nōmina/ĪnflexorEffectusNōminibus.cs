using System;
using System.Linq;
using System.Threading.Tasks.Task;

using Nūntiī.Nūntius;
using Miscella;
using Praebeunda.Multiplex;
using Praebeunda.Īnflectendum;
using Ēnumerātiōnēs;
using Īnflexōrēs.Effectī.Nōmina.NōminaGraeca;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

namespace Īnflexōrēs.Effectī.Nōmina
{
  [AsyncOverloads]
  public abstract partial class ĪnflexorEffectusNōminibus : ĪnflexorEffectusNōminibus<Īnflectendum.Nōmen>
  {
    public enum Versiō
    {
      Nōmen_Prīmum, Nōmen_Secundum_Masculīnum, Nōmen_Secundum_Neutrum, Nōmen_Secundum_Varium_Cum_Litterā_E,
      Nōmen_Secundum_Varium_Sine_Litterā_E, Nōmen_Tertium, Nōmen_Tertium_Neutrum,
      Nōmen_Tertium_Cum_Genitīvō_Variō, Nōmen_Tertium_Cum_Ablātīvō_Variō, Nōmen_Tertium_Cum_Genitīvō_Ablātīvōque_Variō,
      Nōmen_Tertium_Neutrum_Cum_Genitīvō_Variō, Nōmen_Tertium_Neutrum_Cum_Ablātīvō_Variō, Nōmen_Tertium_Neutrum_Cum_Genitīvō_Ablātīvōque_Variō,
      Nōmen_Quārtum, Nōmen_Quārtum_Varium, Nōmen_Quīntum
    }

    public static readonly Func<Versiō, Task<Lazy<ĪnflexorEffectusNōminibus?>>> Relātor = async versiō => versiō switch
    {
      Versiō.Nōmen_Prīmum => ĪnflexorEffectusPrīmusNōminibus.Faciendum,
      Versiō.Nōmen_Secundum_Masculīnum => ĪnflexorEffectusSecundusMasculīnusNōminibus.Faciendum,
      Versiō.Nōmen_Secundum_Neutrum => ĪnflexorEffectusSecundusNeuterNōminibus.Faciendum,
      Versiō.Nōmen_Secundum_Varium_Cum_Litterā_E => ĪnflexorEffectusSecundusVariusNōminibusCumLitterāE.Faciendum,
      Versiō.Nōmen_Secundum_Varium_Sine_Litterā_E => ĪnflexorEffectusSecundusVariusNōminibusSineLitterāE.Faciendum,
      Versiō.Nōmen_Tertium => ĪnflexorEffectusTertiusNōminibus.Faciendum,
      Versiō.Nōmen_Tertium_Neutrum => ĪnflexorEffectusTertiusNeuterNōminibus.Faciendum,
      Versiō.Nōmen_Tertium_Cum_Genitīvō_Variō => ĪnflexorEffectusTertiusNōminibusCumGenitīvōVariō.Faciendum,
      Versiō.Nōmen_Tertium_Cum_Ablātīvō_Variō => ĪnflexorEffectusTertiusNōminibusCumAblātīvōVariō.Faciendum,
      Versiō.Nōmen_Tertium_Cum_Genitīvō_Ablātīvōque_Variō => ĪnflexorEffectusTertiusNōminibusCumGenitīvōAblātīvōqueVariō.Faciendum,
      Versiō.Nōmen_Tertium_Neutrum_Cum_Genitīvō_Variō => ĪnflexorEffectusTertiusNeuterNōminibusCumGenitīvōVariō.Faciendum,
      Versiō.Nōmen_Tertium_Neutrum_Cum_Ablātīvō_Variō => ĪnflexorEffectusTertiusNeuterNōminibusCumAblātīvōVariō.Faciendum,
      Versiō.Nōmen_Tertium_Neutrum_Cum_Genitīvō_Ablātīvōque_Variō => ĪnflexorEffectusTertiusNeuterNōminibusCumGenitīvōAblātīvōqueVariō.Faciendum,
      Versiō.Nōmen_Quārtum => ĪnflexorEffectusQuārtusNōminibus.Faciendum,
      Versiō.Nōmen_Quārtum_Varium => ĪnflexorEffectusQuārtusVariusNōminibus.Faciendum,
      Versiō.Nōmen_Quīntum => ĪnflexorEffectusQuīntusNōminibus.Faciendum,
      _ => new Lazy(null),
    };

    protected ĪnflexorEffectusNōminibus(in Versiō versiō, in Lazy<Nūntius<ĪnflexorEffectusNōminibus>> nūntius,
                                        in Func<Īnflectendum.Nōmen, Enum[], string> rādīcātor)
                                           : base(versiō, nūntius, nameof(Īnflectendum.Nōmen.Nominātīvum), rādīcātor,
                                                  Ūtilitātēs.Combīnō(Casus.GetValues().Except(Casus.Dērēctus).ToSortedSet(),
                                                                     Numerālis.GetValues().Except(Numerālis.Nūllus).ToSortedSet()))
    { }

    public abstract string Singulāre(in Casus casus);
    public abstract string Plūrāle(in Casus casus);
    public sealed string? Suffixum(in Enum[] illa)
              => await(illa.FirstOf<Numerālis>(), illa.FirstOf<Casus>()) switch
              {
                var īnscītum when default(Numerālis).Equals(numerālis).Or(default(Casus).Equals(casus))
                                        => Task.FromResult<string?>(null),
                (Numerālis.Singulāris, _) => SingulāreAsync(casus),
                (Numerālis.Plūrālis, _) => PlūrāleAsync(casus)
              };
  }
}
