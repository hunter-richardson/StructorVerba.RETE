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
      Aut_Tertius_Aut_Prīmus_Aut_Secundus_Cum_Genitīvō_Ablātīvōque_Variō, Prōnōminālis, Prōnōminālis_Varius,
      Incomparābilis_Aut_Prīmus_Aut_Secundus, Incomparābilis_Plūrālis_Aut_Prīmus_Aut_Secundus,
      Incomparābilis_Aut_Prīmus_Aut_Secundus_Cum_Litterā_Ē, Incomparābilis_Aut_Prīmus_Aut_Secundus_Sine_Litterā_Ē,
      Incomparābilis_Aut_Tertius_Cum_Genitīvō_Variō, Incomparābilis_Aut_Tertius_Cum_Ablātīvō_Variō,
      Incomparābilis_Aut_Tertius_Cum_Genitīvō_Ablātīvōque_Variō,
      Incomparābilis_Prōnōminālis, Incomparābilis_Prōnōminālis_Varius
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
              Versiō.Aut_Prīma_Aut_Secunda_Aut_Tertia or
              Versiō.Aut_Prīma_Aut_Secunda_Aut_Tertia_Cum_Litterā_E or
              Versiō.Aut_Prīma_Aut_Secunda_Aut_Tertia_Sine_Litterā_E or
              Versiō.Prōnōminālis or
              Versiō.Prōnōminālis_Varius
                        => Tabula.Adiectīva_Aut_Prīma_Aut_Secunda_Aut_Tertia,
              Versiō.Aut_Tertia_Aut_Prīma_Aut_Secunda or
              Versiō.Aut_Tertia_Aut_Prīma_Aut_Secunda_Cum_Genitīvō_Variō or
              Versiō.Aut_Tertia_Aut_Prīma_Aut_Secunda_Cum_Ablātīvō_Variō or
              Versiō.Aut_Tertia_Aut_Prīma_Aut_Secunda_Cum_Genitīvō_Ablātīvōque_Variō
                        => Tabula.Adiectīva_Aut_Tertia_Aut_Prīma_Aut_Secunda,
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
