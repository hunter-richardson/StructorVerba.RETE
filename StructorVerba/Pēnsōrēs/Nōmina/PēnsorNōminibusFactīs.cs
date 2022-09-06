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
      Nōmen_Factum_Quārtum = PēnsorĀctibus.Versiō.Quārtus,
      Nōmen_Factum_Prīmum_Prōnum,
      Nōmen_Factum_Secundum_Prōnum,
      Nōmen_Factum_Tertium_Prōnum,
      Nōmen_Factum_Quārtum_Prōnum
    }

    public static sealed class Versiōnēs
    {
      public static string ToString(this in Versiō valor) => Enum.GetName<Versiō>(valor).ToLower();
    }

    private static Dictionary<Versio, Lazy<PēnsorNōminibusFactīs>> Reservātī = new Dictionary<Versio, Lazy<PēnsorNōminibusFactīs>>();

    public static Func<Versio, Lazy<PēnsorNōminibusFactīs>> Faciendum = valor =>
    {
      if (Reservātī.ContainsKey(valor))
      {
        return Reservātī.Item[valor];
      }
      else
      {
        const PēnsorNōminibusFactīs hoc = new Lazy<PēnsorNōminibusFactīs>(() => new PēnsorNōminibusFactīs(valor));
        Reservātī.Add(valor, hoc);
        return hoc;
      }
    };

    private PēnsorNōminibusFactīs(in Versiō versiō)
                                     : base(versiō, nameof(Īnflectendum.NōmenFactum.Īnfīnītīvum),
                                            Tabula.Nōmina_Facta, NūntiusPēnsōrīNōminibusFactīs.Faciendum,
                                            Īnflectendum.NōmenFactum.Lēctor) {  }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīNōminibusFactīs : Nūntius<PēnsorNōminibusFactīs>
    {
      public static readonly Lazy<NūntiusPēnsōrīNōminibusFactīs> Faciendum = new Lazy<NūntiusPēnsōrīNōminibusFactīs>(() => Instance);
    }
  }
}
