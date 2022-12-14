using System;
using System.Collections.Generic.HashSet;

using Miscella;
using Nūntiī.Nūntius;
using Ēnumerātiōnēs;

using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Īnflexōrēs.Incertī.Āctūs
{
  [Lazy]
  public sealed partial class ĪnflexorVerbīEsse : ĪnflexorIncertus<Multiplex.Āctus>
  {
    private ĪnflexorVerbīEsse()
    : base(Catēgoria.Āctus, new Lazy<Nūntius<ĪnflexorVerbīEsse>>(), Modus.Participālis.SingleItemSet(),
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

      FōrmamAsync("sum", Modus.Indicātīvus, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("es", Modus.Indicātīvus, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("est", Modus.Indicātīvus, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("sumus", Modus.Indicātīvus, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("estis", Modus.Indicātīvus, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("sunt", Modus.Indicātīvus, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("eram", Modus.Indicātīvus, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("erās", Modus.Indicātīvus, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("erat", Modus.Indicātīvus, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("erāmus", Modus.Indicātīvus, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("erātis", Modus.Indicātīvus, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("erant", Modus.Indicātīvus, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("erō", Modus.Indicātīvus, Tempus.Futūrum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("eris", Modus.Indicātīvus, Tempus.Futūrum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("erit", Modus.Indicātīvus, Tempus.Futūrum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("erimus", Modus.Indicātīvus, Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("eritis", Modus.Indicātīvus, Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("erunt", Modus.Indicātīvus, Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("fuī", Modus.Indicātīvus, Tempus.Perfectum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("fuistī", Modus.Indicātīvus, Tempus.Perfectum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("fuit", Modus.Indicātīvus, Tempus.Perfectum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("fuimus", Modus.Indicātīvus, Tempus.Perfectum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("fuistis", Modus.Indicātīvus, Tempus.Perfectum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("fuērunt", Modus.Indicātīvus, Tempus.Perfectum, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("fueram", Modus.Indicātīvus, Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("fuerās", Modus.Indicātīvus, Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("fuerat", Modus.Indicātīvus, Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("fuerāmus", Modus.Indicātīvus, Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("fuerāstis", Modus.Indicātīvus, Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("fuerant", Modus.Indicātīvus, Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("fuerō", Modus.Indicātīvus, Tempus.Futūrum_Exāctum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("fueris", Modus.Indicātīvus, Tempus.Futūrum_Exāctum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("fuerit", Modus.Indicātīvus, Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("fuerimus", Modus.Indicātīvus, Tempus.Futūrum_Exāctum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("fueristis", Modus.Indicātīvus, Tempus.Futūrum_Exāctum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("fuerunt", Modus.Indicātīvus, Tempus.Futūrum_Exāctum, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("sim", Modus.Subiūnctīvus, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("sīs", Modus.Subiūnctīvus, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("sit", Modus.Subiūnctīvus, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("sīmus", Modus.Subiūnctīvus, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("sītis", Modus.Subiūnctīvus, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("sint", Modus.Subiūnctīvus, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("essem", Modus.Subiūnctīvus, Tempus.Infectum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("essēs", Modus.Subiūnctīvus, Tempus.Infectum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("esset", Modus.Subiūnctīvus, Tempus.Infectum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("essēmus", Modus.Subiūnctīvus, Tempus.Infectum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("essētis", Modus.Subiūnctīvus, Tempus.Infectum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("essent", Modus.Subiūnctīvus, Tempus.Infectum, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("fuerim", Modus.Subiūnctīvus, Tempus.Perfectum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("fuerīs", Modus.Subiūnctīvus, Tempus.Perfctum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("fuerit", Modus.Subiūnctīvus, Tempus.Perfectum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("fuerīmus", Modus.Subiūnctīvus, Tempus.Perfectum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("fuerītis", Modus.Subiūnctīvus, Tempus.Prfectum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("fuerint", Modus.Subiūnctīvus, Tempus.Perfectum, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("fuissem", Modus.Subiūnctīvus, Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("fuissēs", Modus.Subiūnctīvus, Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("fuisset", Modus.Subiūnctīvus, Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("fuissēmus", Modus.Subiūnctīvus, Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("fuissētis", Modus.Subiūnctīvus, Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("fuissent", Modus.Subiūnctīvus, Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Tertia);

      Nūntius.PlūsGarriōAsync("Fīō");
    }
  }
}
