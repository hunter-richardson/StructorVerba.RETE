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
      Āctus_Prīmus, Āctus_Prīmus_Varius, Āctus_Secundus, Āctus_Quārtus,
      Āctus_Tertius, Āctus_Tertius_Varius, Āctus_Tertius_Cum_Imperātīvō_Brevī,
      Āctus_Prīmus_Dēpōnēns, Āctus_Secundus_Dēpōnēns, Āctus_Tertius_Dēpōnēns, Āctus_Quārtus_Dēpōnēns,
      Āctus_Prīmus_Semidēpōnēns, Āctus_Secundus_Semidēpōnēns, Āctus_Tertius_Semidēpōnēns,
      Āctus_Secundus_Impersōnālis, Āctus_Tertius_Impersōnālis,
      Āctus_Prīmus_Impersōnālis_Semidēpōnēns, Āctus_Secundus_Impersōnālis_Semidēpōnēns,
      Āctus_Tertius_Impersōnālis_Semidēpōnēns,
      Āctus_Prīmus_Impersōnālis_Semidēpōnēns_Imperfectus,
      Āctus_Secundus_Impersōnālis_Semidēpōnēns_Imperfectus,
      Āctus_Tertius_Impersōnālis_Semidēpōnēns_Imperfectus,
      Āctus_Secundus_Impersōnālis_Perfectō, Āctus_Tertius_Impersōnālis_Perfectō
    }

    public static sealed class Versiōnēs
    {
      public static string ToString(this in Versiō valor) => Enum.GetName<Versiō>(valor).ToLower();
    }

    private static Dictionary<Versio, Lazy<PēnsorĀctibus>> Reservātī = new Dictionary<Versio, Lazy<PēnsorĀctibus>>();

    public static Func<Versio, Lazy<PēnsorĀctibus>> Relātor = valor =>
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
                             : base(versiō: versiō, quaerendī: nameof(Īnflectendum.Āctus.Īnfīnītīvum),
                                    tabula: Tabula.Āctūs, nūntius: new Lazy<Nūntius<PēnsorĀctibus>>(),
                                    lēctor: Īnflectendum.Āctus.Lēctor)
          => Nūntius.PlūsGarriōAsync("Fīō");
  }
}
