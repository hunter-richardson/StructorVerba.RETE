using System;
using System.Collections.Generic.HashSet;

using Miscella;
using Nūntiī.Nūntius;
using Praebeunda.Īnfectendum.Āctus;
using Pēnsōrēs.Īnflectenda.PēnsorĀctibus.Versiō;
using Ēnumerātiōnēs;

using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Īnflexōrēs.Incertī.Āctūs
{
  [Lazy]
  public sealed partial class ĪnflexorVerbīFacere : ĪnflexorIncertus<Multiplex.Āctus>
  {
    private static readonly Lazy<ĪnflexorVerbīFierī> RelātusPassīvus = ĪnflexorVerbīFierī.Lazy;
    private static readonly Lazy<Īnfectendum.Āctus> RelātusĀctīvus
          = new Lazy(() => await Īnfectendum.Āctus.Cōnstrūctor.Invoke("facere", "fēcisse", "factum",
                                                                      PēnsorĀctibus.Versiō.Āctus_Tertius_Cum_Imperātīvō_Brevī));

    private ĪnflexorVerbīFacere()
         : base(Catēgoria.Āctus, new Lazy<Nūntius<ĪnflexorVerbīFacere>>(),
                Ūtilitātēs.Combīnō(Modus.Īnfīnītīvus.SingleItemSet(), Vōx.Passīva.SingleItemSet()),
                Ūtilitātēs.Combīnō(Modus.Īnfīnītīvus.SingleItemSet(), Vōx.Āctīva.SingleItemSet(),
                                   new HashSet<Tempus>() { Tempus.Praesēns, Tempus.Perfectum }),
                Ūtilitātēs.Combīnō(Modus.Imperātīvus.SingleItemSet(), Vōx.GetValues().Except(Vōx.Nūlla).ToHashSet(),
                                   new HashSet<Tempus>() { Tempus.Praesēns, Tempus.Futūrum, Tempus.Perfectum },
                                   Numerālis.GetValues().Except(Numerālis.Nūllus).ToSortedSet()),
                Ūtilitātēs.Combīnō(Modus.Participālis.SingleItemSet(),
                                   new HashSet<Tempus>() { Tempus.Praesēns, Tempus.Perfectum }),
                Ūtilitātēs.Combīnō(Modus.Participālis.SingleItemSet(), Tempus.Futūrum.SingleItemSet(),
                                   Vōx.GetValues().Except(Vōx.Nūlla).ToHashSet()),
                Ūtilitātēs.Combīnō(new HashSet<Modus>() { Modus.Indicātīvus, Modus.Subiūnctīvus },
                                   new HashSet<Tempus>() { Tempus.Perfectum, Tempus.Plūsquamperfectum, Tempus.Futūrum_Exāctum },
                                   Numerālis.GetValues().Except(Numerālis.Nūllus).ToSortedSet(),
                                   Persōna.GetValues().Except(Persōna.Nūlla).ToSortedSet(),
                                   Vōx.Āctīva.SingleItemSet())
                          .Except(illa => Ūtilitātēs.Omnia(illa.FirstOf<Modus>() is Modus.Subiūnctīvus,
                                                           illa.FirstOf<Tempus>() is Tempus.Futūrum_Exāctum)),
                Ūtilitātēs.Combīnō(new HashSet<Modus>() { Modus.Indicātīvus, Modus.Subiūnctīvus },
                                   new HashSet<Tempus>() { Tempus.Praesēns, Tempus.Īnfectum, Tempus.Futūrum },
                                   Numerālis.GetValues().Except(Numerālis.Nūllus).ToSortedSet(),
                                   Persōna.GetValues().Except(Persōna.Nūlla).ToSortedSet(),
                                   Vōx.GetValues().Except(Vōx.Nūlla).ToHashSet())
                          .Except(illa => Ūtilitātēs.Omnia(illa.FirstOf<Modus>() is Modus.Subiūnctīvus,
                                                           illa.FirstOf<Tempus>() is Tempus.Futūrum)))
    {
      RelātusPassīvus.Value.Tabulātor.Invoke()
                           .ForEach(illa => FōrmamAsync(fōrma: await RelātusPassīvus.Value.ScrībamAsync(illa),
                                                        illa: illa.Add(Vōx.Passīva)));
      Tabula.Except(illa => Fōrmae.Keys.Contains(illa))
            .ForEach(illa => FōrmamAsync(fōrma: await RelātusĀctīvus.Value.ĪnflectemAsync(illa).Scrīptum, illa: illa));

      Nūntius.PlūsGarriōAsync("Fīō");
    }
  }
}
