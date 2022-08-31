using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;

namespace Pēnsōrēs.Āctibus
{
  public sealed class PēnsorĀctibusEffectīs : PēnsorĪnflectendīs<Īnflectendum.ĀctusEffectus, Multiplex.Āctus>
  {
    private static Dictionary<Enum, PēnsorĀctibusEffectīs> Reservātī = new Dictionary<Enum, PēnsorĀctibusEffectīs>();

    public static Func<Enum, PēnsorĀctibusEffectīs> Faciendum = valor =>
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

    private PēnsorĀctibusEffectīs(in Enum versiō)
                                   : base(versiō, Ēnumerātiōnēs.Catēgoria.Āctus,
                                          NūntiusPēnsōrīĀctibusEffectīs.Faciendum,
                                          nameof(Īnflectendum.ĀctusEffectus.Īnfīnītīvum),
                                          Īnflectendum.ĀctusEffectus.Lēctor) {  }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīĀctibusEffectīs : Nūntius<PēnsōrĀctibusEffectīs>
    {
      public static readonly Lazy<NūntiusPēnsōrīĀctibusEffectīs> Faciendum = new Lazy<NūntiusPēnsōrīĀctibusEffectīs>(() => Instance);
    }
  }
}
