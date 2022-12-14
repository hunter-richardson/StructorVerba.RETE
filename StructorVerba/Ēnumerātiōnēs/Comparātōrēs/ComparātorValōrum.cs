using System;
using System.Collections.Generic.Comparer;

using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Ēnumerātiōnēs.Comparātōrēs
{
  [Lazy]
  public sealed partial class ComparātorValōrum : Comparer<Enum>
  {
    public readonly ComparātorClassium Relātum = ComparātorClassium.Lazy.Value;

    public Boolean Equals(in Type prīma, in Type secunda) => Compare(prīma, secunda).Equals(0);
    public int Compare(in Enum prīma, in Enum secunda)
          => Relātum.Equals(prīma.GetType(), secunda.GetType())
                          .Choose(Comparer<Enum>.Default.Compare(prīma, secunda),
                                  Relātum.Equals(prīma.GetType(), secunda.GetType()));
  }
}
