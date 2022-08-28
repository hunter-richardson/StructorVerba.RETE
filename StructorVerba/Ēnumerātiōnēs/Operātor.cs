using Miscella.Extensions;
namespace Ēnumerātiōnēs
{
  public enum Operātor
  {
    Additor, Subtractor, Multiplicātor, Dīvīsor, Mānsor
  }

  public static sealed class Operātōrēs
  {
    public static readonly Func<Operātor, string> Scrīptor = valor => valor.ToString().ToLower();
    public static readonly Func<Operātor, char> Litterator =
             operātor => operātor switch
             {
               Additor       => '+',
               Subtractor    => '-',
               Multiplicātor => '*',
               Dīvīsor       => '/',
               Mānsor        => '%',
             };
  }
}
