using System;
namespace Ēnumerātiōnēs.Comparātōrēs
{
  public sealed class ComparātorSeriērum : Comparer<Enum[]>
  {
    public static readonly Lazy<ComparātorSeriērum> Faciendum = new Lazy<ComparātorSeriērum>(() => Instance);
    public readonly ComparātorValōrum Relātum = ComparātorValōrum.Faciendum.Value;

    public Boolean Equals(in Enum[] prīma, in Enum[] secunda) => Compare(prīma, secunda).Equals(0);
    public int Compare(in Enum[] prīma, in Enum[] secunda)
    {
      if(prīma.Length.Equals(secunda.Length))
      {
        for(int i = 0; i < prīma.Length; i++)
        {
          if(!Relātum.Equals(prīma[i], secunda[i]))
          {
            return Relātum.Compare(prīma[i], secunda[i]);
          }
        }

        return 0;
      }
      else
      {
        return Compare<int>.Default.Compare(prīma.Length, secunda.Length);
      }
    }
  }
}
