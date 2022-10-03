using System;
using System.Collections.Generic.Dictionary;

using Praebeunda.Īnflectendum;

namespace Pēnsōrēs.Nōmina
{
  public sealed class PēnsorNōminibusFactīs : PēnsorNōminibus<Īnflectendum.NōmenFactum>
  {
    public enum Versiō
    {
      Nōmen_Factum_Prīmum = PēnsorĀctibus.Versiō.Prīmus,
      Nōmen_Factum_Secundum = PēnsorĀctibus.Versiō.Secundus,
      Nōmen_Factum_Tertium = PēnsorĀctibus.Versiō.Tertius,
      Nōmen_Factum_Tertium_Varium = PēnsorĀctibus.Versiō.Tertius_Varius,
      Nōmen_Factum_Quārtum = PēnsorĀctibus.Versiō.Quārtus,
      Nōmen_Factum_Prīmum_Prōnum,
      Nōmen_Factum_Secundum_Prōnum,
      Nōmen_Factum_Tertium_Prōnum,
      Nōmen_Factum_Tertium_Varium_Prōnum,
      Nōmen_Factum_Quārtum_Prōnum
    }

    public static sealed class Versiōnēs
    {
      public static string ToString(this in Versiō valor) => Enum.GetName<Versiō>(valor).ToLower();
    }

    private static Dictionary<Versio, Lazy<PēnsorNōminibusFactīs>> Reservātī = new Dictionary<Versio, Lazy<PēnsorNōminibusFactīs>>();

    public static Func<Versio, Lazy<PēnsorNōminibusFactīs>> Relātor = valor =>
    {
      if (Reservātī.ContainsKey(valor))
      {
        return Reservātī.Item[valor];
      }
      else
      {
        const PēnsorNōminibusFactīs hoc = new Lazy(() => new PēnsorNōminibusFactīs(valor));
        Reservātī.Add(valor, hoc);
        return hoc;
      }
    };

    private PēnsorNōminibusFactīs(in Versiō versiō)
                                     : base(versiō: versiō, quaerendī: nameof(Īnflectendum.NōmenFactum.Īnfīnītīvum),
                                            tabula: Tabula.Nōmina_Facta, nūntius: new Lazy<Nūntius<PēnsorNōminibusFactīs>>(),
                                            lēctor: Īnflectendum.NōmenFactum.Lēctor)
          => Nūntius.PlūsGarriōAsync("Fīō");
  }
}
