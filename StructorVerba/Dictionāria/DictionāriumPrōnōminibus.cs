using System;

using Miscella;
using Nūntiī.Nūntius;
using Praebeunda.Multiplex.Prōnōmen;
using Ēnumerātiōnēs;
using Īnflexōrēs.Exāctī.ĪnflexorExāctusPrōnōminibus;
using Īnflexōrēs.Incertī;
using Īnflexōrēs.Incertī.Prōnōmina;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Dictionāria
{
  [Singleton]
  public sealed partial class DictionāriumPrōnōminibus : Dictionārium<Multiplex.Prōnōmen>
  {
    public static readonly Lazy<DictionāriumPrōnōminibus> Faciendum = new Lazy(() => Instance);

    public readonly Func<IEnumerable<Enum>[]> Praegenerātor
        = () => Ūtilitātēs.Seriēs(Ūtilitātēs.Combīnō(Genus.GetValues().Except(Genus.Nūllum).ToHasSet(),
                                                     new HashSet<Casus>() { Casus.Nōminātīvus, Casus.Accūsātīvus, Casus.Vocātīvus },
                                                     Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet()),
                                  Ūtilitātēs.Combīnō(Genus.GetValues().Except(Genus.Nūllum).ToHashSet(),
                                                     new HashSet<Casus>() { Casus.Ablātīvus, Casus.Locātīvus, Casus.Inatrumentālis },
                                                     Numerālis.Singulāris.SingleItemSet()),
                                  Ūtilitātēs.Combīnō(Genus.GetValues().Except(Genus.Nūllum).ToHashSet(),
                                                     Casus.Genitīvus.SingleItemSet(),
                                                     Numerālis.Singulāris.SingleItemSet()),
                                  Ūtilitātēs.Combīnō(new HashSet<Casus>() { Casus.Datīvus, Casus.Ablātīvus, Casus.Locātīvus, Casus.Instrumentālis },
                                                     Numerālis.Plūrālis.SingleItemSet()),
                                  Ūtilitātēs.Combīnō(new HashSet<Casus>() { Casus.Genitīvus, Casus.Datīvus },
                                                     Numerālis.Singulāris.SingleItemSet()));

    protected readonly Lazy<ĪnflexorPraefīxus> Aliquid
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: ĪnflexorVerbīQuid.Faciendum, praefīxum: "ali"));
    protected readonly Lazy<ĪnflexorRescrīptus> Ecquid
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: ĪnflexorVerbīQuid.Faciendum,
                                               rescrīptor: scrīptum => scrīptum switch
                                                                        {
                                                                          "cuius" => "ecculus",
                                                                          _ => "ec".Concat(scrīptum)
                                                                        }));
    protected readonly Lazy<ĪnflexorIncertus> Ego = ĪnfexorVerbīEgo.Faciendum;
    protected readonly Lazy<ĪnflexorSuffīxus> Egomet
       = new Lazy(() => new ĪnflexorSuffīxus(relātus: ĪnflexorVerbīEgo.Faciendum, suffīxum: "met"));
    protected readonly Lazy<ĪnflexorIncertus> Hoc = ĪnflexorVerbīHoc.Faciendum;
    protected readonly Lazy<ĪnflexorIncertus> Id = ĪnflexorVerbīId.Faciendum;
    protected readonly Lazy<ĪnflexorRescrīptus> Idem
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: ĪnflexorVerbīQuid.Faciendum,
                                               rescrīptor: scrīptum => (scrīptum switch
                                                                        {
                                                                          "id" => "i",
                                                                          "is" => "ī",
                                                                          _ => scrīptum
                                                                        }).Concat("dem")));
    protected readonly Lazy<ĪnflexorRescrīptus> Illoc
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: ĪnflexorVerbīHoc.Faciendum,
                                               rescrīptor: scrīptum => scrīptum.ReplaceFirst("h", "ill")));
    protected readonly Lazy<ĪnflexorIncertus> Illud = ĪnflexorVerbīIllud.Faciendum;
    protected readonly Lazy<ĪnflexorIncertus> Ipsum = ĪnflexorVerbīIpsum.Faciendum;
    protected readonly Lazy<ĪnflexorRescrīptus> Istud
       = new Lazy(() => new ĪnflexorRescrīptus(ĪnflexorVerbīIllud.Faciendum,
                                               rescrīptor: scrīptum => scrīptum.ReplaceFirst("ill", "ist")));
    protected readonly Lazy<ĪnflexorRescrīptus> Quid
       = new Lazy(() => new ĪnflexorRescrīptus(ĪnflexorVerbīId.Faciendum,
                                               rescrīptor: scrīptum => scrīptum switch
                                                                        {
                                                                          "ea" or "eae" => "quae",
                                                                          "eum" => "quem",
                                                                          "eius" => "cuius",
                                                                          _ => scrīptum.ReplaceFirst("e", "qu")
                                                                        }));
    protected readonly Lazy<ĪnflexorSuffīxus> Quidpiam
       = new Lazy(() => new ĪnflexorSuffīxus(relātus: ĪnflexorVerbīQuid.Faciendum, suffīxum: "piam"));
    protected readonly Lazy<ĪnflexorSuffīxus> Quidquam
       = new Lazy(() => new ĪnflexorSuffīxus(relātus: ĪnflexorVerbīQuid.Faciendum, suffīxum: "quam"));
    protected readonly Lazy<ĪnflexorSuffīxus> Quidque
       = new Lazy(() => new ĪnflexorSuffīxus(relātus: ĪnflexorVerbīQuid.Faciendum,
                                             suffīxum: Encliticum.Coniugāns.ToString()));
    protected readonly Lazy<ĪnflexorRescrīptus> Quidquid
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: ĪnflexorVerbīQuid.Faciendum,
                                               rescrīptor: scrīptum => scrīptum.Concat(scrīptum)));
    protected readonly Lazy<ĪnflexorRescrīptus> Quod
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: ĪnflexorVerbīQuid.Faciendum,
                                               rescrīptor: scrīptum => scrīptum switch
                                                                        {
                                                                          "quid" => "quod",
                                                                          "quis" => "quī",
                                                                          _ => scrīptum
                                                                        }));
    protected readonly Lazy<ĪnflexorSuffīxus> Quodpiam
       = new Lazy(() => new ĪnflexorSuffīxus(relātus: ĪnflexorVerbīQuod.Faciendum, suffīxum: "piam"));
    protected readonly Lazy<ĪnflexorIncertus> Sē = ĪnflexorVerbīSē.Faciendum;
    protected readonly Lazy<ĪnflexorSuffīxus> Sēmet
       = new Lazy(() => new ĪnflexorSuffīxus(relātus: ĪnflexorVerbīSē.Faciendum, suffīxum: "met"));
    protected readonly Lazy<ĪnflexorIncertus> Tū = ĪnflexorVerbīTū.Faciendum;
    protected readonly Lazy<ĪnflexorRescrīptus> Tūte
        = new Lazy(() => new ĪnflexorRescrīptus(relātus: ĪnflexorVerbīIpsum.Faciendum,
                                                rescrīptor: scrīptum => (scrīptum is "tū").Choose("tūte", scrīptum)));
    protected readonly Lazy<ĪnflexorRescrīptus> Tūtemet
        = new Lazy(() => new ĪnflexorRescrīptus(relātus: ĪnflexorVerbīIpsum.Faciendum,
                                                rescrīptor: scrīptum => (scrīptum is "tū").Choose("tūtemet", scrīptum.Concat("met"))));
    private DictionāriumPrōnōminibus()
         : base(new Lazy<Nūntius<DictionāriumPrōnōminibus>>())
         => Nūntius.PlūsGarriōAsync("Fīō");
  }
}
