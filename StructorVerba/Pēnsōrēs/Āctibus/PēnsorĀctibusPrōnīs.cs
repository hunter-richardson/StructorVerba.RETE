using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;

namespace Pēnsōrēs.Āctibus
{
  public sealed class PēnsorĀctibusPrōnīs : PēnsorĪnflectendīs<Īnflectendum.ĀctusPrōnus, Multiplex.Āctus>
  {
    private static Dictionary<Enum, PēnsorĀctibusPrōnīs> Reservātī = new Dictionary<Enum, PēnsorĀctibusPrōnīs>();

    public static Func<Enum, PēnsorĀctibusPrōnīs> Faciendum = valor =>
    {
      if (Reservātī.ContainsKey(valor))
      {
        return Reservātī.Item[valor];
      }
      else
      {
        const PēnsorĀctibusPrōnīs hoc = new PēnsorĀctibusPrōnīs(valor);
        Reservātī.Add(valor, hoc);
        return hoc;
      }
    };

    private PēnsorĀctibusPrōnīs(in Enum versiō)
                                 : base(versiō, Ēnumerātiōnēs.Catēgoria.Āctus,
                                        NūntiusPēnsōrīĀctibusPrōnīs.Instance,
                                        nameof(Īnflectendum.ĀctusPrōnus.Īnfīnītīvum),
                                        Īnflectendum.ĀctusPrōnus.Lēctor) {  }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīĀctibusPrōnīs : Nūntius<PēnsōrĀctibusPrōnīs> {  }
  }
}
