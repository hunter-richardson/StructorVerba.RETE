using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;

namespace Pēnsōrēs.Nōminibus
{
  public sealed class PēnsorNōminibus : PēnsorĪnflectendīs<Īnflectendum.Nōmen, Multiplex.Nōmen>
  {
    private static Dictionary<Enum, PēnsorNōminibus> Reservātī = new Dictionary<Enum, PēnsorNōminibus>();

    public static Func<Enum, PēnsorNōminibus> Faciendum = valor =>
    {
      if (Reservātī.ContainsKey(valor))
      {
        return Reservātī.Item[valor];
      }
      else
      {
        const PēnsorNōminibus hoc = new PēnsorNōminibus(valor);
        Reservātī.Add(valor, hoc);
        return hoc;
      }
    };

    private PēnsorNōminibus(in Enum versiō)
                             : base(versiō, Ēnumerātiōnēs.Catēgoria.Nōmen,
                                    NūntiusPēnsōrīNōminibus.Faciendum,
                                    nameof(Īnflectendum.Nōmen.Nominātīvum),
                                    Īnflectendum.Nōmen.Lēctor) {  }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīNōminibus : Nūntius<PēnsōrNōminibus>
    {
      public static readonly Lazy<NūntiusPēnsōrīNōminibus> Faciendum = new Lazy<NūntiusPēnsōrīNōminibus>(() => Instance);
    }
  }
}
