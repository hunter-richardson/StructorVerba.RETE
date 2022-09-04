using System;
using System.Collections.Generic.IEnumerable;

using Miscella;
using Praebeunda.Īnflecendum;
using Īnflexōrēs.Effectī.Nōmina.ĪnflexorEffectusNōminibusFactīs;
using Ēnumerātiōnēs;

namespace Īnflexōrēs.Dēfectī.Nōmina
{
  public abstract class ĪnflexorNōminibusFactīsPrōnīs : ĪnflexorDēfectusNōminibus<Īnflectendum.NōmenFactum>
  {
    public static readonly Func<PēnsorNōminibusFactīs.Versiō, Task<Lazy<ĪnflexorNōminibusFactīsPrōnīs?>>> Relātor = async versiō => versiō switch
    {
      Nōmen_Factum_Prīmum_Prōnum => null,
      Nōmen_Factum_Secundum_Prōnum => null,
      Nōmen_Factum_Tertium_Prōnum => null,
      Nōmen_Factum_Quārtum_Prōnum => null,
      _ => new Lazy(null),
    };

    protected ĪnflexorNōminibusFactīsPrōnīs(in Lazy<Nūntius<ĪnflexorNōminibusFactīsPrōnīs>> nūntius,
                                            in Lazy<ĪnflexorEffectusNōminibusFactīs> relātus, in params IEnumerable<Enum[]> illa)
                                                                                     : base(nūntius, relātus, illa) { }

    protected sealed Enum[] Referō(in Enum[] illa)
    {
      Factum factum = illa.FirstOf<Factum>();
      factum = (factum is Factum.Supīnum).Choose(Factum.Gerundīvum, factum);
      return Ūtilitātēs.Seriēs(factum, illa.FirstOf<Casus>());
    }
  }
}
