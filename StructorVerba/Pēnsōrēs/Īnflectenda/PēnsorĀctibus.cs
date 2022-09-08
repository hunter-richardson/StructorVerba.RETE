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
      Secundus_Impersōnālis, Tertius_Impersōnālis,
      Prīmus_Impersōnālis_Semidēpōnēns, Secundus_Impersōnālis_Semidēpōnēns, Tertius_Impersōnālis_Semidēpōnēns,
      Prīmus_Impersōnālis_Semidēpōnēns_Imperfectus,
      Secundus_Impersōnālis_Semidēpōnēns_Imperfectus,
      Tertius_Impersōnālis_Semidēpōnēns_Imperfectus,
      Secundus_Impersōnālis_Perfectō, Tertius_Impersōnālis_Perfectō,
      Tertius_Perfectus, Quārtus_Perfectus
    }

    public static sealed class Versiōnēs
    {
      public static string ToString(this in Versiō valor) => Enum.GetName<Versiō>(valor).ToLower();
    }

    private static Dictionary<Versio, Lazy<PēnsorĀctibus>> Reservātī = new Dictionary<Versio, Lazy<PēnsorĀctibus>>();

    public static Func<Versio, Lazy<PēnsorĀctibus>> Faciendum = valor =>
    {
      if (Reservātī.ContainsKey(valor))
      {
        return Reservātī.Item[valor];
      }
      else
      {
        const Lazy<PēnsorĀctibus> hoc = new Lazy(() => new PēnsorĀctibus(valor));
        Reservātī.Add(valor, hoc);
        return hoc;
      }
    };

    private PēnsorĀctibus(in Versiō versiō)
                             : base(versiō, nameof(Īnflectendum.Āctus.Īnfīnītīvum), Tabula.Āctūs,
                                    new Lazy<Nūntius<PēnsorĀctibus>>(),
                                    Īnflectendum.Āctus.Lēctor) { }
  }
}
