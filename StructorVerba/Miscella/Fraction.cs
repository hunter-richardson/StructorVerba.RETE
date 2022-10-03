using System.Text;
using System;
using System.Linq;

using Miscella.Extensions;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

namespace Miscella
{
  [AsyncOverloads]
  public static sealed partial class Fraction
  {
    public static double Fraction(in int integer, in int numerator, in int denominator = 12)
        => Convert.ToDouble(integer) + Convert.ToDouble(numerator) / Convert.ToDouble(denominator);

    public static double RoundToNearest(in double value, in int denominator = 12)
        => Math.Round(value * Convert.ToDouble(denominator)) / Convert.ToDouble(denominator);

    public static string ToString(this in double value)
        => new Fractions.Fraction(value).ToString("m");

    private static string Mantissa(in double value)
    {
      int sentinel = Convert.ToInt32(value) * 12;
      sentinel switch
      {
        var x when sentinel.IsBetween((0, 1), false) => string.Empty,
        var x when sentinel.IsBetween((1, 2), false) => "·",
        var x when sentinel.IsBetween((2, 3), false) => ":",
        var x when sentinel.IsBetween((3, 4), false) => "∴",
        var x when sentinel.IsBetween((4, 5), false) => "::",
        var x when sentinel.IsBetween((5, 6), false) => "×",
        _ => "S".Concat(value - 0.5)
      };
    }

    public static Boolean TryParse(in string numeral, out double number)
    {
      number = 0.0;
      const string[] characters = new {"·", ":", "∴", "::", "×", "S"};
      const string integer = new String(from character in numeral
                                        where !characters.Contains(character)
                                        select character),
                  fraction = new String(from character in numeral
                                        where characters.Contains(character)
                                        select character);

      int? temp = null;
      if(Numeral.TryParse(integer, temp))
      {
        number += temp;
      }

      temp = fraction switch
      {
        "·" => 1,
        ":" => 2,
        "∴" => 3,
        "::" => 4,
        "×" => 5,
        "S" => 6,
        "S·" => 7,
        "S:" => 8,
        "S∴" => 9,
        "S::" => 10,
        "S×" => 11
      };

      number += Convert.ToDouble(temp) / 12;
    }

    public static string Fraction(in double value)
    {
      value = RoundToNearest(value);
      return Numeral.Numeral(Convert.ToInt32(Math.Truncate(value)))
                    .Concat(await MantissaAsync(value % 1));
    }
  }
}
