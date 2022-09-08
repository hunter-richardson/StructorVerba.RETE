using System;
using System.Collections.Generic.IEnumerable;
using System.Threading.Tasks.Task;

using Nūntiī.Nūntius;
using Miscella.Extensions;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

namespace Īnflexōrēs.Incertī
{
  [AsyncOverloads]
  public sealed partial class ĪnflexorPrefixus<Hoc> : Īnflexor<Hoc>
  {
    private readonly ĪnflexorIncertus<Hoc> Relātus { get; }
    private readonly string Prefixum { get; }
    public ĪnflexorPrefixus(in Lazy<ĪnflexorIncertus<Hoc>> relātus,
                            in Lazy<Nūntius<ĪnflexorPrefixus<Hoc>>> nūntius,
                            in string? prefixum)
                                    : base(relātus.Value.Catēgoria, nūntius, relātus.Value.Tabulātor.Invoke())
    {
      Relātus = relātus.Value;
      Prefixum = prefixum ?? string.Empty;
    }

    public string Scrībam(in Enum[] illa)
    {
      const string? relātum = await Relātus.ScrībamAsync(illa);
      return string.IsNullOrWhitespace(relātum)
                   .Choose(string.Empty, Prefixum.Concat(relātum));
    }
  }
}
