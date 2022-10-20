using System;

using Miscella;
using Nūntiī.Nūntius;
using Praebeunda.Multiplex.Prōnōmen;
using Ēnumerātiōnēs;
using Īnflexōrēs.Exāctī.ĪnflexorExāctusPrōnōminibus;
using Īnflexōrēs.Incertī;
using Īnflexōrēs.Incertī.Prōnōmina;

using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Dictionāria
{
  [Lazy]
  public sealed partial class DictionāriumPrōnōminibus : Dictionārium<Multiplex.Prōnōmen>
  {
    public static readonly Func<IEnumerable<Enum>[]> Praegenerātor
        = () => Ūtilitātēs.Seriēs(Ūtilitātēs.Combīnō(Genus.GetValues().Except(Genus.Nūllum).ToHasSet(),
                                                     new HashSet<Casus>() { Casus.Nōminātīvus, Casus.Accūsātīvus, Casus.Vocātīvus },
                                                     Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet()),
                                  Ūtilitātēs.Combīnō(Genus.GetValues().Except(Genus.Nūllum).ToHashSet(),
                                                     new HashSet<Casus>() { Casus.Ablātīvus, Casus.Locātīvus, Casus.Instrumentālis },
                                                     Numerālis.Singulāris.SingleItemSet()),
                                  Ūtilitātēs.Combīnō(Genus.GetValues().Except(Genus.Nūllum).ToHashSet(),
                                                     Casus.Genitīvus.SingleItemSet(),
                                                     Numerālis.Singulāris.SingleItemSet()),
                                  Ūtilitātēs.Combīnō(new HashSet<Casus>() { Casus.Datīvus, Casus.Ablātīvus, Casus.Locātīvus, Casus.Instrumentālis },
                                                     Numerālis.Plūrālis.SingleItemSet()),
                                  Ūtilitātēs.Combīnō(new HashSet<Casus>() { Casus.Genitīvus, Casus.Datīvus },
                                                     Numerālis.Singulāris.SingleItemSet()));

    protected readonly Lazy<ĪnflexorPraefīxus> Aliquid
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Quid, praefīxum: "ali"));
    protected readonly Lazy<ĪnflexorPraefīxus> Aliquod
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Quod, praefīxum: "ali"));
    protected readonly Lazy<ĪnflexorSuffīxus> Aliquodpiam
       = new Lazy(() => new ĪnflexorSuffīxus(relātus: Aliquod, suffīxum: "piam"));
    protected readonly Lazy<ĪnflexorRescrīptus> Ecquid
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Quid,
                                               rescrīptor: scrīptum => scrīptum switch
                                                                        {
                                                                          "cuius" => "ecculus",
                                                                          _ => "ec".Concat(scrīptum)
                                                                        }));
    protected readonly Lazy<ĪnflexorCircumfīxus> Ecquod
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Quod, praefīxum: "ec"));
    protected readonly Lazy<ĪnflexorIncertus> Ego = ĪnfexorVerbīEgo.Lazy;
    protected readonly Lazy<ĪnflexorSuffīxus> Egomet
       = new Lazy(() => new ĪnflexorSuffīxus(relātus: Ego, suffīxum: "met"));
    protected readonly Lazy<ĪnflexorIncertus> Hoc = Hoc;
    protected readonly Lazy<ĪnflexorIncertus> Id = Id;
    protected readonly Lazy<ĪnflexorRescrīptus> Idem
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Quid,
                                               rescrīptor: scrīptum => (scrīptum switch
                                                                        {
                                                                          "id" => "i",
                                                                          "is" => "ī",
                                                                          _ => scrīptum
                                                                        }).Concat("dem")));
    protected readonly Lazy<ĪnflexorRescrīptus> Illoc
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Hoc,
                                               rescrīptor: scrīptum => scrīptum.ReplaceFirst("h", "ill")));
    protected readonly Lazy<ĪnflexorIncertus> Illud = ĪnflexorVerbīIllud.Lazy;
    protected readonly Lazy<ĪnflexorIncertus> Ipsum = ĪnflexorVerbīIpsum.Lazy;
    protected readonly Lazy<ĪnflexorRescrīptus> Istud
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Illud,
                                               rescrīptor: scrīptum => scrīptum.ReplaceFirst("ill", "ist")));
    protected readonly Lazy<ĪnflexorRescrīptus> Quid
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Id,
                                               rescrīptor: scrīptum => scrīptum switch
                                                                        {
                                                                          "ea" or "eae" => "quae",
                                                                          "eum" => "quem",
                                                                          "eius" => "cuius",
                                                                          _ => scrīptum.ReplaceFirst("e", "qu")
                                                                        }));
    protected readonly Lazy<ĪnflexorSuffīxus> Quidpiam
       = new Lazy(() => new ĪnflexorSuffīxus(relātus: Quid, suffīxum: "piam"));
    protected readonly Lazy<ĪnflexorSuffīxus> Quidquam
       = new Lazy(() => new ĪnflexorSuffīxus(relātus: Quid, suffīxum: "quam"));
    protected readonly Lazy<ĪnflexorSuffīxus> Quidque
       = new Lazy(() => new ĪnflexorSuffīxus(relātus: Quid,
                                             suffīxum: Encliticum.Coniugāns.ToString()));
    protected readonly Lazy<ĪnflexorRescrīptus> Quidquid
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Quid,
                                               rescrīptor: scrīptum => scrīptum.Concat(scrīptum)));
    protected readonly Lazy<ĪnflexorCircumfīxus> Quidvīs
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Quid, praefīxum: "vīs"));
    protected readonly Lazy<ĪnflexorRescrīptus> Quod
       = new Lazy(() => new ĪnflexorRescrīptus(relātus: Quid,
                                               rescrīptor: scrīptum => scrīptum switch
                                                                        {
                                                                          "quid" => "quod",
                                                                          "quis" => "quī",
                                                                          _ => scrīptum
                                                                        }));
    protected readonly Lazy<ĪnflexorSuffīxus> Quodpiam
       = new Lazy(() => new ĪnflexorSuffīxus(relātus: Quod, suffīxum: "piam"));
    protected readonly Lazy<ĪnflexorCircumfīxus> Quodvīs
       = new Lazy(() => new ĪnflexorPraefīxus(relātus: Quod, praefīxum: "vīs"));

    protected readonly Lazy<ĪnflexorIncertus> Sē = Sē;
    protected readonly Lazy<ĪnflexorSuffīxus> Sēmet
       = new Lazy(() => new ĪnflexorSuffīxus(relātus: Sē, suffīxum: "met"));
    protected readonly Lazy<ĪnflexorIncertus> Tū = Tū;
    protected readonly Lazy<ĪnflexorRescrīptus> Tūte
        = new Lazy(() => new ĪnflexorRescrīptus(relātus: Tū,
                                                rescrīptor: scrīptum => (scrīptum is "tū").Choose("tūte", scrīptum)));
    protected readonly Lazy<ĪnflexorRescrīptus> Tūtemet
        = new Lazy(() => new ĪnflexorRescrīptus(relātus: Ipsum,
                                                rescrīptor: scrīptum => (scrīptum is "tū").Choose("tūtemet", scrīptum.Concat("met"))));
    private DictionāriumPrōnōminibus()
         : base(new Lazy<Nūntius<DictionāriumPrōnōminibus>>())
         => Nūntius.PlūsGarriōAsync("Fīō");
  }
}
