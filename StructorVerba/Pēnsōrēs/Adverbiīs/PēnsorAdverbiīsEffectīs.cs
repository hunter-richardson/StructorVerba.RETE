using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;

namespace Pēnsōrēs.Adverbiīs
{
  public sealed class PēnsorAdverbiīsEffectīs : PēnsorĪnflectendīs<Īnflectendum.AdverbiumEffectum, Multiplex.Adverbium>
  {
    private static Dictionary<Enum, PēnsorAdverbiīsEffectīs> Reservātī = new Dictionary<Enum, PēnsorAdverbiīsEffectīs>();

    public static Func<Enum, PēnsorAdverbiīsEffectīs> Faciendum = valor =>
    {
      if (Reservātī.ContainsKey(valor))
      {
        return Reservātī.Item[valor];
      }
      else
      {
        const PēnsorAdverbiīsEffectīs hoc = new PēnsorAdverbiīsEffectīs(valor);
        Reservātī.Add(valor, hoc);
        return hoc;
      }
    };

    private PēnsorAdverbiīsEffectīs(in Enum versiō)
                                     : base(versiō, Ēnumerātiōnēs.Catēgoria.Adverbium,
                                            NūntiusPēnsōrīAdverbiīsEffectīs.Instance,
                                            nameof(Īnflectendum.AdverbiumEffectum.Positīvum),
                                            Īnflectendum.AdverbiumEffectum.Lēctor) {  }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīAdverbiīsEffectīs : Nūntius<PēnsorAdverbiīsEffectīs> {  }
  }
}
