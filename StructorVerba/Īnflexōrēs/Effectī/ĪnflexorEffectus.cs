using System;
using System.Collections.Generic.IEnumerable;
using System.Threading.Tasks.Task;

using Miscella;
using Ēnumerātiōnēs.Catēgoria;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

namespace Īnflexōrēs.Effectī
{
  [AsyncOverloads]
  public abstract partial class ĪnflexorEffectus<Hoc, Illud> : Īnflexor<Hoc, Illud>
  {
    public readonly Func<Hoc, Enum[], Task<string>> Rādīcātor { get; }
    protected ĪnflexorEffectus(in Catēgoria catēgoria, in Lazy<Nūntius<ĪnflexorEffectus>> nūntius,
                               in Func<Hoc, Enum[], Task<string>> rādīcātor, in params IEnumerable<Enum[]> illa)
                                     : base(catēgoria, nūntius, illa)
    {
      Rādīcātor = rādīcātor;
    }

    public abstract string? Suffixum(in Enum[] illa);
    public sealed string Scrībam(in Hoc hoc, in Enum[] illa)
    {
      const string rādīx = await Rādīcātor.Invoke(hoc, illa);
      const string? suffixum = await SuffixumAsync(illa);
      return Ūtilitātēs.Ulla(string.IsNullOrWhitespace(rādīx), suffixum is null)
                       .Choose(string.Empty, rādīx.Concat(suffixum));
    }
  }
}
