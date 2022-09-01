using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;

namespace Pēnsōrēs.Āctūs
{
  public sealed class PēnsorĀctibusImperfectīs : PēnsorĀctibus<Īnflectendum.ĀctusImperfectus>
  {
    private static Dictionary<Enum, PēnsorĀctibusImperfectīs> Reservātī = new Dictionary<Enum, PēnsorĀctibusImperfectīs>();

    public static Func<Enum, PēnsorĀctibusImperfectīs> Faciendum = valor =>
    {
      if (Reservātī.ContainsKey(valor))
      {
        return Reservātī.Item[valor];
      }
      else
      {
        const PēnsorĀctibusImperfectīs hoc = new PēnsorĀctibusImperfectīs(valor);
        Reservātī.Add(valor, hoc);
        return hoc;
      }
    };

    private PēnsorĀctibusImperfectīs(in Enum versiō)
                                      : base(versiō, nameof(Īnflectendum.ĀctusImperfectus.Īnfīnītīvum),
                                             Tabula.Āctūs_Imperfectī, NūntiusPēnsōrīĀctibusImperfectīs.Faciendum,
                                             Īnflectendum.ĀctusImperfectus.Lēctor) {  }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīĀctibusImperfectīs : Nūntius<PēnsōrĀctibusImperfectīs>
    {
      public static readonly Lazy<NūntiusPēnsōrīĀctibusImperfectīs> Faciendum = new Lazy<NūntiusPēnsōrīĀctibusImperfectīs>(() => Instance);
    }
  }
}
