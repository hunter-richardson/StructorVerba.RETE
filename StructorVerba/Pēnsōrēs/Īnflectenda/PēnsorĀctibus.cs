using System;
using System.Collections.Generic.Dictionary;

using Praebeunda.Multiplex;
using Praebeunda.Īnflectendum;

namespace Pēnsōrēs.Īnflectenda
{
  public abstract partial class PēnsorĀctibus : Pēnsor<Īnflectendum.Āctus, Multiplex.Āctus>
  {
    public enum Versiō
    {
      Prīmus, Prīmus_Varius, Secundus, Quārtus,
      Tertius, Tertius_Varius, Tertius_Cum_Imperātīvō_Brevī,
      Prīmus_Dēpōnēns, Secundus_Dēpōnēns, Tertius_Dēpōnēns, Quārtus_Dēpōnēns,
      Prīmus_Semidēpōnēns, Secundus_Semidēpōnēns, Tertius_Semidēpōnēns,
      Secundus_Impersōnālis_Semidēpōnēns, Tertius_Impersōnālis_Semidēpōnēns,
      Prīmus_Impersōnālis_Semidēpōnēns_Imperfecta,
      Secundus_Impersōnālis_Semidēpōnēns_Imperfecta,
      Tertius_Impersōnālis_Semidēpōnēns_Imperfecta,
      Secundus_Impersōnālis_Perfectō, Tertius_Impersōnālis_Perfectō
    }

    public static sealed class Versiōnēs
    {
      public static string ToString(this in Versiō valor) => Enum.GetName<Versiō>(valor).ToLower();
    }

    private static Dictionary<Versio, PēnsorĀctibus> Reservātī = new Dictionary<Versio, PēnsorĀctibus>();

    public static Func<Versio, PēnsorĀctibus> Faciendum = valor =>
    {
      if (Reservātī.ContainsKey(valor))
      {
        return Reservātī.Item[valor];
      }
      else
      {
        const PēnsorĀctibus hoc = new PēnsorĀctibus(valor);
        Reservātī.Add(valor, hoc);
        return hoc;
      }
    };

    private PēnsorĀctibus(in Versiō versiō)
                             : base(versiō, nameof(Īnflectendum.Āctus.Īnfīnītīvum),
                                    Tabula.Āctūs, NūntiusPēnsōrīĀctibus.Faciendum, Īnflectendum.Āctus.Lēctor) { }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīĀctibus : Nūntius<PēnsorĀctibus>
    {
      public static readonly Lazy<NūntiusPēnsōrīĀctibus> Faciendum = new Lazy<NūntiusPēnsōrīĀctibus>(() => Instance);
    }
  }
}
