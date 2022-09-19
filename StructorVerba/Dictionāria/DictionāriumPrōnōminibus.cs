using System;

using Miscella;
using Nūntiī.Nūntius;
using Praebeunda.Multiplex.Prōnōmen;
using Ēnumerātiōnēs;
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

    protected readonly Lazy<ĪnflexorPrefixus> Aliquid
       = new Lazy(() => new ĪnflexorPrefixus(ĪnfexorVerbīQuid.Faciendum, "ali"));
    protected readonly Lazy<ĪnflexorRescrīptus> Ecquid
       = new Lazy(() => new ĪnflexorRescrīptus(ĪnfexorVerbīQuid.Faciendum,
                                               scrīptum => scrīptum switch
                                                {
                                                  "cuius" => "ecculus",
                                                  _ => "ec".Concat(scrīptum)
                                                }));
    protected readonly Lazy<ĪnflexorIncertus> Ego = ĪnfexorVerbīEgo.Faciendum;
    protected readonly Lazy<ĪnflexorSuffixus> Egomet
       = new Lazy(() => new ĪnflexorSuffixus(ĪnfexorVerbīEgo.Faciendum, "met"));
    protected readonly Lazy<ĪnflexorIncertus> Hoc = ĪnfexorVerbīHoc.Faciendum;
    protected readonly Lazy<ĪnflexorIncertus> Id = ĪnfexorVerbīId.Faciendum;
    protected readonly Lazy<ĪnflexorRescrīptus> Idem
       = new Lazy(() => new ĪnflexorRescrīptus(ĪnfexorVerbīQuid.Faciendum,
                                               scrīptum => (scrīptum[1] switch
                                                {
                                                  "id" => "i",
                                                  "is" => "ī",
                                                  _ => scrīptum
                                                }).Concat("dem")));
    protected readonly Lazy<ĪnflexorRescrīptus> Illoc
       = new Lazy(() => new ĪnflexorRescrīptus(ĪnflexorVerbīHoc.Faciendum,
                                               scrīptum => scrīptum.ReplaceFirst("h", "ill")));
    protected readonly Lazy<ĪnflexorIncertus> Illud = ĪnfexorVerbīIllud.Faciendum;
    protected readonly Lazy<ĪnflexorIncertus> Ipsum = ĪnfexorVerbīIpsum.Faciendum;
    protected readonly Lazy<ĪnflexorRescrīptus> Istud
       = new Lazy(() => new ĪnflexorRescrīptus(ĪnflexorVerbīIllud.Faciendum,
                                               scrīptum => scrīptum.ReplaceFirst("ill", "ist")));
    protected readonly Lazy<ĪnflexorIncertus> Quid = ĪnfexorVerbīQuid.Faciendum;
    protected readonly Lazy<ĪnflexorSuffixus> Quidpiam
       = new Lazy(() => new ĪnflexorSuffixus(ĪnfexorVerbīQuid.Faciendum, "piam"));
    protected readonly Lazy<ĪnflexorSuffixus> Quidquam
       = new Lazy(() => new ĪnflexorSuffixus(ĪnfexorVerbīQuid.Faciendum, "quam"));
    protected readonly Lazy<ĪnflexorSuffixus> Quidque
       = new Lazy(() => new ĪnflexorSuffixus(ĪnfexorVerbīQuid.Faciendum, Ecliticum.Coniugāns.ToString()));
    protected readonly Lazy<ĪnflexorRescrīptus> Quidquid
       = new Lazy(() => new ĪnflexorRescrīptus(ĪnfexorVerbīQuid.Faciendum,
                                               scrīptum => scrīptum.Concat(scrīptum)));
    protected readonly Lazy<ĪnflexorRescrīptus> Quod
       = new Lazy(() => new ĪnflexorRescrīptus(ĪnfexorVerbīQuid.Faciendum,
                                               scrīptum => scrīptum switch
                                                {
                                                  "quid" => "quod",
                                                  "quis" => "quī",
                                                  _ => scrīptum
                                                }));
    protected readonly Lazy<ĪnflexorSuffixus> Quodpiam
       = new Lazy(() => new ĪnflexorSuffixus(ĪnfexorVerbīQuod.Faciendum, "piam"));
    protected readonly Lazy<ĪnflexorIncertus> Sē = ĪnflexorVerbīSē.Faciendum;

    private DictionāriumPrōnōminibus()
         : base(new Lazy<Nūntius<DictionāriumPrōnōminibus>>()) { }
  }
}
