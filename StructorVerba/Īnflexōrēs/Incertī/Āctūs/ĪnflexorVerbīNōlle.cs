using System;
using System.Collections.Generic.HashSet;

using Miscella;
using Nūntiī.Nūntius;
using Ēnumerātiōnēs;

using Lomok.NET.PropertyGenerators.LazyAttribute;

namespace Īnflexōrēs.Incertī.Āctūs
{
  [Lazy]
  public sealed partial class ĪnflexorVerbīNōlle : ĪnflexorIncertus<Multiplex.Āctus>
  {
    private readonly Lazy<ĪnflexorRescrīptus> Relātus
     = new Lazy(() => new ĪnflexorRescrīptus(relātus: ĪnflexorVerbīVelle.Lazy,
                                             rescrīptor: scrīptum => "nō".Concat(scrīptum.Substring(2))));

    private ĪnflexorVerbīNōlle()
        : base(Catēgoria.Āctus, new Lazy<Nūntius<ĪnflexorVerbīNōlle>>(), Modus.Participālis.SingleItemSet(),
               Ūtilitātēs.Combīnō(Modus.Īnfīnītīvus.SingleItemSet(),
                                  new HashSet<Tempus>() { Tempus.Praesēns, Tempus.Perfectum }),
               Ūtilitātēs.Combīnō(new HashSet<Modus>() { Modus.Indicātīvus, Modus.Subiūnctīvus },
                                  Tempus.GetValues().Except(Tempus.Intemporāle).ToHashSet(),
                                  Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet(),
                                  Persōna.GetValues().Except(Persōna.Nūlla).ToHashSet())
                         .Except(illa => Ūtilitātēs.Omnia(illa.FirstOf<Modus>() is Modus.Subiūnctīvus,
                                                          illa.FirstOf<Tempus>() is Tempus.Futūrum or Tempus.Futūrum_Exāctum))
                         .Except(illa => Ūtilitātēs.Omnia(illa.FirstOf<Modus>() is Modus.Indicātīvus,
                                                          illa.FirstOf<Tempus>() is Tempus.Praesēns,
                                                          illa.FirstOf<Numerālis>() is Numerālis.Singulāris,
                                                          illa.FirstOf<Persōna>() is not Persōna.Prīma))
                         .Except(illa => Ūtilitātēs.Omnia(illa.FirstOf<Modus>() is Modus.Indicātīvus,
                                                          illa.FirstOf<Tempus>() is Tempus.Praesēns,
                                                          illa.FirstOf<Numerālis>() is Numerālis.Plūrālis,
                                                          illa.FirstOf<Persōna>() is Persōna.Secunda)))
    {
      Tabula.ForEach(illa => FōrmamAsync(fōrma: await Relātus.ScrībamAsync(illa), illa: illa));
      Nūntius.PlūsGarriōAsync("Fīō");
    }
  }
}
