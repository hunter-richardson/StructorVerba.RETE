using System.Collections.Generic;
using System;

using Miscella;
using Nūntiī.Nūntius;
using Ēnumerātiōnēs;

using Lomok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Incertī.Āctūs
{
  [Singleton]
  public sealed partial class ĪnflexorVerbīAiere : ĪnflexorIncertus<Multiplex.Āctus>
  {
    public static readonly Lazy<ĪnflexorVerbīAiere> Faciendum = new Lazy(() => Instance);
    private ĪnflexorVerbīAiere()
         : base(Catēgoria.Āctus, new Lazy<Nūntius<ĪnflexorVerbīAiere>>(), Modus.Īnfīnītīvus.SingleItemSet(),
                Modus.Imperātīvus.SingleItemSet(), Modus.Participālis.SingleItemSet(),
                Ūtilitātēs.Combīnō(Modus.Subiūnctīvus.SingleItemSet(),
                                   new HashSet<Persōna>() { Persōna.Prīma, Persōna.Secunda }),
                Ūtilitātēs.Combīnō(Modus.Subiūnctīvus.SingleItemSet(), Persōna.Tertia.SingleItemSet(),
                                   Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet()),
                Ūtilitātēs.Combīnō(Tempus.Praesēns.SingleItemSet(),
                                   new HashSet<Persōna>() { Persōna.Prīma, Persōna.Secunda }),
                Ūtilitātēs.Combīnō(Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet(),
                                   Tempus.Praesēns.SingleItemSet(), Persōna.Tertia.SingleItemSet()),
                Ūtilitātēs.Combīnō(Tempus.Īnfectum.SingleItemSet(),
                                   new HashSet<Persōna>() { Persōna.Secunda, Persōna.Tertia }),
                Ūtilitātēs.Combīnō(Tempus.Perfectum.SingleItemSet(),
                                   Persōna.GetValues().Except(Persōna.Nūlla).ToHashSet(),
                                   Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet()))
    {
      FōrmamAsync("aiere", Modus.Īnfīnītīvus);
      FōrmamAsync("ai", Modus.Imperātīvus);
      FōrmamAsync("aiēns", Modus.Participālis);

      FōrmamAsync("ait", Tempus.Praesēns, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("aiunt", Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Tertia);

      FōrmamAsync("aiēbam", Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("aiēbās", Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("aiēbat", Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("aiēbāmus", Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("aiēbātis", Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("aiēbant", Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Tertia);
      FōrmamAsync("aiat", Modus.Subiūnctīvus, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("aiant", Modus.Subiūnctīvus, Numerālis.Plūrālis, Persōna.Tertia);

      FōrmamAsync("aiō", Tempus.Praesēns, Persōna.Prīma);
      FōrmamAsync("ais", Tempus.Perfectum, Persōna.Secunda);
      FōrmamAsync("aistī", Tempus.Perfectum, Persōna.Secunda);
      FōrmamAsync("ait", Tempus.Perfectum, Persōna.Tertia);
      FōrmamAsync("aiās", Modus.Subiūnctīvus, Persōna.Secunda);
    }
  }
}
