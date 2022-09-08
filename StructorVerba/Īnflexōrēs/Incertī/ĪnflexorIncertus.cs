using System;
using System.Collections.Generic;
using System.Threading.Tasks.Task;

using Miscella;
using Ēnumerātiōnēs.Comparātōrēs;
using Praebeunda.Multiplex;
using Nūntiī.Nūntius;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

namespace Īnflexōrēs.Incertī
{
  [AsyncOverloads]
  public abstract partial class ĪnflexorIncertus<Hoc> : Īnflexor<Hoc>
  {
    private readonly IDictionary<Enum[], string> Fōrmae = new PredicatedSortedDictionary<Enum[], string>(ComparātorSeriērum,
                                                                                                         Tabula.Contains, "Ēnumerātiō scīta'stō",
                                                                                                         string.IsNullOrWhiteSpace, "Fōrma invacua'stō");
    public readonly Func<IDictionary<Enum[], string>> Fōrmātor = () => Fōrmae.ToImmutableSortedDictionary();

    protected ĪnflexorIncertus(in Ēnumerātiōnēs.Catēgoria catēgoria,
                               in Lazy<Nūntius<ĪnflexorIncertus<Hoc>>> nūntius,
                               in params IEnumerable<Enum[]> illa)
                                                   : base(catēgoria, nūntius, illa) { }

    protected ĪnflexorIncertus(in Ēnumerātiōnēs.Catēgoria catēgoria,
                               in Lazy<Nūntius<ĪnflexorIncertus<Hoc>>> nūntius,
                               in params Enum illa)
                                                   : base(catēgoria, nūntius, illa) { }

    public sealed void Fōrmam(in string fōrma, in params Enum illa)
    {
      Array.Sort(illa, ComparātorValōrum);
      try
      {
        Fōrmae.AddAsync(illa, fōrma);
      }
      catch (ArgumentException error)
      {
        Nūntius.TerreōAsync(error);
      }
    }

    public sealed string Scrībam(in params Enum illa)
              => Ūtilitātēs.Seriēs((from linea in Fōrmae
                                    where ComparātorSeriērum.Equals(linea.Key, illa.Sort(ComparātorValōrum))
                                    select linea.Value).First(),
                                   (from linea in Fōrmae
                                    where illa.ContainsAll(linea.Key)
                                    select linea.Value).Single(),
                                   Fōrmae.Item[illa])
                            .FirstNonNull(string.Empty);
  }
}
