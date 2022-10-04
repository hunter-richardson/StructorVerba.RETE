using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;
using Pēnsōrēs.Pēnsor.Tabula;

namespace Pēnsōrēs.Numerāmina
{
  public abstract class PēnsorNumerāminibus : PēnsorĪnflectendīs<Īnflectendum.Numerāmen, Multiplex.Numerāmen>
  {
    public enum Versiō
    {
      Cardinālium_Solōrum, Cardinālium_Ōrdināliumque, Cardinālium_Et_Ōrdinālium_Et_Adverbiōrum,
      Cardinālium_Et_Ōrdinālium_Et_Distribūtīvōrum, Cardinālium_Et_Ōrdinālium_Et_Adverbiōrum_Et_Distribūtīvōrum,
      Omnium_Praeter_Multiplicātīva, Omnium_Praeter_Frāctiōnēs, Omnium
    }

    public static sealed class Versiōnēs
    {
      public static string ToString(this in Versiō valor) => Enum.GetName<Versiō>(valor).ToLower();
    }

    private static Dictionary<Versiō, Lazy<PēnsorNumerāminibus>> Reservātī = new Dictionary<Versiō, Lazy<PēnsorNumerāminibus>>();

    public static Func<Versiō, Lazy<PēnsorNumerāminibus>> Relātor = valor =>
    {
      if (Reservātī.ContainsKey(valor))
      {
        return Reservātī.Item[valor];
      }
      else
      {
        const Lazy<PēnsorNumerāminibus> hoc = new Lazy(() => new PēnsorNumerāminibus(valor));
        Reservātī.Add(valor, hoc);
        return hoc;
      }
    };

    protected PēnsorNumerāminibus(in Versiō versiō)
                                     : base(versiō: versiō, quaerendī: nameof(Īnflectendum.Numerāmen.Numerus),
                                            tabula: Tabula.Numerāmina, nūntius: new Lazy<Nūntius<PēnsorNumerāminibus>>(),
                                            lēctor: Īnflectendum.Numerāmen.Lēctor) { }
  }
}
