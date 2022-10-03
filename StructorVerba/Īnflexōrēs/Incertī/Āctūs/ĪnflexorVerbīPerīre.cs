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
  public sealed partial class ĪnflexorVerbīPerīre : ĪnflexorIncertus<Multiplex.Āctus>
  {
    private readonly Lazy<ĪnflexorVerbīĪre> Relātus = ĪnflexorVerbīĪre.Lazy;

    private ĪnflexorVerbīPerīre()
        : base(Catēgoria.Āctus, new Lazy<Nūntius<ĪnflexorVerbīPerīre>>(), Modus.Participālis.SingleItemSet(),
               Ūtilitātēs.Colligō(Modus.Īnfīnītīvus.SingleItemSet(),
                                  Vōx.GetValues().Except(Vōx.Nūlla).ToHashSet()),
               Ūtilitātēs.Combīnō(Modus.Imperātīvus.SingleItemSet(),
                                  Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet(),
                                  new HashSet<Tempus>() { Tempus.Praesēns, Tempus.Futūrum }),
               Ūtilitātēs.Combīnō(new HashSet<Modus>() { Modus.Indicātīvus, Modus.Subiūnctīvus },
                                  Tempus.GetValues().Except(Tempus.Dērēctus).ToHashSet(),
                                  Vōx.Passīva.SingleItemSet())
                         .Except(illa => Ūtilitātēs.Omnia(illa.FirstOf<Modus>() is Modus.Subiūnctīvus,
                                                          illa.FirstOf<Tempus>() is Tempus.Futūrum or Tempus.Futūrum_Exāctum)),
               Ūtilitātēs.Combīnō(new HashSet<Modus>() { Modus.Indicātīvus, Modus.Subiūnctīvus },
                                  Tempus.GetValues().Except(Tempus.Dērēctus).ToHashSet(),
                                  Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet(),
                                  Persōna.GetValues().Except(Persōna.Nūlla).ToHashSet())
                         .Except(illa => Ūtilitātēs.Omnia(illa.FirstOf<Modus>() is Modus.Subiūnctīvus,
                                                          illa.FirstOf<Tempus>() is Tempus.Futūrum or Tempus.Futūrum_Exāctum)))
    {
      FōrmamAsync("perīre", Modus.Īnfīnītīvus, Vōx.Āctīva);
      FōrmamAsync("perīsse", Modus.Īnfīnītīvus, Vōx.Passīva);
      FōrmamAsync("periēns", Modus.Participālis);

      (from valōrēs in Tabula
       where Ūtilitātēs.Omnia(valōrēs.Contains(Vōx.Passīva),
                             !valōrēs.Contains(Modus.Īnfīnītīvus))
       select valōrēs).ForEach(illa =>
                                {
                                  const Modus modus = illa.FirstOf<Modus>();
                                  const Vōx vōx = illa.FirstOf<Vōx>();
                                  const Tempus tempus = illa.FirstOf<Tempus>();
                                  FōrmamAsync(fōrma: "per".Concat(await Relātus.Value.ScrībamAsync(modus, vōx, tempus, Numerālis.Singulāris, Persōna.Tertia)), illa: illa);
                                });

      (from valōrēs in Tabula
       where valōrēs.ContainsAny(Modus.Īnfīnītīvus, Modus.Participālis, Vōx.Passīva)
       select valōrēs).ForEach(illa => FōrmamAsync(fōrma: "per".Concat(await Relātus.Value.ScrībamAsync(illa)), illa: illa));

      Nūntius.PlūsGarriōAsync("Fīō");
    }
  }
}
