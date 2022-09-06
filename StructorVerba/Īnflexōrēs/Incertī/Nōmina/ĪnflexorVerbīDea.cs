using System;

using Miscella.Ūtilitātēs;
using Praebeunda.Multiplex.Nōmen;
using Praebeunda.Īnflendum.Nōmen;
using Ēnumerātiōnēs;
using Īnflexōrēs.Effectī.Nōmina.ĪnflexorEffectusPrīmusNōminibus;

using Lombok.NET.MethodGenerators.SingletonAttribute;

namespace Īnflexōrēs.Incertī.Nōmina
{
  public sealed partial class ĪnflexorVerbīDea : ĪnflexorIncertī<Multiplex.Nōmen>
  {
    public static readonly Lazy<ĪnflexorVerbīDea> Faciendum
                     = new Lazy<ĪnflexorVerbīDea>(() => Instance);

    private readonly ĪnflexorEffectusPrīmusNōminibus Relātum = ĪnflexorEffectusPrīmusNōminibus.Faciendum.Value;
    private ĪnflexorVerbīDea()
          : base(Ēnumerātiōnēs.Catēgoria.Nōmen, NūntiusĪnflexōrīVerbīCommūnisDeus.Faciendum,
                 Ūtilitātēs.Combīnō(Casus.GetValues().Except(Casus.Dērēctus).ToSortedSet(),
                                    Numerālis.GetValues().Except(Numerālis.Nūllus).ToSortedSet()))
    {
      Ūtilitātēs.Seriēs(Casus.Datīvus, Casus.Ablātīvus, Casus.Locātīvus, Casus.Instrumentālis)
                .ForEach(valor => FōrmamAsync("deābus", valor, Numerālis.Plūrālis));

      Tabula.Except(valōrēs => Fōrmae.Keys.Contains(valōrēs))
            .ForEach(valōrēs => FōrmamAsync("de".Concat(Relātum.Suffixum(valōrēs))));
    }

    [Singleton]
    private sealed partial class NūntiusĪnflexōrīVerbīDea : Nūntius<ĪnflexorVerbīDea>
    {
      public static readonly Lazy<NūntiusĪnflexōrīVerbīDea> Faciendum
                       = new Lazy<NūntiusĪnflexōrīVerbīDea>(() => Instance);
    }
  }
}
