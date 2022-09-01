using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;
using Īnflexōrēs.Effectī.Nōmina.ĪnflexorEffectusNōminibus.Versio;

namespace Pēnsōrēs.Nōmina
{
  public abstract class PēnsorNōminibus<Hoc> : PēnsorĪnflectendīs<Hoc, Multiplex.Nōmen>
  {
    private PēnsorNōminibus(in Enum versiō, in string quaerendī,
                            in Lazy<Nūntius<PēnsorĪnflectendīs<Hoc>>> nūntius,
                            in Func<JsonElement, Task<Hoc>> lēctor)
                             : base(versiō, Ēnumerātiōnēs.Catēgoria.Nōmen, quaerendī, nūntius, lēctor) { }
  }

  public sealed class PēnsorNōminibus : PēnsorNōminibus<Īnflectendum.Nōmen>
  {
    private static Dictionary<ĪnflexorEffectusNōminibus.Versio, PēnsorNōminibus> Reservātī
             = new Dictionary<ĪnflexorEffectusNōminibus.Versio, PēnsorNōminibus>();

    public static Func<ĪnflexorEffectusNōminibus.Versio, PēnsorNōminibus> Faciendum = valor =>
    {
      if (Reservātī.ContainsKey(valor))
      {
        return Reservātī.Item[valor];
      }
      else
      {
        const PēnsorNōminibus hoc = new PēnsorNōminibus(valor);
        Reservātī.Add(valor, hoc);
        return hoc;
      }
    };

    private PēnsorNōminibus(in ĪnflexorEffectusNōminibus.Versio versiō)
                                                         : base(versiō, nameof(Īnflectendum.Nōmen.Nominātīvum),
                                                                Tabula.Nōmina, NūntiusPēnsōrīNōminibus.Faciendum,
                                                                Īnflectendum.Nōmen.Lēctor) {  }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīNōminibus : Nūntius<PēnsōrNōminibus>
    {
      public static readonly Lazy<NūntiusPēnsōrīNōminibus> Faciendum = new Lazy<NūntiusPēnsōrīNōminibus>(() => Instance);
    }
  }
}
