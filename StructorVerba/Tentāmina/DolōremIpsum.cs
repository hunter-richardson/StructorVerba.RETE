using Internal;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Miscella;
using Ēnumerātiōnēs;

namespace Tentāmina
{
  [TestClass]
  public sealed partial class DolōremIpsum
  {
    private readonly Lazy<Lēctor> Lēctor = Lēctor.Faciendum;

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
    private readonly string Prōdūcendum = "Quī dolōrem ipsum quia dolor sit amet cōnsectetur adipīscī velit sed quia nōnnumquam eius modī tempora incidunt ut labōre et dolōre magnam aliquam quaerat voluptatem";

    [TestMethod]
    public void Prōdūcam()
    {
      await TentāmenVerbōrum.VērificemAsync(Verba);

      const Verbum?[] verba = Ūtilitātēs.Seriēs(await Lēctor.Value.InveniamAsync("quod", Catēgoria.Prōnōmen, Genus.Masculīnum, Casus.Nōminātīvus, Numerālis.Singulāris),
                                                await Lēctor.Value.InveniamAsync("dolor", Catēgoria.Nōmen, Casus.Accūsātīvus, Numerālis.Singulāris),
                                                await Lēctor.Value.InveniamAsync("ipsum", Catēgoria.Prōnōmen, Genus.Masculīnum, Casus.Accūsātīvus, Numerālis.Singulāris),
                                                await Lēctor.Value.InveniamAsync("quia", Catēgoria.Coniūnctiō),
                                                await Lēctor.Value.InveniamAsync("dolor", Catēgoria.Nōmen, Casus.Nōminātīvus, Numerālis.Singulāris),
                                                await Lēctor.Value.InveniamAsync("esse", Catēgoria.Āctus, Modus.Subiūnctīvus, Vōx.Āctīva,
                                                                                 Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma),
                                                await Lēctor.Value.InveniamAsync("amāre", Catēgoria.Āctus, Modus.Subiūnctīvus, Vōx.Āctīva,
                                                                                 Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma),
                                                await Lēctor.Value.InveniamAsync("consectārī", Catēgoria.Āctus, Modus.Subiūnctīvus,
                                                                                 Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma),
                                                await Lēctor.Value.InveniamAsync("adipīscī", Catēgoria.Āctus, Modus.Īnfīnītīvus, Tempus.Praesēns),
                                                await Lēctor.Value.InveniamAsync("velle", Catēgoria.Āctus, Modus.Subiūnctīvus,
                                                                                 Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma),
                                                await Lēctor.Value.InveniamAsync("sed", Catēgoria.Coniūnctiō),
                                                await Lēctor.Value.InveniamAsync("quia", Catēgoria.Coniūnctiō),
                                                await Lēctor.Value.InveniamAsync("nōnnumquam", Catēgoria.Adverbium),
                                                await Lēctor.Value.InveniamAsync("id", Catēgoria.Prōnōmen, Casus.Genitīvus, Numerālis.Singulāris),
                                                await Lēctor.Value.InveniamAsync("modus", Catēgoria.Nōmen, Casus.Genitīvus, Numerālis.Singulāris),
                                                await Lēctor.Value.InveniamAsync("tempus", Catēgoria.Nōmen, Casus.Nōminātīvus, Numerālis.Plūrālis),
                                                await Lēctor.Value.InveniamAsync("incidere", Catēgoria.Āctus, Modus.Indicātīvus, Vōx.Āctīva,
                                                                                 Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Tertia),
                                                await Lēctor.Value.InveniamAsync("ut", Catēgoria.Coniūnctiō),
                                                await Lēctor.Value.InveniamAsync("dolor", Catēgoria.Nōmen, Casus.Ablātīvus, Numerālis.Singulāris),
                                                await Lēctor.Value.InveniamAsync("et", Catēgoria.Coniūnctiō),
                                                await Lēctor.Value.InveniamAsync("labor", Catēgoria.Nōmen, Casus.Ablātīvus, Numerālis.Singulāris),
                                                await Lēctor.Value.InveniamAsync("magnum", Catēgoria.Adiectīvum, Genus.Fēminīnum, Casus.Accūsātīvus, Numerālis.Singulāris),
                                                await Lēctor.Value.InveniamAsync("aliquid", Catēgoria.Prōnōmen, Genus.Fēminīnum, Casus.Accūsātīvus, Numerālis.Singulāris),
                                                await Lēctor.Value.InveniamAsync("quaerere", Catēgoria.Āctus, Modus.Subiūnctīvus, Vōx.Āctīva,
                                                                                 Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Tertia),
                                                await Lēctor.Value.InveniamAsync("voluptās", Catēgoria.Nōmen, Casus.Ablātīvus, Numerālis.Singulāris));
      Console.WriteLine(await TentāmenVerbōrum.AgōAsync(verba: verba, locūtiō: Prōdūcendum));
    }
  }
}
