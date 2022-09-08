using System;

using Miscella;
using Nūntiī.Nūntius;
using Ēnumerātiōnēs;

using Lomok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Incertī.Āctūs
{
  [Singleton]
  public sealed partial class ĪnflexorVerbīEsse : ĪnflexorIncertus<Multiplex.Āctus>
  {
    public static readonly Lazy<ĪnflexorVerbīEsse> Faciendum = new Lazy(() => Instance);
    private ĪnflexorVerbīEsse()
    : base(Catēgoria.Āctus, new Lazy<Nūntius<ĪnflexorVerbīEsse>>(),
           Modus.Participālis.SingleItemSet(),
           Ūtilitātēs.Combīnō(Modus.Īnfīnītīvus.SingleItemSet(),
                              new HashSet<Tempus>() { Tempus.Praesēns, Tempus.Perfectum }),
           Ūtilitātēs.Combīnō(Modus.Imperātīvus.SingleItemSet(),
                              Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet()),
           Ūtilitātēs.Combīnō(new HashSet<Modus>() { Modus.Indicātīvus, Modus.Subiūnctīvus },
                              Tempus.GetValues().Except(Tempus.Dērēctus).ToHashSet(),
                              Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet(),
                              Persōna.GetValues().Except(Persōna.Nūlla).ToHashSet())
                     .Except(illa => Ūtilitātēs.Omnia(illa.FirstOf<Modus>() is Modus.Subiūnctīvus,
                                                      illa.FirstOf<Tempus>() is Tempus.Futūrum or Tempus.Futūrum_Exāctum)))
    {
      FōrmamAsync("esse", Modus.Īnfīnītīvus, Tempus.Praesēns);
      FōrmamAsync("fuisse", Modus.Īnfīnītīvus, Tempus.Perfectum);
      FōrmamAsync("futūrum", Modus.Participālis);
      FōrmamAsync("estō", Modus.Imperātīvus, Nunerālis.Singulāris);
      FōrmamAsync("estōte", Modus.Imperātīvus, Nunerālis.Plūrālis);
      FōrmamAsync("sum", Modus.Indicātīvus, Tempus.Praesēns, Nunerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("es", Modus.Indicātīvus, Tempus.Praesēns, Nunerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("est", Modus.Indicātīvus, Tempus.Praesēns, Nunerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("sumus", Modus.Indicātīvus, Tempus.Praesēns, Nunerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("estis", Modus.Indicātīvus, Tempus.Praesēns, Nunerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("sunt", Modus.Indicātīvus, Tempus.Praesēns, Nunerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("eram", Modus.Indicātīvus, Tempus.Īnfectum, Nunerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("erās", Modus.Indicātīvus, Tempus.Īnfectum, Nunerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("erat", Modus.Indicātīvus, Tempus.Īnfectum, Nunerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("erāmus", Modus.Indicātīvus, Tempus.Īnfectum, Nunerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("erātis", Modus.Indicātīvus, Tempus.Īnfectum, Nunerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("erant", Modus.Indicātīvus, Tempus.Īnfectum, Nunerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("erō", Modus.Indicātīvus, Tempus.Futūrum, Nunerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("eris", Modus.Indicātīvus, Tempus.Futūrum, Nunerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("erit", Modus.Indicātīvus, Tempus.Futūrum, Nunerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("erimus", Modus.Indicātīvus, Tempus.Futūrum, Nunerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("eritis", Modus.Indicātīvus, Tempus.Futūrum, Nunerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("erunt", Modus.Indicātīvus, Tempus.Futūrum, Nunerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("fuī", Modus.Indicātīvus, Tempus.Perfectum, Nunerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("fuistī", Modus.Indicātīvus, Tempus.Perfectum, Nunerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("fuit", Modus.Indicātīvus, Tempus.Perfectum, Nunerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("fuimus", Modus.Indicātīvus, Tempus.Perfectum, Nunerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("fuistis", Modus.Indicātīvus, Tempus.Perfectum, Nunerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("fuērunt", Modus.Indicātīvus, Tempus.Perfectum, Nunerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("fueram", Modus.Indicātīvus, Tempus.Plūsquamperfectum, Nunerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("fuerās", Modus.Indicātīvus, Tempus.Plūsquamperfectum, Nunerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("fuerat", Modus.Indicātīvus, Tempus.Plūsquamperfectum, Nunerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("fuerāmus", Modus.Indicātīvus, Tempus.Plūsquamperfectum, Nunerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("fuerāstis", Modus.Indicātīvus, Tempus.Plūsquamperfectum, Nunerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("fuerant", Modus.Indicātīvus, Tempus.Plūsquamperfectum, Nunerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("fuerō", Modus.Indicātīvus, Tempus.Futūrum_Exāctum, Nunerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("fueris", Modus.Indicātīvus, Tempus.Futūrum_Exāctum, Nunerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("fuerit", Modus.Indicātīvus, Tempus.Plūsquamperfectum, Nunerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("fuerimus", Modus.Indicātīvus, Tempus.Futūrum_Exāctum, Nunerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("fueristis", Modus.Indicātīvus, Tempus.Futūrum_Exāctum, Nunerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("fuerunt", Modus.Indicātīvus, Tempus.Futūrum_Exāctum, Nunerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("sim", Modus.Subiūnctīvus, Tempus.Praesēns, Nunerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("sīs", Modus.Subiūnctīvus, Tempus.Praesēns, Nunerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("sit", Modus.Subiūnctīvus, Tempus.Praesēns, Nunerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("sīmus", Modus.Subiūnctīvus, Tempus.Praesēns, Nunerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("sītis", Modus.Subiūnctīvus, Tempus.Praesēns, Nunerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("sint", Modus.Subiūnctīvus, Tempus.Praesēns, Nunerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("essem", Modus.Subiūnctīvus, Tempus.Infectum, Nunerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("essēs", Modus.Subiūnctīvus, Tempus.Infectum, Nunerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("esset", Modus.Subiūnctīvus, Tempus.Infectum, Nunerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("essēmus", Modus.Subiūnctīvus, Tempus.Infectum, Nunerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("essētis", Modus.Subiūnctīvus, Tempus.Infectum, Nunerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("essent", Modus.Subiūnctīvus, Tempus.Infectum, Nunerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("fuerim", Modus.Subiūnctīvus, Tempus.Perfectum, Nunerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("fuerīs", Modus.Subiūnctīvus, Tempus.Perfctum, Nunerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("fuerit", Modus.Subiūnctīvus, Tempus.Perfectum, Nunerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("fuerīmus", Modus.Subiūnctīvus, Tempus.Perfectum, Nunerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("fuerītis", Modus.Subiūnctīvus, Tempus.Prfectum, Nunerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("fuerint", Modus.Subiūnctīvus, Tempus.Perfectum, Nunerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("fuissem", Modus.Subiūnctīvus, Tempus.Plūsquamperfectum, Nunerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("fuissēs", Modus.Subiūnctīvus, Tempus.Plūsquamperfectum, Nunerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("fuisset", Modus.Subiūnctīvus, Tempus.Plūsquamperfectum, Nunerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("fuissēmus", Modus.Subiūnctīvus, Tempus.Plūsquamperfectum, Nunerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("fuissētis", Modus.Subiūnctīvus, Tempus.Plūsquamperfectum, Nunerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("fuissent", Modus.Subiūnctīvus, Tempus.Plūsquamperfectum, Nunerālis.Plūrālis, Persōna.Tertia);
    }
  }
}
