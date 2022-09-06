using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;
using Pēnsōrēs.Pēnsor.Tabula;

namespace Pēnsōrēs.Īnflectenda
{
  public abstract class PēnsorAdiectīvīs : PēnsorĪnflectendīs<Īnflectendum.AdiectīvumAutPrīmumAutSecundumAutTertium, Multiplex.Adiectīvum>
  {
    public enum Versiō
    {
      Aut_Prīmus_Aut_Secundus_Aut_Tertius, Aut_Prīmus_Aut_Secundus_Aut_Tertius_Cum_Litterā_Ē,
      Aut_Prīmus_Aut_Secundus_Aut_Tertius_Sine_Litterā_Ē, Aut_Tertius_Aut_Prīmus_Aut_Secundus,
      Aut_Tertius_Aut_Prīmus_Aut_Secundus_Cum_Genitīvō_Variō, Aut_Tertius_Aut_Prīmus_Aut_Secundus_Cum_Ablātīvō_Variō,
      Aut_Tertius_Aut_Prīmus_Aut_Secundus_Cum_Genitīvō_Ablātīvōque_Variō, Prōnōminālis, Prōnōminālis_Cum_Litterā_Ē, Prōnōminālis_Sine_Litterā_Ē,
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

    private static Dictionary<Versio, PēnsorAdiectīvīs> Reservātī = new Dictionary<Versio, PēnsorAdiectīvīs>();

    public static Func<Versio, PēnsorAdiectīvīs> Faciendum = valor =>
    {
      if (Reservātī.ContainsKey(valor))
      {
        return Reservātī.Item[valor];
      }
      else
      {
        const PēnsorAdiectīvīs hoc = new PēnsorAdiectīvīs(valor);
        Reservātī.Add(valor, hoc);
        return hoc;
      }
    };

    private static readonly Func<Versiō, Tabula?> Tabulātor =
              versiō => versiō switch
                        {
                          Versiō.Aut_Tertius_Aut_Prīmus_Aut_Secundus or
                          Versiō.Aut_Tertius_Aut_Prīmus_Aut_Secundus_Cum_Genitīvō_Variō or
                          Versiō.Aut_Tertius_Aut_Prīmus_Aut_Secundus_Cum_Ablātīvō_Variō or
                          Versiō.Aut_Tertius_Aut_Prīmus_Aut_Secundus_Cum_Genitīvō_Ablātīvōque_Variō or
                          Versiō.Incomparābilis_Aut_Tertius_Cum_Genitīvō_Variō or
                          Versiō.Incomparābilis_Aut_Tertius_Cum_Ablātīvō_Variō or
                          Versiō.Incomparābilis_Aut_Tertius_Cum_Genitīvō_Ablātīvōque_Variō
                                    => Tabula.Adiectīva_Aut_Tertia_Aut_Prīma_Aut_Secunda,
                          Versiō.Aut_Prīmus_Aut_Secundus_Aut_Tertius or
                          Versiō.Aut_Prīmus_Aut_Secundus_Aut_Tertius_Cum_Litterā_E or
                          Versiō.Aut_Prīmus_Aut_Secundus_Aut_Tertius_Sine_Litterā_E or
                          Versiō.Prōnōminālis or
                          Versiō.Prōnōminālis_Cum_Litterā_Ē or
                          Versiō.Prōnōminālis_Sine_Litterā_Ē or
                          Versiō.Incomparābilis_Aut_Prīmus_Aut_Secundus or
                          Versiō.Incomparābilis_Plūrālis_Aut_Prīmus_Aut_Secundus or
                          Versiō.Incomparābilis_Aut_Prīmus_Aut_Secundus_Cum_Litterā_Ē or
                          Versiō.Incomparābilis_Aut_Prīmus_Aut_Secundus_Sine_Litterā_Ē or
                          Versiō.Incomparābilis_Prōnōminālis or
                          Versiō.Incomparābilis_Prōnōminālis_Cum_Litterā_Ē or
                          Versiō.Incomparābilis_Prōnōminālis_Sine_Litterā_Ē
                                    => Tabula.Adiectīva_Aut_Prīma_Aut_Secunda_Aut_Tertia,
                          _ => null
                        };

    protected PēnsorAdiectīvīs(in Versiō versiō)
                                  : base(versiō, nameof(Īnflectendum.AdiectīvumAutPrīmumAutSecundumAutTertium.Positīvum),
                                         Tabulātor.Invoke(versiō), NūntiusPēnsōrīAdiectīvīs.Faciendum,
                                         Īnflectendum.AdiectīvumAutPrīmumAutSecundumAutTertium.Lēctor) { }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīAdiectīvīs : Nūntius<PēnsorAdiectīvīs>
    {
      public static readonly Lazy<NūntiusPēnsōrīAAdiectīvīs> Faciendum = new Lazy<NūntiusPēnsōrīAdiectīvīs>(() => Instance);
    }
  }
}
