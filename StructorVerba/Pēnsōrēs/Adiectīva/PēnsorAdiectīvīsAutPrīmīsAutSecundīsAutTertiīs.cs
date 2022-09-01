using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;

namespace Pēnsōrēs.Adiectiva
{
  public sealed class PēnsorAdiectīvīsAutPrīmīsAutSecundīsAutTertiīs
            : PēnsorAdiectīvīs<Īnflectendum.AdiectīvumAutPrīmumAutSecundumAutTertium>
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

    private PēnsorAdiectīvīsAutPrīmīsAutSecundīsAutTertiīs(in ĪnflexōrēsEffectusĀctibus.Versiō versiō)
                                                                                        : base(versiō,
                                                                                               nameof(Īnflectendum.AdiectīvumAutPrīmumAutSecundumAutTertium.Positīvum),
                                                                                               NūntiusPēnsōrīAdiectīvīsAutPrīmīsAutSecundīsAutTertiīs.Faciendum,
                                                                                               Īnflectendum.AdiectīvumAutPrīmumAutSecundumAutTertium.Lēctor) {  }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīAdiectīvīsAutPrīmīsAutSecundīsAutTertiīs
               : Nūntius<PēnsorAdiectīvīsAutPrīmīsAutSecundīsAutTertiīs>
    {
      public static readonly Lazy<NūntiusPēnsōrīAdiectīvīsAutPrīmīsAutSecundīsAutTertiīs> Faciendum =
                         new Lazy<NūntiusPēnsōrīAdiectīvīsAutPrīmīsAutSecundīsAutTertiīs>(() => Instance);
    }
  }
}
