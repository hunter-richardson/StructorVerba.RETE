using System;
using Praebeunda.Multiplex.Adverbium;
using Ēnumerātiōnēs;
using Nūntiī.Nūntius;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs
{
  [Singleton]
  [AsyncOverloads]
  public sealed partial class ĪnflexorAdverbiīs : Īnflexor<Īnflectendum.Adverbium, Multiplex.Adverbium>
  {
    public enum Versiō
    { Exāctum }

    public static readonly Lazy<ĪnflexorAdverbiīs> Faciendum = new Lazy<ĪnflexorAdverbiīs>(() => Instance);

    protected ĪnflexorAdverbiīs()
          : base(Ēnumerātiōnēs.Catēgoria.Adverbium,
                 NūntiusĪnflexōrīAdverbiīsAdverbium.Faciendum,
                 Gradus.GetValues().Except(Gradus.Nūllus)) { }

    public string? Scrībam(in Īnflectendum.Adverbium adverbium, in Enum[] illa)
    {
      return Gradūs.Iactor.Invoke(from illud in illa
                                  where illud is Gradus
                                  select illud).First() switch
      {
        Positīvus => adverbium.Positīvus,
        Comparātīvus => adverbium.Comparātīvus,
        Superlātīvus => adverbium.Superlātīvus,
        _ => null
      };
    }

    [Singleton]
    private sealed partial class NūntiusĪnflexōrīAdverbiīsAdverbium : Nūntius<ĪnflexorAdverbiīs>
    {
      public static readonly Lazy<NūntiusĪnflexōrīAdverbiīsAdverbium> Faciendum =
                         new Lazy<NūntiusĪnflexōrīAdverbiīsAdverbium>(() => Instance);
    }
  }
}
