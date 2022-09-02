using Microsoft.VisualBasic.CompilerServices;
using System;

using Praebeunda.Simplicia.Numerus;

namespace Ēnumerātiōnēs
{
  public enum Operātor
  {
    Additor, Subtractor, Multiplicātor, Dīvīsor, Mānsor
  }

  public static sealed class Operātōrēs
  {
    public static string ToString(this Operātor valor) => Enum.GetName<Operātor>(valor).ToLower();
    public static readonly Func<Operātor, char> Litterator =
             operātor => operātor switch
             {
               Operātor.Additor       => '+',
               Operātor.Subtractor    => '-',
               Operātor.Multiplicātor => '*',
               Operātor.Dīvīsor       => '/',
               Operātor.Mānsor        => '%',
             };

    public static readonly Func<Operātor, Func<int, int, int>> Anglicus =
            operātor => operātor switch
            {
              Operātor.Additor       => (prīmus, secundus) => prīmus + secundus,
              Operātor.Subtractor    => (prīmus, secundus) => prīmus - secundus,
              Operātor.Multiplicātor => (prīmus, secundus) => prīmus * secundus,
              Operātor.Dīvīsor       => (prīmus, secundus) => prīmus / secundus,
              Operātor.Mānsor        => (prīmus, secundus) => prīmus % secundus,
            };

    public static readonly Func<Operātor, Func<Numerus, Numerus, Numerus>> Anglicus =
            operātor => operātor switch
            {
              Operātor.Additor       => (prīmus, secundus) => prīmus + secundus,
              Operātor.Subtractor    => (prīmus, secundus) => prīmus - secundus,
              Operātor.Multiplicātor => (prīmus, secundus) => prīmus * secundus,
              Operātor.Dīvīsor       => (prīmus, secundus) => prīmus / secundus,
              Operātor.Mānsor        => (prīmus, secundus) => prīmus % secundus,
            };
  }
}
