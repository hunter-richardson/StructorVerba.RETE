using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;

namespace Pēnsōrēs.Adverbiīs
{
  public sealed class PēnsorAdverbiīsIncomparātīvīs : PēnsorĪnflectendīs<Īnflectendum.AdverbiumIncomparātīvum, Multiplex.Adverbium>
  {
    private static Dictionary<Enum, PēnsorAdverbiīsIncomparātīvīs> Reservātī = new Dictionary<Enum, PēnsorAdverbiīsIncomparātīvīs>();

    public static Func<Enum, PēnsorAdverbiīsIncomparātīvīs> Faciendum = valor =>
    {
      if (Reservātī.ContainsKey(valor))
      {
        return Reservātī.Item[valor];
      }
      else
      {
        const PēnsorAdverbiīsIncomparātīvīs hoc = new PēnsorAdverbiīsIncomparātīvīs(valor);
        Reservātī.Add(valor, hoc);
        return hoc;
      }
    };

    private PēnsorAdverbiīsIncomparātīvīs(in Enum versiō)
                                           : base(versiō, Ēnumerātiōnēs.Catēgoria.Adverbium,
                                                  NūntiusPēnsōrīAdverbiīsIncomparātīvīs.Faciendum,
                                                  nameof(Īnflectendum.AdverbiumIncomparātīvum.Scrīptum),
                                                  Īnflectendum.AdverbiumIncomparātīvum.Lēctor) {  }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīAdverbiīsIncomparātīvīs : Nūntius<PēnsorAdverbiīsIncomparātīvīs>
    {
      public static readonly Lazy<NūntiusPēnsōrīAdverbiīsIncomparātīvīs> Faciendum = new Lazy<NūntiusPēnsōrīAdverbiīsIncomparātīvīs>(() => Instance);
    }
  }
}
