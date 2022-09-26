using Internal;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Miscella;
using Ēnumerātiōnēs.Catēgoria;

namespace Tentāmina
{
  [TestClass]
  public sealed partial class Carthāgō
  {
    private readonly Lazy<Lēctor> Lēctor = Lēctor.Faciendum;
    private readonly string Prōdūcendum = "Ecce lingua Latīna placet prōdestque";

    [TestMethod]
    public void Prōdūcam() => Console.WriteLine(TentāmenVerbōrum.Agō(Ūtilitātēs.Seriēs(Lēctor.Value.Inveniam("ecce", Catēgoria.Interiectiō),
                                                                                       Lēctor.Value.Inveniam("lingua", Catēgoria.Nōmen, Numerālis.Singulāris, Casus.Nōminātīvus),
                                                                                       Lēctor.Value.Inveniam("Latīnum", Catēgoria.Adiectīvum, Genus.Fēminīnum, Numerālis.Singulāris, Casus.Nōminātīvus),
                                                                                       Lēctor.Value.Inveniam("placēre", Catēgoria.Āctūs, Modus.Indicātīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Tertia),
                                                                                       Lēctor.Value.Inveniam("prōdesse", Catēgoria.Āctūs, Modus.Indicātīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Tertia, Encliticum.Coniugāns)),
                                                                     Prōdūcendum));
  }
}
