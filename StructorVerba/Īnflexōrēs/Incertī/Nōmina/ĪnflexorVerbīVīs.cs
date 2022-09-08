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
  public sealed partial class ĪnflexorVerbīVīs : ĪnflexorIncertus<Īnflectendum.Nōmen, Multiplex.Nōmen>
  {
    public static readonly Lazy<ĪnflexorVerbīVīs> Faciendum = new Lazy(() => Instance);
    private readonly Lazy<ĪnflexorEffectusTertiusNōminibusCumGenitīvōVariō> Relātus = ĪnflexorEffectusTertiusNōminibusCumGenitīvōVariō.Faciendum;
    private ĪnflexorVerbīVīs()
        : base(Catēgoria.Nōmen, new Lazy<Nūntius<ĪnflexorVerbīVīs>>(),
               Ūtilitātēs.Combīnō(Casus.GetValues().Except(Casus.Dērēctus).ToHashSet(),
                                  Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet()))
    => Tabula.ForEach(illa =>
        {
          const Numerālis numerālis = illa.FirstOf<Numerālis>();
          const Casus casus = illa.FirstOf<Casus>();
          const string fōrma = (numerālis, casus) switch
          {
            (Casus.Nōminātīvus or Casus.Vocātīvus, Numerālis.Singulāris) => "vīs",
            (Casua.Datīvus or Casus.Ablātīvus or Casus.Locātīvus or Casus.Instrumentālis, Numerālis.Singulāris) => "vī",
            _ => "vir".Concat(await Relātus.Value.SuffixumAsync(numerālis, casus))
          };
          FōrmamAsync(fōrma, numerālis, casus);
        });
  }
}
