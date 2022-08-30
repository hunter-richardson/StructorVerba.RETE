using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;

namespace Pēnsōrēs.Nōminibus
{
  public sealed class PēnsorNōminibusFactīs : PēnsorĪnflectendīs<Īnflectendum.NōmenFactum, Multiplex.Nōmen>
  {
    private static Dictionary<Enum, PēnsorNōminibusFactīs> Reservātī = new Dictionary<Enum, PēnsorNōminibusFactīs>();

    public static Func<Enum, PēnsorNōminibusFactīs> Faciendum = valor =>
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

    private PēnsorNōminibusFactīs(in Enum versiō)
                                   : base(versiō, Ēnumerātiōnēs.Catēgoria.Nōmen,
                                          NūntiusPēnsōrīNōminibusFactīs.Instance,
                                          nameof(Īnflectendum.NōmenFactum.Īnfīnītīvum),
                                          Īnflectendum.NōmenFactum.Lēctor) {  }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīNōminibusFactīs : Nūntius<PēnsōrNōminibusFactīs> {  }
  }
}
