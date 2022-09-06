using System;
using System.Collections.Generic.IEnumerable;

using Miscella;
using Praebeunda.Īnflecendum;
using Īnflexōrēs.Effectī.Nōmina.NōminaFacta.ĪnflexorEffectusNōminibusFactīs;
using Ēnumerātiōnēs;

namespace Īnflexōrēs.Dēfectī.Nōmina
{
  public sealed class ĪnflexorNōminibusFactīsPrōnīs : ĪnflexorDēfectusNōminibus<Īnflectendum.NōmenFactum>
  {
    private static readonly Lazy<ĪnflexorNōminibusFactīsPrōnīs> Prīmus
                      = new Lazy<ĪnflexorNōminibusFactīsPrōnīs>(() => new ĪnflexorNōminibusFactīsPrōnīs(ĪnflexorEffectusPrīmusNōminibusFactīs.Faciendum));
    private static readonly Lazy<ĪnflexorNōminibusFactīsPrōnīs> Secundus
                      = new Lazy<ĪnflexorNōminibusFactīsPrōnīs>(() => new ĪnflexorNōminibusFactīsPrōnīs(ĪnflexorEffectusSecundusNōminibusFactīs.Faciendum));
    private static readonly Lazy<ĪnflexorNōminibusFactīsPrōnīs> Tertius
                      = new Lazy<ĪnflexorNōminibusFactīsPrōnīs>(() => new ĪnflexorNōminibusFactīsPrōnīs(ĪnflexorEffectusTertiusNōminibusFactīs.Faciendum));
    private static readonly Lazy<ĪnflexorNōminibusFactīsPrōnīs> Quārtus
                      = new Lazy<ĪnflexorNōminibusFactīsPrōnīs>(() => new ĪnflexorNōminibusFactīsPrōnīs(ĪnflexorEffectusQuārtusNōminibusFactīs.Faciendum));
    public static readonly Func<PēnsorNōminibusFactīs.Versiō, Task<Lazy<ĪnflexorNōminibusFactīsPrōnīs?>>> Relātor = async versiō => versiō switch
    {
      Nōmen_Factum_Prīmum_Prōnum => Prīmus,
      Nōmen_Factum_Secundum_Prōnum => Secundus,
      Nōmen_Factum_Tertium_Prōnum => Tertius,
      Nōmen_Factum_Quārtum_Prōnum => Quārtus,
      _ => new Lazy(null),
    };

    private ĪnflexorNōminibusFactīsPrōnīs(in Lazy<ĪnflexorEffectusNōminibusFactīs> relātus)
                           : base(NūntiusĪnflexōrīNōminibusFactīsPrōnīs.Faciendum, relātus) { }

    protected Enum[] Referō(in Enum[] illa)
    {
      Factum factum = illa.FirstOf<Factum>();
      factum = (factum is Factum.Supīnum).Choose(Factum.Gerundīvum, factum);
      return Ūtilitātēs.Seriēs(factum, illa.FirstOf<Casus>());
    }

    [Singleton]
    private sealed partial class NūntiusĪnflexōrīNōminibusFactīsPrōnīs : Nūntius<ĪnflexorNōminibusFactīsPrōnīs>
    {
      public static readonly Lazy<NūntiusĪnflexōrīNōminibusFactīsPrōnīs> Faciendum
                       = new Lazy<NūntiusĪnflexōrīNōminibusFactīsPrōnīs>(() => Instance);
    }
  }
}
