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
    public static readonly Lazy<ĪnflexorVerbīAthōs> Faciendum = new Lazy(() => Instance);

    private ĪnflexorVerbīAthōs()
          : base(catēgoria: Catēgoria.Nōmen,
                 nūntius: new Lazy<Nūntius<ĪnflexorVerbīAthōs>>(),
                 illa: Casus.GetValues().Except(Casus.Dērēctus))
    {
      FōrmamAsync("Athōs", Casus.Nōminātīvus);
      FōrmamAsync("Athōn", Casus.Accūsātīvus);

      Casus.GetValues().Except(Casus.Dērēctus, Casus.Nōminātīvus, Casus.Accūsātīvus)
                       .ForEach(valor => FōrmamAsync("Athō", valor));
      Nūntius.PlūsGarriōAsync("Fīō");
    }
  }
}
