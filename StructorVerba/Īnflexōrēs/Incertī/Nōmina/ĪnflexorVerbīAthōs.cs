using System;

using Praebeunda.Multiplex.Nōmen;
using Praebeunda.Īnflendum.Nōmen;
using Ēnumerātiōnēs;

using Lombok.NET.MethodGenerators.SingletonAttribute;

namespace Īnflexōrēs.Incertī.Nōmina
{
  public sealed partial class ĪnflexorVerbīAthōs : ĪnflexorIncertī<Multiplex.Nōmen>
  {
    public static readonly Lazy<ĪnflexorVerbīAthōs> Faciendum
                     = new Lazy<ĪnflexorVerbīAthōs>(() => Instance);

    private ĪnflexorVerbīAthōs()
          : base(Ēnumerātiōnēs.Catēgoria.Nōmen,
                 NūntiusĪnflexōrīVerbīAthōs.Faciendum,
                 Casus.GetValues().Except(Casus.Dērēctus))
    {
      FōrmamAsync("Athōs", Casus.Nominātīvus);
      FōrmamAsync("Athōn", Casus.Accusātīvus);

      Casus.GetValues().Except(Casus.Dērēctus, Casus.Nominātīvus, Casus.Accusātīvus)
                       .ForEach(valor => FōrmamAsync("Athō", valor));
    }

    [Singleton]
    private sealed partial class NūntiusĪnflexōrīVerbīAthōs : Nūntius<ĪnflexorVerbīAthōs>
    {
      public static readonly Lazy<NūntiusĪnflexōrīVerbīAthōs> Faciendum
                       = new Lazy<NūntiusĪnflexōrīVerbīAthōs>(() => Instance);
    }
  }
}
