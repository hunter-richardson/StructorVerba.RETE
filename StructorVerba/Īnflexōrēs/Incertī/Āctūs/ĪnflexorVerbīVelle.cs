using System;
using System.Collections.Generic.HashSet;

using Miscella;
using Nūntiī.Nūntius;
using Ēnumerātiōnēs;

using Lomok.NET.PropertyGenerators.LazyAttribute;

namespace Īnflexōrēs.Incertī.Āctūs
{
  [Lazy]
  public sealed partial class ĪnflexorVerbīVelle : ĪnflexorIncertus<Multiplex.Āctus>
  {
    private ĪnflexorVerbīVelle()
        : base(Catēgoria.Āctus, new Lazy<Nūntius<ĪnflexorVerbīVelle>>(), Modus.Participālis.SingleItemSet(),
               Ūtilitātēs.Combīnō(Modus.Īnfīnītīvus.SingleItemSet(),
                                  new HashSet<Tempus>() { Tempus.Praesēns, Tempus.Perfectum }),
               Ūtilitātēs.Combīnō(new HashSet<Modus>() { Modus.Indicātīvus, Modus.Subiūnctīvus },
                                  Tempus.GetValues().Except(Tempus.Intemporāle).ToHashSet(),
                                  Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet(),
                                  Persōna.GetValues().Except(Persōna.Nūlla).ToHashSet())
                         .Except(illa => Ūtilitātēs.Omnia(illa.FirstOf<Modus>() is Modus.Subiūnctīvus,
                                                          illa.FirstOf<Tempus>() is Tempus.Futūrum or Tempus.Futūrum_Exāctum)))
    {
      FōrmamAsync("velle", Modus.Īnfīnītīvus, Tempus.Praesēns);
      FōrmamAsync("voluisse", Modus.Īnfīnītīvus, Tempus.Perfectum);
      FōrmamAsync("volēns", Modus.Participālis);

      FōrmamAsync("volō", Modus.Indicātīvus, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("vīs", Modus.Indicātīvus, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("vult", Modus.Indicātīvus, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("volumus", Modus.Indicātīvus, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("vultis", Modus.Indicātīvus, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("volunt", Modus.Indicātīvus, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("volēbam", Modus.Indicātīvus, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("volēbās", Modus.Indicātīvus, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("volēbat", Modus.Indicātīvus, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("volēbāmus", Modus.Indicātīvus, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("volēbātis", Modus.Indicātīvus, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("volēbant", Modus.Indicātīvus, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("volam", Modus.Indicātīvus, Tempus.Futūrum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("volēs", Modus.Indicātīvus, Tempus.Futūrum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("volet", Modus.Indicātīvus, Tempus.Futūrum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("volēmus", Modus.Indicātīvus, Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("volētis", Modus.Indicātīvus, Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("volunt", Modus.Indicātīvus, Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("voluī", Modus.Indicātīvus, Tempus.Perfectum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("voluistī", Modus.Indicātīvus, Tempus.Perfectum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("voluit", Modus.Indicātīvus, Tempus.Perfectum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("voluimus", Modus.Indicātīvus, Tempus.Perfectum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("voluitis", Modus.Indicātīvus, Tempus.Perfectum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("voluērunt", Modus.Indicātīvus, Tempus.Perfectum, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("volueram", Modus.Indicātīvus, Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("voluerās", Modus.Indicātīvus, Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("voluerat", Modus.Indicātīvus, Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("voluerāmus", Modus.Indicātīvus, Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("voluerātis", Modus.Indicātīvus, Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("voluerant", Modus.Indicātīvus, Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("voluerō", Modus.Indicātīvus, Tempus.Futūrum_Exāctum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("volueris", Modus.Indicātīvus, Tempus.Futūrum_Exāctum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("voluerit", Modus.Indicātīvus, Tempus.Futūrum_Exāctum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("voluerimus", Modus.Indicātīvus, Tempus.Futūrum_Exāctum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("volueritis", Modus.Indicātīvus, Tempus.Futūrum_Exāctum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("voluerint", Modus.Indicātīvus, Tempus.Futūrum_Exāctum, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("velim", Modus.Subiūnctīvus, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("velīs", Modus.Subiūnctīvus, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("velit", Modus.Subiūnctīvus, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("velīmus", Modus.Subiūnctīvus, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("velītis", Modus.Subiūnctīvus, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("velint", Modus.Subiūnctīvus, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("vellem", Modus.Subiūnctīvus, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("vellēs", Modus.Subiūnctīvus, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("vellet", Modus.Subiūnctīvus, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("vellēmus", Modus.Subiūnctīvus, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("vellētis", Modus.Subiūnctīvus, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("vellent", Modus.Subiūnctīvus, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("voluerim", Modus.Subiūnctīvus, Tempus.Perfectum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("voluerīs", Modus.Subiūnctīvus, Tempus.Perfectum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("voluerit", Modus.Subiūnctīvus,  Tempus.Perfectum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("voluerīmus", Modus.Subiūnctīvus, Tempus.Perfectum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("voluerītis", Modus.Subiūnctīvus, Tempus.Perfectum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("voluerint", Modus.Subiūnctīvus, Tempus.Perfectum, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("voluissem", Modus.Subiūnctīvus, Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("voluissēs", Modus.Subiūnctīvus, Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("voluisset", Modus.Subiūnctīvus, Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("voluissēmus", Modus.Subiūnctīvus, Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("voluissētis", Modus.Subiūnctīvus, Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("voluissent", Modus.Subiūnctīvus, Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Tertia);

      Nūntius.PlūsGarriōAsync("Fīō");
    }
  }
}
