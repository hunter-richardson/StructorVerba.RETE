using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;

namespace Pēnsōrēs.Adiectiva
{
  public sealed class PēnsorAdiectīvīsIncomparātīvīsAutPrīmīsAutSecundīsAutTertiīs
            : PēnsorAdiectīvīs<Īnflectendum.AdiectīvumIncomparātīvumAutPrīmumAutSecundumAutTertium>
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
                                                                          : base(versiō,
                                                                                 nameof(Īnflectendum.AdiectīvumIncomparātīvumAutPrīmumAutSecundumAutTertium.Neutrum),
                                                                                 NūntiusPēnsōrīAdiectīvīsIncomparātīvīsAutPrīmīsAutSecundīsAutTertiīs.Faciendum,
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
