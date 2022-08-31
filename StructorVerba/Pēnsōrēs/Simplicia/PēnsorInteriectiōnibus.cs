using System;

using Nūntiī.Nūntius;
using Praebeunda.Simplicia;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Pēnsōrēs.Simplicia
{
  [Singleton]
  public sealed partial class PēnsorInteriectiōnibus : PēnsorVerbīs<Interiectiō>
  {
    public static readonly Lazy<PēnsorInteriectiōnibus> Faciendum = new Lazy<PēnsorInteriectiōnibus>(() => Instance);
    private PēnsorInteriectiōnibus()
        : base(NūntiusPēnsōrīInteriectiōnum.Faciendum, Interiectiō.Lēctor) {  }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīInteriectiōnum : Nūntius<PēnsorInteriectiōnibus>
    {
      public static readonly Lazy<NūntiusPēnsōrīInteriectiōnum> Faciendum = new Lazy<NūntiusPēnsōrīInteriectiōnum>(() => Instance);
    }
  }
}
