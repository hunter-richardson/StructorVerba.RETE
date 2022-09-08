using System;

using Nūntiī.Nūntius;
using Praebeunda.Multiplex.Adverbium;
using Ēnumerātiōnēs;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs
{
  [Singleton]
  [AsyncOverloads]
  public sealed partial class ĪnflexorAdverbiīs : Īnflexor<Īnflectendum.Adverbium, Multiplex.Adverbium>
  {
    public static readonly Lazy<ĪnflexorAdverbiīs> Faciendum = new Lazy(() => Instance);

    protected ĪnflexorAdverbiīs()
          : base(Ēnumerātiōnēs.Catēgoria.Adverbium,
                 new Lazy<Nūntius<ĪnflexorAdverbiīs>>(),
                 Gradus.GetValues().Except(Gradus.Nūllus)) { }

    public sealed string? Scrībam(in Īnflectendum.Adverbium adverbium, in Enum[] illa)
              => illa.FirstOf<Gradus>() switch
                  {
                    Positīvus => adverbium.Positīvus,
                    Comparātīvus => adverbium.Comparātīvus,
                    Superlātīvus => adverbium.Superlātīvus,
                    _ => null
                  };
  }
}
