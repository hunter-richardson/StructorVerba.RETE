using Internal;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Miscella;
using Praebeunda.Multiplex.Āctūs;
using Ēnumerātiōnēs.Catēgoria;

namespace Tentāmina
{
  [TestClass]
  public sealed partial class Carthāgō
  {
    private readonly Lazy<Lēctor> Lēctor = Lēctor.Faciendum;
    private readonly string Prōdūcendum = "Cēterum cēnseō Carthāginem esse dēlendam";

    [TestMethod]
    public void Prōdūcam() => Console.WriteLine(TentāmenVerbōrum.Agō(Ūtilitātēs.Seriēs(Lēctor.Value.Inveniam("cēterum", Catēgoria.Adverbium),
                                                                                       Lēctor.Value.Inveniam("cēnsēre", Catēgoria.Āctūs, Modus.Indicātīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma),
                                                                                       Lēctor.Value.Inveniam("Carthāgō", Catēgoria.Nōmen, Numerālis.Singulāris, Casus.Accūsātīvus),
                                                                                       Lēctor.Value.Inveniam("esse", Catēgoria.Āctūs, Modus.Īnfīnītīvus, Tempus.Praesēns),
                                                                                       Lēctor.Value.Inveniam("dēlēre", Catēgoria.Āctūs, Modus.Participālis, Vōx.Passīva, Tempus.Futūrum)
                                                                                                  ?.Cast<Āctūs>()?.Relātor.Invoke(Genus.Fēminīnum, Numerālis.Singulāris, Casus.Accūsātīvus)),
                                                                     Prōdūcendum));
  }
}
