using System;
using System.Collections.Generic.IEnumerable;
using System.Threading.Tasks.Task;

using Nūntiī.Nūntius;
using Miscella.Extensions;
using Praebeunda.Lemma;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

namespace Īnflexōrēs.Incertī
{
  [AsyncOverloads]
  public sealed partial class ĪnflexorPraefīxus<Hoc> : Īnflexor<Hoc>
  {
    private readonly Īnflexor<Hoc>? Relātus { get; }
    private readonly string Praefīxum { get; }
    public ĪnflexorPraefīxus(in Lazy<Īnflexor<Hoc>> relātus,
                             in string praefīxum = string.Empty)
        : base(catēgoria: relātus.Value.Catēgoria,
               nūntius: new Lazy<Nūntius<ĪnflexorPraefīxus>>(),
               illa: relātus.Value.Tabulātor.Invoke())
    {
      Relātus = relātus.Value;
      Praefīxum = praefīxum;
      Nūntius.PlūsGarriōAsync("Fīō");
    }

    public string Scrībam(in Enum[] illa)
    {
      string? relātum = await Relātus.ScrībamAsync(illa: illa);
      return string.IsNullOrWhitespace(relātum)
                   .Choose(string.Empty, Praefīxum.Concat(relātum));
    }
  }
}
