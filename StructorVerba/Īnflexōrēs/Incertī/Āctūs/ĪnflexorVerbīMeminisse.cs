using System;
using System.Collections.Generic.HashSet;
using System.Linq;

using Miscella;
using Nūntiī.Nūntius;
using Ēnumerātiōnēs;

using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Īnflexōrēs.Incertī.Āctūs
{
  [Lazy]
  public sealed partial class ĪnflexorVerbīMeminisse : ĪnflexorIncertus<Multiplex.Āctus>
  {
    private readonly Lazy<ĪnflexorPerfectusSōlusĀctibus> Relātus
     = new Lazy(() => new ĪnflexorPerfectusSōlusĀctibus(ĪnflexorEffectusTertiusĀctibus.Lazy,
                                                        "meminisse", string.Empty));

    private ĪnflexorVerbīMeminisse()
         : base(Catēgoria.Āctus, new Lazy<Nūntius<ĪnflexorVerbīMeminisse>>(),
                Modus.Īnfīnītīvus.SingleItemSet(),
                Ūtilitātēs.Combīnō(Modus.Imperātīvus.SingleItemSet(),
                                   Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet()),
                Ūtilitātēs.Combīnō(new HashSet<Modus>() { Modus.Indicātīvus, Modus.Subiūnctīvus },
                                   new HashSet<Tempus>() { Tempus.Perfectum, Tempus.Plūsquamperfectum, Tempus.Futūrum_Exāctum },
                                   Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet(),
                                   Persōna.GetValues().Except(Persōna.Nūlla).ToHashSet()))
    {
      FōrmamAsync("mementō", Modus.Imperātīvus, Numerālis.Singulāris);
      FōrmamAsync("mementōte", Modus.Imperātīvus, Numerālis.Plūrālis);

      (from valōrēs in Tabula
       where valōrēs.ContainsAny(Modus.Indicātīvus, Modus.Subiūnctīvus, Modus.Īnfīnītīvus)
       select valōrēs).ForEach(illa => FōrmamAsync(fōrma: await Relātus.Value.ScrībamAsync(illa), illa: illa));

      Nūntius.PlūsGarriōAsync("Fīō");
    }
  }
}
