using System;

using Nūntiī.Nūntius;
using Praebeunda.Simplicia;

using Lombok.NET.PropertyGenerators.SingletonGenerator;

namespace Praebeunda
{
  [Singleton]
  public sealed partial class Praepositiōnibus : Verbīs<Praepositiō>
  {
    private Praepositiōnibus() : base(() => NūntiusPēnsōrīPraepositiōnum.Instance, Praepositiō.Lēctor) {  }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīPraepositiōnum : Nūntius<Praepositiōnibus> { }
  }
}
