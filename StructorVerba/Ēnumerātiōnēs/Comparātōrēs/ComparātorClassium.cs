using System;
using System.Collections.Generic.Comparer;

using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Ēnumerātiōnēs.Comparātōrēs
{
  [Lazy]
  public sealed partial class ComparātorClassium : Comparer<Type>
  {
    public Boolean Equals(in Type prīma, in Type secunda) => Compare(prīma, secunda).Equals(0);
    public int Compare(in Type prīma, in Type secunda)
          => new StringComparer(StringComparer.InvariantCulture, false)
                    .Compare(prīma.FullName, secunda.FullName);
  }
}
