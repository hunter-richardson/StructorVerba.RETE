using System.Collections.Generic;
using System;
using System.Collections.Generic.HashSet;

using Miscella;
using Nūntiī.Nūntius;
using Praebeunda.Multiplex.Āctus;
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
               Ūtilitātēs.Colligō(Modus.Īnfīnītīvus.SingleItemSet(), Tempus.Perfectum.SingleItemSet()),
               Ūtilitātēs.Combīnō(Modus.Īnfīnītīvus.SingleItemSet(), Tempus.Praesēns.SingleItemSet(),
                                  Vōx.GetValues().Except(Vōx.Nūlla).ToHashSet()),
               Ūtilitātēs.Combīnō(Modus.Participālis.SingleItemSet(),
                                  new HashSet<Tempus>() { Tempus.Praesēns, Tempus.Perfectum },
                                  Vōx.GetValues().Except(Vōx.Nūlla).ToHashSet(),
                                  Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet()),
               Ūtilitātēs.Combīnō(Modus.Participālis.SingleItemSet(), Tempus.Futūrum.SingleItemSet(),
                                  Vōx.GetValues().Except(Vōx.Nūlla).ToHashSet()),
               Ūtilitātēs.Combīnō(Modus.Imperātīvus.SingleItemSet(),
                                  Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet(),
                                  new HashSet<Tempus>() { Tempus.Praesēns, Tempus.Futūrum },
                                  Vōx.GetValues().Except(Vōx.Nūlla).ToHashSet()),
              Ūtilitātēs.Combīnō(new HashSet<Modus>() { Modus.Indicātīvus, Modus.Subiūnctīvus },
                                  Vōx.GetValues().Except(Vōx.Nūlla).ToHashSet(),
                                  Tempus.GetValues().Except(Tempus.Dērēctus).ToHashSet(),
                                  Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet(),
                                  Persōna.GetValues().Except(Persōna.Nūlla).ToHashSet())
                        .Except(illa => Ūtilitātēs.Omnia(illa.FirstOf<Modus>() is Modus.Subiūnctīvus,
                                                          illa.FirstOf<Tempus>() is Tempus.Futūrum or Tempus.Futūrum_Exāctum)))
    {
      FōrmamAsync("īre", Modus.Īnfīnītīvus, Vōx.Āctīva, Tempus.Praesēns);
      FōrmamAsync("īrī", Modus.Īnfīnītīvus, Vōx.Passīva, Tempus.Praesēns);
      FōrmamAsync("īsse", Modus.Īnfīnītīvus, Tempus.Perfectum);
      FōrmamAsync("iēns", Modus.Participālis, Vōx.Āctīva, Tempus.Praesēns);
      FōrmamAsync("itūrum", Modus.Participālis, Vōx.Āctīva, Tempus.Futūrum);
      FōrmamAsync("eundum", Modus.Participālis, Vōx.Passīva, Tempus.Futūrum);
      FōrmamAsync("itum", Modus.Participālis, Vōx.Passīva, Tempus.Perfectum);

      FōrmamAsync("ī", Modus.Imperātīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Singulāris);
      FōrmamAsync("īte", Modus.Imperātīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Plūrālis);
      FōrmamAsync("ītō", Modus.Imperātīvus, Vōx.Āctīva, Tempus.Futūrum, Numerālis.Singulāris);
      FōrmamAsync("ītōte", Modus.Imperātīvus, Vōx.Āctīva, Tempus.Futūrum, Numerālis.Plūrālis);
      FōrmamAsync("īre", Modus.Īnfīnītīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Singulāris);
      FōrmamAsync("īminī", Modus.Īnfīnītīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Plūrālis);
      FōrmamAsync("ītor", Modus.Imperātīvus, Vōx.Passīva, Tempus.Futūrum, Numerālis.Singulāris);
      FōrmamAsync("euntor", Modus.Imperātīvus, Vōx.Passīva, Tempus.Futūrum, Numerālis.Plūrālis);

      FōrmamAsync("eō", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("īs", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("it", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("īmus", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("ītis", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("eunt", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("ībam", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("ībās", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("ibat", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("ībāmus", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("ībātis", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("ebant", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("ībō", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("ībis", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("ibit", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("ībimus", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("ībitis", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("ībunt", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("īvī", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("īvistī", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("īvit", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("īvīmus", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("īstis", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("iērunt", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("ieram", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("ierās", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("ierat", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("ierāmus", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("ierātis", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("ierant", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("ierō", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum_Exāctum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("ieris", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum_Exāctum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("ierit", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum_Exāctum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("ierimus", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum_Exāctum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("ieritis", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum_Exāctum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("ierint", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum_Exāctum, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("eor", Modus.Indicātīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("īris", Modus.Indicātīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("ītur", Modus.Indicātīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("īmur", Modus.Indicātīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("īminī", Modus.Indicātīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("euntur", Modus.Indicātīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("ībar", Modus.Indicātīvus, Vōx.Passīva, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("ībāris", Modus.Indicātīvus, Vōx.Passīva, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("ibātur", Modus.Indicātīvus, Vōx.Passīva, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("ībāmur", Modus.Indicātīvus, Vōx.Passīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("ībāminī", Modus.Indicātīvus, Vōx.Passīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("ebantur", Modus.Indicātīvus, Vōx.Passīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("ībor", Modus.Indicātīvus, Vōx.Passīva, Tempus.Futūrum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("īberis", Modus.Indicātīvus, Vōx.Passīva, Tempus.Futūrum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("iberit", Modus.Indicātīvus, Vōx.Passīva, Tempus.Futūrum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("īberimur", Modus.Indicātīvus, Vōx.Passīva, Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("īberiminī", Modus.Indicātīvus, Vōx.Passīva, Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("ībuntur", Modus.Indicātīvus, Vōx.Passīva, Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("eam", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("eās", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("eat", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("eāmus", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("eātis", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("eant", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("īrem", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("īrēs", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("iret", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("īrēmus", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("īrētis", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("īrent", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("ierim", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("ierīs", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("ierit", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("ierīmus", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("ierītis", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("ierint", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("īssem", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("īssēs", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("īsset", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("īssēmus", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("īssētis", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("īssent", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("ear", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("eāris", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("eātur", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("eāmur", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("eāminī", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("eantur", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("īrer", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("īrēris", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("irētur", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("īrēmur", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("īrēminī", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("īrentur", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Tertia);
    }
  }
}
