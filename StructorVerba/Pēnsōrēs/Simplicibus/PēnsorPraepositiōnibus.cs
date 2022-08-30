using System;

using Nūntiī.Nūntius;
using Praebeunda.Simplicia;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Pēnsōrēs.Simplicibus
{
  [Singleton]
  public sealed partial class PēnsorPraepositiōnibus : PēnsorVerbīs<Praepositiō>
  {
    private PēnsorPraepositiōnibus() : base(() => NūntiusPēnsōrīPraepositiōnum.Instance, Praepositiō.Lēctor) {  }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīPraepositiōnum : Nūntius<PēnsorPraepositiōnibus> {  }
  }
}
