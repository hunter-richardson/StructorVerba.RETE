using System;
using System.Collections.Generic.Dictionary;

using Nūntiī.Nūntius;
using Praebeunda;

namespace Pēnsōrēs.Nōmina
{
  public sealed class PēnsorNōminibus : PēnsorNōminibus<Īnflectendum.Nōmen>
  {
    public enum Versiō
    {
      Nōmen_Prīmum, Nōmen_Prīmum_Singulāris, Nōmen_Prīmum_Plūrālis,
      Nōmen_Secundum_Masculīnum, Nōmen_Secundum_Masculīnum_Singulāris, Nōmen_Secundum_Neutrum,
      Nōmen_Secundum_Varium_Cum_Litterā_E, Nōmen_Secundum_Varium_Sine_Litterā_E,
      Nōmen_Tertium, Nōmen_Tertium_Singulāris, Nōmen_Tertium_Neutrum, Nōmen_Tertium_Cum_Genitīvō_Variō,
      Nōmen_Tertium_Cum_Ablātīvō_Variō, Nōmen_Tertium_Cum_Genitīvō_Ablātīvōque_Variō,
      Nōmen_Tertium_Neutrum_Cum_Genitīvō_Variō, Nōmen_Tertium_Neutrum_Cum_Ablātīvō_Variō,
      Nōmen_Tertium_Neutrum_Cum_Genitīvō_Ablātīvōque_Variō,
      Nōmen_Quārtum, Nōmen_Quārtum_Varium, Nōmen_Quīntum
    }

    public static sealed class Versiōnēs
    {
      public static string ToString(this in Versiō valor) => Enum.GetName<Versiō>(valor).ToLower();
    }

    private static Dictionary<Versio, Lazy<PēnsorNōminibus>> Reservātī = new Dictionary<Versio, Lazy<PēnsorNōminibus>>();

    public static Func<Versio, Lazy<PēnsorNōminibus>> Relātor = valor =>
    {
      if (Reservātī.ContainsKey(valor))
      {
        return Reservātī.Item[valor];
      }
      else
      {
        const Lazy<PēnsorNōminibus> hoc = new Lazy(() => new PēnsorNōminibus(valor));
        Reservātī.Add(valor, hoc);
        return hoc;
      }
    };

    private PēnsorNōminibus(in Versiō versiō)
                               : base(versiō: versiō, quaerendī: nameof(Īnflectendum.Nōmen.Nōminātīvum),
                                      tabula: Tabula.Nōmina, nūntius: new Lazy<Nūntius<PēnsorNōminibus>>(),
                                      lēctor: Īnflectendum.Nōmen.Lēctor)
          => Nūntius.PlūsGarriōAsync("Fīō");
  }
}
