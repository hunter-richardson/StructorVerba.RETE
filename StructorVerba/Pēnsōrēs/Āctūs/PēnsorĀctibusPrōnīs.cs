using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;

namespace Pēnsōrēs.Āctūs
{
  public sealed class PēnsorĀctibusPrōnīs : PēnsorĀctibus<Īnflectendum.ĀctusPrōnus>
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
                                 : base(versiō, nameof(Īnflectendum.ĀctusPrōnus.Īnfīnītīvum),
                                        Tabula.Āctūs_Prōnī, NūntiusPēnsōrīĀctibusPrōnīs.Faciendum,
                                        Īnflectendum.ĀctusPrōnus.Lēctor) {  }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīĀctibusPrōnīs : Nūntius<PēnsōrĀctibusPrōnīs>
    {
      public static readonly Lazy<NūntiusPēnsōrīĀctibusPrōnīs> Faciendum = new Lazy<NūntiusPēnsōrīĀctibusPrōnīs>(() => Instance);
    }
  }
}
