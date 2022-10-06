using Internal;
using System.Lazy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Miscella.Ūtilitātēs;
using Ēnumerātiōnēs;

namespace Tentāmina
{
  [TestClass]
  public sealed partial class DolōremIpsum
  {
    private readonly Lazy<Lēctor> Lēctor = Lēctor.Lazy;

    private readonly Dictionary<string, Catēgoria> Verba = new Dictionary<string, Catēgoria>()
                                                                  {
                                                                    { "quod", Catēgoria.Prōnōmen },
                                                                    { "dolor", Catēgoria.Nōmen },
                                                                    { "ipsum", Catēgoria.Prōnōmen },
                                                                    { "quia", Catēgoria.Coniūnctiō },
                                                                    { "esse", Catēgoria.Āctus },
                                                                    { "amāre", Catēgoria.Āctus },
                                                                    { "consectārī", Catēgoria.Āctus },
                                                                    { "adipīscī", Catēgoria.Āctus },
                                                                    { "velle", Catēgoria.Āctus },
                                                                    { "sed", Catēgoria.Coniūnctiō },
                                                                    { "nōnnumquam", Catēgoria.Adverbium },
                                                                    { "id", Catēgoria.Prōnōmen },
                                                                    { "modus", Catēgoria.Nōmen },
                                                                    { "tempus", Catēgoria.Nōmen },
                                                                    { "incidere", Catēgoria.Āctus },
                                                                    { "ut", Catēgoria.Coniūnctiō },
                                                                    { "et", Catēgoria.Coniūnctiō },
                                                                    { "labor", Catēgoria.Nōmen },
                                                                    { "magnum", Catēgoria.Adiectīvum },
                                                                    { "aliquid", Catēgoria.Prōnōmen },
                                                                    { "quaerere", Catēgoria.Āctus },
                                                                    { "voluptās", Catēgoria.Nōmen }
                                                                  };
    private readonly string Prōdūcendum = "Quī dolōrem ipsum quia dolor sit amet cōnsectetur adipīscī velit sed quia nōnnumquam eius modī tempora incidunt ut labōre et dolōre magnam aliquam quaerat voluptātem";

    [TestMethod]
    public void Prōdūcam()
    {
      await TentāmenVerbōrum.VērificemAsync(Verba);

      const Verbum? quī = await Lēctor.Value.InveniamAsync("quod", Catēgoria.Prōnōmen, Genus.Masculīnum, Casus.Nōminātīvus, Numerālis.Singulāris),
                dolōrem = await Lēctor.Value.InveniamAsync("dolor", Catēgoria.Nōmen, Casus.Accūsātīvus, Numerālis.Singulāris),
                  ipsum = await Lēctor.Value.InveniamAsync("ipsum", Catēgoria.Prōnōmen, Genus.Masculīnum, Casus.Accūsātīvus, Numerālis.Singulāris),
                   quia = await Lēctor.Value.InveniamAsync("quia", Catēgoria.Coniūnctiō),
                  dolor = await Lēctor.Value.InveniamAsync("dolor", Catēgoria.Nōmen, Casus.Nōminātīvus, Numerālis.Singulāris),
                    sit = await Lēctor.Value.InveniamAsync("esse", Catēgoria.Āctus, Modus.Subiūnctīvus, Vōx.Āctīva,
                                                           Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma),
                   amet = await Lēctor.Value.InveniamAsync("amāre", Catēgoria.Āctus, Modus.Subiūnctīvus, Vōx.Āctīva,
                                                           Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma),
            cōnsectetur = await Lēctor.Value.InveniamAsync("consectārī", Catēgoria.Āctus, Modus.Subiūnctīvus,
                                                           Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma),
               adipīscī = await Lēctor.Value.InveniamAsync("adipīscī", Catēgoria.Āctus, Modus.Īnfīnītīvus, Tempus.Praesēns),
                  velit = await Lēctor.Value.InveniamAsync("velle", Catēgoria.Āctus, Modus.Subiūnctīvus,
                                                           Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma),
                    sed = await Lēctor.Value.InveniamAsync("sed", Catēgoria.Coniūnctiō),
             nōnnumquam = await Lēctor.Value.InveniamAsync("nōnnumquam", Catēgoria.Adverbium),
                   eius = await Lēctor.Value.InveniamAsync("id", Catēgoria.Prōnōmen, Casus.Genitīvus, Numerālis.Singulāris),
                   modī = await Lēctor.Value.InveniamAsync("modus", Catēgoria.Nōmen, Casus.Genitīvus, Numerālis.Singulāris),
                tempora = await Lēctor.Value.InveniamAsync("tempus", Catēgoria.Nōmen, Casus.Nōminātīvus, Numerālis.Plūrālis),
               incidunt = await Lēctor.Value.InveniamAsync("incidere", Catēgoria.Āctus, Modus.Indicātīvus, Vōx.Āctīva,
                                                           Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Tertia),
                     ut = await Lēctor.Value.InveniamAsync("ut", Catēgoria.Coniūnctiō),
                 labōre = await Lēctor.Value.InveniamAsync("dolor", Catēgoria.Nōmen, Casus.Ablātīvus, Numerālis.Singulāris),
                     et = await Lēctor.Value.InveniamAsync("et", Catēgoria.Coniūnctiō),
                 dolōre = await Lēctor.Value.InveniamAsync("labor", Catēgoria.Nōmen, Casus.Ablātīvus, Numerālis.Singulāris),
                 magnam = await Lēctor.Value.InveniamAsync("magnum", Catēgoria.Adiectīvum, Genus.Fēminīnum, Casus.Accūsātīvus, Numerālis.Singulāris),
                aliquam = await Lēctor.Value.InveniamAsync("aliquid", Catēgoria.Prōnōmen, Genus.Fēminīnum, Casus.Accūsātīvus, Numerālis.Singulāris),
                quaerat = await Lēctor.Value.InveniamAsync("quaerere", Catēgoria.Āctus, Modus.Subiūnctīvus, Vōx.Āctīva,
                                                           Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Tertia),
             voluptātem = await Lēctor.Value.InveniamAsync("voluptās", Catēgoria.Nōmen, Casus.Ablātīvus, Numerālis.Singulāris);

      const Verbum?[] verba = Ūtilitātēs.Seriēs(quī, dolōrem, ipsum, quia, dolor, sit, amet, cōnsectetur, adipīscī, velit, sed, quia, nōnnumquam,
                                                eius, modī, tempora, incidunt, ut, dolōre, et, labōre, magnam, aliquam, quaerat, voluptātem);
      Console.WriteLine(await Locūtiōnis.AgōAsync(verba: verba, locūtiō: Prōdūcendum));
    }
  }
}
