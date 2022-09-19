using System;
using System.Collections.Generic.IEnumerable;

using Miscella;
using Praebeunda.Īnflecendum;
using Pēnsōrēs.Īnflectenda.PēnsorAdiectīvīs.Versiō;
using Īnflexōrēs.Effectī.Adiectīva;
using Ēnumerātiōnēs;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttritbue;
using Lombok.NET.PropertyGenerators.SingletonAttritbue;

namespace Īnflexōrēs.Dēfectī.Adiectīva
{
  public abstract class ĪnflexorIncomparābilisAdiectīvīs : ĪnflexorDēfectusAdiectīvīs<Īnflectendum.Adiectīva>
  {
    [AsyncOverloads]
    private static readonly Lazy<ĪnflexorIncomparābilisAdiectīvīs> AutPrīmusAutSecundus
            = new Lazy(() => new ĪnflexorIncomparābilisAdiectīvīs(relātus: ĪnflexorEffectusAdiectīvīsAutPrīmusAutSecundusAutTertius.Faciendum));
    private static readonly Lazy<ĪnflexorIncomparābilisAdiectīvīs> AutPrīmusAutSecundusCumLitterāE
            = new Lazy(() => new ĪnflexorIncomparābilisAdiectīvīs(relātus: ĪnflexorEffectusAdiectīvīsAutPrīmusAutSecundusAutTertiusCumLitterāE.Faciendum));
    private static readonly Lazy<ĪnflexorIncomparābilisAdiectīvīs> AutPrīmusAutSecundusSineLitterāE
            = new Lazy(() => new ĪnflexorIncomparābilisAdiectīvīs(relātus: ĪnflexorEffectusAdiectīvīsAutPrīmusAutSecundusAutTertiusSineLitterāE.Faciendum));
    private static readonly Lazy<ĪnflexorIncomparābilisAdiectīvīs> Tertius
            = new Lazy(() => new ĪnflexorIncomparābilisAdiectīvīs(relātus: ĪnflexorEffectusAdiectīvīsAutTertiusAutPrīmusAutSecundus.Faciendum));
    private static readonly Lazy<ĪnflexorIncomparābilisAdiectīvīs> TertiusCumGenitīvōVariō
            = new Lazy(() => new ĪnflexorIncomparābilisAdiectīvīs(relātus: ĪnflexorEffectusAdiectīvīsAutTertiusAutPrīmusAutSecundusCumGenitīvōVariō.Faciendum));
    private static readonly Lazy<ĪnflexorIncomparābilisAdiectīvīs> TertiusCumAblātīvōVariō
            = new Lazy(() => new ĪnflexorIncomparābilisAdiectīvīs(relātus: ĪnflexorEffectusAdiectīvīsAutTertiusAutPrīmusAutSecundusCumAblātīvōVariō.Faciendum));
    private static readonly Lazy<ĪnflexorIncomparābilisAdiectīvīs> TertiusCumGenitīvōAblātīvōqueVariō
            = new Lazy(() => new ĪnflexorIncomparābilisAdiectīvīs(relātus: ĪnflexorEffectusAdiectīvīsAutTertiusAutPrīmusAutSecundusCumGenitīvōAblātīvōqueVariō.Faciendum));
    private static readonly Lazy<ĪnflexorIncomparābilisAdiectīvīs> Prōnōminālis
            = new Lazy(() => new ĪnflexorIncomparābilisAdiectīvīs(relātus: ĪnflexorEffectusPrōnōminālisAdiectīvīs.Faciendum));
    private static readonly Lazy<ĪnflexorIncomparābilisAdiectīvīs> PrōnōminālisCumLitterāE
            = new Lazy(() => new ĪnflexorIncomparābilisAdiectīvīs(relātus: ĪnflexorEffectusPrōnōminālisAdiectīvīsCumLitterāE.Faciendum));
    private static readonly Lazy<ĪnflexorIncomparābilisAdiectīvīs> PrōnōminālisSineLitterāE
            = new Lazy(() => new ĪnflexorIncomparābilisAdiectīvīs(relātus: ĪnflexorEffectusPrōnōminālisAdiectīvīsAutPrīmusSineLitterāE.Faciendum));

    public static readonly Func<PēnsorAdiectīvīs.Versiō, Task<Lazy<ĪnflexorIncomparābilisAdiectīvīs?>>> Relātor
        = async versiō => versiō switch
                          {
                            PēnsorAdiectīvīs.Versiō.Incomparābilis_Aut_Prīmus_Aut_Secundus => AutPrīmusAutSecundus,
                            PēnsorAdiectīvīs.Versiō.Incomparābilis_Aut_Prīmus_Aut_Secundus_Cum_Litterā_Ē => AutPrīmusAutSecundusCumLitterāE,
                            PēnsorAdiectīvīs.Versiō.Incomparābilis_Aut_Prīmus_Aut_Secundus_Sine_Litterā_Ē => AutPrīmusAutSecundusSineLitterāE,
                            PēnsorAdiectīvīs.Versiō.Incomparābilis_Aut_Tertius => Tertius,
                            PēnsorAdiectīvīs.Versiō.Incomparābilis_Aut_Tertius_Cum_Genitīvō_Variō => TertiusCumGenitīvōVariō,
                            PēnsorAdiectīvīs.Versiō.Incomparābilis_Aut_Tertius_Cum_Ablātīvō_Variō => TertiusCumAblātīvōVariō,
                            PēnsorAdiectīvīs.Versiō.Incomparābilis_Aut_Tertius_Cum_Genitīvō_Ablātīvōque_Variō => TertiusCumGenitīvōAblātīvōqueVariō,
                            PēnsorAdiectīvīs.Versiō.Incomparābilis_Prōnōminālis => Prōnōminālis,
                            PēnsorAdiectīvīs.Versiō.Incomparābilis_Prōnōminālis_Cum_Litterā_Ē => PrōnōminālisCumLitterāE,
                            PēnsorAdiectīvīs.Versiō.Incomparābilis_Prōnōminālis_Sine_Litterā_Ē => PrōnōminālisSineLitterāE,
                            _ => new Lazy(null),
                          };

    private ĪnflexorIncomparābilisAdiectīvīs(in Lazy<ĪnflexorEffectusAdiectīvīs> relātus)
        : base(nūntius: new Lazy<Nūntius<ĪnflexorIncomparābilisAdiectīvīs>>(), relātus: relātus)
        => Nūntius.PlūsGarriōAsync("Fīō");

    protected sealed Enum[] Referō(in Enum[] illa)
         => Ūtilitātēs.Seriēs(Gradus.Positīvus, illa.FirstOf<Genus>(), illa.FirstOf<Numerālis>(), illa.FirstOf<Casus>());
  }
}
