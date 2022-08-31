using System;

using Nūntiī.Nūntius;
using Praebeunda.Simplicia;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Pēnsōrēs.Simplicibus
{
  [Singleton]
  public sealed partial class PēnsorConiūnctiōnibus : PēnsorVerbīs<Coniūnctiō>
  {
    private PēnsorConiūnctiōnibus()
        : base(NūntiusPēnsōrīConiūnctiōnum.Faciendum, Coniūnctiō.Lēctor) {  }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīConiūnctiōnum : Nūntius<PēnsorConiūnctiōnibus>
    {
      public static readonly Lazy<NūntiusPēnsōrīConiūnctiōnum> Faciendum = new Lazy<NūntiusPēnsōrīConiūnctiōnum>(() => Instance);
    }
  }
}
