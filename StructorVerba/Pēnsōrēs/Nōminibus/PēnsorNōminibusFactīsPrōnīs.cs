using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;

namespace Pēnsōrēs.Nōminibus
{
  public sealed class PēnsorNōminibusFactīsPrōnīs : PēnsorĪnflectendīs<Īnflectendum.NōmenFactumPrōnum, Multiplex.Nōmen>
  {
    private static Dictionary<Enum, PēnsorNōminibusFactīsPrōnīs> Reservātī = new Dictionary<Enum, PēnsorNōminibusFactīsPrōnīs>();

    public static Func<Enum, PēnsorNōminibusFactīsPrōnīs> Faciendum = valor =>
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

    private PēnsorNōminibusFactīsPrōnīs(in Enum versiō)
                                         : base(versiō, Ēnumerātiōnēs.Catēgoria.Nōmen,
                                                NūntiusPēnsōrīNōminibusFactīsPrōnīs.Instance,
                                                nameof(Īnflectendum.NōmenFactumPrōnum.Īnfīnītīvum),
                                                Īnflectendum.NōmenFactumPrōnum.Lēctor) {  }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīNōminibusFactīsPrōnīs : Nūntius<PēnsōrNōminibusFactīsPrōnīs> {  }
  }
}
