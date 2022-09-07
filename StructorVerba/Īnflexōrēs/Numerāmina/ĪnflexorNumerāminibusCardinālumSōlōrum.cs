using System;

using Nūntiī.Nūntius;
using Praebeunda.Īnflectendum.NumerāmenCardinālumSōlōrum;
using Praebeunda.Multiplex.Numerāmen;
using Ēnumerātiōnēs;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Numerāmina
{
  [Singleton]
  [AsyncOverloads]
  public sealed partial class ĪnflexorNumerāminibusCardinālumSōlōrum : ĪnflexorNumerāminibus<NumerāmenCardinālumSōlōrum>
  {
    public static readonly Lazy<ĪnflexorNumerāminibusCardinālumSōlōrum> Faciendum = new Lazy<ĪnflexorNumerāminibusCardinālumSōlōrum>(() => Instance);
    protected ĪnflexorNumerāminibusCardinālumSōlōrum()
          : base(new Lazy<Nūntius<ĪnflexorNumerāminibusCardinālumSōlōrum>>(() => new Nūntius<ĪnflexorNumerāminibusCardinālumSōlōrum>()),
                 Numerium.Numerus, Numerium.Cardināle) { }

    public string Scrībam(in NumerāminibusCardinālumŌrdinālumque numerāmen, in Numerium numerium)
            => Numerium.Cardināle.Equals(numerium).Choose(numerāmen.Cardināle, numerāmen.Numerus);
  }
}
