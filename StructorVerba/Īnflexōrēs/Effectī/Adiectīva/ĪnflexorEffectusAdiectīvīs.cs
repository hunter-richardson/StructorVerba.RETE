using System;
using System.Collections.Generic.HashSet;
using System.Threading.Tasks;
using System.Runtime.InteropServices.ComTypes;

using Miscella;
using Nūntiī.Nūntius;
using Praebeunda.Multiplex.Adiectīvum;
using Praebeunda.Īnflectendum.AdiectīvaAutPrīmaAutSecundaAutTertia;
using Pēnsōrēs.Īnflectenda.PēnsorAdiectīvīs.Versiō;
using Ēnumerātiōnēs;
using Īnflexōrēs.Effectī.Nōmina;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

namespace Īnflexōrēs.Effectī.Adiectīva
{
  [AsyncOverloads]
  public abstract partial class ĪnflexorEffectusAdiectīvīs<Hoc> : ĪnflexorEffectus<Hoc, Multiplex.Adiectīvum>
  {
    public static readonly Func<PēnsorAdiectīvīs.Versiō, Task<Lazy<ĪnflexorEffectusAdiectīvīs?>>> Relātor
              = async versiō => versiō switch
                                {
                                  Versiō.Aut_Prīmus_Aut_Secundus_Aut_Tertius
                                            => ĪnflexorEffectusAdiectīvīsAutPrīmusAutSecundusAutTertius.Faciendum,
                                  Versiō.Aut_Prīmus_Aut_Secundus_Aut_Tertius_Cum_Litterā_Ē
                                            => ĪnflexorEffectusAdiectīvīsAutPrīmusAutSecundusAutTertiusCumLitterāE.Faciendum,
                                  Versiō.Aut_Prīmus_Aut_Secundus_Aut_Tertius_Sine_Litterā_Ē
                                            => ĪnflexorEffectusAdiectīvīsAutPrīmusAutSecundusAutTertiusSineLitterāE.Faciendum,
                                  Versiō.Aut_Tertius_Aut_Prīmus_Aut_Secundus
                                            => ĪnflexorEffectusAdiectīvīsAutTertiusAutPrīmusAutSecundus.Faciendum,
                                  Versiō.Aut_Tertius_Aut_Prīmus_Aut_Secundus_Cum_Genitīvō_Variō
                                            => ĪnflexorEffectusAdiectīvīsAutTertiusAutPrīmusAutSecundusCumAblātīvōVariō.Faciendum,
                                  Versiō.Aut_Tertius_Aut_Prīmus_Aut_Secundus_Cum_Ablātīvō_Variō
                                            => ĪnflexorEffectusAdiectīvīsAutTertiusAutPrīmusAutSecundusCumGenitīvōAblātīvōqueVariō.Faciendum,
                                  Versiō.Aut_Tertius_Aut_Prīmus_Aut_Secundus_Cum_Genitīvō_Ablātīvōque_Variō
                                            => ĪnflexorEffectusAdiectīvīsAutTertiusAutPrīmusAutSecundusCumGenitīvōAblātīvōqueVariō.Faciendum,
                                  Versiō.Prōnōminālis => null,
                                  Versiō.Prōnōminālis_Cum_Litterā_Ē => null,
                                  Versiō.Prōnōminālis_Sine_Litterā_Ē => null,
                                  _ => new Lazy(null)
                                };

    protected ĪnflexorEffectusAdiectīvīs(in Lazy<Nūntius<ĪnflexorEffectusAdiectīvīs<Hoc>>> nūntius,
                                         in string quaerendī, in Func<Hoc, Enum[], string> rādīcātor)
                                            : this(versiō, nūntius, quaerendī, rādīcātor,
                                                   Ūtilitātēs.Combīnō(Gradus.GetValues().Except(default(Gradus)).ToHashSet(),
                                                                      Genus.GetValues().Except(default(Genus)).ToHashSet(),
                                                                      new HashSet<Casus>() { Casus.Nominātīvus, Casus.Genitīvus, Casus.Accusātīvus, Casus.Vocātīvus },
                                                                      Numerālis.GetValues().Except(default(Numerālis)).ToHashSet()),
                                                   Ūtilitātēs.Combīnō(Gradus.GetValues().Except(default(Gradus)).ToHashSet(),
                                                                      new HashSet<Casus>() { Casus.Ablātīvus, Casus.Locātīvus, Casus.Instrumentālis },
                                                                      Numerālis.Plūrālis.SingleItemSet()),
                                                   Ūtilitātēs.Combīnō(Gradus.GetValues().Except(default(Gradus)).ToHashSet(),
                                                                      Genus.GetValues().Except(default(Genus)).ToHashSet(),
                                                                      new HashSet<Casus>() { Casus.Ablātīvus, Casus.Locātīvus, Casus.Instrumentālis },
                                                                      Numerālis.Singulāris.SingleItemSet())) { }

    public abstract Lazy<ĪnflexorEffectusNōminibus>? Relātum(in Gradus gradus, in Genus genus);

    public virtual string Īnfīxum(in Gradus gradus, in Genus genus, in Numerālis numerālis, in Casus casus)
              => (gradus, genus, numerālis, casus) switch
                  {
                    (Gradus.Comparātīvus, Genus.Neutrum, Numerālis.Singulāris, Casus.Nominātīvus or Casus.Accusātīvus or Casus.Vocātīvus) => "ius",
                    (Gradus.Comparātīvus, _, Numerālis.Singulāris, Casus.Nominātīvus or Casus.Vocātīvus) => "ior",
                    (Gradus.Comparātīvus, _, _, _) => "iōr",
                    (_, _, _, _) => string.Empty
                  };

    public virtual string? Suffixum(in Enum[] illa)
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
        const ĪnflexorEffectusNōminibus? relātum = (await RelātumAsync(gradus, genus))?.Value;
        if(relātum is not null)
        {
          const string īnfixum = await ĪnfīxumAsync(gradus, genus, numerālis, casus),
                       suffixum = await relātum.SuffixumAsync(numerālis, casus);
          return (suffixum is not null).Choose((īnfixum)?.Concat(suffixum), null);
        }
        else
        {
          return null;
        }
      }
    }
  }
}
