using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Pēnsōrēs.Āctibus
{
  public sealed class PēnsorĀctibusPrōnīsImperfectīs : PēnsorĪnflectendīs<Īnflectendum.ĀctusPrōnusImperfectus, Multiplex.Āctus>
  {
    private static Dictionary<Enum, PēnsorĀctibusPrōnīsImperfectīs> Reservātī = new Dictionary<Enum, PēnsorĀctibusPrōnīsImperfectīs>();

    public static Func<Enum, PēnsorĀctibusPrōnīsImperfectīs> Faciendum = valor =>
    {
      if (Reservātī.ContainsKey(valor))
      {
        return Reservātī.Item[valor];
      }
      else
      {
        const PēnsorĀctibusPrōnīsImperfectīs hoc = new PēnsorĀctibusPrōnīsImperfectīs(valor);
        Reservātī.Add(valor, hoc);
        return hoc;
      }
    };

    private PēnsorĀctibusPrōnīsImperfectīs(in Enum versiō)
                                            : base(versiō, Ēnumerātiōnēs.Catēgoria.Āctus,
                                                   NūntiusPēnsōrīĀctibusPrōnīsImperfectīs.Faciendum,
                                                   nameof(Īnflectendum.ĀctusPrōnusImperfectus.Īnfīnītīvum),
                                                   Īnflectendum.ĀctusPrōnusImperfectus.Lēctor) {  }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīĀctibusPrōnīsImperfectīs : Nūntius<PēnsōrĀctibusPrōnīsImperfectīs>
    {
      public static readonly Lazy<NūntiusPēnsōrīĀctibusPrōnīsImperfectīs> Faciendum = new Lazy<NūntiusPēnsōrīĀctibusPrōnīsImperfectīs>(() => Instance);
    }
  }
}
