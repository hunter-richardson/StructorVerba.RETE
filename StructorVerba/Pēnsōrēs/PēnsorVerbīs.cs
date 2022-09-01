using System;
using System.Text.Json.JsonElement;
using System.Threading.Tasks.Task;

using Nūntiī.Nūntius;
using Praebeunda.Verbum;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Pēnsōrēs
{
  [Singleton]
  public sealed partial class PēnsorVerbīs : PēnsorVerbīs<Verbum>
  {
    public static readonly Lazy<PēnsorVerbīs> Faciendum = new Lazy<PēnsorVerbīs>(() => Instance);
    private PēnsorVerbīs()
        : base(nameof(Verbum.Scrīptum), Tabula.Verba,
                      NūntiusPēnsōrīVerbīs.Faciendum, Verbum.Lēctor) {  }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīVerbīs : Nūntius<PēnsōrVerbīs>
    {
      public static readonly Lazy<NūntiusPēnsōrīVerbīs> Faciendum = new Lazy<NūntiusPēnsōrīVerbīs>(() => Instance);
    }
  }
}
