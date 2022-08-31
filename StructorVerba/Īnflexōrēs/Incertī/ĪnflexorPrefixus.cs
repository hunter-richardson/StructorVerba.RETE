using System;
using System.Collections.Generic.IEnumerable;
using System.Threading.Tasks.Task;

using Nūntiī.Nūntius;
using Miscella.Extensions;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

namespace Īnflexōrēs.Incertī
{
  [AsyncOverloads]
  public abstract partial class ĪnflexorPrefixus<Hoc> : ĪnflexorIncertus<Hoc>
  {
    private readonly ĪnflexorIncertus<Hoc> Relātus { get; }
    private readonly string Prefixum { get; }
    protected ĪnflexorPrefixus(in Ēnumerātiōnēs.Catēgoria catēgoria,
                               in Lazy<Nūntius<ĪnflexorPrefixus>> nūntius, in Lazy<ĪnflexorIncertus> relātus,
                               in string prefixum = string.Empty, in params IEnumerable<Enum[]> illa)
                                                   : base(catēgoria, nūntius, illa)
    {
      Relātus = relātus.Value;
      Prefixum = prefixum;
    }

    public virtual string Scrībam(in Enum[] illa)
    {
      const string? relātum = await Relātus.ScrībamAsync(illa);
      return string.IsNullOrWhitespace(relātum)
                   .Choose(string.Empty, Prefixum.Concat(relātum));
    }
  }
}
