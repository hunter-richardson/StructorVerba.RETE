using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;
using Pēnsōrēs.Pēnsor.Tabula;

namespace Pēnsōrēs.Adiectīva
{
  public sealed class PēnsorAdiectīvīsIncomparābilibusTertiīs
      : PēnsorĪnflectendīs<Īnflectendum.AdiectīvumIncomparābileTertium, Multiplex.Adiectīvum>
  {
    public enum Versiō
    {
      Incomparābilis_Tertius_Cum_Genitīvō_Variō, Incomparābilis_Tertius_Cum_Ablātīvō_Variō,
      Incomparābilis_Tertius_Cum_Genitīvō_Ablātīvōque_Variō
    }

    public static sealed class Versiōnēs
    {
      public static string ToString(this in Versiō valor) => Enum.GetName<Versiō>(valor).ToLower();
    }

    private static Dictionary<Versiō, Lazy<PēnsorAdiectīvīsIncomparābilibusTertiīs>> Reservātī
             = new Dictionary<Versiō, Lazy<PēnsorAdiectīvīsIncomparābilibusTertiīs>>();

    public static Func<Versiō, Lazy<PēnsorAdiectīvīsIncomparābilibusTertiīs>> Relātor = valor =>
    {
      if (Reservātī.ContainsKey(valor))
      {
        return Reservātī.Item[valor];
      }
      else
      {
        const Lazy<PēnsorAdiectīvīsIncomparābilibusTertiīs> hoc = new Lazy(() => new PēnsorAdiectīvīsIncomparābilibusTertiīs(valor));
        Reservātī.Add(valor, hoc);
        return hoc;
      }
    };

    protected PēnsorAdiectīvīsIncomparābilibusTertiīs(in Versiō versiō)
                                                 : base(versiō: versiō,
                                                        quaerendī: Casus.Nōminātīvum.Columna(),
                                                        tabula: Tabula.Adiectīva_Incomparābilia_Tertia,
                                                        nūntius: new Lazy<Nūntius<PēnsorAdiectīvīsIncomparābilibusTertiīs>>(),
                                                        lēctor: Īnflectendum.AdiectīvumIncomparābileTertium.Lēctor)
          => Nūntius.PlūsGarriōAsync("Fīō");
  }
}
