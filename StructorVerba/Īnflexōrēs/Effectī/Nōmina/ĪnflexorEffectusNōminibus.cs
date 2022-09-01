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
  [AsyncOverloads]
  public abstract partial class ĪnflexorEffectusNōminibus : ĪnflexorEffectusNōminibus<Īnflectendum.Nōmen>
  {
    public enum Versiō
    {
      Nōmen_Prīmus, Nōmen_Secundus_Masculīnus, Nōmen_Secundus_Neuter, Nōmen_Secundus_Varius_Cum_Litterā_Ē,
      Nōmen_Secundus_Varius_Sine_Litterā_Ē,  Nōmen_Tertius, Nōmen_Tertius_Neuter,
      Nōmen_Tertius_Cum_Genitīvō_Variō, Nōmen_Tertius_Cum_Ablātīvō_Variō, Nōmen_Tertius_Cum_Genitīvō_Ablātīvōque_Variō,
      Nōmen_Tertius_Neuter_Cum_Genitīvō_Variō, Nōmen_Tertius_Neuter_Cum_Ablātīvō_Variō, Nōmen_Tertius_Neuter_Cum_Genitīvō_Ablātīvōque_Variō,
      Nōmen_Quārtus, Nōmen_Quārtus_Varius, Nōmen_Quīntus, Nōmen_Graecus_Prīmus, Nōmen_Graecus_Prīmus_Cum_Litterā_Ē,
      Nōmen_Graecus_Prīmus_Cum_Litterīs_ĒS, Nōmen_Graecus_Prīmus_Cum_Litterīs_ĀS, Nōmen_Graecus_Secundus, Nōmen_Graecus_Tertius,
      Nōmen_Graecus_Tertius_Varius, Nōmen_Graecus_Quārtus
    }

    public static readonly Func<Versiō, Task<Lazy<ĪnflexorEffectusNōminibus?>>> Relātor = async versiō => versiō switch
    {
      Versiō.Nōmen_Prīmus => null,
      Versiō.Nōmen_Secundus_Masculīnus => null,
      Versiō.Nōmen_Secundus_Neuter => null,
      Versiō.Nōmen_Secundus_Varius_Cum_Litterā_Ē => null,
      Versiō.Nōmen_Secundus_Varius_Sine_Litterā_Ē => null,
      Versiō.Nōmen_Tertius => null,
      Versiō.Nōmen_Tertius_Neuter => null,
      Versio.Nōmen_Tertius_Cum_Genitīvō_Variō => null,
      Versiō.Nōmen_Tertius_Cum_Ablātīvō_Variō => null,
      Versiō.Nōmen_Tertius_Cum_Genitīvō_Ablātīvōque_Variō => null,
      Versiō.Nōmen_Tertius_Neuter_Cum_Genitīvō_Variō => null,
      Versiō.Nōmen_Tertius_Neuter_Cum_Ablātīvō_Variō => null,
      Versiō.Nōmen_Tertius_Neuter_Cum_Genitīvō_Ablātīvōque_Variō => null,
      Versiō.Nōmen_Quārtus => null,
      Versiō.Nōmen_Quārtus_Varius => null,
      Versiō.Nōmen_Quīntus => null,
      Versiō.Nōmen_Graecus_Prīmus => null,
      Versiō.Nōmen_Graecus_Prīmus_Cum_Litterā_Ē => null,
      Versiō.Nōmen_Graecus_Prīmus_Cum_Litterīs_ĒS => null,
      Versiō.Nōmen_Graecus_Prīmus_Cum_Litterīs_ĀS => null,
      Versiō.Nōmen_Graecus_Secundus => null,
      Versiō.Nōmen_Graecus_Tertius => null,
      Versiō.Nōmen_Graecus_Tertius_Varius => null,
      Versiō.Nōmen_Graecus_Quārtus => null,
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
