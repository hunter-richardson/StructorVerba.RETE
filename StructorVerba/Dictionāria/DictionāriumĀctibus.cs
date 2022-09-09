using System;
using System.Threading.Tasks.Task;

using Miscella.Extensions;
using Praebeunda.Multiplex.Āctus;
using Ēnumerātiōnēs;
using Īnflexōrēs.Incertī;
using Īnflexōrēs.Incertī.Āctūs;

using Lombok.NET.PropertyGenerators.SingletonAribute;

namespace Dictionāria
{
  [Singleton]
  public sealed partial class DictionāriumĀctibus : Dictionārium<Multiplex.Āctus>
  {
    public static readonly Lazy<DictionāriumĀctibus> Faciendum = new Lazy(() => Instance);

    protected readonly Lazy<ĪnflexorPrefixus> Abdare
       = new Lazy(() => new ĪnflexorPrefixus(ĪnflexorVerbīDare.Faciendum, "ab"));
    protected readonly Lazy<ĪnflexorRescrīptus> Abesse
       = new Lazy(() => new ĪnflexorRescrīptus(ĪnflexorVerbīEsse.Faciendum,
                                               scrīptum => scrīptum.StartsWith('f')
                                                                   .Choose("ā", "ab").Concat(scrīptum)));
    protected readonly Lazy<ĪnflexorPrefixus> Abīre
       = new Lazy(() => new ĪnflexorPrefixus(ĪnflexorVerbīĪre.Faciendum, "ab"));
    protected readonly Lazy<ĪnflexorPrefixus> Addare
       = new Lazy(() => new ĪnflexorPrefixus(ĪnflexorVerbīDare.Faciendum, "ad"));
    protected readonly Lazy<ĪnflexorPrefixus> Adesse
       = new Lazy(() => new ĪnflexorPrefixus(ĪnflexorVerbīEsse.Faciendum, "ad"));
    protected readonly Lazy<ĪnflexorRescrīptus> Afferre
       = new Lazy(() => new ĪnflexorRescrīptus(ĪnflexorVerbīFerre.Faciendum,
                                               scrīptum => "a".Concat(scrīptum[0]).Concat(scrīptum)));
    protected readonly Lazy<ĪnflexorIncertus> Aiere = ĪnflexorVerbīAiere.Faciendum;
    protected readonly Lazy<ĪnflexorRescrīptus> Auferre
       = new Lazy(() => new ĪnflexorRescrīptus(ĪnflexorVerbīFerre.Faciendum,
                                               scrīptum => (scrīptum[0] switch
                                                            {
                                                              'f' => "au",
                                                              't' => "abs",
                                                              'l' => "ab",
                                                              _ => string.Empty
                                                            }).Concat(scrīptum)));
    protected readonly Lazy<ĪnflexorPrefixus> Circumferre
       = new Lazy(() => new ĪnflexorPrefixus(ĪnflexorVerbīFerre.Faciendum, "circum"));
    protected readonly Lazy<ĪnflexorPrefixus> Circumīre
       = new Lazy(() => new ĪnflexorPrefixus(ĪnflexorVerbīĪre.Faciendum, "circum"));
    protected readonly Lazy<ĪnflexorPerfectusSōlusĀctibus> Coepisse
       = new Lazy(() => new ĪnflexorPerfectusSōlusĀctibus(ĪnflexorEffectusTertiusĀctibus.Faciendum,
                                                          "coepisse", "coeptum"));
    protected readonly Lazy<ĪnflexorIncertus> Coesse = ĪnflexorVerbīCoesse.Faciendum;
    protected readonly Lazy<ĪnflexorPrefixus> Condare
       = new Lazy(() => new ĪnflexorPrefixus(ĪnflexorVerbīDare.Faciendum, "con"));
    protected readonly Lazy<ĪnflexorPrefixus> Coīre
       = new Lazy(() => new ĪnflexorPrefixus(ĪnflexorVerbīĪre.Faciendum, "co"));
    protected readonly Lazy<ĪnflexorRescrīptus> Cōnferre
       = new Lazy(() => new ĪnflexorRescrīptus(ĪnflexorVerbīFerre.Faciendum,
                                               scrīptum => (scrīptum[0] switch
                                                            {
                                                              'f' => "cōn",
                                                              't' => "con",
                                                              'l' => "col",
                                                              _ => string.Empty
                                                            }).Concat(scrīptum)));
    protected readonly Lazy<ĪnflexorIncertus> Dare = ĪnflexorVerbīDare.Faciendum;
    protected readonly Lazy<ĪnflexorPrefixus> Dēdare
       = new Lazy(() => new ĪnflexorPrefixus(ĪnflexorVerbīDare.Faciendum, "dē"));
    protected readonly Lazy<ĪnflexorPrefixus> Dēesse
       = new Lazy(() => new ĪnflexorPrefixus(ĪnflexorVerbīEsse.Faciendum, "dē"));
    protected readonly Lazy<ĪnflexorPrefixus> Dēferre
       = new Lazy(() => new ĪnflexorPrefixus(ĪnflexorVerbīFerre.Faciendum, "dē"));
    protected readonly Lazy<ĪnflexorIncertus> Deīre = ĪnflexorVerbīDeīre.Faciendum;
    protected readonly Lazy<ĪnflexorRescrīptus> Differre
       = new Lazy(() => new ĪnflexorRescrīptus(ĪnflexorVerbīFerre.Faciendum,
                                               scrīptum => (scrīptum[0] switch
                                                          {
                                                            'f' => "dif",
                                                            't' => "dis",
                                                            'l' => "dī",
                                                            _ => string.Empty
                                                          }).Concat(scrīptum)));
    protected readonly Lazy<ĪnflexorIncertus> Disperīre = ĪnflexorVerbīDisperīre.Faciendum;
    protected readonly Lazy<ĪnflexorPrefixus> Dīdare
       = new Lazy(() => new ĪnflexorPrefixus(ĪnflexorVerbīDare.Faciendum, "dī"));
    protected readonly Lazy<ĪnflexorRescrīptus> Efferre
       = new Lazy(() => new ĪnflexorRescrīptus(ĪnflexorVerbīFerre.Faciendum,
                                               scrīptum => (scrīptum[0] switch
                                                              {
                                                                'f' => "ef",
                                                                't' => "ex",
                                                                'l' => "ē",
                                                                _ => string.Empty
                                                              }).Concat(scrīptum)));
    protected readonly Lazy<ĪnflexorIncertus> Esse = ĪnflexorVerbīEsse.Faciendum;
    protected readonly Lazy<ĪnflexorPrefixus> Exīre
       = new Lazy(() => new ĪnflexorPrefixus(ĪnflexorVerbīĪre.Faciendum, "ex"));
    protected readonly Lazy<ĪnflexorIncertus> Facere = ĪnflexorVerbīFacere.Faciendum;
    protected readonly Lazy<ĪnflexorIncertus> Ferre = ĪnflexorVerbīFerre.Faciendum;
    protected readonly Lazy<ĪnflexorPrefixus> Interesse
       = new Lazy(() => new ĪnflexorPrefixus(ĪnflexorVerbīEsse.Faciendum, "inter"));
    protected readonly Lazy<ĪnflexorPrefixus> Interferre
       = new Lazy(() => new ĪnflexorPrefixus(ĪnflexorVerbīFerre.Faciendum, "inter"));
    protected readonly Lazy<ĪnflexorPrefixus> Intrōferre
       = new Lazy(() => new ĪnflexorPrefixus(ĪnflexorVerbīFerre.Faciendum, "intrō"));
    protected readonly Lazy<ĪnflexorPrefixus> Inīre
       = new Lazy(() => new ĪnflexorPrefixus(ĪnflexorVerbīĪre.Faciendum, "in"));
    protected readonly Lazy<ĪnflexorIncertus> Inquiī = ĪnflexorVerbīInquiī.Faciendum;
    protected readonly Lazy<ĪnflexorPrefixus> Interīre
       = new Lazy(() => new ĪnflexorPrefixus(ĪnflexorVerbīĪre.Faciendum, "inter"));
    protected readonly Lazy<ĪnflexorPrefixus> Introīre
       = new Lazy(() => new ĪnflexorPrefixus(ĪnflexorVerbīĪre.Faciendum, "intro"));
    protected readonly Lazy<ĪnflexorIncertus> Meminisse = ĪnflexorVerbīMeminisse.Faciendum;
    protected readonly Lazy<ĪnflexorIncertus> Mālle = ĪnflexorVerbīMālle.Faciendum;
    protected readonly Lazy<ĪnflexorPrefixus> Nequīre
       = new Lazy(() => new ĪnflexorPrefixus(ĪnflexorVerbīĪre.Faciendum, "nequ"));
    protected readonly Lazy<ĪnflexorIncertus> Nōlle = ĪnflexorVerbīNōlle.Faciendum;
    protected readonly Lazy<ĪnflexorPrefixus> Obesse
       = new Lazy(() => new ĪnflexorPrefixus(ĪnflexorVerbīEsse.Faciendum, "ob"));
    protected readonly Lazy<ĪnflexorPrefixus> Obīre
       = new Lazy(() => new ĪnflexorPrefixus(ĪnflexorVerbīĪre.Faciendum, "ob"));
    protected readonly Lazy<ĪnflexorRescrīptus> Offerre
       = new Lazy(() => new ĪnflexorRescrīptus(ĪnflexorVerbīFerre.Faciendum,
                                               scrīptum => scrīptum.StartsWith('f').Choose("of", "ob").Concat(scrīptum)));
    protected readonly Lazy<ĪnflexorPrefixus> Perferre
       = new Lazy(() => new ĪnflexorPrefixus(ĪnflexorVerbīFerre.Faciendum, "per"));
    protected readonly Lazy<ĪnflexorPrefixus> Postferre
       = new Lazy(() => new ĪnflexorPrefixus(ĪnflexorVerbīFerre.Faciendum, "post"));
    protected readonly Lazy<ĪnflexorPrefixus> Praeesse
       = new Lazy(() => new ĪnflexorPrefixus(ĪnflexorVerbīEsse.Faciendum, "prae"));
    protected readonly Lazy<ĪnflexorIncertus> Praeterferre = ĪnflexorVerbīPraeterferre.Faciendum;
    protected readonly Lazy<ĪnflexorIncertus> Perīre = ĪnflexorVerbīPerīre.Faciendum;
    protected readonly Lazy<ĪnflexorRescrīptus> Prōdesse
       = new Lazy(() => new ĪnflexorPrefixus(ĪnflexorVerbīEsse.Faciendum,
                                             scrīptum => scrīptum.StartsWith('e').Choose("prōd", "prō").Concat(scrīptum)));
    protected readonly Lazy<ĪnflexorPrefixus> Prōdīre
       = new Lazy(() => new ĪnflexorPrefixus(ĪnflexorVerbīĪre.Faciendum, "prōd"));
    protected readonly Lazy<ĪnflexorPrefixus> Prōferre
       = new Lazy(() => new ĪnflexorPrefixus(ĪnflexorVerbīFerre.Faciendum, "prō"));
    protected readonly Lazy<ĪnflexorPrefixus> Quīre
       = new Lazy(() => new ĪnflexorPrefixus(ĪnflexorVerbīĪre.Faciendum, "qu"));
    protected readonly Lazy<ĪnflexorRescrīptus> Redīre
       = new Lazy(() => new ĪnflexorRescrīptus(ĪnflexorVerbīPerīre.Faciendum,
                                               scrīptum => scrīptum.ReplaceFirst("per", "red")));
    protected readonly Lazy<ĪnflexorRescrīptus> Refferre
       = new Lazy(() => new ĪnflexorRescrīptus(ĪnflexorVerbīFerre.Faciendum,
                                               scrīptum => scrīptum.StartsWith('t').Choose("ret", "re").Concat(scrīptum)));
    protected readonly Lazy<ĪnflexorPrefixus> Subesse
       = new Lazy(() => new ĪnflexorPrefixus(ĪnflexorVerbīEsse.Faciendum, "sub"));
    protected readonly Lazy<ĪnflexorPrefixus> Subīre
       = new Lazy(() => new ĪnflexorPrefixus(ĪnflexorVerbīĪre.Faciendum, "sub"));
    protected readonly Lazy<ĪnflexorRescrīptus> Sufferre
       = new Lazy(() => new ĪnflexorRescrīptus(ĪnflexorVerbīFerre.Faciendum,
                                               scrīptum => (scrīptum[0] switch
                                                              {
                                                                'f' => "suf",
                                                                't' => "sus",
                                                                'l' => "sub",
                                                                _ => string.Empty
                                                              }).Concat(scrīptum)));
    protected readonly Lazy<ĪnflexorPrefixus> Superesse
       = new Lazy(() => new ĪnflexorPrefixus(ĪnflexorVerbīEsse.Faciendum, "super"));
    protected readonly Lazy<ĪnflexorPrefixus> Trānsabīre
       = new Lazy(() => new ĪnflexorPrefixus(ĪnflexorVerbīĪre.Faciendum, "trānsab"));
    protected readonly Lazy<ĪnflexorPrefixus> Trānsīre
       = new Lazy(() => new ĪnflexorPrefixus(ĪnflexorVerbīĪre.Faciendum, "trāns"));
    protected readonly Lazy<ĪnflexorRescrīptus> Posse
       = new Lazy(() => new ĪnflexorRescrīptus(ĪnflexorVerbīEsse.Faciendum,
                                               scrīptum => scrīptum switch
                                                            {
                                                              "esse" => "posse",
                                                              var īnscītum when scrīptum.StartsWith("estō") => string.Empty,
                                                              var īnscītum when scrīptum.StartsWith('s') => "pos".Concat(scrīptum),
                                                              var īnscītum when scrīptum.StartsWith('e') => "pot".Concat(scrīptum),
                                                              var īnscītum when scrīptum.StartsWith('f') => "pot".Concat(scrīptum.Substring(1)),
                                                              _ => string.Empty
                                                            }));
    protected readonly Lazy<ĪnflexorRescrīptus> Prōdesse
       = new Lazy(() => new ĪnflexorRescrīptus(ĪnflexorVerbīEsse.Faciendum,
                                               scrīptum => scrīptum.StartsWith('e')
                                                                   .Choose("prō", "prōd").Concat(scrīptum)));
    protected readonly Lazy<ĪnflexorPrefixus> Venīre
       = new Lazy(() => new ĪnflexorPrefixus(ĪnflexorVerbīĪre.Faciendum, "ven"));
    protected readonly Lazy<ĪnflexorIncertus> Velle = ĪnflexorVerbīVelle.Faciendum;
    protected readonly Lazy<ĪnflexorPrefixus> Īnesse
       = new Lazy(() => new ĪnflexorPrefixus(ĪnflexorVerbīEsse.Faciendum, "īn"));
    protected readonly Lazy<ĪnflexorRescrīptus> Īnferre
       = new Lazy(() => new ĪnflexorRescrīptus(ĪnflexorVerbīFerre.Faciendum,
                                               scrīptum => (scrīptum[0] switch
                                                            {
                                                              'f' => "īn",
                                                              't' => "in",
                                                              'l' => "il",
                                                              _ => string.Empty
                                                            }).Concat(scrīptum)));
    protected readonly Lazy<ĪnflexorIncertus> Īnfierī = ĪnflexorVerbīĪnfierī.Faciendum;
    protected readonly Lazy<ĪnflexorIncertus> Īre = ĪnflexorVerbīĪre.Faciendum;
    protected readonly Lazy<ĪnflexorPerfectusSōlusĀctibus> Ōdisse
       = new Lazy(() => new ĪnflexorPerfectusSōlusĀctibus(ĪnflexorEffectusQuārtusĀctibus.Faciendum,
                                                          "ōdisse", "ōsum"));

    private DictionāriumĀctibus()
        : base(new Lazy<Nūntius<DictionāriumĀctibus>>()) { }
  }
}
