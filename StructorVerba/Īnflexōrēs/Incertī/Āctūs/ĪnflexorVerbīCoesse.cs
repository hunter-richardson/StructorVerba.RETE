using System;
using System.Collections.Generic.HashSet;

using Miscella;
using Nūntiī.Nūntius;
using Ēnumerātiōnēs;

using Lomok.NET.PropertyGenerators.LazyAttribute;

namespace Īnflexōrēs.Incertī.Āctūs
{
  [Lazy]
  public sealed partial class ĪnflexorVerbīCoesse : ĪnflexorIncertus<Multiplex.Āctus>
  {
    private readonly Lazy<ĪnflexorRescrīptus> Relātus
     = new Lazy(() => new ĪnflexorRescrīptus(ĪnflexorVerbīEsse.Lazy,
                                             scrīptum => scrīptum.StartsWith('e')
                                                                 .Choose("co", "cōn").Concat(scrīptum)));

    private ĪnflexorVerbīEsse()
          : base(Catēgoria.Āctus, new Lazy<Nūntius<ĪnflexorVerbīCoesse>>(), Modus.Participālis.SingleItemSet(),
                 Ūtilitātēs.Combīnō(Modus.Īnfīnītīvus.SingleItemSet(),
                                    new HashSet<Tempus>() { Tempus.Praesēns, Tempus.Perfectum }),
                 Ūtilitātēs.Combīnō(new HashSet<Modus>() { Modus.Indicātīvus, Modus.Subiūnctīvus },
                                    Tempus.GetValues().Except(Tempus.Dērēctus).ToHashSet())
                           .Except(illa => Ūtilitātēs.Omnia(illa.FirstOf<Modus>() is Modus.Subiūnctīvus,
                                                            illa.FirstOf<Tempus>() is Tempus.Futūrum or Tempus.Futūrum_Exāctum)))
          => Tabula.ForEach(illa => FōrmamAsync(fōrma: await Relātus.Value.ScrībamAsync(illa), illa: illa));
  }
}
