using System;

using Nūntiī.Nūntius;
using Praebeunda.Īnflectendum.NumerāmenOmniumPraeterFrāctiōnēs;
using Praebeunda.Multiplex.Numerāmen;
using Ēnumerātiōnēs;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Numerāmina
{
  [AsyncOverloads]
  public sealed partial class ĪnflexorNumerāminibusOmniumPraeterFrāctiōnēs : ĪnflexorNumerāminibus<NumerāmenOmniumPraeterFrāctiōnēs>
  {
    public static readonly Lazy<ĪnflexorNumerāminibusOmniumPraeterFrāctiōnēs> Faciendum =
                       new Lazy<ĪnflexorNumerāminibusOmniumPraeterFrāctiōnēs>(() => Instance);
    protected ĪnflexorNumerāminibusOmniumPraeterFrāctiōnēs()
          : base(new Lazy<Nūntius<ĪnflexorNumerāminibusOmniumPraeterFrāctiōnēs>>(() => new Nūntius<ĪnflexorNumerāminibusOmniumPraeterFrāctiōnēs>()),
                 Numerium.GetValues().Except(Numerium.Frāctiōnāle)) { }
    public string Scrībam(in NumerāmenOmniumPraeterFrāctiōnēs numerāmen, in Numerium numerium)
            => numerium switch
                {
                  Numerium.Numerus => numerāmen.Numerus,
                  Numerium.Ōrdināle => numerāmen.Ōrdināle,
                  Numerium.Cardināle => numerāmen.Cardināle,
                  Numerium.Adverbium => numerāmen.Adverbium,
                  Numerium.Multiplicātīvum => numerāmen.Multiplicātīvum,
                  Numerium.Distribūtīvum => numerāmen.Distribūtīvum,
                  _ => numerāmen.Numerus
                };

    [Singleton]
    private sealed partial class NūntiusĪnflexōrīNumerāminibusOmniumPraeterFrāctiōnēs : Nūntius<ĪnflexorNumerāminibusOmniumPraeterFrāctiōnēs>
    {
      public static readonly Lazy<NūntiusĪnflexōrīNumerāminibusOmniumPraeterFrāctiōnēs> Faciendum =
                         new Lazy<NūntiusĪnflexōrīNumerāminibusOmniumPraeterFrāctiōnēs>(() => Instance);
    }
  }
}
