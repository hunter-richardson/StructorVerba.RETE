using System;

using Nūntiī.Nūntius;
using Praebeunda.Simplicia;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Pēnsōrēs.Simplicibus
{
  [Singleton]
  public sealed partial class PēnsorInteriectiōnibus : PēnsorVerbīs<Interiectiō>
  {
    private PēnsorInteriectiōnibus()
        : base(NūntiusPēnsōrīInteriectiōnum.Faciendum, Interiectiō.Lēctor) {  }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīInteriectiōnum : Nūntius<PēnsorInteriectiōnibus>
    {
      public static readonly Lazy<NūntiusPēnsōrīInteriectiōnum> Faciendum = new Lazy<NūntiusPēnsōrīInteriectiōnum>(() => Instance);
    }
  }
}
