using System;

using Nūntiī.Nūntius;
using Praebeunda.Simplicia;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Pēnsōrēs.Simplicia
{
  [Singleton]
  public sealed partial class PēnsorPraepositiōnibus : PēnsorVerbīs<Praepositiō>
  {
    public static readonly Lazy<PēnsorPraepositiōnibus> Faciendum = new Lazy<PēnsorPraepositiōnibus>(() => Instance);
    private PēnsorPraepositiōnibus()
          : base(NūntiusPēnsōrīPraepositiōnum.Faciendum, Praepositiō.Lēctor) {  }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīPraepositiōnum : Nūntius<PēnsorPraepositiōnibus>
    {
      public static readonly Lazy<NūntiusPēnsōrīPraepositiōnum> Faciendum = new Lazy<NūntiusPēnsōrīPraepositiōnum>(() => Instance);
    }
  }
}
