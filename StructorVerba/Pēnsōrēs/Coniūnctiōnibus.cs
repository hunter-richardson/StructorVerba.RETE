using System;

using Nūntiī.Nūntius;
using Praebeunda.Simplicia;

using Lombok.NET.PropertyGenerators.SingletonGenerator;

namespace Pēnsōrēs
{
  [Singleton]
  public sealed partial class Coniūnctiōnibus : Verbīs<Coniūnctiō>
  {
    private Coniūnctiōnibus() : base(() => NūntiusPēnsōrīConiūnctiōnum.Instance, Coniūnctiō.Lēctor) {  }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīConiūnctiōnum : Nūntius<Coniūnctiōnibus> {  }
  }
}
