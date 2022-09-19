using System;
using System.Collections.Generic.IEnumerable;

using Miscella;
using Praebeunda.Īnflecendum;
using Pēnsōrēs.Nōmina.PēnsorNōminibusFactīs.Versiō;
using Īnflexōrēs.Effectī.Nōmina.NōminaFacta.ĪnflexorEffectusNōminibusFactīs;
using Ēnumerātiōnēs;

namespace Īnflexōrēs.Dēfectī.Nōmina
{
  public sealed class ĪnflexorNōminibusFactīsPrōnīs : ĪnflexorDēfectusNōminibus<Īnflectendum.NōmenFactum>
  {
    private static readonly Lazy<ĪnflexorNōminibusFactīsPrōnīs> Prīmus
            = new Lazy(() => new ĪnflexorNōminibusFactīsPrōnīs(versiō: PēnsorNōminibusFactīs.Versiō.Nōmen_Factum_Prīmum));
    private static readonly Lazy<ĪnflexorNōminibusFactīsPrōnīs> Secundus
            = new Lazy(() => new ĪnflexorNōminibusFactīsPrōnīs(versiō: PēnsorNōminibusFactīs.Versiō.Nōmen_Factum_Secundum));
    private static readonly Lazy<ĪnflexorNōminibusFactīsPrōnīs> Tertius
            = new Lazy(() => new ĪnflexorNōminibusFactīsPrōnīs(versiō: PēnsorNōminibusFactīs.Versiō.Nōmen_Factum_Tertium));
    private static readonly Lazy<ĪnflexorNōminibusFactīsPrōnīs> TertiusVarius
            = new Lazy(() => new ĪnflexorNōminibusFactīsPrōnīs(versiō: PēnsorNōminibusFactīs.Versiō.Nōmen_Factum_Tertium_Varium));
    private static readonly Lazy<ĪnflexorNōminibusFactīsPrōnīs> Quārtus
            = new Lazy(() => new ĪnflexorNōminibusFactīsPrōnīs(versiō: PēnsorNōminibusFactīs.Versiō.Nōmen_Factum_Quārtum));
    public static readonly Func<PēnsorNōminibusFactīs.Versiō, Task<Lazy<ĪnflexorNōminibusFactīsPrōnīs?>>> Relātor
        = async versiō => versiō switch
                          {
                            Nōmen_Factum_Prīmum_Prōnum => Prīmus,
                            Nōmen_Factum_Secundum_Prōnum => Secundus,
                            Nōmen_Factum_Tertium_Prōnum => Tertius,
                            Nōmen_Factum_Tertium_Varium_Prōnum => TertiusVarius,
                            Nōmen_Factum_Quārtum_Prōnum => Quārtus,
                            _ => new Lazy(null),
                          };

    private ĪnflexorNōminibusFactīsPrōnīs(PēnsorNōminibusFactīs.Versiō versiō)
        : base(nūntius: new Lazy<Nūntius<ĪnflexorNōminibusFactīsPrōnīs>>(),
               relātus: ĪnflexorEffectusNōminibusFactīs.Relātor.Invoke(versiō))
        => Nūntius.PlūsGarriōAsync("Fīō");

    protected Enum[] Referō(in Enum[] illa)
    {
      Factum factum = illa.FirstOf<Factum>();
      factum = (factum is Factum.Supīnum).Choose(Factum.Gerundīvum, factum);
      return Ūtilitātēs.Seriēs(factum, illa.FirstOf<Casus>());
    }
  }
}
