using System;
using System.Collections.Generic.HashSet;

using Miscella;
using Nūntiī.Nūntius;
using Ēnumerātiōnēs;

using Lomok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Incertī.Āctūs
{
  [Singleton]
  public sealed partial class ĪnflexorVerbīMālle : ĪnflexorIncertus<Multiplex.Āctus>
  {
    public static readonly Lazy<ĪnflexorVerbīMālle> Faciendum = new Lazy(() => Instance);

    private readonly Lazy<ĪnflexorVerbīVelle> Relātus = ĪnflexorVerbīVelle.Faciendum;

    private ĪnflexorVerbīMālle()
        : base(Catēgoria.Āctus, new Lazy<Nūntius<ĪnflexorVerbīMālle>>(), Modus.Participālis.SingleItemSet(),
               Ūtilitātēs.Combīnō(Modus.Īnfīnītīvus.SingleItemSet(),
                                  new HashSet<Tempus>() { Tempus.Praesēns, Tempus.Perfectum }),
               Ūtilitātēs.Combīnō(new HashSet<Modus>() { Modus.Indicātīvus, Modus.Subiūnctīvus },
                                  Tempus.GetValues().Except(Tempus.Intemporāle).ToHashSet(),
                                  Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet(),
                                  Persōna.GetValues().Except(Persōna.Nūlla).ToHashSet())
                         .Except(illa => Ūtilitātēs.Omnia(illa.FirstOf<Modus>() is Modus.Subiūnctīvus,
                                                          illa.FirstOf<Tempus>() is Tempus.Futūrum or Tempus.Futūrum_Exāctum)))
    {
      FōrmamAsync("māvīs", Modus.Indicātīvus, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Secunda);
      FōrmamAsync("māvult", Modus.Indicātīvus, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Tertia);
      FōrmamAsync("māvultis", Modus.Indicātīvus, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Secunda);

      Tabula.Except(illa => Fōrmae.Keys.Contains(illa))
            .ForEach(illa => FōrmamAsync(await Relātus.ScrībamAsync(illa)
                                                      .ReplaceFirst("vo", "mā")
                                                      .ReplaceFirst("ve", "mā"),
                                         illa));
    }
  }
}
