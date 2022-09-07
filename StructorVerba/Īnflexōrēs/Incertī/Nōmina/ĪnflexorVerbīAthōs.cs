using System;

using Nūntiī.Nuntius;
using Praebeunda.Multiplex.Nōmen;
using Praebeunda.Īnflendum.Nōmen;
using Ēnumerātiōnēs;

using Lombok.NET.MethodGenerators.SingletonAttribute;

namespace Īnflexōrēs.Incertī.Nōmina
{
  [Singleton]
  public sealed partial class ĪnflexorVerbīAthōs : ĪnflexorIncertus<Īnflectendum.Nōmen, Multiplex.Nōmen>
  {
    public static readonly Lazy<ĪnflexorVerbīAthōs> Faciendum
                     = new Lazy<ĪnflexorVerbīAthōs>(() => Instance);

    private ĪnflexorVerbīAthōs()
          : base(Ēnumerātiōnēs.Catēgoria.Nōmen,
                 new Lazy<Nūntius<ĪnflexorVerbīAthōs>>(() => new Nūntius<ĪnflexorVerbīAthōs>()),
                 Casus.GetValues().Except(Casus.Dērēctus))
    {
      FōrmamAsync("Athōs", Casus.Nominātīvus);
      FōrmamAsync("Athōn", Casus.Accusātīvus);

      Casus.GetValues().Except(Casus.Dērēctus, Casus.Nominātīvus, Casus.Accusātīvus)
                       .ForEach(valor => FōrmamAsync("Athō", valor));
    }
  }
}
