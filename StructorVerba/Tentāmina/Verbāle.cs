using Internal;
using System.Lazy;
using System.Threading.Tasks.Task;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Miscella;
using Praebeunda.Verbum;
using Ēnumerātiōnēs.Catēgoria;

namespace Tentāmina
{
  [TestClass]
  public sealed partial class Verbāle
  {
    private Lazy<Lēctor> Lēctor = Lēctor.Lazy;
    private Lazy<Lēctor> Frāctor = Frāctor.Lazy;
    private Lazy<Lēctor> Numerātor = Numerātor.Lazy;

    private Func<Catēgoria, Task> Ullum
        = async catēgoria =>
                {
                  const Verbum? verbum = await catēgoria switch
                                                {
                                                  Catēgoria.Numerus => Numerātor.Value.FortisGenerātor.Invoke(),
                                                  Catēgoria.Frāctus => Frāctor.Value.FortisGenerātor.Invoke(),
                                                  _ => Lēctor.Value.ForsInveniatAsync(catēgoria)
                                                };
                  await Necesse.Quod.ExsistitAsync(verbum: verbum, error: $"Prōductum {catēgoria} vacat");
                  await Necesse.Quod.AequāturAsync(catēgoria: catēgoria, error: $"Prōductum {catēgoria} vacat exspectātiōne differt");
                  return Console.WriteLine($"Prōducta {catēgoria}: {verbum}");
                };

    [TestMethod]
    public void Āctus() => await Ullum.Invoke(Catēgoria.Āctus);
    [TestMethod]
    public void Adiectīvum() => await Ullum.Invoke(Catēgoria.Adiectīvum);
    [TestMethod]
    public void Adverbium() => await Ullum.Invoke(Catēgoria.Adverbium);
    [TestMethod]
    public void Coniūnctiō() => await Ullum.Invoke(Catēgoria.Coniūnctiō);
    [TestMethod]
    public void Frāctus() => await Ullum.Invoke(Catēgoria.Frāctus);
    [TestMethod]
    public void Interiectiō() => await Ullum.Invoke(Catēgoria.Interiectiō);
    [TestMethod]
    public void Nōmen() => await Ullum.Invoke(Catēgoria.Nōmen);
    [TestMethod]
    public void Numerāmen() => await Ullum.Invoke(Catēgoria.Numerāmen);
    [TestMethod]
    public void Numerus() => await Ullum.Invoke(Catēgoria.Numerus);
    [TestMethod]
    public void Praepositiō() => await Ullum.Invoke(Catēgoria.Praepositiō);
    [TestMethod]
    public void Prōnōmen() => await Ullum.Invoke(Catēgoria.Prōnōmen);
    [TestMethod]
    public void Omnia()
        => Catēgoria.GetValues()
                    .ForEach(valor => await Ullum.Invoke(valor));
  }
}
