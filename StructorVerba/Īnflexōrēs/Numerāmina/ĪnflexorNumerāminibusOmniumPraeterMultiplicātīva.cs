using Praebeunda.Īnflectendum.NumerāmenOmniumPraeterMultiplicātīva;
using Praebeunda.Multiplex.Numerāmen;
using Ēnumerātiōnēs;
using Nūntiī.Nūntius;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Numerāmina
{
  [Singleton]
  [AsyncOverloads]
  public sealed partial class ĪnflexorNumerāminibusOmniumPraeterMultiplicātīva : ĪnflexorNumerāminibus<NumerāmenOmniumPraeterMultiplicātīva>
  {
    public static readonly Lazy<ĪnflexorNumerāminibusOmniumPraeterMultiplicātīva> Faciendum = new Lazy<ĪnflexorNumerāminibusOmniumPraeterMultiplicātīva>(() => Instance);
    protected ĪnflexorNumerāminibusOmniumPraeterMultiplicātīva()
          : base(Ēnumerātiōnēs.Catēgoria.Numerāmen, NūntiusĪnflexōrīNumerāminibusOmniumPraeterMultiplicātīva.Faciendum,
                  Numerium.GetValues().Except(Numerium.Multiplicātīvum)) { }

    public string Scrībam(in NumerāmenOmniumPraeterMultiplicātīva numerāmen, in Numerium numerium)
            => numerium switch
            {
              Numerium.Ōrdināle => numerāmen.Ōrdināle,
              Numerium.Cardināle => numerāmen.Cardināle,
              Numerium.Adverbium => numerāmen.Adverbium,
              Numerium.Distribūtīvum => numerāmen.Distribūtīvum,
              Numerium.Frāctiōnāle => numerāmen.Frāctiōnāle,
              _ => numerāmen.Numerus
            };

    [Singleton]
    private sealed partial class NūntiusĪnflexōrīNumerāminibusOmniumPraeterMultiplicātīva : Nūntius<ĪnflexorNumerāminibusOmniumPraeterMultiplicātīva>
    {
      public static readonly Lazy<NūntiusĪnflexōrīNumerāminibusOmniumPraeterMultiplicātīva> Faciendum =
                         new Lazy<NūntiusĪnflexōrīNumerāminibusOmniumPraeterMultiplicātīva>(() => Instance);
    }
  }
}
