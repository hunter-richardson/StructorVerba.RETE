using System;
using System.Collections.Generic.HashSet;

using Miscella;
using Nūntiī.Nūntius;
using Praebeunda.Īnfectendum.Āctus;
using Pēnsōrēs.Īnflectenda.PēnsorĀctibus.Versiō;
using Ēnumerātiōnēs;

using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Īnflexōrēs.Incertī.Āctūs
{
  [Lazy]
  public sealed partial class ĪnflexorVerbīFacere : ĪnflexorIncertus<Multiplex.Āctus>
  {
    private static readonly Lazy<Īnfectendum.Āctus> Relātus
          = new Lazy(() => await Īnfectendum.Āctus.Cōnstrūctor.Invoke("facere", "fēcisse", "factum",
                                                                      PēnsorĀctibus.Versiō.Āctus_Tertius_Varius));

    private ĪnflexorVerbīFacere()
         : base(Catēgoria.Āctus, new Lazy<Nūntius<ĪnflexorVerbīFacere>>(),
                Ūtilitātēs.Combīnō(Modus.Īnfīnītīvus.SingleItemSet(), Vōx.Passīva.SingleItemSet()),
                Ūtilitātēs.Combīnō(Modus.Īnfīnītīvus.SingleItemSet(), Vōx.Āctīva.SingleItemSet(),
                                   new HashSet<Tempus>() { Tempus.Praesēns, Tempus.Perfectum }),
                Ūtilitātēs.Combīnō(Modus.Imperātīvus.SingleItemSet(), Vōx.GetValues().Except(Vōx.Nūlla).ToHashSet(),
                                   new HashSet<Tempus>() { Tempus.Praesēns, Tempus.Futūrum, Tempus.Perfectum },
                                   Numerālis.GetValues().Except(Numerālis.Nūllus).ToSortedSet()),
                Ūtilitātēs.Combīnō(Modus.Participālis.SingleItemSet(),
                                   new HashSet<Tempus>() { Tempus.Praesēns, Tempus.Perfectum }),
                Ūtilitātēs.Combīnō(Modus.Participālis.SingleItemSet(), Tempus.Futūrum.SingleItemSet(),
                                   Vōx.GetValues().Except(Vōx.Nūlla).ToHashSet()),
                Ūtilitātēs.Combīnō(new HashSet<Modus>() { Modus.Indicātīvus, Modus.Subiūnctīvus },
                                   new HashSet<Tempus>() { Tempus.Perfectum, Tempus.Plūsquamperfectum, Tempus.Futūrum_Exāctum },
                                   Numerālis.GetValues().Except(Numerālis.Nūllus).ToSortedSet(),
                                   Persōna.GetValues().Except(Persōna.Nūlla).ToSortedSet(),
                                   Vōx.Āctīva.SingleItemSet())
                          .Except(illa => Ūtilitātēs.Omnia(illa.FirstOf<Modus>() is Modus.Subiūnctīvus,
                                                           illa.FirstOf<Tempus>() is Tempus.Futūrum_Exāctum)),
                Ūtilitātēs.Combīnō(new HashSet<Modus>() { Modus.Indicātīvus, Modus.Subiūnctīvus },
                                   new HashSet<Tempus>() { Tempus.Praesēns, Tempus.Īnfectum, Tempus.Futūrum },
                                   Numerālis.GetValues().Except(Numerālis.Nūllus).ToSortedSet(),
                                   Persōna.GetValues().Except(Persōna.Nūlla).ToSortedSet(),
                                   Vōx.GetValues().Except(Vōx.Nūlla).ToHashSet())
                          .Except(illa => Ūtilitātēs.Omnia(illa.FirstOf<Modus>() is Modus.Subiūnctīvus,
                                                           illa.FirstOf<Tempus>() is Tempus.Futūrum)))
    {
      FōrmamAsync("fierī", Modus.Īnfīnītīvus, Vōx.Passīva, Tempus.Praesēns);

      FōrmamAsync("fac", Modus.Imperātīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Singulāris);
      FōrmamAsync("fī", Modus.Īnfīnītīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Singulāris);
      FōrmamAsync("fīte", Modus.Īnfīnītīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Plūrālis);
      FōrmamAsync("fītō", Modus.Imperātīvus, Vōx.Passīva, Tempus.Futūrum, Numerālis.Singulāris);
      FōrmamAsync("fītōte", Modus.Imperātīvus, Vōx.Passīva, Tempus.Futūrum, Numerālis.Plūrālis);

      FōrmamAsync("fīō", Modus.Indicātīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("fīs", Modus.Indicātīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("fit", Modus.Indicātīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("fīmus", Modus.Indicātīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("fītis", Modus.Indicātīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("fīunt", Modus.Indicātīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("fīēbam", Modus.Indicātīvus, Vōx.Passīva, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("fīēbās", Modus.Indicātīvus, Vōx.Passīva, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("fīēbat", Modus.Indicātīvus, Vōx.Passīva, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("fīēbāmus", Modus.Indicātīvus, Vōx.Passīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("fīēbātis", Modus.Indicātīvus, Vōx.Passīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("fīēbant", Modus.Indicātīvus, Vōx.Passīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("fīam", Modus.Indicātīvus, Vōx.Passīva, Tempus.Futūrum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("fīēs", Modus.Indicātīvus, Vōx.Passīva, Tempus.Futūrum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("fīet", Modus.Indicātīvus, Vōx.Passīva, Tempus.Futūrum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("fīēmus", Modus.Indicātīvus, Vōx.Passīva, Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("fīētis", Modus.Indicātīvus, Vōx.Passīva, Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("fīent", Modus.Indicātīvus, Vōx.Passīva, Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("fīam", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("fīās", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("fīat", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("fīāmus", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("fīātis", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("fīant", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("fīerem", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("fīerēs", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("fieret", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("fīerēmus", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("fīerētis", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("fīerent", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Tertia);

      Tabula.Except(illa => Fōrmae.Keys.Contains(illa))
            .ForEach(illa => FōrmamAsync(fōrma: await Relātus.ScrībamAsync(illa), illa: illa));

      Nūntius.PlūsGarriōAsync("Fīō");
    }
  }
}
