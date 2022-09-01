using System.Threading.Tasks;
using System.Runtime.InteropServices.ComTypes;
using System;

using Miscella;
using Nūntiī.Nūntius;
using Praebeunda.Multiplex.Adiectīvum;
using Praebeunda.Īnflectendum.AdiectīvaAutPrīmaAutSecundaAutTertia;
using Ēnumerātiōnēs;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

namespace Īnflexōrēs.Effectī.Adiectīva
{
  [AsyncOverloads]
  public abstract partial class ĪnflexōrēsEffectusAdiectīvīs<Hoc> : ĪnflexorEffectus<Hoc, Multiplex.Adiectīvum>
  {
    public enum Versiō
    {
      Aut_Prīma_Aut_Secunda_Aut_Tertia, Aut_Prīma_Aut_Secunda_Aut_Tertia_Cum_Litterā_Ē, Aut_Prīma_Aut_Secunda_Aut_Tertia_Sine_Litterā_Ē,
      Aut_Tertia_Aut_Prīma_Aut_Secunda, Aut_Tertia_Aut_Prīma_Aut_Secunda_Cum_Genitīvō_Variō, Aut_Tertia_Aut_Prīma_Aut_Secunda_Cum_Ablātīvō_Variō,
      Aut_Tertia_Aut_Prīma_Aut_Secunda_Cum_Genitīvō_Ablātīvōque_Variō, Prōnōminālis, Prōnōminālis_Varius
    }

    public static readonly Func<Versiō, Task<Lazy<ĪnflexōrēsEffectusAdiectīvīs?>>> Relātor = async versiō => versiō switch
    {
      Versiō.Aut_Prīma_Aut_Secunda_Aut_Tertia => null,
      Versiō.Aut_Prīma_Aut_Secunda_Aut_Tertia_Cum_Litterā_Ē => null,
      Versiō.Aut_Prīma_Aut_Secunda_Aut_Tertia_Sine_Litterā_Ē => null,
      Versiō.Aut_Tertia_Aut_Prīma_Aut_Secunda => null,
      Versiō.Aut_Tertia_Aut_Prīma_Aut_Secunda_Cum_Genitīvō_Variō => null,
      Versiō.Aut_Tertia_Aut_Prīma_Aut_Secunda_Cum_Ablātīvō_Variō => null,
      Versiō.Aut_Tertia_Aut_Prīma_Aut_Secunda_Cum_Genitīvō_Ablātīvōque_Variō => null,
       _ => new Lazy(null)
    };

    protected ĪnflexōrēsEffectusAdiectīvīs(in Versiō versiō,
                                           in Lazy<Nūntius<ĪnflexōrēsEffectīAdiectīvīs<Hoc>>> nūntius,
                                           in string quaerendī, in Func<Hoc, Enum[], string> rādīcātor,
                                           in params IEnumerable<Enum[]> illa)
                                            : base(versiō, nūntius, quaerendī, rādīcātor, illa) { }

    protected ĪnflexōrēsEffectusAdiectīvīs(in Versiō versiō,
                                           in Lazy<Nūntius<ĪnflexōrēsEffectīAdiectīvīs<Hoc>>> nūntius,
                                           in string quaerendī, in Func<Hoc, Enum[], string> rādīcātor)
                                            : this(versiō, nūntius, quaerendī, rādīcātor,
                                                   Ūtilitātēs.Combīnō(Gradus.GetValues().Except(default(Gradus)).ToHashSet(),
                                                                      Genus.GetValues().Except(default(Genus)).ToHashSet(),
                                                                      new SortedSet<Casus>() { Casus.Nominātīvus, Casus.Genitīvus, Casus.Accusātīvus, Casus.Vocātīvus },
                                                                      Numerālis.GetValues().Except(default(Numerālis)).ToHashSet()),
                                                   Ūtilitātēs.Combīnō(Gradus.GetValues().Except(default(Gradus)).ToHashSet(),
                                                                      new SortedSet<Casus>() { Casus.Ablātīvus, Casus.Locātīvus, Casus.Instrumentālis },
                                                                      Numerālis.Plūrālis.SingleItemSet()),
                                                   Ūtilitātēs.Combīnō(Gradus.GetValues().Except(default(Gradus)).ToHashSet(),
                                                                      Genus.GetValues().Except(default(Genus)).ToHashSet(),
                                                                      new SortedSet<Casus>() { Casus.Ablātīvus, Casus.Locātīvus, Casus.Instrumentālis },
                                                                      Numerālis.Singulāris.SingleItemSet())) { }

