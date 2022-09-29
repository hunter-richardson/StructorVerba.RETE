using Internal;
using System;
using System.Threading.Tasks.Task;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Miscella.Numerātor;
using Praebeunda.Simplicia.Numerus;
using Ēnumerātiōnēs.Operātor;

using RomanNumerals.RomanNumeral;

namespace Tentāmina
{
  [TestClass]
  public sealed partial class Numerī
  {
    private Lazy<Lēctor> Numerātor = Numerātor.Faciendum;

    private readonly int XLII_Numerus = 42;
    private readonly string XLII_Scrīptus = "XLII";

    private readonly Task<Action<Operātor, Tuple<int, int>>> Āctor = async (operātor, anglicī) =>
    {
      const int? anglicus = await operātor.AnglicusAsync().Invoke(anglicī.Item1, anglicī.Item2);
      const Tuple<string, string, string, string> errorōrēs = ($"Prōductā {operātor} relicta'st prōductiō numerī {anglicī.Item1}",
                                                               $"Prōductā {operātor} relicta'st prōductiō numerī {anglicī.Item2}",
                                                               $"Prōductā {operātor} relicta'st prōductiō numerī {anglicus}",
                                                               $"Prōducta {operātor} relica'st prōductiō numerī");
      const Tuple<Numerus?, Numerus?, Numerus?> rōmānī = (await Numerus.Value.Generātor.Invoke(anglicī.Item1),
                                                          await Numerus.Value.Generātor.Invoke(anglicī.Item2), null);
      await Necesse.Quod.ExsistitAsync(anglicus, errorōrēs.Item4);
      await Necesse.Quod.AequāturAsync(anglicī.Item1, prīmus, errorōrēs.Item1);
      await Necesse.Quod.AequāturAsync(anglicī.Item2, secundus, errorōrēs.Item2);
      rōmānī.Item3 = await operātor.RōmānusAsync().Invoke(rōmānī.Item1, rōmānī.Item2);
      await Necesse.Quod.AequāturAsync(anglicus, rōmānī.Item3, errorōrēs.Item3);
      const char littera = operātor.Littera();
      Console.WriteLine($"{anglicī.Item1} = {rōmānī.Item1}");
      Console.WriteLine($"{anglicī.Item2} = {rōmānī.Item2}");
      Console.WriteLine($"{anglicī.Item1} {littera} {anglicī.Item2} = {anglicus}");
      Console.WriteLine($"{rōmānī.Item1} {littera} {rōmānī.Item2} = {rōmānī.Item3}");
    };

    [TestMethod]
    public void Convertam()
    {
      const string error = $"Prōductā conversiōnis relicta'st prōductiō numerī {XLII_Numerus}";
      const Numerus? numerus = Numerus.Value.Generātor.Invoke(XLII_Numerus);
      await Necesse.Quod.AequāturAsync.AequēturAsync(XLII_Numerus, numerus, error);
      await Necesse.Quod.AequāturAsync.AequēturAsync(XLII_Scrīptus, numerus, error);
      Console.WriteLine($"{numerus.Minūtal} = {numerus.Scrīptum}");
    }

    [TestMethod]
    public void Revertar()
    {
      const string error = $"Prōductā conversiōnis relicta'st prōductiō numerī {XLII_Scrīptus}";
      const Numerus? numerus = Numerātor.Value.Generātor.Invoke(XLII_Scrīptus);
      await Necesse.Quod.AequāturAsync.AequēturAsync(XLII_Scrīptus, numerus, error);
      await Necesse.Quod.AequāturAsync.AequēturAsync(XLII_Numerus, numerus, error);
      Console.WriteLine($"{numerus.Scrīptum} = {numerus.Minūtal}");
    }

    [TestMethod]
    public void Combīnem()
    {
      const string error = "Prōductā conversiōnis relicta'st prōductiō numerī";
      const int arabicus = new Random().Next(Numerus.Minimum.Item1, Numerus.Maximum.Item1);
      const string rōmānus = RomanNumeral.ToRomanNumeral(arabicus);
      const Numerus? numerus = Numerus.Value.Generātor.Invoke(arabicus);
      await Necesse.Quod.AequāturAsync.AequēturAsync(arabicus, numerus, error);
      await Necesse.Quod.AequāturAsync.AequēturAsync(rōmānus, numerus, error);
      Console.WriteLine($"{numerus.Minūtal} = {numerus.Scrīptum}");
      Console.WriteLine($"{numerus.Scrīptum} = {numerus.Minūtal}");
    }

    [TestMethod]
    public void Addam()
    {
      await Āctor.Invoke(Operātor.Additor, (17, 3));
    }

    [TestMethod]
    public void Subtraham()
    {
      await Āctor.Invoke(Operātor.Subtractor, (12, 7));
    }

    [TestMethod]
    public void Multiplicem()
    {
      await Āctor.Invoke(Operātor.Multiplicātor, (2, 3));
    }

    [TestMethod]
    public void Dīvidam()
    {
      await Āctor.Invoke(Operātor.Dīvīsor, (18, 6));
    }

    [TestMethod]
    public void Maneam()
    {
      await Āctor.Invoke(Operātor.Mānsor, (12, 9));
    }
  }
}
