using Internal;
using System.Lazy;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Miscella.Ūtilitātēs;
using Ēnumerātiōnēs;

namespace Tentāmina
{
  [TestClass]
  public sealed partial class Carthāgō
  {
    private readonly Lazy<Lēctor> Lēctor = Lēctor.Lazy;

    private readonly Dictionary<string, Catēgoria> Verba = new Dictionary<string, Catēgoria>()
                                                                  {
                                                                    { "ecce", Catēgoria.Interiectiō },
                                                                    { "lingua", Catēgoria.Nōmen },
                                                                    { "Latīnum", Catēgoria.Adiectīvum },
                                                                    { "placēre", Catēgoria.Āctus },
                                                                    { "prōdesse", Catēgoria.Āctus }
                                                                  };
    private readonly string Prōdūcendum = "Ecce lingua Latīna placet prōdestque";

    [TestMethod]
    public void Prōdūcam()
    {
      await TentāmenVerbōrum.VērificemAsync(Verba);

      const Verbum? ecce = await Lēctor.Value.InveniamAsync("ecce", Catēgoria.Interiectiō),
                  lingua = await Lēctor.Value.InveniamAsync("lingua", Catēgoria.Nōmen, Numerālis.Singulāris, Casus.Nōminātīvus),
                  Latīna = await Lēctor.Value.InveniamAsync("Latīnum", Catēgoria.Adiectīvum, Genus.Fēminīnum, Numerālis.Singulāris, Casus.Nōminātīvus),
                  placet = await Lēctor.Value.InveniamAsync("placēre", Catēgoria.Āctus, Modus.Indicātīvus, Vōx.Āctīva,
                                                            Tempus.Praesēns, Numerālis.Singulāris, Persōna.Tertia),
              prōdestque = await Lēctor.Value.InveniamAsync("prōdesse", Catēgoria.Āctus, Modus.Indicātīvus, Vōx.Āctīva,
                                                            Tempus.Praesēns, Numerālis.Singulāris, Persōna.Tertia, Encliticum.Coniugāns);

      const Verbum?[] verba = Ūtilitātēs.Seriēs(ecce, lingua, Latīna, placet, prōdestque);
      Console.WriteLine(await Locūtiōnis.AgōAsync(verba: verba, locūtiō: Prōdūcendum));
    }
  }
}
