using System;
using System.Collections.Generic.HashSet;
using System.Linq;

using Miscella;
using Nūntiī.Nūntius;
using Praebeunda.Multiplex.Āctus;
using Ēnumerātiōnēs;

using Lomok.NET.PropertyGenerators.LazyAttribute;

namespace Īnflexōrēs.Incertī.Āctūs
{
  [Lazy]
  public sealed partial class ĪnflexorVerbīDeīre : ĪnflexorIncertus<Multiplex.Āctus>
  {
    private readonly Lazy<ĪnflexorVerbīĪre> Relātus = ĪnflexorVerbīĪre.Lazy;

    private ĪnflexorVerbīDeīre()
        : base(Catēgoria.Āctus, new Lazy<Nūntius<ĪnflexorVerbīDeīre>>(), Modus.Participālis.SingleItemSet(),
               Ūtilitātēs.Colligō(Modus.Īnfīnītīvus.SingleItemSet(),
                                  new HashSet<Tempus>() { Tempus.Praesēns, Tempus.Perfectum }),
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
      FōrmamAsync("deiēns", Modus.Participālis);
      (from valōrēs in Tabula
       where !valōrēs.Contains(Modus.Participālis)
       select valōrēs).ForEach(illa => FōrmamAsync(fōrma: "de".Concat(await Relātus.Value.ScrībamAsync(illa)), illa: illa));

      Nūntius.PlūsGarriōAsync("Fīō");
    }
  }
}
