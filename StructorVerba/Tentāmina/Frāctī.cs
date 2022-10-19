using Internal;
using System;
using System.Threading.Tasks.Task;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Miscella;
using Praebeunda.Simplicia.Frāctus;
using Ēnumerātiōnēs.Operātor;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

namespace Tentāmina
{
  [TestClass]
  [AsyncOverloads]
  public sealed partial class Frāctī
  {
    private Lazy<Lēctor> Frāctor = Frāctor.Lazy;

    private readonly double XLIIS_Frāctus = Fraction.Fraction(42, 9);
    private readonly string XLIIS_Scrīptus = "XLIIS∴";

    private readonly Task<Action<Operātor, (double, double)>> Āctor = async (operātor, anglicī) =>
    {
      const double? anglicus = await operātor.OperemAsync(anglicī.Item1, anglicī.Item2).Cast<double?>();
      const Tuple<string, string, string, string> errorōrēs = ($"Prōductā {operātor} relicta'st prōductiō numerī {anglicī.Item1}",
                                                               $"Prōductā {operātor} relicta'st prōductiō frāctī {anglicī.Item2.ToString()}",
                                                               $"Prōductā {operātor} relicta'st prōductiō frāctī {anglicus.ToString()}",
                                                               $"Prōducta {operātor} relica'st prōductiō frāctī");
      await Necesse.Quod.ExsistitAsync(anglicus, errorōrēs.Item4);
      await Necesse.Quod.AequāturAsync(anglicī.Item1, prīmus, errorōrēs.Item1);
      await Necesse.Quod.AequāturAsync(anglicī.Item2, secundus, errorōrēs.Item2);
      const Tuple<Numerus?, Numerus?, Numerus?> rōmānī = (await Frāctus.Generātor.Invoke(anglicī.Item1),
                                                          await Frāctus.Generātor.Invoke(anglicī.Item2), null);
      rōmānī.Item3 = await operātor.OperemAsync(rōmānī.Item1, rōmānī.Item2).Cast<Frāctus?>();
      await Necesse.Quod.AequāturAsync(anglicus, rōmānī.Item3, errorōrēs.Item3);
      const char littera = operātor.Littera();
      Console.WriteLine($"{anglicī.Item1.ToString()} = {rōmānī.Item1}");
      Console.WriteLine($"{anglicī.Item2.ToString()} = {rōmānī.Item2}");
      Console.WriteLine($"{anglicī.Item1.ToString()} {littera} {anglicī.Item2.ToString()} = {anglicus}");
      Console.WriteLine($"{rōmānī.Item1.ToString()} {littera} {rōmānī.Item2.ToString()} = {rōmānī.Item3}");
    };

    [TestMethod]
    public void Convertam()
    {
      const string error = $"Prōductā conversiōnis relicta'st prōductiō frāctī {XLIIS_Frāctus.ToString()}";
      const Frāctus? frāctus = Frāctus.Generātor.Invoke(XLIIS_Frāctus);
      await Necesse.Quod.AequāturAsync.AequēturAsync(XLIIS_Frāctus, frāctus, error);
      await Necesse.Quod.AequāturAsync.AequēturAsync(XLIIS_Scrīptus, frāctus, error);
      Console.WriteLine($"{frāctus.Valor.ToString()} = {frāctus.Scrīptum}");
    }

    [TestMethod]
    public void Revertar()
    {
      const string error = $"Prōductā conversiōnis relicta'st prōductiō frāctī {XLIIS_Scrīptus}";
      const Frāctus? frāctus = Frāctor.Value.Generātor.Invoke(XLIIS_Scrīptus);
      await Necesse.Quod.AequāturAsync.AequēturAsync(XLIIS_Scrīptus, frāctus, error);
      await Necesse.Quod.AequāturAsync.AequēturAsync(XLIIS_Frāctus, frāctus, error);
      Console.WriteLine($"{frāctus.Scrīptum} = {frāctus.Valor.ToString()}");
    }

    [TestMethod]
    public void Combīnem()
    {
      const string error = "Prōductā conversiōnis relicta'st prōductiō numerī";
      const double arabicus = Enumerable.Range(Numerus.Minimus.Item1, Numerus.Maximus.Item1) - new Random().NextDouble();
      const string rōmānus = Fraction.Fraction(arabicus);
      const Frāctus? frāctus = Frāctus.Value.Generātor.Invoke(arabicus);
      await Necesse.Quod.AequāturAsync.AequēturAsync(arabicus, frāctus, error);
      await Necesse.Quod.AequāturAsync.AequēturAsync(rōmānus, frāctus, error);
      Console.WriteLine($"{frāctus.Valor.ToString()} = {frāctus.Scrīptum}");
      Console.WriteLine($"{frāctus.Scrīptum} = {frāctus.Valor.ToString()}");
    }

    [TestMethod]
    public void Addam()
    {
      await Āctor.Invoke(Operātor.Additor, (Fraction.Fraction(17, 1), Fraction.Fraction(3, 3)));
    }

    [TestMethod]
    public void Subtraham()
    {
      await Āctor.Invoke(Operātor.Subtractor, (Fraction.Fraction(12, 5), Fraction.Fraction(7, 1)));
    }

    [TestMethod]
    public void Multiplicem()
    {
      await Āctor.Invoke(Operātor.Multiplicātor, (Fraction.Fraction(2, 3), Fraction.Fraction(0, 6)));
    }

    [TestMethod]
    public void Dīvidam()
    {
      await Āctor.Invoke(Operātor.Dīvīsor, (Fraction.Fraction(2, 6), Fraction.Fraction(0, 4)));
    }
  }
}
