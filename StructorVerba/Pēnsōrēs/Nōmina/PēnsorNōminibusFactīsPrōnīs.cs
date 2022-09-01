using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;
using Īnflexōrēs.Effectī.Nōmina.NōminaFacta.ĪnflexorEffectusNōminibusFactīsPrōnīs.Versio;

namespace Pēnsōrēs.Nōmina
{
  public sealed class PēnsorNōminibusFactīsPrōnīs : PēnsorNōminibus<Īnflectendum.NōmenFactumPrōnum>
  {
    private static Dictionary<ĪnflexorEffectusNōminibusFactīsPrōnīs.Versio, PēnsorNōminibusFactīsPrōnīs> Reservātī
             = new Dictionary<ĪnflexorEffectusNōminibusFactīsPrōnīs.Versio, PēnsorNōminibusFactīsPrōnīs>();

    public static Func<ĪnflexorEffectusNōminibusFactīsPrōnīs.Versio, PēnsorNōminibusFactīsPrōnīs> Faciendum = valor =>
    {
      if (Reservātī.ContainsKey(valor))
      {
        return Reservātī.Item[valor];
      }
      else
      {
        const PēnsorNōminibusFactīsPrōnīs hoc = new PēnsorNōminibusFactīsPrōnīs(valor);
        Reservātī.Add(valor, hoc);
        return hoc;
      }
    };

    private PēnsorNōminibusFactīsPrōnīs(in ĪnflexorEffectusNōminibusFactīsPrōnīs.Versio versiō)
                                                                                 : base(versiō, nameof(Īnflectendum.NōmenFactumPrōnum.Īnfīnītīvum),
                                                                                        Tabula.Nōmina_Facta_Prōna, NūntiusPēnsōrīNōminibusFactīsPrōnīs.Faciendum,
                                                                                        Īnflectendum.NōmenFactumPrōnum.Lēctor) {  }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīNōminibusFactīsPrōnīs : Nūntius<PēnsōrNōminibusFactīsPrōnīs>
    {
      public static readonly Lazy<NūntiusPēnsōrīNōminibusFactīsPrōnīs> Faciendum = new Lazy<NūntiusPēnsōrīNōminibusFactīsPrōnīs>(() => Instance);
    }
  }
}
