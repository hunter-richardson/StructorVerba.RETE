using System.Collections.Generic;
using System;

using Miscella;
using Nūntiī.Nūntius;
using Ēnumerātiōnēs;

using Lomok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Incertī.Āctūs
{
  [Singleton]
  public sealed partial class ĪnflexorVerbīInquiī : ĪnflexorIncertus<Multiplex.Āctus>
  {
    public static readonly Lazy<ĪnflexorVerbīInquiī> Faciendum = new Lazy(() => Instance);
    private ĪnflexorVerbīInquiī()
         : base(Catēgoria.Āctus, new Lazy<Nūntius<ĪnflexorVerbīInquiī>>(), Modus.Īnfīnītīvus.SingleItemSet(),
                Modus.Participālis.SingleItemSet(), Modus.Subiūnctīvus.SingleItemSet(), Tempus.Īnfectum.SingleItemSet(),
                Ūtilitātēs.Combīnō(Modus.Imperātīvus, new HashSet<Tempus>() { Tempus.Praesēns, Tempus.Futūrum }),
                Ūtilitātēs.Combīnō(Modus.Indicātīvus, Tempus.Praesēns.SingleItemSet(),
                                   Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet(),
                                   Persōna.GetValues().Except(Persōna.Nūlla).ToHashSet()),
                Ūtilitātēs.Combīnō(Modus.Indicātīvus, Tempus.Futūrum.SingleItemSet(),
                                   new HashSet<Persōna>() { Persōna.Secunda, Persōna.Tertia }),
                Ūtilitātēs.Combīnō(Modus.Indicātīvus, Tempus.Perfectum.SingleItemSet(),
                                   Persōna.GetValues().Except(Persōna.Nūlla).ToHashSet()))
    {
      FōrmamAsync("inquiī", Modus.Īnfīnītīvus);
      FōrmamAsync("inquiēns", Modus.Participālis);
      FōrmamAsync("inquiat", Modus.Subiūnctīvus);
      FōrmamAsync("inquiēbat", Tempus.Īnfectum);
      FōrmamAsync("inque", Modus.Imperātīvus, Tempus.Praesēns);
      FōrmamAsync("inquitō", Modus.Imperātīvus, Tempus.Futūrum);

      FōrmamAsync("inquam", Modus.Indicātīvus, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("inquis", Modus.Indicātīvus, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("inquit", Modus.Indicātīvus, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("inquimus", Modus.Indicātīvus, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("inquitis", Modus.Indicātīvus, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Secunda);
      FōrmamAsync("inquiunt", Modus.Indicātīvus, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Tertia);

      FōrmamAsync("inquiēs", Modus.Indicātīvus, Tempus.Futūrum, Persōna.Secunda);
      FōrmamAsync("inquiet", Modus.Indicātīvus, Tempus.Futūrum, Persōna.Tertia);
      FōrmamAsync("inquiī", Modus.Indicātīvus, Tempus.Perfectum, Persōna.Prīma);
      FōrmamAsync("inquistī", Modus.Indicātīvus, Tempus.Perfectum, Persōna.Secunda);
      FōrmamAsync("inquit", Modus.Indicātīvus, Tempus.Perfectum, Persōna.Tertia);

      Nūntius.PlūsGarriōAsync("Fīō");
    }
  }
}
