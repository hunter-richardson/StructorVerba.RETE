using System;
using System.Collections.Generic.HashSet;

using Miscella;
using Nūntiī.Nūntius;
using Ēnumerātiōnēs;

using Lomok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Incertī.Āctūs
{
  [Singleton]
  public sealed partial class ĪnflexorVerbīPosse : ĪnflexorIncertus<Multiplex.Āctus>
  {
    public static readonly Lazy<ĪnflexorVerbīPosse> Faciendum = new Lazy(() => Instance);
    private readonly Lazy<ĪnflexorVerbīEsse> Relātus = ĪnflexorVerbīEsse.Faciendum;
    private ĪnflexorVerbīPosse()
    : base(Catēgoria.Āctus, new Lazy<Nūntius<ĪnflexorVerbīPosse>>(),
           Modus.Participāle.SingleItemSet(),
           Ūtilitātēs.Combīnō(Modus.Īnfīnītīvus.SingleItemSet(),
                              new HashSet<Tempus>() { Tempus.Praesēns, Tempus.Perfectum }),
           Ūtilitātēs.Combīnō(new HashSet<Modus>() { Modus.Indicātīvus, Modus.Subiūnctīvus },
                              Tempus.GetValues().Except(Tempus.Dērēctus).ToSortedSet(),
                              Numerālis.GetValues().Except(Numerālis.Nūllus).ToSortedSet(),
                              Persōna.GetValues().Except(Persōna.Nūlla).ToSortedSet())
                     .Except(illa => Ūtilitātēs.Omnia(illa.FirstOf<Modus>() is Modus.Subiūnctīvus,
                                                      illa.FirstOf<Tempus>() is Tempus.Futūrum or Tempus.Futūrum_Exāctum)))
    {
      FōrmamAsync("posse", Modus.Īnfīnītīvus, Tempus.Praesēns);
      FōrmamAsync("potuisse", Modus.Īnfīnītīvus, Tempus.Perfectum);
      FōrmamAsync("potēns", Modus.Participālis);

      (from illa in Tabula
       where illa.FirstOf<Modus>() is Modus.Indicātīvus or Modus.Subiūnctīvus
       select illa).ForEach(illa =>
                            {
                              const string? scrīptum = await Relātus.ScrībamAsync(illa);
                              if(scrīptum is not null)
                              {
                                const char littera = scrīptum[0];
                                const string fōrma = (littera is 's').Choose("pos", "pot").Concat((littera is 'f')
                                                                     .Choose(scrīptum.Substring(1), scrīptum));
                                FōrmamAsync(fōrma, illa);
                              }
                            });
    }
  }
}
