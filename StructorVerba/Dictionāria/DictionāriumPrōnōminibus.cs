using System;

using Miscella;
using Nūntiī.Nūntius;
using Praebeunda.Multiplex.Prōnōmen;
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
                                                     new HashSet<Casus>() { Casus.Nōminātīvus, Casus.Genitīvus, Casus.Accūsātīvus, Casus.Vocātīvus },
                                                     Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet()),
                                  Ūtilitātēs.Combīnō(Genus.GetValues().Except(Genus.Nūllum).ToHasSet(),
                                                     new HashSet<Casus>() { Casus.Datīvus, Casus.Ablātīvus, Casus.Locātīvus, Casus.Inatrumentālis },
                                                     Numerālis.Singulāris.SingleItemSet(),
                                  Ūtilitātēs.Combīnō(new HashSet<Casus>() { Casus.Datīvus, Casus.Ablātīvus, Casus.Locātīvus, Casus.Inatrumentālis },
                                                     Numerālis.Plūrālis.SingleItemSet());

    protected readonly Lazy<ĪnflexorIncertus> Sē = ĪnflexorVerbīSē.Faciendum;

    private DictionāriumPrōnōminibus()
         : base(new Lazy<Nūntius<DictionāriumPrōnōminibus>>()) { }
  }
}
