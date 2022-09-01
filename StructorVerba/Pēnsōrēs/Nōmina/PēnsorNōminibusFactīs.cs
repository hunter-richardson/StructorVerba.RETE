using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;
using Īnflexōrēs.Effectī.Nōmina.NōminaFacta.ĪnflexorEffectusNōminibusFactīs.Versio;

namespace Pēnsōrēs.Nōmina
{
  public sealed class PēnsorNōminibusFactīs : PēnsorNōminibus<Īnflectendum.NōmenFactum>
  {
    private static Dictionary<ĪnflexorEffectusNōminibusFactīs.Versio, PēnsorNōminibusFactīs> Reservātī
             = new Dictionary<ĪnflexorEffectusNōminibusFactīs.Versio, PēnsorNōminibusFactīs>();

    public static Func<ĪnflexorEffectusNōminibusFactīs.Versio, PēnsorNōminibusFactīs> Faciendum = valor =>
    {
      if (Reservātī.ContainsKey(valor))
      {
        return Reservātī.Item[valor];
      }
      else
      {
        const PēnsorNōminibusFactīs hoc = new PēnsorNōminibusFactīs(valor);
        Reservātī.Add(valor, hoc);
        return hoc;
      }
    };

    private PēnsorNōminibusFactīs(in ĪnflexorEffectusNōminibusFactīs.Versio versiō)
                                                                     : base(versiō, nameof(Īnflectendum.NōmenFactum.Īnfīnītīvum),
                                                                            Tabula.Nōmina_Facta, NūntiusPēnsōrīNōminibusFactīs.Faciendum,
                                                                            Īnflectendum.NōmenFactum.Lēctor) {  }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīNōminibusFactīs : Nūntius<PēnsorNōminibusFactīs>
    {
      public static readonly Lazy<NūntiusPēnsōrīNōminibusFactīs> Faciendum = new Lazy<NūntiusPēnsōrīNōminibusFactīs>(() => Instance);
    }
  }
}