    public abstract string? NeutrumPositīvumSingulāre(in Casus casus);
    public abstract string? NeutrumPositīvumPlūrāle(in Casus casus);
    public abstract string? MasculīnumPositīvumSingulāre(in Casus casus);
    public abstract string? MasculīnumPositīvumPlūrāle(in Casus casus);
    public abstract string? FēminīnumPositīvumSingulāre(in Casus casus);
    public abstract string? FēminīnumPositīvumPlūrāle(in Casus casus);
    public abstract string? NeutrumComparātīvumSingulāre(in Casus casus);
    public abstract string? NeutrumComparātīvumPlūrāle(in Casus casus);
    public abstract string? MasculīnumComparātīvumSingulāre(in Casus casus);
    public abstract string? MasculīnumComparātīvumPlūrāle(in Casus casus);
    public abstract string? FēminīnumComparātīvumSingulāre(in Casus casus);
    public abstract string? FēminīnumComparātīvumPlūrāle(in Casus casus);
    public abstract string? NeutrumSuperlātīvumSingulāre(in Casus casus);
    public abstract string? NeutrumSuperlātīvumPlūrāle(in Casus casus);
    public abstract string? MasculīnumSuperlātīvumSingulāre(in Casus casus);
    public abstract string? MasculīnumSuperlātīvumPlūrāle(in Casus casus);
    public abstract string? FēminīnumSuperlātīvumSingulāre(in Casus casus);
    public abstract string? FēminīnumSuperlātīvumPlūrāle(in Casus casus);
    public sealed string? Suffixum(in Enum[] illa)
    {
      const Gradus gradus = Gradūs.Iactor.Invoke((from illud in illa
                                                  where illud is Gradus
                                                  select illud).First());
      const Genus genus = Genera.Iactor.Invoke((from illud in illa
                                                where illud is Genus
                                                select illud).First());
      const Casus casus = Casūs.Iactor.Invoke((from illud in illa
                                               where illud is Casus
                                               select illud).First());
      const Numerālis numerālis = Numerālēs.Iactor.Invoke((from illud in illla
                                                           where illud is Numerālis
                                                           select illud).First());
      return await (gradus, genus, numerālis, casus) switch
      {
        var īnscītum when Ūtilitātēs.Seriēs(gradus, genus, numerālis, casus)
                                    .ContainsAny(default(Gradus), default(Genus), default(Numerālis), default(Casus))
                                                                  => Task.CompletedTask,
        (Genus.Neutrum, Gradus.Positīvus, Numerālis.Singulāris, _) => NeutrumPositīvumSingulāreAsync(casus),
        (Genus.Neutrum, Gradus.Positīvus, Numerālis.Plūrālis, _) => NeutrumPositīvumPlūrāleAsync(casus),
        (Genus.Masculīnum, Gradus.Positīvus, Numerālis.Singulāris, _) => MasculīnumPositīvumSingulāreAsync(casus),
        (Genus.Masculīnum, Gradus.Positīvus, Numerālis.Plūrālis, _) => MasculīnumPositīvumPlūrāleAsync(casus),
        (Genus.Fēminīnum, Gradus.Positīvus, Numerālis.Singulāris, _) => FēminīnumPositīvumSingulāreAsync(casus),
        (Genus.Fēminīnum, Gradus.Positīvus, Numerālis.Plūrālis, _) => FēminīnumPositīvumPlūrāleAsync(casus),
        (Genus.Neutrum, Gradus.Comparātīvus, Numerālis.Singulāris, _) => NeutrumComparātīvumSingulāreAsync(casus),
        (Genus.Neutrum, Gradus.Comparātīvus, Numerālis.Plūrālis, _) => NeutrumComparātīvumPlūrāleAsync(casus),
        (Genus.Masculīnum, Gradus.Comparātīvus, Numerālis.Singulāris, _) => MasculīnumComparātīvumSingulāreAsync(casus),
        (Genus.Masculīnum, Gradus.Comparātīvus, Numerālis.Plūrālis, _) => MasculīnumComparātīvumPlūrāleAsync(casus),
        (Genus.Fēminīnum, Gradus.Comparātīvus, Numerālis.Singulāris, _) => FēminīnumComparātīvumSingulāreAsync(casus),
        (Genus.Fēminīnum, Gradus.Comparātīvus, Numerālis.Plūrālis, _) => FēminīnumComparātīvumPlūrāleAsync(casus),
        (Genus.Neutrum, Gradus.Superlātīvus, Numerālis.Singulāris, _) => NeutrumSuperlātīvumSingulāreAsync(casus),
        (Genus.Neutrum, Gradus.Superlātīvus, Numerālis.Plūrālis, _) => NeutrumSuperlātīvumPlūrāleAsync(casus),
        (Genus.Masculīnum, Gradus.Superlātīvus, Numerālis.Singulāris, _) => MasculīnumSuperlātīvumSingulāreAsync(casus),
        (Genus.Masculīnum, Gradus.Superlātīvus, Numerālis.Plūrālis, _) => MasculīnumSuperlātīvumPlūrāleAsync(casus),
        (Genus.Fēminīnum, Gradus.Superlātīvus, Numerālis.Singulāris, _) => FēminīnumSuperlātīvumSingulāreAsync(casus),
        (Genus.Fēminīnum, Gradus.Superlātīvus, Numerālis.Plūrālis, _) => FēminīnumSuperlātīvumPlūrāleAsync(casus),
        _ => null
      };
    }
  }
}
