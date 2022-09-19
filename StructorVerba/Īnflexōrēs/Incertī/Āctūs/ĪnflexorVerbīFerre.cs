using System;
using System.Collections.Generic.HashSet;

using Miscella;
using Nūntiī.Nūntius;
using Ēnumerātiōnēs;

using Lomok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Incertī.Āctūs
{
  [Singleton]
  public sealed partial class ĪnflexorVerbīFerre : ĪnflexorIncertus<Multiplex.Āctus>
  {
    public static readonly Lazy<ĪnflexorVerbīFerre> Faciendum = new Lazy(() => Instance);
    private ĪnflexorVerbīFerre()
        : base(Catēgoria.Āctus, new Lazy<Nūntius<ĪnflexorVerbīFerre>>(),
               Ūtilitātēs.Combīnō(Modus.Īnfīnītīvus.SingleItemSet(), Vōx.Āctīva.SingleItemSet(),
                                  new HashSet<Tempus>() { Tempus.Praesēns, Tempus.Perfectum }),
               Ūtilitātēs.Combīnō(Modus.Īnfīnītīvus.SingleItemSet(), Vōx.Passīva.SingleItemSet()),
               Ūtilitātēs.Combīnō(Modus.Participālis.SingleItemSet(), Tempus.Futūrum.SingleItemSet(),
                                  Vōx.GetValues().Except(Vōx.Nūlla).ToHashSet()),
               Ūtilitātēs.Combīnō(Modus.Participālis.SingleItemSet(),
                                  new HashSet<Tempus>() { Tempus.Praesēns, Tempus.Perfectum }),
               Ūtilitātēs.Combīnō(Modus.Imperātīvus.SingleItemSet(), Vōx.GetValues().Except(Vōx.Nūlla).ToHashSet(),
                                  Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet(),
                                  new HashSet<Tempus>() { Tempus.Praesēns, Tempus.Futūrum }),
                Ūtilitātēs.Combīnō(new HashSet<Modus>() { Modus.Indicātīvus, Modus.Subiūnctīvus },
                                   Tempus.GetValues().Except(Tempus.Dērēctus).ToHashSet(),
                                   Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet(),
                                   Persōna.GetValues().Except(Persōna.Nūlla).ToHashSet())
                          .Except(illa => Ūtilitātēs.Omnia(illa.FirstOf<Modus>() is Modus.Subiūnctīvus,
                                                           illa.FirstOf<Tempus>() is Tempus.Futūrum or Tempus.Futūrum_Exāctum)))
    {
      FōrmamAsync("ferre", Modus.Īnfīnītīvus, Vōx.Āctīva, Tempus.Praesēns);
      FōrmamAsync("tulisse", Modus.Īnfīnītīvus, Vōx.Āctīva, Tempus.Perfectum);
      FōrmamAsync("ferrī", Modus.Īnfīnītīvus, Vōx.Passīva);
      FōrmamAsync("ferēns", Modus.Participālis, Vōx.Āctīva, Tempus.Praesēns);
      FōrmamAsync("lātūrum", Modus.Participālis, Vōx.Āctīva, Tempus.Futūrum);
      FōrmamAsync("ferendum", Modus.Participālis, Vōx.Passīva, Tempus.Futūrum);
      FōrmamAsync("lātum", Modus.Participālis, Vōx.Passīva, Tempus.Perfectum);

      FōrmamAsync("fer", Modus.Imperātīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Singulāris);
      FōrmamAsync("ferte", Modus.Imperātīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Plūrālis);
      FōrmamAsync("fertō", Modus.Imperātīvus, Vōx.Āctīva, Tempus.Futūrum, Numerālis.Singulāris);
      FōrmamAsync("fertōte", Modus.Imperātīvus, Vōx.Āctīva, Tempus.Futūrum, Numerālis.Plūrālis);
      FōrmamAsync("ferre", Modus.Imperātīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Singulāris);
      FōrmamAsync("feriminī", Modus.Imperātīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Plūrālis);
      FōrmamAsync("fertor", Modus.Imperātīvus, Vōx.Passīva, Tempus.Futūrum, Numerālis.Singulāris);
      FōrmamAsync("feruntor", Modus.Imperātīvus, Vōx.Passīva, Tempus.Futūrum, Numerālis.Plūrālis);

      FōrmamAsync("ferō", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("fers", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("fert", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("ferimus", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("fertis", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("ferunt", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("ferēbam", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("ferēbās", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("ferēbat", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("ferēbāmus", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("ferēbātis", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("ferēbant", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("feram", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("ferēs", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("feret", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("ferēmus", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("ferētis", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum, Numerālis.Plūrālis, Persona.Secunda);
      FōrmamAsync("ferent", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("tulī", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("tulistī", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("tulit", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("tulimus", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("tulistis", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("tulērunt", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("tuleram", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("tulerās", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("tulerat", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("tulerāmus", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("tulerātis", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("tulerant", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("tulerō", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum_Exāctum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("tuleris", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum_Exāctum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("tulerit", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum_Exāctum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("tulerimus", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum_Exāctum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("tuleritis", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum_Exāctum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("tulerunt", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum_Exāctum, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("feror", Modus.Indicātīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("ferris", Modus.Indicātīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("fertur", Modus.Indicātīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("ferimur", Modus.Indicātīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("feriminī", Modus.Indicātīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("feruntur", Modus.Indicātīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("ferēbar", Modus.Indicātīvus, Vōx.Passīva, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("ferēbāris", Modus.Indicātīvus, Vōx.Passīva, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("ferēbātur", Modus.Indicātīvus, Vōx.Passīva, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("ferēbāmur", Modus.Indicātīvus, Vōx.Passīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("ferēbāminī", Modus.Indicātīvus, Vōx.Passīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("ferēbantur", Modus.Indicātīvus, Vōx.Passīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("ferar", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("ferēris", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("ferētur", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("ferēmur", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("ferēminī", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("ferentur", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("feram", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("ferās", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("ferat", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("ferāmus", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("ferātis", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("ferant", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("ferrem", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("ferrēs", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("ferret", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("ferrēmus", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("ferrētis", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("ferrent", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("tulerim", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("tulerīs", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("tulerit", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("tulerīmus", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("tulerītis", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("tulerint", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("tulissem", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("tulissēs", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("tulisset", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("tulissēmus", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("tulissētis", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("tulissent", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("ferar", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("ferāris", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("ferātur", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("ferāmur", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("ferāminī", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("ferantur", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("ferrer", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("ferrēris", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("ferrētur", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("ferrēmur", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("ferrēminī", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("ferrentur", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Tertia);

      Nūntius.PlūsGarriōAsync("Fīō");
    }
  }
}
