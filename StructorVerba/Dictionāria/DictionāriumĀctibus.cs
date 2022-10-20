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
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Dare, praefīxum: "ab"));
    protected readonly Lazy<ĪnflexorRescrīptus> Abesse
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Esse,
                                               rescrīptor: scrīptum => scrīptum.StartsWith('f')
                                                                               .Choose("ā", "ab").Concat(scrīptum)));
    protected readonly Lazy<ĪnflexorPraefīxus> Abīre
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Īre, praefīxum: "ab"));
    protected readonly Lazy<ĪnflexorPraefīxus> Addare
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Dare, praefīxum: "ad"));
    protected readonly Lazy<ĪnflexorPraefīxus> Adesse
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Esse, praefīxum: "ad"));
    protected readonly Lazy<ĪnflexorRescrīptus> Afferre
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Ferre,
                                               rescrīptor: scrīptum => "a".Concat(scrīptum[0]).Concat(scrīptum)));
    protected readonly Lazy<ĪnflexorIncertus> Aiere = ĪnflexorVerbīAiere.Lazy;
    protected readonly Lazy<ĪnflexorRescrīptus> Auferre
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Ferre,
                                               rescrīptor: scrīptum => (scrīptum[0] switch
                                                                        {
                                                                          'f' => "au",
                                                                          't' => "abs",
                                                                          'l' => "ab",
                                                                          _ => string.Empty
                                                                        }).Concat(scrīptum)));
    protected readonly Lazy<ĪnflexorRescrīptus> Benefacere
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Facere,
                                               rescrīptor: scrīptum => "bene".Concat((scrīptum is "fac").Choose("face", scrīptum))));
    protected readonly Lazy<ĪnflexorRescrīptus> Calfacere
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Facere,
                                               rescrīptor: scrīptum => "cal".Concat((scrīptum is "fac").Choose("face", scrīptum))));
    protected readonly Lazy<ĪnflexorRescrīptus> Calefacere
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Facere,
                                               rescrīptor: scrīptum => "cale".Concat((scrīptum is "fac").Choose("face", scrīptum))));
    protected readonly Lazy<ĪnflexorPraefīxus> Circumferre
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Ferre, praefīxum: "circum"));
    protected readonly Lazy<ĪnflexorPraefīxus> Circumīre
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Īre, praefīxum: "circum"));
    protected readonly Lazy<ĪnflexorIncertus> Coesse = ĪnflexorVerbīCoesse.Lazy;
    protected readonly Lazy<ĪnflexorRescrīptus> Commonefacere
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Facere,
                                               rescrīptor: scrīptum => "commone".Concat((scrīptum is "fac").Choose("face", scrīptum))));
    protected readonly Lazy<ĪnflexorPraefīxus> Condare
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Dare, praefīxum: "con"));
    protected readonly Lazy<ĪnflexorRescrīptus> Condocefacere
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Facere,
                                               rescrīptor: scrīptum => "condoce".Concat((scrīptum is "fac").Choose("face", scrīptum))));
    protected readonly Lazy<ĪnflexorPraefīxus> Confervēfacere
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Fervēfacere,
                                              praefīxum: "con"));
    protected readonly Lazy<ĪnflexorPerfectusSōlusĀctibus> Coepisse
       = new Lazy(() => new ĪnflexorPerfectusSōlusĀctibus(relātus: ĪnflexorEffectusTertiusĀctibus.Lazy,
                                                          perfectum: "coepisse", supīnum: "coeptum"));
    protected readonly Lazy<ĪnflexorPraefīxus> Coīre
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Īre, praefīxum: "co"));
    protected readonly Lazy<ĪnflexorPraefīxus> Collabefierī
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Fierī, praefīxum: "collabe"));
    protected readonly Lazy<ĪnflexorPraefīxus> Cōnfierī
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Fierī, praefīxum: "cōn"));
    protected readonly Lazy<ĪnflexorRescrīptus> Cōnferre
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Ferre,
                                               rescrīptor: scrīptum => (scrīptum[0] switch
                                                                        {
                                                                          'f' => "cōn",
                                                                          't' => "con",
                                                                          'l' => "col",
                                                                          _ => string.Empty
                                                                        }).Concat(scrīptum)));
    protected readonly Lazy<ĪnflexorRescrīptus> Cōnsuēfacere
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Facere,
                                               rescrīptor: scrīptum => "cōnsuē".Concat((scrīptum is "fac").Choose("face", scrīptum))));
    protected readonly Lazy<ĪnflexorIncertus> Dare = Dare;
    protected readonly Lazy<ĪnflexorPraefīxus> Dēdare
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Dare, praefīxum: "dē"));
    protected readonly Lazy<ĪnflexorPraefīxus> Dēesse
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Esse, praefīxum: "dē"));
    protected readonly Lazy<ĪnflexorPraefīxus> Dēferre
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Ferre, praefīxum: "dē"));
    protected readonly Lazy<ĪnflexorPraefīxus> Dēfervēfacere
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Fervēfacere,
                                              praefīxum: "dē"));
    protected readonly Lazy<ĪnflexorPraefīxus> Dēfierī
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Fierī, praefīxum: "dē"));
    protected readonly Lazy<ĪnflexorIncertus> Deīre = ĪnflexorVerbīDeīre.Lazy;
    protected readonly Lazy<ĪnflexorRescrīptus> Differre
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Ferre,
                                               rescrīptor: scrīptum => (scrīptum[0] switch
                                                                        {
                                                                          'f' => "dif",
                                                                          't' => "dis",
                                                                          'l' => "dī",
                                                                          _ => string.Empty
                                                                        }).Concat(scrīptum)));
    protected readonly Lazy<ĪnflexorIncertus> Disperīre = ĪnflexorVerbīDisperīre.Lazy;
    protected readonly Lazy<ĪnflexorPraefīxus> Dīdare
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Dare, praefīxum: "dī"));
    protected readonly Lazy<ĪnflexorRescrīptus> Efferre
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Ferre.Lazy,
                                               rescrīptor: scrīptum => (scrīptum[0] switch
                                                                        {
                                                                          'f' => "ef",
                                                                          't' => "ex",
                                                                          'l' => "ē",
                                                                          _ => string.Empty
                                                                        }).Concat(scrīptum)));
    protected readonly Lazy<ĪnflexorIncertus> Esse = ĪnflexorVerbīEsse.Lazy;
    protected readonly Lazy<ĪnflexorPraefīxus> Exīre
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Īre, praefīxum: "ex"));
    protected readonly Lazy<ĪnflexorRescrīptus> Expergēfacere
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Facere,
                                               rescrīptor: scrīptum => "expergē".Concat((scrīptum is "fac").Choose("face", scrīptum))));
    protected readonly Lazy<ĪnflexorIncertus> Facere = ĪnflexorVerbīFacere.Lazy;
    protected readonly Lazy<ĪnflexorIncertus> Ferre = ĪnflexorVerbīFerre.Lazy;
    protected readonly Lazy<ĪnflexorRescrīptus> Fervēfacere
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Facere,
                                               rescrīptor: scrīptum => "fervē".Concat((scrīptum is "fac").Choose("face", scrīptum))));
    protected readonly Lazy<ĪnflexorIncertus> Fierī = ĪnflexorVerbīFierī.Lazy;
    protected readonly Lazy<ĪnflexorPraefīxus> Incalfacere
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Calfacere,
                                              praefīxum: "in"));
    protected readonly Lazy<ĪnflexorRescrīptus> Infervefacere
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Facere,
                                               rescrīptor: scrīptum => "inferve".Concat((scrīptum is "fac").Choose("face", scrīptum))));
    protected readonly Lazy<ĪnflexorPraefīxus> Interesse
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Esse, praefīxum: "inter"));
    protected readonly Lazy<ĪnflexorPraefīxus> Interferre
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Ferre, praefīxum: "inter"));
    protected readonly Lazy<ĪnflexorPraefīxus> Intrōferre
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Ferre, praefīxum: "intrō"));
    protected readonly Lazy<ĪnflexorPraefīxus> Inīre
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Īre, praefīxum: "in"));
    protected readonly Lazy<ĪnflexorIncertus> Inquiī = ĪnflexorVerbīInquiī.Lazy;
    protected readonly Lazy<ĪnflexorPraefīxus> Interīre
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Īre, praefīxum: "inter"));
    protected readonly Lazy<ĪnflexorPraefīxus> Introīre
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Īre, praefīxum: "intro"));
    protected readonly Lazy<ĪnflexorRescrīptus> Labefacere
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Facere,
                                               rescrīptor: scrīptum => "labe".Concat((scrīptum is "fac").Choose("face", scrīptum))));
    protected readonly Lazy<ĪnflexorRescrīptus> Liquifacere
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Facere,
                                               rescrīptor: scrīptum => "liqui".Concat((scrīptum is "fac").Choose("face", scrīptum))));
    protected readonly Lazy<ĪnflexorRescrīptus> Madefacere
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Facere,
                                               rescrīptor: scrīptum => "made".Concat((scrīptum is "fac").Choose("face", scrīptum))));
    protected readonly Lazy<ĪnflexorRescrīptus> Malefacere
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Facere,
                                               rescrīptor: scrīptum => "male".Concat((scrīptum is "fac").Choose("face", scrīptum))));
    protected readonly Lazy<ĪnflexorIncertus> Meminisse = ĪnflexorVerbīMeminisse.Lazy;
    protected readonly Lazy<ĪnflexorRescrīptus> Mollifacere
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Facere,
                                               rescrīptor: scrīptum => "molli".Concat((scrīptum is "fac").Choose("face", scrīptum))));
    protected readonly Lazy<ĪnflexorRescrīptus> Multifacere
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Facere,
                                               rescrīptor: scrīptum => "multi".Concat((scrīptum is "fac").Choose("face", scrīptum))));
    protected readonly Lazy<ĪnflexorIncertus> Mālle = ĪnflexorVerbīMālle.Lazy;
    protected readonly Lazy<ĪnflexorRescrīptus> Mānsuēfacere
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Facere,
                                               rescrīptor: scrīptum => "mānsuē".Concat((scrīptum is "fac").Choose("face", scrīptum))));
    protected readonly Lazy<ĪnflexorPraefīxus> Nequīre
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Īre, praefīxum: "nequ"));
    protected readonly Lazy<ĪnflexorIncertus> Nōlle = ĪnflexorVerbīNōlle.Lazy;
    protected readonly Lazy<ĪnflexorPraefīxus> Obesse
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Esse, praefīxum: "ob"));
    protected readonly Lazy<ĪnflexorPraefīxus> Obīre
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Īre, praefīxum: "ob"));
    protected readonly Lazy<ĪnflexorPraefīxus> Obsolefierī
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Fierī, praefīxum: "obsole"));
    protected readonly Lazy<ĪnflexorPraefīxus> Obstupefacere
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Stupefacere,
                                              praefīxum: "ob"));
    protected readonly Lazy<ĪnflexorRescrīptus> Offerre
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Ferre,
                                               rescrīptor: scrīptum => scrīptum.StartsWith('f').Choose("of", "ob").Concat(scrīptum)));
    protected readonly Lazy<ĪnflexorRescrīptus> Olfacere
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Facere,
                                               rescrīptor: scrīptum => "ol".Concat((scrīptum is "fac").Choose("face", scrīptum))));
    protected readonly Lazy<ĪnflexorRescrīptus> Patefacere
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Facere,
                                               rescrīptor: scrīptum => "pate".Concat((scrīptum is "fac").Choose("face", scrīptum))));
    protected readonly Lazy<ĪnflexorRescrīptus> Pavefacere
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Facere,
                                               rescrīptor: scrīptum => "pave".Concat((scrīptum is "fac").Choose("face", scrīptum))));
    protected readonly Lazy<ĪnflexorPraefīxus> Percalfacere
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Calfacere,
                                              praefīxum: "per"));
    protected readonly Lazy<ĪnflexorPraefīxus> Perferre
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Ferre, praefīxum: "per"));
    protected readonly Lazy<ĪnflexorPraefīxus> Permadefacere
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Madefacere,
                                              praefīxum: "per"));
    protected readonly Lazy<ĪnflexorPraefīxus> Pervelle
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Velle,
                                              praefīxum: "per"));
    protected readonly Lazy<ĪnflexorIncertus> Perīre = ĪnflexorVerbīPerīre.Lazy;
    protected readonly Lazy<ĪnflexorPraefīxus> Postferre
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Ferre, praefīxum: "post"));
    protected readonly Lazy<ĪnflexorPraefīxus> Praeesse
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Esse, praefīxum: "prae"));
    protected readonly Lazy<ĪnflexorIncertus> Praeterferre = ĪnflexorVerbīPraeterferre.Lazy;
    protected readonly Lazy<ĪnflexorRescrīptus> Posse
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Esse,
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
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Esse,
                                               rescrīptor: scrīptum => scrīptum.StartsWith('e')
                                                                               .Choose("prō", "prōd").Concat(scrīptum)));
    protected readonly Lazy<ĪnflexorPraefīxus> Prōdīre
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Īre, praefīxum: "prōd"));
    protected readonly Lazy<ĪnflexorPraefīxus> Prōferre
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Ferre, praefīxum: "prō"));
    protected readonly Lazy<ĪnflexorRescrīptus> Putrefacere
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Facere,
                                               rescrīptor: scrīptum => "putre".Concat((scrīptum is "fac").Choose("face", scrīptum))));
    protected readonly Lazy<ĪnflexorPraefīxus> Quīre
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Īre, praefīxum: "qu"));
    protected readonly Lazy<ĪnflexorPraefīxus> Recalfacere
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Calfacere,
                                              praefīxum: "re"));
    protected readonly Lazy<ĪnflexorRescrīptus> Redīre
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Perīre,
                                               rescrīptor: scrīptum => scrīptum.ReplaceFirst("per", "red")));
    protected readonly Lazy<ĪnflexorRescrīptus> Refferre
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Ferre,
                                               rescrīptor: scrīptum => scrīptum.StartsWith('t').Choose("ret", "re").Concat(scrīptum)));
    protected readonly Lazy<ĪnflexorRescrīptus> Rārefacere
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Facere,
                                               rescrīptor: scrīptum => "rāre".Concat((scrīptum is "fac").Choose("face", scrīptum))));
    protected readonly Lazy<ĪnflexorRescrīptus> Satisfacere
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Facere,
                                               rescrīptor: scrīptum => "satis".Concat((scrīptum is "fac").Choose("face", scrīptum))));
    protected readonly Lazy<ĪnflexorRescrīptus> Stupefacere
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Facere,
                                               rescrīptor: scrīptum => "stupe".Concat((scrīptum is "fac").Choose("face", scrīptum))));
    protected readonly Lazy<ĪnflexorPraefīxus> Subesse
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Esse, praefīxum: "sub"));
    protected readonly Lazy<ĪnflexorPraefīxus> Subīre
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Īre, praefīxum: "sub"));
    protected readonly Lazy<ĪnflexorPraefīxus> Subolfacere
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Olfacere, praefīxum: "sub"));
    protected readonly Lazy<ĪnflexorRescrīptus> Sufferre
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Ferre,
                                               rescrīptor: scrīptum => (scrīptum[0] switch
                                                                        {
                                                                          'f' => "suf",
                                                                          't' => "sus",
                                                                          'l' => "sub",
                                                                          _ => string.Empty
                                                                        }).Concat(scrīptum)));
    protected readonly Lazy<ĪnflexorPraefīxus> Suffierī
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Fierī, praefīxum: "suf"));
    protected readonly Lazy<ĪnflexorPraefīxus> Superesse
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Esse, praefīxum: "super"));
    protected readonly Lazy<ĪnflexorPraefīxus> Superfierī
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Fierī, praefīxum: "super"));
    protected readonly Lazy<ĪnflexorPraefīxus> Trānsabīre
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Īre, praefīxum: "trānsab"));
    protected readonly Lazy<ĪnflexorPraefīxus> Trānsīre
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Īre, praefīxum: "trāns"));
    protected readonly Lazy<ĪnflexorRescrīptus> Tepefacere
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Facere,
                                               rescrīptor: scrīptum => "tepe".Concat((scrīptum is "fac").Choose("face", scrīptum))));
    protected readonly Lazy<ĪnflexorRescrīptus> Tremefacere
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Facere,
                                               rescrīptor: scrīptum => "treme".Concat((scrīptum is "fac").Choose("face", scrīptum))));
    protected readonly Lazy<ĪnflexorRescrīptus> Tumefacere
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Facere,
                                               rescrīptor: scrīptum => "tume".Concat((scrīptum is "fac").Choose("face", scrīptum))));
    protected readonly Lazy<ĪnflexorRescrīptus> Vacuēfacere
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Facere,
                                               rescrīptor: scrīptum => "vacuē".Concat((scrīptum is "fac").Choose("face", scrīptum))));
    protected readonly Lazy<ĪnflexorPraefīxus> Venīre
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Īre, praefīxum: "ven"));
    protected readonly Lazy<ĪnflexorIncertus> Velle = ĪnflexorVerbīVelle.Lazy;
    protected readonly Lazy<ĪnflexorRescrīptus> Ārefacere
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Facere,
                                               rescrīptor: scrīptum => "āre".Concat((scrīptum is "fac").Choose("face", scrīptum))));
    protected readonly Lazy<ĪnflexorRescrīptus> Ārfacere
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Facere,
                                               rescrīptor: scrīptum => "ār".Concat((scrīptum is "fac").Choose("face", scrīptum))));
    protected readonly Lazy<ĪnflexorPraefīxus> Īnesse
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Esse, praefīxum: "īn"));
    protected readonly Lazy<ĪnflexorRescrīptus> Īnferre
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Ferre,
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
