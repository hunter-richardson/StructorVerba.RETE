using System;
using System.Enum;
using System.Collections.Generic.Comparer;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Ēnumerātiōnēs.Comparātōrēs
{
  [Singleton]
  public sealed partial class ComparātorValōrum : Comparer<Enum>
  {
    public static readonly Lazy<ComparātorValōrum> Faciendum = new Lazy<ComparātorValōrum>(() => Instance);
    public readonly ComparātorClassium Relātum = ComparātorClassium.Faciendum.Value;

    public Boolean Equals(in Type prīma, in Type secunda) => Compare(prīma, secunda).Equals(0);
    public int Compare(in Enum prīma, in Enum secunda)
          => Relātum.Equals(prīma.GetType(), secunda.GetType())
                          .Choose(Comparer<Enum>.Default.Compare(prīma, secunda),
                                  Relātum.Equals(prīma.GetType(), secunda.GetType()));
  }
}
