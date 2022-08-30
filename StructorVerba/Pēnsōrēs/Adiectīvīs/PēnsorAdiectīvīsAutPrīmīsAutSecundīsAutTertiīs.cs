using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;

namespace Pēnsōrēs.Adiectivīs
{
  public sealed class PēnsorAdiectīvīsAutPrīmīsAutSecundīsAutTertiīs
            : PēnsorĪnflectendīs<Īnflectendum.AdiectīvumAutPrīmumAutSecundumAutTertium, Multiplex.Adiectīvum>
  {
    private static Dictionary<Enum, PēnsorAdiectīvīsAutPrīmīsAutSecundīsAutTertiīs> Reservātī = new Dictionary<Enum, PēnsorAdiectīvīsAutPrīmīsAutSecundīsAutTertiīs>();

    public static Func<Enum, PēnsorAdiectīvīsAutPrīmīsAutSecundīsAutTertiīs> Faciendum = valor =>
    {
      if (Reservātī.ContainsKey(valor))
      {
        return Reservātī.Item[valor];
      }
      else
      {
        const PēnsorAdiectīvīsAutPrīmīsAutSecundīsAutTertiīs hoc = new PēnsorAdiectīvīsAutPrīmīsAutSecundīsAutTertiīs(valor);
        Reservātī.Add(valor, hoc);
        return hoc;
      }
    };

    private PēnsorAdiectīvīsAutPrīmīsAutSecundīsAutTertiīs(in Enum versiō)
                                                            : base(versiō, Ēnumerātiōnēs.Catēgoria.Adiectīvum,
                                                                   NūntiusPēnsōrīAdiectīvīsAutPrīmīsAutSecundīsAutTertiīs.Instance,
                                                                   nameof(Īnflectendum.AdiectīvumAutPrīmumAutSecundumAutTertium.Positīvum),
                                                                   Īnflectendum.AdiectīvumAutPrīmumAutSecundumAutTertium.Lēctor) {  }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīAdiectīvīsAutPrīmīsAutSecundīsAutTertiīs
               : Nūntius<PēnsorAdiectīvīsAutPrīmīsAutSecundīsAutTertiīs> {  }
  }
}
