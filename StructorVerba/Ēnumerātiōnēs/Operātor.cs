using System;

using Praebeunda.Simplicia;
using Lombok.NET.MethodGenerators.AsyncOverloadsAttributes;

namespace Ēnumerātiōnēs
{
  public enum Operātor
  {
    Additor, Subtractor, Multiplicātor, Dīvīsor, Mānsor
  }

  [AsyncOverloads]
  public static sealed class Operātōrēs
  {
    public static string ToString(this in Operātor valor) => Enum.GetName<Operātor>(valor).ToLower();

    public static char Littera(this in Operātor valor)
              => operātor switch
                  {
                    Operātor.Additor => '+',
                    Operātor.Subtractor => '-',
                    Operātor.Multiplicātor => '*',
                    Operātor.Dīvīsor => '/',
                    Operātor.Mānsor => '%'
                  };

    private static Func<int, int, int?> Arabicus(this in Operātor valor)
              => operātor switch
                  {
                    Operātor.Additor => (prīmus, secundus) => prīmus + secundus,
                    Operātor.Subtractor => (prīmus, secundus) => prīmus - secundus,
                    Operātor.Multiplicātor => (prīmus, secundus) => prīmus * secundus,
                    Operātor.Dīvīsor => (prīmus, secundus) => prīmus / secundus,
                    Operātor.Mānsor => (prīmus, secundus) => prīmus % secundus
                  };

    private static Func<Numerus, Numerus, Numerus?> Rōmānus(this in Operātor valor)
              => operātor switch
                  {
                    Operātor.Additor => (prīmus, secundus) => prīmus + secundus,
                    Operātor.Subtractor => (prīmus, secundus) => prīmus - secundus,
                    Operātor.Multiplicātor => (prīmus, secundus) => prīmus * secundus,
                    Operātor.Dīvīsor => (prīmus, secundus) => prīmus / secundus,
                    Operātor.Mānsor => (prīmus, secundus) => prīmus % secundus
                  };

    private static Func<double, double, double>? ArabicusFrāctōrum(this in Operātor operātor)
                => operātor switch
                    {
                      Operātor.Additor => (prīmus, secundus) => prīmus + secundus,
                      Operātor.Subtractor => (prīmus, secundus) => prīmus - secundus,
                      Operātor.Multiplicātor => (prīmus, secundus) => prīmus * secundus,
                      Operātor.Dīvīsor => (prīmus, secundus) => prīmus / secundus,
                      Operātor.Mānsor => null
                    };

    private static Func<Frāctus, Frāctus, Frāctus>? RōmānusFrāctōrum(this in Operātor operātor)
                => operātor switch
                    {
                      Operātor.Additor => (prīmus, secundus) => prīmus + secundus,
                      Operātor.Subtractor => (prīmus, secundus) => prīmus - secundus,
                      Operātor.Multiplicātor => (prīmus, secundus) => prīmus * secundus,
                      Operātor.Dīvīsor => (prīmus, secundus) => prīmus / secundus,
                      Operātor.Mānsor => null
                    };


    public object? Operem(this in Operātor operātor, in int prīmum, in int secundum)
                => (await operātor.ArabicusAsync()).Invoke(prīmum, secundum);

    public object? Operem(this in Operātor operātor, in double prīmum, in double secundum)
                => (await operātor.ArabicusFrāctōrumAsync())?.Invoke(prīmum, secundum);

    public object? Operem(this in Operātor operātor, in Numerus prīmum, in Numerus secundum)
                => (await operātor.RōmānusAsync()).Invoke(prīmum, secundum);

    public object? Operem(this in Operātor operātor, in Frāctus prīmum, in Frāctus secundum)
                => (await operātor.RōmānusFrāctōrumAsync())?.Invoke(prīmum, secundum);
  }
}
