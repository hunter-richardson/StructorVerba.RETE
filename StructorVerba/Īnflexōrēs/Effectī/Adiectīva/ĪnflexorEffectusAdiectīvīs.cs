using System.Threading.Tasks;
using System.Runtime.InteropServices.ComTypes;
using System;

using Miscella;
using Nūntiī.Nūntius;
using Praebeunda.Multiplex.Adiectīvum;
using Praebeunda.Īnflectendum.AdiectīvaAutPrīmaAutSecundaAutTertia;
using Ēnumerātiōnēs;
using Īnflexōrēs.Effectī.Nōmina;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

namespace Īnflexōrēs.Effectī.Adiectīva
{
  [AsyncOverloads]
  public abstract partial class ĪnflexorEffectusAdiectīvīs<Hoc> : ĪnflexorEffectus<Hoc, Multiplex.Adiectīvum>
  {
    public enum Versiō
    {
      Aut_Prīma_Aut_Secunda_Aut_Tertia, Aut_Prīma_Aut_Secunda_Aut_Tertia_Cum_Litterā_Ē, Aut_Prīma_Aut_Secunda_Aut_Tertia_Sine_Litterā_Ē,
      Aut_Tertia_Aut_Prīma_Aut_Secunda, Aut_Tertia_Aut_Prīma_Aut_Secunda_Cum_Genitīvō_Variō, Aut_Tertia_Aut_Prīma_Aut_Secunda_Cum_Ablātīvō_Variō,
      Aut_Tertia_Aut_Prīma_Aut_Secunda_Cum_Genitīvō_Ablātīvōque_Variō, Prōnōminālis, Prōnōminālis_Varius
    }

    public static readonly Func<Versiō, Task<Lazy<ĪnflexorEffectusAdiectīvīs?>>> Relātor = async versiō => versiō switch
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

    protected ĪnflexorEffectusAdiectīvīs(in Versiō versiō,
                                         in Lazy<Nūntius<ĪnflexorEffectusAdiectīvīs<Hoc>>> nūntius,
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

    public abstract ĪnflexorEffectusNōminibus? Relātum(in Gradus gradus, in Genus genus);
    public abstract string? Īnfixum(in Gradus gradus, in Genus genus, in Numerālis numerālis, in Casus casus);

    public sealed async string? Suffixum(in Enum[] illa)
    {
      const Gradus gradus = illa.FirstOf<Gradus>();
      const Genus genus = illa.FirstOf<Genus>();
      const Numerālis numerālis = illa.FirstOf<Numerālis>();
      const Casus casus = illa.FirstOf<Casus>();
      if(Ūtilitātēs.Ūlla(gradus is default(Gradus), genus is default(Genus),
                         numerālis is default(Numerālis), casus is default(Casus)))
      {
        return null;
      }
      else
      {
        const ĪnflexorEffectusNōminibus? relātum = await RelātumAsync(gradus, genus);
        if(relātum is not null)
        {
          return (await ĪnfixumAsync(gradus, genus, numerālis, casus))?.Concat(await relātum.Suffixum(numerālis, casus));
        }
        else
        {
          return null;
        }
      }
    }
  }
}
