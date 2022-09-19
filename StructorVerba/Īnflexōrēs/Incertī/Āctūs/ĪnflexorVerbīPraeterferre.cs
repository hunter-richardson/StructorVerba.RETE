using System;
using System.Collections.Generic.HashSet;
using System.Linq;

using Miscella;
using Nūntiī.Nūntius;
using Ēnumerātiōnēs;

using Lomok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Incertī.Āctūs
{
  [Singleton]
  public sealed partial class ĪnflexorVerbīPraeterferre : ĪnflexorIncertus<Multiplex.Āctus>
  {
    public static readonly Lazy<ĪnflexorVerbīPraeterferre> Faciendum = new Lazy(() => Instance);

    private readonly Lazy<ĪnflexorVerbīFerre> Relātus = ĪnflexorVerbīFerre.Faciendum;

    private ĪnflexorVerbīPraeterferre()
        : base(Catēgoria.Āctus, new Lazy<Nūntius<ĪnflexorVerbīPraeterferre>>(),
               Ūtilitātēs.Combīnō(Modus.Īnfīnītīvus.SingleItemSet(), Vōx.GetValues().Except(Vōx.Nūlla).ToHashSet()),
               Ūtilitātēs.Combīnō(Modus.Participālis.SingleItemSet(), Tempus.Futūrum.SingleItemSet(),
                                  Vōx.GetValues().Except(Vōx.Nūlla).ToHashSet()),
               Ūtilitātēs.Combīnō(Modus.Participālis.SingleItemSet(),
                                  new HashSet<Tempus>() { Tempus.Praesēns, Tempus.Perfectum }),
               Ūtilitātēs.Combīnō(Modus.Imperātīvus.SingleItemSet(), Vōx.GetValues().Except(Vōx.Nūlla).ToHashSet(),
                                  Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet(),
                                  new HashSet<Tempus>() { Tempus.Praesēns, Tempus.Futūrum }),
                Ūtilitātēs.Combīnō(new HashSet<Modus>() { Modus.Indicātīvus, Modus.Subiūnctīvus },
                                   new HashSet<Tempus>() { Tempus.Praesēns, Tempus.Īnfectum, Tempus.Futūrum },
                                   Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet(),
                                   Persōna.GetValues().Except(Persōna.Nūlla).ToHashSet())
                          .Except(illa => Ūtilitātēs.Omnia(illa.FirstOf<Modus>() is Modus.Subiūnctīvus,
                                                           illa.FirstOf<Tempus>() is Tempus.Futūrum or Tempus.Futūrum_Exāctum)))
    {
      FōrmamAsync("praeterferre", Modus.Īnfīnītīvus, Vōx.Āctīva);
      (from valōrēs in Tabula
       where valōrēs.ContainsAny(Modus.Īnfīnītīvus, Vōx.Passīva)
       select valōrēs).ForEach(illa => FōrmamAsync(fōrma: "praeter".Concat(await Relātus.Value.ScrībamAsync(illa)), illa: illa));

      Nūntius.PlūsGarriōAsync("Fīō");
    }
  }
}
