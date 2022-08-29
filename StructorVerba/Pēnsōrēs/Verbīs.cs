using System;
using System.Text.Json.JsonElement;

using Nūntiī.Nūntius;
using Praebeunda;
using Praebeunda.Simplicia;

using Lombok.NET.PropertyGenerators.SingletonGenerator;

namespace Pēnsōrēs
{
  private abstract partial class Verbīs<Hoc> : Pēnsor<Hoc> where Hoc : Verbum<Hoc> {
    private Verbīs(in Func<Nūntius<Pēnsor<Hoc>>> nūntius, in Func<JsonElement, Hoc?> lēctor)
             : base(nameof(Verbum.scrīptum), Tabula.Verba, lēctor) {  }
  }
}
