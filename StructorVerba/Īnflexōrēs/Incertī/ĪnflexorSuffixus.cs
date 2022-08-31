using System;
using System.Collections.Generic.IEnumerable;
using System.Threading.Tasks.Task;

using Nūntiī.Nūntius;
using Miscella.Extensions;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

namespace Īnflexōrēs.Incertī
{
  [AsyncOverloads]
  public abstract partial class ĪnflexorSuffixus<Hoc> : ĪnflexorIncertus<Hoc>
  {
    private readonly ĪnflexorIncertus<Hoc> Relātus { get; }
    private readonly string Suffixum { get; }
    protected ĪnflexorSuffixus(in Ēnumerātiōnēs.Catēgoria catēgoria,
                               in Lazy<Nūntius<ĪnflexorSuffixus>> nūntius, in Lazy<ĪnflexorIncertus> relātus,
                               in string Suffixum = string.Empty, in params IEnumerable<Enum[]> illa)
                                                   : base(catēgoria, nūntius, illa)
    {
      Relātus = relātus.Value;
      Suffixum = suffixum;
    }

    public virtual string Scrībam(in Enum[] illa)
    {
      const string? relātum = await Relātus.ScrībamAsync(illa);
      return string.IsNullOrWhitespace(relātum)
                   .Choose(string.Empty, relātum.Concat(Suffixum));
    }
  }
}
