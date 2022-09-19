using System.Collections.Generic;
using System;
using System.Collections.Generic.HashSet;

using Miscella;
using Nūntiī.Nūntius;
using Ēnumerātiōnēs;

using Lomok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Incertī.Āctūs
{
  [Singleton]
  public sealed partial class ĪnflexorVerbīĪnfierī : ĪnflexorIncertus<Multiplex.Āctus>
  {
    public static readonly Lazy<ĪnflexorVerbīĪnfierī> Faciendum = new Lazy(() => Instance);
    private ĪnflexorVerbīĪnfierī()
         : base(Catēgoria.Āctus, new Lazy<Nūntius<ĪnflexorVerbīĪnfierī>>(), Modus.Īnfīnītīvus.SingleItemSet(),
                Modus.Imperātīvus.SingleItemSet(), Modus.Participālis.SingleItemSet(), Tempus.Futūrum.SingleItemSet(),
                Ūtilitātēs.Combīnō(new HashSet<Modus>() { Modus.Indicātīvus, Modus.Subiūnctīvus },
                                   new HashSet<Tempus>() { Tempus.Praesēns, Tempus.Īnfectum }))
    {
      FōrmamAsync("īnfierī", Modus.Īnfīnītīvus);
      FōrmamAsync("īnfītō", Modus.Imperātīvus);
      FōrmamAsync("īnfiendum", Modus.Participālis);
      FōrmamAsync("īnfīet", Tempus.Futūrum);

      FōrmamAsync("īnfit", Modus.Indicātīvus, Tempus.Praesēns);
      FōrmamAsync("īnfiēbat", Modus.Indicātīvus, Tempus.Īnfectum);
      FōrmamAsync("īnfit", Modus.Subiūnctīvus, Tempus.Praesēns);
      FōrmamAsync("īnfieret", Modus.Subiūnctīvus, Tempus.Īnfectum);

      Nūntius.PlūsGarriōAsync("Fīō");
    }
  }
}
