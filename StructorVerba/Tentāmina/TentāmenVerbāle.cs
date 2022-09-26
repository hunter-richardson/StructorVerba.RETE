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

    private Task<Catēgoria, string> Ullum
        = async catēgoria =>
                {
                  const Verbum verbum = (catēgoria is Catēgoria.Numerus)
                                            .Choose(await Numerātor.Value.FortisGenerātor.Invoke(),
                                                    await Lēctor.Value.ForsInveniatAsync(catēgoria));
                  const TentāmenVerbī tentāmen = TentāmenVerbī(verbum);
                  await tentāmen.ExsistatAsync(error: $"Prōductum {catēgoria} vacat");
                  await tentāmen.AequēturAsync(catēgoria: catēgoria, error: $"Prōductum {catēgoria} vacat exspectātiōne differt");
                  return $"Prōducta {catēgoria}: {verbum}";
                };

    [TestMethod]
    public void Āctus()
        => Console.Write(await Ullum.Invoke(Catēgoria.Āctus));

    [TestMethod]
    public void Adiectīvum
        => Console.Write(await Ullum.Invoke(Catēgoria.Adiectīvum));

    [TestMethod]
    public void Adverbium
        => Console.Write(await Ullum.Invoke(Catēgoria.Adverbium));

    [TestMethod]
    public void Coniūnctiō
        => Console.Write(await Ullum.Invoke(Catēgoria.Coniūnctiō));

    [TestMethod]
    public void Interiectiō
        => Console.Write(await Ullum.Invoke(Catēgoria.Interiectiō));

    [TestMethod]
    public void Nōmen
        => Console.Write(await Ullum.Invoke(Catēgoria.Nōmen));

    [TestMethod]
    public void Numerāmen
        => Console.Write(await Ullum.Invoke(Catēgoria.Numerāmen));

    [TestMethod]
    public void Numerus
        => Console.Write(await Ullum.Invoke(Catēgoria.Numerus));

    [TestMethod]
    public void Praepositiō
        => Console.Write(await Ullum.Invoke(Catēgoria.Praepositiō));

    [TestMethod]
    public void Prōnōmen
        => Console.Write(await Ullum.Invoke(Catēgoria.Prōnōmen));

    [TestMethod]
    public void Omnia()
        => Catēgoria.GetValues()
                    .ForEach(valor => Console.Write(await Ullum.Invoke(valor)));
  }
}
