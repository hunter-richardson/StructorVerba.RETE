using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;

namespace Pēnsōrēs.Adiectiva
{
  public sealed class PēnsorAdiectīvīsAutTertiīsAutPrīmīsAutSecundīs
            : PēnsorAdiectīvīs<Īnflectendum.AdiectīvumTertiumAutPrīmumAutSecundum>
  {
    private static Dictionary<ĪnflexorEffectusĀctibus.Versiō, PēnsorAdiectīvīsAutTertiīsAutPrīmīsAutSecundīs> Reservātī
             = new Dictionary<ĪnflexorEffectusĀctibus.Versiō, PēnsorAdiectīvīsAutTertiīsAutPrīmīsAutSecundīs>();

    public static Func<ĪnflexorEffectusĀctibus.Versiō, PēnsorAdiectīvīsAutTertiīsAutPrīmīsAutSecundīs> Faciendum = valor =>
    {
      if (Reservātī.ContainsKey(valor))
      {
        return Reservātī.Item[valor];
      }
      else
      {
        const PēnsorAdiectīvīsAutTertiīsAutPrīmīsAutSecundīs hoc = new PēnsorAdiectīvīsAutTertiīsAutPrīmīsAutSecundīs(valor);
        Reservātī.Add(valor, hoc);
        return hoc;
      }
    };

    private PēnsorAdiectīvīsAutTertiīsAutPrīmīsAutSecundīs(in ĪnflexorEffectusĀctibus.Versiō versiō)
                                                                                      : base(versiō,
                                                                                             nameof(Īnflectendum.AdiectīvumTertiumAutPrīmumAutSecundum.Nominātīvum),
                                                                                             NūntiusPēnsōrīAdiectīvīsAutTertiīsAutPrīmīsAutSecundīs.Faciendum,
                                                                                             Īnflectendum.AdiectīvumTertiumAutPrīmumAutSecundum.Lēctor) {  }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīAdiectīvīsAutTertiīsAutPrīmīsAutSecundīs
               : Nūntius<PēnsorAdiectīvīsAutTertiīsAutPrīmīsAutSecundīs>
    {
      public static readonly Lazy<NūntiusPēnsōrīAdiectīvīsAutTertiīsAutPrīmīsAutSecundīs> Faciendum =
                         new Lazy<NūntiusPēnsōrīAdiectīvīsAutTertiīsAutPrīmīsAutSecundīs>(() => Instance);
    }
  }
}
