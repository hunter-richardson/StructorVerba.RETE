using System;
using System.Collections.Generic.HashSet;
using System.Linq;

using Miscella;
using Nūntiī.Nūntius;
using Praebeunda.Multiplex.Āctus;
using Ēnumerātiōnēs;

using Lomok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Incertī.Āctūs
{
  [Singleton]
  public sealed partial class ĪnflexorVerbīDisperīre : ĪnflexorIncertus<Multiplex.Āctus>
  {
    public static readonly Lazy<ĪnflexorVerbīDisperīre> Faciendum = new Lazy(() => Instance);

    private readonly Lazy<ĪnflexorVerbīĪre> Relātus = ĪnflexorVerbīĪre.Faciendum;

    private ĪnflexorVerbīDisperīre()
        : base(Catēgoria.Āctus, new Lazy<Nūntius<ĪnflexorVerbīDisperīre>>(), Modus.Participālis.SingleItemSet(),
               Ūtilitātēs.Colligō(Modus.Īnfīnītīvus.SingleItemSet(),
                                  Vōx.GetValues().Except(Vōx.Nūlla).ToHashSet()),
               Ūtilitātēs.Combīnō(Modus.Imperātīvus.SingleItemSet(),
                                  Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet(),
                                  new HashSet<Tempus>() { Tempus.Praesēns, Tempus.Futūrum }),
              Ūtilitātēs.Combīnō(new HashSet<Modus>() { Modus.Indicātīvus, Modus.Subiūnctīvus },
                                  Tempus.GetValues().Except(Tempus.Dērēctus).ToHashSet(),
                                  Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet(),
                                  Persōna.GetValues().Except(Persōna.Nūlla).ToHashSet())
                        .Except(illa => Ūtilitātēs.Omnia(illa.FirstOf<Modus>() is Modus.Subiūnctīvus,
                                                          illa.FirstOf<Tempus>() is Tempus.Futūrum or Tempus.Futūrum_Exāctum)))
    {
      FōrmamAsync("disperīre", Modus.Īnfīnītīvus, Vōx.Āctīva);
      FōrmamAsync("disperīsse", Modus.Īnfīnītīvus, Vōx.Passīva);
      FōrmamAsync("disperiēns", Modus.Participālis);
      (from valōrēs in Tabula
       where !valōrēs.ContainsAny(Modus.Īnfīnītīvus, Modus.Participālis)
       select valōrēs).ForEach(illa => FōrmamAsync(fōrma: "disper".Concat(await Relātus.Value.ScrībamAsync(illa)), illa: illa));

      Nūntius.PlūsGarriōAsync("Fīō");
    }
  }
}
