using System;
using System.Collections.Generic.IEnumerable;
using System.Threading.Tasks.Task;

using Nūntiī.Nūntius;
using Miscella.Extensions;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

namespace Īnflexōrēs.Incertī
{
  [AsyncOverloads]
  public sealed partial class ĪnflexorSuffīxus<Hoc> : Īnflexor<Hoc>
  {
    private readonly Īnflexor<Hoc> Relātus { get; }
    private readonly Lemma? Lemma { get; }
    private readonly string Suffīxum { get; }
    public ĪnflexorSuffīxus(in Lazy<Īnflexor<Hoc>> relātus,
                            in string suffīxum = string.Empty)
        : base(catēgoria: relātus.Value.Catēgoria, nūntius: new Lazy<Nūntius<ĪnflexorSuffīxus>>(),
               illa: relātus.Value.Tabulātor.Invoke())
    {
      Relātus = relātus.Value;
      Lemma = null;
      Suffīxum = suffīxum;
      Nūntius.PlūsGarriōAsync("Fīō");
    }

    public ĪnflexorSuffīxus(in Lemma lemma, in string suffīxum = string.Empty)
        : base(catēgoria: lemma.Catēgoria,
               nūntius: new Lazy<Nūntius<ĪnflexorSuffīxus>>(),
               illa: lemma.Tabulātor.Invoke())
    {
      Relātus = null;
      Lemma = lemma;
      Suffīxum = suffīxum;
      Nūntius.PlūsGarriōAsync("Fīō");
    }

    public string Scrībam(in Enum[] illa)
    {
      string? relātum = await Relātus?.ScrībamAsync(illa: illa) ??
                        await Lemma?.Īnflexor.Invoke(illa)?.Scrīptum;
      return string.IsNullOrWhitespace(relātum)
                   .Choose(string.Empty, relātum.Concat(Suffīxum));
    }
  }
}
