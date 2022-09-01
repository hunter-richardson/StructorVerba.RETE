using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Pēnsōrēs.Āctibus
{
  public sealed class PēnsorĀctibusPrōnīsImperfectīs : PēnsorĀctibus<Īnflectendum.ĀctusPrōnusImperfectus>
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
                                            : base(versiō, nameof(Īnflectendum.ĀctusPrōnusImperfectus.Īnfīnītīvum),
                                             Tabula.Āctūs_Prōnī_Imperfectī, NūntiusPēnsōrīĀctibusPrōnīsImperfectīs.Faciendum,
                                             Īnflectendum.ĀctusPrōnusImperfectusfectus.Lēctor) {  }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīĀctibusPrōnīsImperfectīs : Nūntius<PēnsorĀctibusPrōnīsImperfectīs>
    {
      public static readonly Lazy<NūntiusPēnsōrīĀctibusPrōnīsImperfectīs> Faciendum = new Lazy<NūntiusPēnsōrīĀctibusPrōnīsImperfectīs>(() => Instance);
    }
  }
}
