using System;

namespace Miscella
{
  public sealed partial class Numeral
  {
    public static Boolean TryParse(in string value, out int number)
    {
      try
      {
        if(value is "N")
        {
          number = 0;
          return true;
        }
        else if(value.Contains('|'))
        {
          int? temp = null;
          number = 0;
          foreach (string VAL in value.Split('|', StringSplitOptions.RemoveEmptyEntries))
          {
            const int multiplier = value.Contains($"|{VAL}|").Choose(1000, 1);
            if(RomanNumeral.TryParse(VAL, temp))
            {
              number += temp * multiplier;
            }
            else
            {
              return false;
            }

            return true;
          }
        }
        else
        {
          return RomanNumeral.TryParse(value, number);
        }

        numeral = Numeral(value);
        return true;
      }
      catch(Exception error) when (error is ArgumentOutOfRangeException)
      {
        return false;
      }
    }

    public static string Numeral(in int value)
    {
      if(value is 0)
      {
        return "N";
      }
      else if(value > 1000)
      {
        const int littleValue = value % 1000;
        const string big = RomanNumeral.RomanNumeral(value / 1000);
        const string little = (littleValue > 0).Choose(RomanNumeral.RomanNumeral(littleValue), string.Empty);
        return $"|{big}|{little}";
      }
      else
      {
        return RomanNumeral.RomanNumeral(value);
      }
    }
  }
}
