using Internal;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Miscella;
using Praebeunda.Multiplex.Āctūs;
using Ēnumerātiōnēs;

namespace Tentāmina
{
  [TestClass]
  public sealed partial class Carthāgō
  {
    private readonly Lazy<Lēctor> Lēctor = Lēctor.Lazy;

    private readonly Dictionary<string, Catēgoria> Verba = new Dictionary<string, Catēgoria>()
                                                                  {
                                                                    { "cēterum", Catēgoria.Adverbium },
                                                                    { "cēnsēre", Catēgoria.Āctus },
                                                                    { "Carthāgō", Catēgoria.Nōmen },
                                                                    { "esse", Catēgoria.Āctus },
                                                                    { "dēlēre", Catēgoria.Āctus }
                                                                  };
    private readonly string Prōdūcendum = "Cēterum cēnseō Carthāginem esse dēlendam";

    [TestMethod]
    public async void Prōdūcam()
    {
      await TentāmenVerbōrum.VērificemAsync(Verba);

      const Verbum? cēterum = await Lēctor.Value.InveniamAsync("cēterum", Catēgoria.Adverbium),
                     cēnseō = await Lēctor.Value.InveniamAsync("cēnsēre", Catēgoria.Āctus, Modus.Indicātīvus, Vōx.Āctīva,
                                                              Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma),
                Carthāginem = await Lēctor.Value.InveniamAsync("Carthāgō", Catēgoria.Nōmen, Numerālis.Singulāris, Casus.Accūsātīvus),
                       esse = await Lēctor.Value.InveniamAsync("esse", Catēgoria.Āctus, Modus.Īnfīnītīvus, Tempus.Praesēns),
            dēlendam = await (await Lēctor.Value.InveniamAsync("dēlēre", Catēgoria.Āctus, Modus.Participālis, Vōx.Passīva, Tempus.Futūrum))
                                               ?.Cast<Āctūs>()?.Relātor.Invoke(Genus.Fēminīnum, Numerālis.Singulāris, Casus.Accūsātīvus);

      const Verbum?[] verba = Ūtilitātēs.Seriēs(cēterum, cēnseō, Carthāginem, esse, dēlendam);
      Console.WriteLine(await Locūtiōnis.AgōAsync(verba: verba, locūtiō: Prōdūcendum));
    }
  }
}
