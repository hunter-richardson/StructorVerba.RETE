using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;
using Īnflexōrēs.Effectī.Āctūs.ĪnflexorEffectusĀctibus.Versio;

namespace Pēnsōrēs.Āctūs
{
  public sealed class PēnsorĀctibusEffectīs : PēnsorĀctibus<Īnflectendum.ĀctusEffectus>
  {
    private static Dictionary<ĪnflexorEffectusĀctibus.Versio, PēnsorĀctibusEffectīs> Reservātī
             = new Dictionary<ĪnflexorEffectusĀctibus.Versio, PēnsorĀctibusEffectīs>();

    public static Func<ĪnflexorEffectusĀctibus.Versio, PēnsorĀctibusEffectīs> Faciendum = valor =>
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

    private PēnsorĀctibusEffectīs(in ĪnflexorEffectusĀctibus.Versio versiō)
                                                             : base(versiō, nameof(Īnflectendum.ĀctusEffectus.Īnfīnītīvum),
                                                                    Tabula.Āctūs_Effectī, NūntiusPēnsōrīĀctibusEffectīs.Faciendum,
                                                                    Īnflectendum.ĀctusEffectus.Lēctor) {  }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīĀctibusEffectīs : Nūntius<PēnsorĀctibusEffectīs>
    {
      public static readonly Lazy<NūntiusPēnsōrīĀctibusEffectīs> Faciendum = new Lazy<NūntiusPēnsōrīĀctibusEffectīs>(() => Instance);
    }
  }
}
