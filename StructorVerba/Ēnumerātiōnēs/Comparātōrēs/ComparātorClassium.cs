using System.Globalization;
using System;
using System.Type;
using System.Collections.Generic.Comparer;

using Miscella.Ūtilitātēs;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Ēnumerātiōnēs.Comparātōrēs
{
  [Singleton]
  public sealed partial class ComparātorClassium : Comparer<Type>
  {
    public static readonly Lazy<ComparātorClassium> Faciendum = new Lazy<ComparātorClassium>(() => Instance);

    public Boolean Equals(in Type prīma, in Type secunda) => Compare(prīma, secunda).Equals(0);
    public int Compare(in Type prīma, in Type secunda)
          => new StringComparer(StringComparer.InvariantCulture, false)
                    .Compare(prīma.FullName, secunda.FullName);
  }
}
