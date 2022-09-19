using System;
using System.Collections.Generic;
using System.Linq;
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
    private readonly Lemma? Prīmum { get; }
    private readonly Lemma? Secundum { get; }
    public ĪnflexorConiūnctus(in Lemma? prīmum = null, in Lemma? secundum = null)
        : base(catēgoria: primum?.Catēgoria, nūntius: new Lazy<Nūntius<ĪnflexorConiūnctus>>(),
               illa: Enumerable.Intersect(prīmum?.Tabulātor.Invoke(), secundum?.Tabulātor.Invoke()))
    {
      Prīmum = prīmum;
      Secundum = secundum;
      Nūntius.PlūsGarriōAsync("Fīō");
    }

    public string? Scrībam(in Enum[] illa)
    {
      const string? scrīpumPrīmum = (await Prīmum?.Īnflexor.Invoke(illa))?.Scrīptum;
      const string? scrīpumSecundum = (await Secundum?.Īnflexor.Invoke(illa))?.Scrīptum;
      return Ūtilitātēs.Nūlla(string.IsNullOrWhitespace(scrīpumPrīmum),
                              string.IsNullOrWhitespace(scrīpumSecundum))
                       .Choose(scrīpumPrīmum.Concat(scrīpumSecundum), null);
    }
  }
}
