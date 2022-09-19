using System;

using Miscella;
using Nūntiī.Nuntius;
using Praebeunda.Multiplex.Nōmen;
using Praebeunda.Īnflectendum.Nōmen;
using Ēnumerātiōnēs;
using Īnflexōrēs.Effectī.Nōmen;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Incertī.Nōmina
{
  [Singleton]
  public sealed partial class ĪnflexorVerbīVicis : ĪnflexorIncertus<Īnflectendum.Nōmen, Multiplex.Nōmen>
  {
    public static readonly Lazy<ĪnflexorVerbīVicis> Faciendum = new Lazy(() => Instance);
    private readonly Lazy<ĪnflexorEffectusTertiusNōminibus> Relātus = ĪnflexorEffectusTertiusNōminibus.Faciendum;
    private ĪnflexorVerbīVicis()
        : base(catēgoria: Catēgoria.Nōmen, nūntius: new Lazy<Nūntius<ĪnflexorVerbīVicis>>(),
               illa: Ūtilitātēs.Combīnō(Casus.GetValues().Except(Casus.Dērēctus).ToHashSet(),
                                        Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet())
                               .Except(illa => Ūtilitātēs.Omnēs(illa.FirstOf<Numerālis>() is Numerālis.Singulāris,
                                                                illa.FirstOf<Casus>() is Casus.Nōminātīvus or Casus.Vocātīvus)))
    {
      Tabula.ForEach(illa => FōrmamAsync(fōrma: "vic".Concat(await Relātus.Value.SuffixumAsync(illa: illa)), illa: illa));
      Nūntius.PlūsGarriōAsync("Fīō");
    }
  }
}
