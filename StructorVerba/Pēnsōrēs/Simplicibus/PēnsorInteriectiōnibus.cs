using System;

using Nūntiī.Nūntius;
using Praebeunda.Simplicia;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Pēnsōrēs.Simplicibus
{
  [Singleton]
  public sealed partial class PēnsorInteriectiōnibus : PēnsorVerbīs<Interiectiō>
  {
    private PēnsorInteriectiōnibus() : base(() => NūntiusPēnsōrīInteriectiōnum.Instance, Interiectiō.Lēctor) {  }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīInteriectiōnum : Nūntius<PēnsorInteriectiōnibus> {  }
  }
}
