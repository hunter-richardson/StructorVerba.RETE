using Praebeunda.Īnflectendum.NumerāmenOmnium;
using Praebeunda.Multiplex.Numerāmen;
using Ēnumerātiōnēs;
using Nūntiī.Nūntius;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Numerāmina
{
  [AsyncOverloads]
  public sealed partial class ĪnflexorNumerāminibusOmnium : ĪnflexorNumerāminibus<NumerāmenOmnium>
  {
    public static readonly Lazy<ĪnflexorNumerāminibusOmnium> Faciendum = new Lazy<ĪnflexorNumerāminibusOmnium>(() => Instance);
    protected ĪnflexorNumerāminibusOmnium()
          : base(Ēnumerātiōnēs.Catēgoria.Numerāmen, NūntiusĪnflexōrīNumerāminibusOmnium.Faciendum,
                  Numerium.GetValues()) { }
    public string Scrībam(in NumerāmenOmnium numerāmen, in Numerium numerium)
            => numerium switch
            {
              Numerium.Ōrdināle => numerāmen.Ōrdināle,
              Numerium.Cardināle => numerāmen.Cardināle,
              Numerium.Adverbium => numerāmen.Adverbium,
              Numerium.Multiplicātīvum => numerāmen.Multiplicātīvum,
              Numerium.Distribūtīvum => numerāmen.Distribūtīvum,
              Numerium.Frāctiōnāle => numerāmen.Frāctiōnāle,
              _ => numerāmen.Numerus
            };

    [Singleton]
    private sealed partial class NūntiusĪnflexōrīNumerāminibusOmnium : Nūntius<ĪnflexorNumerāminibusOmnium>
    {
      public static readonly Lazy<NūntiusĪnflexōrīNumerāminibusOmnium> Faciendum
                       = new Lazy<NūntiusĪnflexōrīNumerāminibusOmnium>(() => Instance);
    }
  }
}
