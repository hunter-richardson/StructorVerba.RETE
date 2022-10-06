using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;
using Pēnsōrēs.Pēnsor.Tabula;

namespace Pēnsōrēs.Īnflectenda
{
  public sealed class PēnsorAdiectīvīs : PēnsorĪnflectendīs<Īnflectendum.Adiectīvum, Multiplex.Adiectīvum>
  {
    public enum Versiō
    {
      Aut_Prīmus_Aut_Secundus_Aut_Tertius, Aut_Prīmus_Aut_Secundus_Aut_Tertius_Cum_Litterā_Ē,
      Aut_Prīmus_Aut_Secundus_Aut_Tertius_Sine_Litterā_Ē, Aut_Tertius_Aut_Prīmus_Aut_Secundus,
      Aut_Tertius_Aut_Prīmus_Aut_Secundus_Cum_Genitīvō_Variō, Aut_Tertius_Aut_Prīmus_Aut_Secundus_Cum_Ablātīvō_Variō,
      Aut_Tertius_Aut_Prīmus_Aut_Secundus_Cum_Genitīvō_Ablātīvōque_Variō,
      Aut_Tertius_Aut_Prīmus_Aut_Secundus_Cum_Nominātīvō_Genitīvōque_Variō,
      Prōnōminālis, Prōnōminālis_Cum_Litterā_Ē, Prōnōminālis_Sine_Litterā_Ē,
      Incomparābilis_Aut_Prīmus_Aut_Secundus, Incomparābilis_Plūrālis_Aut_Prīmus_Aut_Secundus,
      Incomparābilis_Aut_Prīmus_Aut_Secundus_Cum_Litterā_Ē, Incomparābilis_Aut_Prīmus_Aut_Secundus_Sine_Litterā_Ē,
      Incomparābilis_Aut_Tertius_Cum_Genitīvō_Variō, Incomparābilis_Aut_Tertius_Cum_Ablātīvō_Variō,
      Incomparābilis_Aut_Tertius_Cum_Genitīvō_Ablātīvōque_Variō,
      Incomparābilis_Prōnōminālis, Incomparābilis_Prōnōminālis_Cum_Litterā_Ē, Incomparābilis_Prōnōminālis_Sine_Litterā_Ē
    }

    public static sealed class Versiōnēs
    {
      public static string ToString(this in Versiō valor) => Enum.GetName<Versiō>(valor).ToLower();
    }

    private static Dictionary<Versiō, Lazy<PēnsorAdiectīvīs>> Reservātī = new Dictionary<Versiō, Lazy<PēnsorAdiectīvīs>>();

    public static Func<Versiō, Lazy<PēnsorAdiectīvīs>> Relātor = valor =>
    {
      if (Reservātī.ContainsKey(valor))
      {
        return Reservātī.Item[valor];
      }
      else
      {
        const Lazy<PēnsorAdiectīvīs> hoc = new Lazy(() => new PēnsorAdiectīvīs(valor));
        Reservātī.Add(valor, hoc);
        return hoc;
      }
    };

    protected PēnsorAdiectīvīs(in Versiō versiō)
                                  : base(versiō: versiō, quaerendī: nameof(Īnflectendum.Adiectīvum.Positīvum),
                                         tabula: Tabul.Adiectīva, nūntius: new Lazy<Nūntius<PēnsorAdiectīvīs>>(),
                                         lēctor: Īnflectendum.Adiectīvum.Lēctor)
          => Nūntius.PlūsGarriōAsync("Fīō");
  }
}
