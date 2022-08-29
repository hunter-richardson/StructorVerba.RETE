using System;
using System.Collections.Generic.IEnumerable;

using Lombok.NET.ConstructorGenerators.NoArgsConstructorGenerator;

namespace Nūntiī
{
  [NoArgsConstructor(Access.Private)]
  internal sealed partial class Temporis : SimpleDateFormatter
  {
    public Func<Temporis> Faciendum = () => new Temporis();

    private readonly IEnumerable<string> Diēs = from diēs in DiēsHebdomadis.GetValues()
                                                select diēs.ToString();
    private readonly IEnumerable<string> Mēnsae = from mēnsa in Mēnsa.GetValues()
                                                  select mēnsa.ToString();

    public string FormatDate(in DateTime tempus)
              => $"{Diēs.ElementAt(tempus.DayOfWeek)} {Mēnsae.ElementAt(tempus.Month)} {RomanNumeral.ToRomanNumeral(tempus.Day)} @ {RomanNumeral.ToRomanNumeral(tempus.Hour)}:{RomanNumeral.ToRomanNumeral(tempus.Minute)}:{RomanNumeral.ToRomanNumeral(tempus.Second)} {TimeZoneInfo.Utc.ToString()}";
  }
}
