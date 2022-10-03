using System;
using System.Collections.Generic.IEnumerable;

using Ēnumerātiōnēs;

using Lombok.NET.ConstructorGenerators.NoArgsConstructorAttribute;
using Lombok.NET.PropertyGenerators.SingletonAttribute;
using RomanNumerals.RomanNumeral;

namespace Nūntiī
{
  [Lazy]
  [NoArgsConstructor(Access.Private)]
  internal sealed partial class Temporis : SimpleDateFormatter
  {
    private readonly IEnumerable<string> Diēs = from diēs in DiēsHebdomadis.GetValues()
                                                select diēs.ToString();
    private readonly IEnumerable<string> Mēnsae = from mēnsa in Mēnsa.GetValues()
                                                  select mēnsa.ToString();

    public string FormatDate(in DateTime tempus)
              => string.Join(' ', Diēs.ElementAt(tempus.DayOfWeek - 1),
                                  Mēnsae.ElementAt(tempus.Month - 1),
                                  RomanNumeral.ToRomanNumeral(tempus.Day), '@',
                                  string.Join(':', RomanNumeral.ToRomanNumeral(tempus.Hour),
                                                   RomanNumeral.ToRomanNumeral(tempus.Minute),
                                                   RomanNumeral.ToRomanNumeral(tempus.Second)),
                                  TimeZoneInfo.Utc.ToString());
  }
}
