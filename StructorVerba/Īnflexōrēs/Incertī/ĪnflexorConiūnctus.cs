using System;
using System.Collections.Generic;
using System.Threading.Tasks.Task;

using Miscella.Ūtilitātēs;
using Nūntiī.Nūntius;
using Praebeunda.Īnflectendum;

using BuilderCommon.BuidlerException;
using Lombok.NET.MethodGeneratorsAsyncOverloadsAttribute;

namespace Īnflexōrēs.Incertī
{
  [AsyncOverloads]
  public sealed partial class ĪnflexorConiūnctus<Hoc> : Īnflexor<Hoc>
  {
    private readonly Īnflectendum? Prīmum { get; }
    private readonly Īnflectendum? Secundum { get; }
    public ĪnflexorConiūnctus(in Lemma? prīmum, in Lemma? secundum)
        : base(primum?.Catēgoria, new Lazy<Nūntius<ĪnflexorConiūnctus>>(),
               IEnumerable.Intersect(prīmum?.Tabulātor.Invoke(), secundum?.Tabulātor.Invoke()))
    {
      Prīmum = await prīmum?.Relātor.Invoke();
      Secundum = await secundum?.Relātor.Invoke();
    }

    public string? Scrībam(in Enum[] illa)
    {
      const string? scrīpumPrīmum = (await Prīmum?.ĪnflectemAsync(illa))?.Scrīptum;
      const string? scrīpumSecundum = (await Secundum?.ĪnflectemAsync(illa))?.Scrīptum;
      return Ūtilitātēs.Nūlla(string.IsNullOrWhitespace(scrīpumPrīmum),
                              string.IsNullOrWhitespace(scrīpumSecundum))
                       .Choose(scrīpumPrīmum.Concat(scrīpumSecundum), null);
    }
  }
}
