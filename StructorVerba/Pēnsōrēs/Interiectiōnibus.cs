using System;

using Nūntiī.Nūntius;
using Praebeunda.Simplicia;

using Lombok.NET.PropertyGenerators.SingletonGenerator;

namespace Pēnsōrēs
{
  [Singleton]
  public sealed partial class Interiectiōnibus : Verbīs<Interiectiō>
  {
    private Interiectiōnibus() : base(() => NūntiusPēnsōrīInteriectiōnum.Instance, Interiectiō.Lēctor) {  }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīInteriectiōnum : Nūntius<Interiectiōnibus> { }
  }
}
