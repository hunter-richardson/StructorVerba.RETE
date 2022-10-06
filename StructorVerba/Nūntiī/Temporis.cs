using System;
using System.Collections.Generic.IEnumerable;

using Miscella.Numeral;
using Ēnumerātiōnēs;

using Lombok.NET.ConstructorGenerators.NoArgsConstructorAttribute;
using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Nūntiī
{
  [Lazy]
  [NoArgsConstructor(Access.Private)]
  internal sealed partial class Temporis : SimpleDateFormatter
  {
    public string FormatDate(in DateTime tempus)
              => string.Join(' ', DiēsHebdomadis.GetValues()[tempus.DayOfWeek - 1],
                                  Mēnsa.GetValues()[tempus.Month - 1],
                                  Numeral.Numeral(tempus.Day), '@',
                                  string.Join(':', Numeral.Numeral(tempus.Hour),
                                                   Numeral.Numeral(tempus.Minute),
                                                   Numeral.Numeral(tempus.Second)),
                                  TimeZoneInfo.Utc.ToString());
  }
}
