using System;
using System.Collections.Generic.HashSet;

using Miscella;
using Nūntiī.Nūntius;
using Praebeunda.Multiplex.Āctus;
using Ēnumerātiōnēs;

using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Īnflexōrēs.Incertī.Āctūs
{
  [Lazy]
  public sealed partial class ĪnflexorVerbīFierī : ĪnflexorIncertus<Multiplex.Āctus>
  {
    private ĪnflexorVerbīFierī()
        : base(Catēgoria.Āctus, new Lazy<Nūntius<ĪnflexorVerbīFierī>>(),
               Ūtilitātēs.Combīnō(Modus.Īnfīnītīvus.SingleItemSet()),
               Ūtilitātēs.Combīnō(Modus.Imperātīvus.SingleItemSet(),
                                  new HashSet<Tempus>() { Tempus.Praesēns, Tempus.Futūrum, Tempus.Perfectum },
                                  Numerālis.GetValues().Except(Numerālis.Nūllus).ToSortedSet()),
               Ūtilitātēs.Combīnō(Modus.Participālis.SingleItemSet()),
               Ūtilitātēs.Combīnō(new HashSet<Modus>() { Modus.Indicātīvus, Modus.Subiūnctīvus },
                                  new HashSet<Tempus>() { Tempus.Praesēns, Tempus.Īnfectum, Tempus.Futūrum },
                                  Numerālis.GetValues().Except(Numerālis.Nūllus).ToSortedSet(),
                                  Persōna.GetValues().Except(Persōna.Nūlla).ToSortedSet())
                         .Except(illa => Ūtilitātēs.Omnia(illa.FirstOf<Modus>() is Modus.Subiūnctīvus,
                                                          illa.FirstOf<Tempus>() is Tempus.Futūrum)))
    {
      FōrmamAsync("fierī", Modus.Īnfīnītīvus);
      FōrmamAsync("factum", Modus.Participālis);

      FōrmamAsync("fī", Modus.Imperātīvus, Tempus.Praesēns, Numerālis.Singulāris);
      FōrmamAsync("fīte", Modus.Imperātīvus, Tempus.Praesēns, Numerālis.Plūrālis);
      FōrmamAsync("fītō", Modus.Imperātīvus, Tempus.Futūrum, Numerālis.Singulāris);
      FōrmamAsync("fītōte", Modus.Imperātīvus, Tempus.Futūrum, Numerālis.Plūrālis);

      FōrmamAsync("fīō", Modus.Indicātīvus, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("fīs", Modus.Indicātīvus, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("fit", Modus.Indicātīvus, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("fīmus", Modus.Indicātīvus, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("fītis", Modus.Indicātīvus, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("fīunt", Modus.Indicātīvus, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("fīēbam", Modus.Indicātīvus, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("fīēbās", Modus.Indicātīvus, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("fīēbat", Modus.Indicātīvus, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("fīēbāmus", Modus.Indicātīvus, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("fīēbātis", Modus.Indicātīvus, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("fīēbant", Modus.Indicātīvus, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("fīam", Modus.Indicātīvus, Tempus.Futūrum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("fīēs", Modus.Indicātīvus, Tempus.Futūrum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("fīet", Modus.Indicātīvus, Tempus.Futūrum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("fīēmus", Modus.Indicātīvus, Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("fīētis", Modus.Indicātīvus, Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("fīent", Modus.Indicātīvus, Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("fīam", Modus.Subiūnctīvus, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("fīās", Modus.Subiūnctīvus, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("fīat", Modus.Subiūnctīvus, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("fīāmus", Modus.Subiūnctīvus, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("fīātis", Modus.Subiūnctīvus, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("fīant", Modus.Subiūnctīvus, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("fīerem", Modus.Subiūnctīvus, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("fīerēs", Modus.Subiūnctīvus, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("fieret", Modus.Subiūnctīvus, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("fīerēmus", Modus.Subiūnctīvus, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("fīerētis", Modus.Subiūnctīvus, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("fīerent", Modus.Subiūnctīvus, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Tertia);
    }
  }
}
