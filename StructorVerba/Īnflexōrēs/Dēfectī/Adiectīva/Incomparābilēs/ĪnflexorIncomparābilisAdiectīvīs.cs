using System;
using System.Collections.Generic.IEnumerable;

using Miscella;
using Praebeunda.Īnflecendum;
using Pēnsōrēs.Īnflectenda.PēnsorAdiectīvīs.Versiō;
using Īnflexōrēs.Effectī.Adiectīva.ĪnflexorEffectusAdiectīvīs;
using Ēnumerātiōnēs;

namespace Īnflexōrēs.Dēfectī.Adiectīva.Incomparābilēs
{
  public abstract class ĪnflexorIncomparābilisAdiectīvīs : ĪnflexorDēfectusAdiectīvīs<Īnflectendum.Adiectīva>
  {
    public static readonly Func<PēnsorAdiectīvīs.Versiō, Task<Lazy<ĪnflexorIncomparābilisAdiectīvīs?>>> Relātor = async versiō => versiō switch
    {
      PēnsorAdiectīvīs.Incomparābilis_Aut_Prīmus_Aut_Secundus => null,
      PēnsorAdiectīvīs.Incomparābilis_Aut_Prīmus_Aut_Secundus_Cum_Litterā_Ē => null,
      PēnsorAdiectīvīs.Incomparābilis_Aut_Prīmus_Aut_Secundus_Sine_Litterā_Ē => null,
      PēnsorAdiectīvīs.Incomparābilis_Aut_Tertius_Cum_Genitīvō_Variō => null,
      PēnsorAdiectīvīs.Incomparābilis_Aut_Tertius_Cum_Ablātīvō_Variō => null,
      PēnsorAdiectīvīs.Incomparābilis_Aut_Tertius_Cum_Genitīvō_Ablātīvōque_Variō => null,
      PēnsorAdiectīvīs.Incomparābilis_Prōnōminālis => null,
      PēnsorAdiectīvīs.Incomparābilis_Prōnōminālis_Varius => null,
      _ => new Lazy(null),
    };

    protected ĪnflexorIncomparābilisAdiectīvīs(in Lazy<Nūntius<ĪnflexorIncomparābilisAdiectīvīs>> nūntius,
                                               in Lazy<ĪnflexorEffectusAdiectīvīs> relātus)
                                                                                           : base(nūntius, relātus) { }

    protected sealed Enum[] Referō(in Enum[] illa)
         => Ūtilitātēs.Seriēs(Gradus.Positīvus, illa.FirstOf<Genus>(), illa.FirstOf<Numerālis>(), illa.FirstOf<Casus>());
  }
}
