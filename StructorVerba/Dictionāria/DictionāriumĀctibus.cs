using System.Lazy;
using System.Threading.Tasks.Task;

using Miscella.Extensions;
using Praebeunda.Multiplex.Āctus;
using Ēnumerātiōnēs;
using Īnflexōrēs.Incertī;
using Īnflexōrēs.Incertī.Āctūs;

using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Dictionāria
{
  [Lazy]
  public sealed partial class DictionāriumĀctibus : Dictionārium<Multiplex.Āctus>
  {
    protected readonly Lazy<ĪnflexorPraefīxus> Abdare
        = new Lazy(() => new ĪnflexorPraefīxus(relātus: ĪnflexorVerbīDare.Lazy, praefīxum: "ab"));
    protected readonly Lazy<ĪnflexorRescrīptus> Abesse
        = new Lazy(() => new ĪnflexorRescrīptus(relātus: ĪnflexorVerbīEsse.Lazy,
                                                rescrīptor: scrīptum => scrīptum.StartsWith('f')
                                                                                .Choose("ā", "ab").Concat(scrīptum)));
    protected readonly Lazy<ĪnflexorPraefīxus> Abīre
        = new Lazy(() => new ĪnflexorPraefīxus(relātus: ĪnflexorVerbīĪre.Lazy, praefīxum: "ab"));
    protected readonly Lazy<ĪnflexorPraefīxus> Addare
        = new Lazy(() => new ĪnflexorPraefīxus(relātus: ĪnflexorVerbīDare.Lazy, praefīxum: "ad"));
    protected readonly Lazy<ĪnflexorPraefīxus> Adesse
        = new Lazy(() => new ĪnflexorPraefīxus(relātus: ĪnflexorVerbīEsse.Lazy, praefīxum: "ad"));
    protected readonly Lazy<ĪnflexorRescrīptus> Afferre
        = new Lazy(() => new ĪnflexorRescrīptus(relātus: ĪnflexorVerbīFerre.Lazy,
                                                rescrīptor: scrīptum => "a".Concat(scrīptum[0]).Concat(scrīptum)));
    protected readonly Lazy<ĪnflexorIncertus> Aiere = ĪnflexorVerbīAiere.Lazy;
    protected readonly Lazy<ĪnflexorRescrīptus> Auferre
        = new Lazy(() => new ĪnflexorRescrīptus(relātus: ĪnflexorVerbīFerre.Lazy,
                                                rescrīptor: scrīptum => (scrīptum[0] switch
                                                                          {
                                                                            'f' => "au",
                                                                            't' => "abs",
                                                                            'l' => "ab",
                                                                            _ => string.Empty
                                                                          }).Concat(scrīptum)));
    protected readonly Lazy<ĪnflexorRescrīptus> Benefacere
        = new Lazy(() => new ĪnflexorRescrīptus(relātus: ĪnflexorVerbīFacere.Lazy,
                                                rescrīptor: scrīptum => "bene".Concat((scrīptum is "fac").Choose("face", scrīptum))));
    protected readonly Lazy<ĪnflexorRescrīptus> Calefacere
        = new Lazy(() => new ĪnflexorRescrīptus(relātus: ĪnflexorVerbīFacere.Lazy,
                                                rescrīptor: scrīptum => "cale".Concat((scrīptum is "fac").Choose("face", scrīptum))));
    protected readonly Lazy<ĪnflexorPraefīxus> Circumferre
        = new Lazy(() => new ĪnflexorPraefīxus(relātus: ĪnflexorVerbīFerre.Lazy, praefīxum: "circum"));
    protected readonly Lazy<ĪnflexorPraefīxus> Circumīre
        = new Lazy(() => new ĪnflexorPraefīxus(relātus: ĪnflexorVerbīĪre.Lazy, praefīxum: "circum"));
    protected readonly Lazy<ĪnflexorIncertus> Coesse = ĪnflexorVerbīCoesse.Lazy;
    protected readonly Lazy<ĪnflexorRescrīptus> Commonefacere
        = new Lazy(() => new ĪnflexorRescrīptus(relātus: ĪnflexorVerbīFacere.Lazy,
                                                rescrīptor: scrīptum => "commone".Concat((scrīptum is "fac").Choose("face", scrīptum))));
    protected readonly Lazy<ĪnflexorPraefīxus> Condare
        = new Lazy(() => new ĪnflexorPraefīxus(relātus: ĪnflexorVerbīDare.Lazy, praefīxum: "con"));
    protected readonly Lazy<ĪnflexorPerfectusSōlusĀctibus> Coepisse
        = new Lazy(() => new ĪnflexorPerfectusSōlusĀctibus(relātus: ĪnflexorEffectusTertiusĀctibus.Lazy,
                                                           perfectum: "coepisse", supīnum: "coeptum"));
    protected readonly Lazy<ĪnflexorPraefīxus> Coīre
        = new Lazy(() => new ĪnflexorPraefīxus(relātus: ĪnflexorVerbīĪre.Lazy, praefīxum: "co"));
    protected readonly Lazy<ĪnflexorRescrīptus> Cōnferre
        = new Lazy(() => new ĪnflexorRescrīptus(relātus: ĪnflexorVerbīFerre.Lazy,
                                                rescrīptor: scrīptum => (scrīptum[0] switch
                                                                          {
                                                                            'f' => "cōn",
                                                                            't' => "con",
                                                                            'l' => "col",
                                                                            _ => string.Empty
                                                                          }).Concat(scrīptum)));
    protected readonly Lazy<ĪnflexorIncertus> Dare = ĪnflexorVerbīDare.Lazy;
    protected readonly Lazy<ĪnflexorPraefīxus> Dēdare
        = new Lazy(() => new ĪnflexorPraefīxus(relātus: ĪnflexorVerbīDare.Lazy, praefīxum: "dē"));
    protected readonly Lazy<ĪnflexorPraefīxus> Dēesse
        = new Lazy(() => new ĪnflexorPraefīxus(relātus: ĪnflexorVerbīEsse.Lazy, praefīxum: "dē"));
    protected readonly Lazy<ĪnflexorPraefīxus> Dēferre
        = new Lazy(() => new ĪnflexorPraefīxus(relātus: ĪnflexorVerbīFerre.Lazy, praefīxum: "dē"));
    protected readonly Lazy<ĪnflexorIncertus> Deīre = ĪnflexorVerbīDeīre.Lazy;
    protected readonly Lazy<ĪnflexorRescrīptus> Differre
        = new Lazy(() => new ĪnflexorRescrīptus(relātus: ĪnflexorVerbīFerre.Lazy,
                                                rescrīptor: scrīptum => (scrīptum[0] switch
                                                                          {
                                                                            'f' => "dif",
                                                                            't' => "dis",
                                                                            'l' => "dī",
                                                                            _ => string.Empty
                                                                          }).Concat(scrīptum)));
    protected readonly Lazy<ĪnflexorIncertus> Disperīre = ĪnflexorVerbīDisperīre.Lazy;
    protected readonly Lazy<ĪnflexorPraefīxus> Dīdare
        = new Lazy(() => new ĪnflexorPraefīxus(relātus: ĪnflexorVerbīDare.Lazy, praefīxum: "dī"));
    protected readonly Lazy<ĪnflexorRescrīptus> Efferre
        = new Lazy(() => new ĪnflexorRescrīptus(relātus: ĪnflexorVerbīFerre.Lazy,
                                                rescrīptor: scrīptum => (scrīptum[0] switch
                                                                          {
                                                                            'f' => "ef",
                                                                            't' => "ex",
                                                                            'l' => "ē",
                                                                            _ => string.Empty
                                                                          }).Concat(scrīptum)));
    protected readonly Lazy<ĪnflexorIncertus> Esse = ĪnflexorVerbīEsse.Lazy;
    protected readonly Lazy<ĪnflexorPraefīxus> Exīre
        = new Lazy(() => new ĪnflexorPraefīxus(relātus: ĪnflexorVerbīĪre.Lazy, praefīxum: "ex"));
    protected readonly Lazy<ĪnflexorIncertus> Facere = ĪnflexorVerbīFacere.Lazy;
    protected readonly Lazy<ĪnflexorIncertus> Ferre = ĪnflexorVerbīFerre.Lazy;
    protected readonly Lazy<ĪnflexorPraefīxus> Interesse
        = new Lazy(() => new ĪnflexorPraefīxus(relātus: ĪnflexorVerbīEsse.Lazy, praefīxum: "inter"));
    protected readonly Lazy<ĪnflexorPraefīxus> Interferre
        = new Lazy(() => new ĪnflexorPraefīxus(relātus: ĪnflexorVerbīFerre.Lazy, praefīxum: "inter"));
    protected readonly Lazy<ĪnflexorPraefīxus> Intrōferre
        = new Lazy(() => new ĪnflexorPraefīxus(relātus: ĪnflexorVerbīFerre.Lazy, praefīxum: "intrō"));
    protected readonly Lazy<ĪnflexorPraefīxus> Inīre
        = new Lazy(() => new ĪnflexorPraefīxus(relātus: ĪnflexorVerbīĪre.Lazy, praefīxum: "in"));
    protected readonly Lazy<ĪnflexorIncertus> Inquiī = ĪnflexorVerbīInquiī.Lazy;
    protected readonly Lazy<ĪnflexorPraefīxus> Interīre
        = new Lazy(() => new ĪnflexorPraefīxus(relātus: ĪnflexorVerbīĪre.Lazy, praefīxum: "inter"));
    protected readonly Lazy<ĪnflexorPraefīxus> Introīre
        = new Lazy(() => new ĪnflexorPraefīxus(relātus: ĪnflexorVerbīĪre.Lazy, praefīxum: "intro"));
    protected readonly Lazy<ĪnflexorRescrīptus> Liquifacere
        = new Lazy(() => new ĪnflexorRescrīptus(relātus: ĪnflexorVerbīFacere.Lazy,
                                                rescrīptor: scrīptum => "liqui".Concat((scrīptum is "fac").Choose("face", scrīptum))));
    protected readonly Lazy<ĪnflexorIncertus> Meminisse = ĪnflexorVerbīMeminisse.Lazy;
    protected readonly Lazy<ĪnflexorIncertus> Mālle = ĪnflexorVerbīMālle.Lazy;
    protected readonly Lazy<ĪnflexorRescrīptus> Malefacere
        = new Lazy(() => new ĪnflexorRescrīptus(relātus: ĪnflexorVerbīFacere.Lazy,
                                                rescrīptor: scrīptum => "male".Concat((scrīptum is "fac").Choose("face", scrīptum))));
    protected readonly Lazy<ĪnflexorRescrīptus> Mollifacere
        = new Lazy(() => new ĪnflexorRescrīptus(relātus: ĪnflexorVerbīFacere.Lazy,
                                                rescrīptor: scrīptum => "molli".Concat((scrīptum is "fac").Choose("face", scrīptum))));
    protected readonly Lazy<ĪnflexorPraefīxus> Nequīre
        = new Lazy(() => new ĪnflexorPraefīxus(relātus: ĪnflexorVerbīĪre.Lazy, praefīxum: "nequ"));
    protected readonly Lazy<ĪnflexorIncertus> Nōlle = ĪnflexorVerbīNōlle.Lazy;
    protected readonly Lazy<ĪnflexorPraefīxus> Obesse
        = new Lazy(() => new ĪnflexorPraefīxus(relātus: ĪnflexorVerbīEsse.Lazy, praefīxum: "ob"));
    protected readonly Lazy<ĪnflexorPraefīxus> Obīre
        = new Lazy(() => new ĪnflexorPraefīxus(relātus: ĪnflexorVerbīĪre.Lazy, praefīxum: "ob"));
    protected readonly Lazy<ĪnflexorRescrīptus> Offerre
        = new Lazy(() => new ĪnflexorRescrīptus(relātus: ĪnflexorVerbīFerre.Lazy,
                                                 rescrīptor: scrīptum => scrīptum.StartsWith('f').Choose("of", "ob").Concat(scrīptum)));
    protected readonly Lazy<ĪnflexorRescrīptus> Olfacere
        = new Lazy(() => new ĪnflexorRescrīptus(relātus: ĪnflexorVerbīFacere.Lazy,
                                                rescrīptor: scrīptum => "ol".Concat((scrīptum is "fac").Choose("face", scrīptum))));
    protected readonly Lazy<ĪnflexorRescrīptus> Patefacere
        = new Lazy(() => new ĪnflexorRescrīptus(relātus: ĪnflexorVerbīFacere.Lazy,
                                                rescrīptor: scrīptum => "pate".Concat((scrīptum is "fac").Choose("face", scrīptum))));
    protected readonly Lazy<ĪnflexorPraefīxus> Perferre
        = new Lazy(() => new ĪnflexorPraefīxus(relātus: ĪnflexorVerbīFerre.Lazy, praefīxum: "per"));
    protected readonly Lazy<ĪnflexorPraefīxus> Postferre
        = new Lazy(() => new ĪnflexorPraefīxus(relātus: ĪnflexorVerbīFerre.Lazy, praefīxum: "post"));
    protected readonly Lazy<ĪnflexorPraefīxus> Praeesse
        = new Lazy(() => new ĪnflexorPraefīxus(relātus: ĪnflexorVerbīEsse.Lazy, praefīxum: "prae"));
    protected readonly Lazy<ĪnflexorIncertus> Praeterferre = ĪnflexorVerbīPraeterferre.Lazy;
    protected readonly Lazy<ĪnflexorIncertus> Perīre = ĪnflexorVerbīPerīre.Lazy;
    protected readonly Lazy<ĪnflexorRescrīptus> Posse
        = new Lazy(() => new ĪnflexorRescrīptus(relātus: ĪnflexorVerbīEsse.Lazy,
                                                rescrīptor: scrīptum => scrīptum switch
                                                                        {
                                                                          "esse" => "posse",
                                                                          var īnscītum when scrīptum.StartsWith("estō") => string.Empty,
                                                                          var īnscītum when scrīptum.StartsWith('s') => "pos".Concat(scrīptum),
                                                                          var īnscītum when scrīptum.StartsWith('e') => "pot".Concat(scrīptum),
                                                                          var īnscītum when scrīptum.StartsWith('f') => "pot".Concat(scrīptum.Substring(1)),
                                                                          _ => string.Empty
                                                                        }));
    protected readonly Lazy<ĪnflexorRescrīptus> Prōdesse
        = new Lazy(() => new ĪnflexorRescrīptus(relātus: ĪnflexorVerbīEsse.Lazy,
                                                rescrīptor: scrīptum => scrīptum.StartsWith('e')
                                                                                .Choose("prō", "prōd").Concat(scrīptum)));
    protected readonly Lazy<ĪnflexorPraefīxus> Prōdīre
        = new Lazy(() => new ĪnflexorPraefīxus(relātus: ĪnflexorVerbīĪre.Lazy, praefīxum: "prōd"));
    protected readonly Lazy<ĪnflexorPraefīxus> Prōferre
        = new Lazy(() => new ĪnflexorPraefīxus(relātus: ĪnflexorVerbīFerre.Lazy, praefīxum: "prō"));
    protected readonly Lazy<ĪnflexorPraefīxus> Quīre
        = new Lazy(() => new ĪnflexorPraefīxus(relātus: ĪnflexorVerbīĪre.Lazy, praefīxum: "qu"));
    protected readonly Lazy<ĪnflexorRescrīptus> Redīre
        = new Lazy(() => new ĪnflexorRescrīptus(relātus: ĪnflexorVerbīPerīre.Lazy,
                                                rescrīptor: scrīptum => scrīptum.ReplaceFirst("per", "red")));
    protected readonly Lazy<ĪnflexorRescrīptus> Referre
        = new Lazy(() => new ĪnflexorRescrīptus(relātus: ĪnflexorVerbīFerre.Lazy,
                                                rescrīptor: scrīptum => scrīptum.StartsWith('t').Choose("ret", "re").Concat(scrīptum)));
    protected readonly Lazy<ĪnflexorRescrīptus> Satisfacere
        = new Lazy(() => new ĪnflexorRescrīptus(relātus: ĪnflexorVerbīFacere.Lazy,
                                                rescrīptor: scrīptum => "satis".Concat((scrīptum is "fac").Choose("face", scrīptum))));
    protected readonly Lazy<ĪnflexorRescrīptus> Stupefacere
        = new Lazy(() => new ĪnflexorRescrīptus(relātus: ĪnflexorVerbīFacere.Lazy,
                                                rescrīptor: scrīptum => "stupe".Concat((scrīptum is "fac").Choose("face", scrīptum))));
    protected readonly Lazy<ĪnflexorPraefīxus> Subesse
        = new Lazy(() => new ĪnflexorPraefīxus(relātus: ĪnflexorVerbīEsse.Lazy, praefīxum: "sub"));
    protected readonly Lazy<ĪnflexorPraefīxus> Subīre
        = new Lazy(() => new ĪnflexorPraefīxus(relātus: ĪnflexorVerbīĪre.Lazy, praefīxum: "sub"));
    protected readonly Lazy<ĪnflexorRescrīptus> Sufferre
        = new Lazy(() => new ĪnflexorRescrīptus(relātus: ĪnflexorVerbīFerre.Lazy,
                                                rescrīptor: scrīptum => (scrīptum[0] switch
                                                                          {
                                                                            'f' => "suf",
                                                                            't' => "sus",
                                                                            'l' => "sub",
                                                                            _ => string.Empty
                                                                          }).Concat(scrīptum)));
    protected readonly Lazy<ĪnflexorPraefīxus> Superesse
        = new Lazy(() => new ĪnflexorPraefīxus(relātus: ĪnflexorVerbīEsse.Lazy, praefīxum: "super"));
    protected readonly Lazy<ĪnflexorPraefīxus> Trānsabīre
        = new Lazy(() => new ĪnflexorPraefīxus(relātus: ĪnflexorVerbīĪre.Lazy, praefīxum: "trānsab"));
    protected readonly Lazy<ĪnflexorPraefīxus> Trānsīre
        = new Lazy(() => new ĪnflexorPraefīxus(relātus: ĪnflexorVerbīĪre.Lazy, praefīxum: "trāns"));
    protected readonly Lazy<ĪnflexorRescrīptus> Tepefacere
        = new Lazy(() => new ĪnflexorRescrīptus(relātus: ĪnflexorVerbīFacere.Lazy,
                                                rescrīptor: scrīptum => "tepe".Concat((scrīptum is "fac").Choose("face", scrīptum))));
    protected readonly Lazy<ĪnflexorPraefīxus> Venīre
        = new Lazy(() => new ĪnflexorPraefīxus(relātus: ĪnflexorVerbīĪre.Lazy, praefīxum: "ven"));
    protected readonly Lazy<ĪnflexorIncertus> Velle = ĪnflexorVerbīVelle.Lazy;
    protected readonly Lazy<ĪnflexorRescrīptus> Ārefacere
        = new Lazy(() => new ĪnflexorRescrīptus(relātus: ĪnflexorVerbīFacere.Lazy,
                                                rescrīptor: scrīptum => "āre".Concat((scrīptum is "fac").Choose("face", scrīptum))));
    protected readonly Lazy<ĪnflexorPraefīxus> Īnesse
        = new Lazy(() => new ĪnflexorPraefīxus(relātus: ĪnflexorVerbīEsse.Lazy, praefīxum: "īn"));
    protected readonly Lazy<ĪnflexorRescrīptus> Īnferre
        = new Lazy(() => new ĪnflexorRescrīptus(relātus: ĪnflexorVerbīFerre.Lazy,
                                                rescrīptor: scrīptum => (scrīptum[0] switch
                                                                          {
                                                                            'f' => "īn",
                                                                            't' => "in",
                                                                            'l' => "il",
                                                                            _ => string.Empty
                                                                          }).Concat(scrīptum)));
    protected readonly Lazy<ĪnflexorIncertus> Īnfierī = ĪnflexorVerbīĪnfierī.Lazy;
    protected readonly Lazy<ĪnflexorIncertus> Īre = ĪnflexorVerbīĪre.Lazy;
    protected readonly Lazy<ĪnflexorPerfectusSōlusĀctibus> Ōdisse
        = new Lazy(() => new ĪnflexorPerfectusSōlusĀctibus(relātus: ĪnflexorEffectusQuārtusĀctibus.Lazy,
                                                           perfectum: "ōdisse", supīnum: "ōsum"));

    private DictionāriumĀctibus()
        : base(new Lazy<Nūntius<DictionāriumĀctibus>>())
        => Nūntius.PlūsGarriōAsync("Fīō");
  }
}
