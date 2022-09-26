using Internal;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Miscella;
using Praebeunda.Verbum;
using Ēnumerātiōnēs.Catēgoria;

namespace Tentāmina
{
  [TestClass]
  public sealed partial class TentāmenVerbāle
  {
    private Lazy<Lēctor> Lēctor = Lēctor.Faciendum;
    private Lazy<Lēctor> Numerātor = Numerātor.Faciendum;

    private Task<Catēgoria, Action> Ullum
        = async catēgoria =>
                {
                  const Verbum? verbum = (catēgoria is Catēgoria.Numerus)
                                            .Choose(await Numerātor.Value.FortisGenerātor.Invoke(),
                                                    await Lēctor.Value.ForsInveniatAsync(catēgoria));
                  const TentāmenVerbī tentāmen = TentāmenVerbī(verbum: verbum);
                  await tentāmen.ExsistatAsync(error: $"Prōductum {catēgoria} vacat");
                  await tentāmen.AequēturAsync(catēgoria: catēgoria, error: $"Prōductum {catēgoria} vacat exspectātiōne differt");
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
