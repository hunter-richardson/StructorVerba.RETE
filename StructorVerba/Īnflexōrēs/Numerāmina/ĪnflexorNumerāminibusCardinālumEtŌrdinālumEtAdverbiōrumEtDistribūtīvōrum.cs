using Praebeunda.Īnflectendum.NumerāmenCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum;
using Praebeunda.Multiplex.Numerāmen;
using Ēnumerātiōnēs;
using Nūntiī.Nūntius;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.SingletonAttribute;
namespace Īnflexōrēs.Numerāmina
{
  [Singleton]
  [AsyncOverloads]
  public sealed partial class ĪnflexorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum : ĪnflexorNumerāminibus<NumerāmenCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum>
  {
    public static readonly Lazy<ĪnflexorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum> Faciendum =
                       new Lazy<ĪnflexorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum>(() => Instance);

    protected ĪnflexorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum()
          : base(Ēnumerātiōnēs.Catēgoria.Numerāmen, NūntiusĪnflexōrīNumerāminibusOmnium.Faciendum,
                  Numerium.Numerus, Numerium.Cardināle, Numerium.Ōrdināle, Numerium.Adverbium, Numerium.Distribūtīvum)
    { }

    public string Scrībam(in NumerāmenCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum numerāmen, in Numerium numerium)
            => numerium switch
            {
              Numerium.Ōrdināle => numerāmen.Ōrdināle,
              Numerium.Cardināle => numerāmen.Cardināle,
              Numerium.Adverbium => numerāmen.Adverbium,
              Numerium.Distribūtīvum => numerāmen.Distribūtīvum,
              _ => numerāmen.Numerus
            };

    [Singleton]
    private sealed partial class NūntiusĪnflexōrīNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum : Nūntius<ĪnflexorNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum>
    {
      public static readonly Lazy<NūntiusĪnflexōrīNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum> Faciendum =
                         new Lazy<NūntiusĪnflexōrīNumerāminibusCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum>(() => Instance);
    }
  }
}
