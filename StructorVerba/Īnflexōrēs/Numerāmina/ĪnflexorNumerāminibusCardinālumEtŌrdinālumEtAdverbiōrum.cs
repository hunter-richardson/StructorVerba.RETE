using Praebeunda.Īnflectendum.NumerāmenCardinālumEtŌrdinālumEtAdverbiōrum;
using Praebeunda.Multiplex.Numerāmen;
using Ēnumerātiōnēs;
using Nūntiī.Nūntius;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.SingletonAttribute;
namespace Īnflexōrēs.Numerāmina
{
  [Singleton]
  [AsyncOverloads]
  public sealed partial class ĪnflexorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrum : ĪnflexorNumerāminibus<NumerāmenCardinālumEtŌrdinālumEtAdverbiōrum>
  {
    public static readonly Lazy<ĪnflexorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrum> Faciendum =
                       new Lazy<ĪnflexorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrum>(() => Instance);

    protected ĪnflexorNumerāminibusOmnium()
          : base(NūntiusĪnflexōrīNumerāminibusOmnium.Faciendum,
                 Numerium.Numerus, Numerium.Cardināle, Numerium.Ōrdināle, Numerium.Adverbium) { }

    public string Scrībam(in NumerāmenCardinālumEtŌrdinālumEtAdverbiōrum numerāmen, in Numerium numerium)
            => numerium switch
            {
              Numerium.Ōrdināle => numerāmen.Ōrdināle,
              Numerium.Cardināle => numerāmen.Cardināle,
              Numerium.Adverbium => numerāmen.Adverbium,
              _ => numerāmen.Numerus
            };

    [Singleton]
    private sealed partial class NūntiusĪnflexōrīNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrum
                : Nūntius<ĪnflexorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrum>
    {
      public static readonly Lazy<NūntiusĪnflexōrīNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrum> Faciendum =
                         new Lazy<NūntiusĪnflexōrīNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrum>(() => Instance);
    }
  }
}
