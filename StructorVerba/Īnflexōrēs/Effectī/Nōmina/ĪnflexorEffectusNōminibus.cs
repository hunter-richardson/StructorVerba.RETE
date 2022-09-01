using System;
using System.Linq;
using System.Threading.Tasks.Task;

using Nūntiī.Nūntius;
using Miscella;
using Praebeunda.Multiplex;
using Praebeunda.Īnflectendum;
using Ēnumerātiōnēs;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

namespace Īnflexōrēs.Effectī.Nōmina
{
  public abstract partial class ĪnflexorEffectusNōminibus<Hoc> : ĪnflexorEffectus<Hoc, Multiplex.Nōmen>
  {
    protected ĪnflexorEffectusNōminibus(in Enum versiō,
                                        in Lazy<Nūntius<ĪnflexorEffectusNōminibus<Hoc>>> nūntius,
                                        in string quaerendī, in Func<Hoc, Enum[], string> rādīcātor,
                                        in params IEnumerable<Enum[]> illa)
                                         : base(versiō, nūntius, quaerendī, rādīcātor, illa) { }
  }

  [AsyncOverloads]
  public abstract partial class ĪnflexorEffectusNōminibus : ĪnflexorEffectusNōminibus<Īnflectendum.Nōmen>
  {
    public enum Versiō
    {
      Prīmus, Secundus_Masculīnus, Secundus_Neuter, Secundus_Varius_Cum_Litterā_Ē, Secundus_Varius_Sine_Litterā_Ē,  Tertius, Tertius_Neuter,
      Tertius_Cum_Genitīvō_Variō, Tertius_Cum_Ablātīvō_Variō, Tertius_Cum_Genitīvō_Ablātīvōque_Variō,
      Tertius_Neuter_Cum_Genitīvō_Variō, Tertius_Neuter_Cum_Ablātīvō_Variō, Tertius_Neuter_Cum_Genitīvō_Ablātīvōque_Variō,
      Quārtus, Quārtus_Varius, Quīntus, Graecus_Prīmus, Graecus_Prīmus_Cum_Litterā_Ē, Graecus_Prīmus_Cum_Litterīs_ĒS,
      Graecus_Prīmus_Cum_Litterīs_ĀS, Graecus_Secundus, Graecus_Tertius, Graecus_Tertius_Varius, Graecus_Quārtus
    }

    public static readonly Func<Versiō, Task<Lazy<ĪnflexorEffectusNōminibus?>>> Relātor = async versiō => versiō switch
    {
      Versiō.Prīmus => null,
      Versiō.Secundus_Masculīnus => null,
      Versiō.Secundus_Neuter => null,
      Versiō.Secundus_Varius_Cum_Litterā_Ē => null,
      Versiō.Secundus_Varius_Sine_Litterā_Ē => null,
      Versiō.Tertius => null,
      Versiō.Tertius_Neuter => null,
      Versio.Tertius_Cum_Genitīvō_Variō => null,
      Versiō.Tertius_Cum_Ablātīvō_Variō => null,
      Versiō.Tertius_Cum_Genitīvō_Ablātīvōque_Variō => null,
      Versiō.Tertius_Neuter_Cum_Genitīvō_Variō => null,
      Versiō.Tertius_Neuter_Cum_Ablātīvō_Variō => null,
      Versiō.Tertius_Neuter_Cum_Genitīvō_Ablātīvōque_Variō => null,
      Versiō.Quārtus => null,
      Versiō.Quārtus_Varius => null,
      Versiō.Quīntus => null,
      Versiō.Graecus_Prīmus => null,
      Versiō.Graecus_Prīmus_Cum_Litterā_Ē => null,
      Versiō.Graecus_Prīmus_Cum_Litterīs_ĒS => null,
      Versiō.Graecus_Prīmus_Cum_Litterīs_ĀS => null,
      Versiō.Graecus_Secundus => null,
      Versiō.Graecus_Tertius => null,
      Versiō.Graecus_Tertius_Varius => null,
      Versiō.Graecus_Quārtus => null,
      _ => new Lazy(null),
    };

    protected ĪnflexorEffectusNōminibus(in Versiō versiō, in Lazy<Nūntius<ĪnflexorEffectusNōminibus>> nūntius,
                                        in Func<Īnflectendum.Nōmen, Enum[], string> rādīcātor)
                                           : base(versiō, nūntius, nameof(Īnflectendum.Nōmen.Nominātīvum), rādīcātor,
                                                  Ūtilitātēs.Combīnō(Casus.GetValues().Except(Casus.Dērēctus).ToSortedSet(),
                                                                 Numerālis.GetValues().Except(Numerālis.Nūllus).ToSortedSet())) { }

    public abstract string? Singulāre(in Casus casus);
    public abstract string? Plūrāle(in Casus casus);
    public sealed string? Suffixum(in Enum[] illa)
    {
      const Casus casus = Casūs.Iactor.Invoke((from illud in illa
                                               where illud is Casus
                                               select illud).First());
      const Numerālis numerālis = Numerālēs.Iactor.Invoke((from illud in illla
                                                           where illud is Numerālis
                                                           select illud).First());
      return await (numerālis, casus) switch
      {
        var īnscītum when default(Numerālis).Equals(numerālis).Or(default(Casus).Equals(casus))
                                => Task.CompletedTask,
        (Numerālis.Singulāris, _) => SingulāreAsync(casus),
        (Numerālis.Plūrālis, _) => PlūrāleAsync(casus)
      };
    }
  }
}
