using System;
using System.Collections.Generic.HashSet;

using Miscella;
using Nūntiī.Nūntius;
using Ēnumerātiōnēs;

using Lomok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Incertī.Āctūs
{
  [Singleton]
  public sealed partial class ĪnflexorVerbīFacere : ĪnflexorIncertus<Multiplex.Āctus>
  {
    public static readonly Lazy<ĪnflexorVerbīFacere> Faciendum = new Lazy(() => Instance);
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
      FōrmamAsync("facere", Modus.Īnfīnītīvus, Vōx.Āctīva, Tempus.Praesēns);
      FōrmamAsync("fierī", Modus.Īnfīnītīvus, Vōx.Passīva, Tempus.Praesēns);
      FōrmamAsync("facisse", Modus.Īnfīnītīvus, Tempus.Perfectum);
      FōrmamAsync("faciēns", Modus.Participālis, Vōx.Āctīva, Tempus.Praesēns);
      FōrmamAsync("factūrum", Modus.Participālis, Vōx.Āctīva, Tempus.Futūrum);
      FōrmamAsync("faciendum", Modus.Participālis, Vōx.Passīva, Tempus.Futūrum);
      FōrmamAsync("factum", Modus.Participālis, Vōx.Passīva, Tempus.Perfectum);

      FōrmamAsync("fac", Modus.Imperātīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Singulāris);
      FōrmamAsync("facite", Modus.Imperātīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Plūrālis);
      FōrmamAsync("facitō", Modus.Imperātīvus, Vōx.Āctīva, Tempus.Futūrum, Numerālis.Singulāris);
      FōrmamAsync("facitōte", Modus.Imperātīvus, Vōx.Āctīva, Tempus.Futūrum, Numerālis.Plūrālis);
      FōrmamAsync("fī", Modus.Īnfīnītīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Singulāris);
      FōrmamAsync("fīte", Modus.Īnfīnītīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Plūrālis);
      FōrmamAsync("fītō", Modus.Imperātīvus, Vōx.Passīva, Tempus.Futūrum, Numerālis.Singulāris);
      FōrmamAsync("fītōte", Modus.Imperātīvus, Vōx.Passīva, Tempus.Futūrum, Numerālis.Plūrālis);

      FōrmamAsync("faciō", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("facis", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("facit", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("facimus", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("facitis", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("faciunt", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("faciēbam", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("faciēbās", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("faciēbat", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("faciēbāmus", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("faciēbātis", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("faciēbant", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("faciam", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("faciēs", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("faciet", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("faciēmus", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("faciētis", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("faceunt", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("fēcī", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("fēcistī", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("fēcit", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("fēcimus", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("fēcitis", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("fēcērunt", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("fēceram", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("fēcerās", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("fēcerat", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("fēcerāmus", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("fēcerātis", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("fēcerant", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("fēcerō", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum_Exāctum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("fēceris", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum_Exāctum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("fēcerit", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum_Exāctum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("fēcerimus", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum_Exāctum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("fēceritis", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum_Exāctum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("fēcerint", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum_Exāctum, Numerālis.Plūrālis, Persōna.Tertia);
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
      FōrmamAsync("faciam", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("faciās", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("faciat", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("faciāmus", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("faciātis", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("faciant", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("facerem", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("facerēs", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("faceret", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("facerēmus", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("facerētis", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("facerent", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("fēcerim", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("fēcerīs", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("fēcerit", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("fēcerīmus", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("fēcerītis", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("fēcerint", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("fēcissem", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("fēcissēs", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("fēcisset", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("fēcissēmus", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("fēcissētis", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("fēcissent", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Tertia);
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
    }
  }
}
