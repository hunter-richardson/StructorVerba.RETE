using System;
using System.Collections.Generic.IEnumerable;
using System.Threading.Tasks.Task;

using Nūntiī.Nūntius;
using Miscella.Extensions;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

namespace Īnflexōrēs.Incertī
{
  [AsyncOverloads]
  public sealed partial class ĪnflexorCircumfixus<Hoc> : Īnflexor<Hoc>
  {
    private readonly ĪnflexorIncertus<Hoc> Relātus { get; }
    private readonly string Prefixum { get; }
    private readonly string Suffixum { get; }
    public ĪnflexorCircumfixus(in Lazy<ĪnflexorIncertus<Hoc>> relātus,
                               in Lazy<Nūntius<ĪnflexorCircumfixus<Hoc>>> nūntius,
                               in string? prefixum, in string? suffixum)
                                          : base(relātus.Value.Catēgoria, nūntius, relātus.Value.Tabulātor.Invoke())
    {
      Relātus = relātus.Value;
      Prefixum = prefixum ?? string.Empty;
      Suffixum = suffixum ?? string.Empty;
    }

    public string Scrībam(in Enum[] illa)
    {
      const string? relātum = await Relātus.ScrībamAsync(illa);
      return string.IsNullOrWhitespace(relātum)
                   .Choose(string.Empty, Prefixum.Concat(relātum).Concat(Suffixum));
    }
  }
}
