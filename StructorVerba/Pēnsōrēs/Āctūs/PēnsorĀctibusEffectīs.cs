using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;
using Īnflexōrēs.Effectī.Āctūs.ĪnflexorEffectusĀctibus.Versio;

namespace Pēnsōrēs.Āctūs
{
  public sealed class PēnsorĀctibusEffectīs : PēnsorĀctibus<Īnflectendum.ĀctusEffectus>
  {
    private static Dictionary<ĪnflexōrēsEffectusĀctibus.Versio, PēnsorĀctibusEffectīs> Reservātī = new Dictionary<ĪnflexōrēsEffectusĀctibus.Versio, PēnsorĀctibusEffectīs>();

    public static Func<ĪnflexōrēsEffectusĀctibus.Versio, PēnsorĀctibusEffectīs> Faciendum = valor =>
    {
      if (Reservātī.ContainsKey(valor))
      {
        return Reservātī.Item[valor];
      }
      else
      {
        const PēnsorĀctibusEffectīs hoc = new PēnsorĀctibusEffectīs(valor);
        Reservātī.Add(valor, hoc);
        return hoc;
      }
    };

    private PēnsorĀctibusEffectīs(in ĪnflexōrēsEffectusĀctibus.Versio versiō)
                                                               : base(versiō, nameof(Īnflectendum.ĀctusEffectus.Īnfīnītīvum),
                                                                      Tabula.Āctūs_Effectī, NūntiusPēnsōrīĀctibusEffectīs.Faciendum,
                                                                      Īnflectendum.ĀctusEffectus.Lēctor) {  }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīĀctibusEffectīs : Nūntius<PēnsōrĀctibusEffectīs>
    {
      public static readonly Lazy<NūntiusPēnsōrīĀctibusEffectīs> Faciendum = new Lazy<NūntiusPēnsōrīĀctibusEffectīs>(() => Instance);
    }
  }
}
