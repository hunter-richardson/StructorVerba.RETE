using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;

namespace Pēnsōrēs.Adiectivīs
{
  public sealed class PēnsorAdiectīvīsIncomparātīvīsAutPrīmīsAutSecundīsAutTertiīs
            : PēnsorĪnflectendīs<Īnflectendum.AdiectīvumIncomparātīvumAutPrīmumAutSecundumAutTertium, Multiplex.Adiectīvum>
  {
    private static Dictionary<Enum, PēnsorAdiectīvīsIncomparātīvīsAutPrīmīsAutSecundīsAutTertiīs> Reservātī = new Dictionary<Enum, PēnsorAdiectīvīsIncomparātīvīsAutPrīmīsAutSecundīsAutTertiīs>();

    public static Func<Enum, PēnsorAdiectīvīsIncomparātīvīsAutPrīmīsAutSecundīsAutTertiīs> Faciendum = valor =>
    {
      if (Reservātī.ContainsKey(valor))
      {
        return Reservātī.Item[valor];
      }
      else
      {
        const PēnsorAdiectīvīsIncomparātīvīsAutPrīmīsAutSecundīsAutTertiīs hoc = new PēnsorAdiectīvīsIncomparātīvīsAutPrīmīsAutSecundīsAutTertiīs(valor);
        Reservātī.Add(valor, hoc);
        return hoc;
      }
    };

    private PēnsorAdiectīvīsIncomparātīvīsAutPrīmīsAutSecundīsAutTertiīs(in Enum versiō)
                                                                          : base(versiō, Ēnumerātiōnēs.Catēgoria.Adiectīvum,
                                                                                 NūntiusPēnsōrīAdiectīvīsIncomparātīvīsAutPrīmīsAutSecundīsAutTertiīs.Faciendum,
                                                                                 nameof(Īnflectendum.AdiectīvumIncomparātīvumAutPrīmumAutSecundumAutTertium.Neutrum),
                                                                                 Īnflectendum.AdiectīvumIncomparātīvumAutPrīmumAutSecundumAutTertium.Lēctor) {  }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīAdiectīvīsIncomparātīvīsAutPrīmīsAutSecundīsAutTertiīs
               : Nūntius<PēnsorAdiectīvīsIncomparātīvīsAutPrīmīsAutSecundīsAutTertiīs>
    {
      public static readonly Lazy<NūntiusPēnsōrīAdiectīvīsIncomparātīvīsAutPrīmīsAutSecundīsAutTertiīs> Faciendum =
                         new Lazy<NūntiusPēnsōrīAdiectīvīsIncomparātīvīsAutPrīmīsAutSecundīsAutTertiīs>(() => Instance);
    }
  }
}
