using System;
using System.Text.Json.JsonElement;

using Ēnumerātiōnēs.Catēgoria;

namespace Praebeunda.Simplicia {
  public sealed class Praepositiō : Verbum<Praepositiō>
  {
    public static readonly Func<JsonElement, Praepositiō> Lēctor = legendum
             => new Praepositiō(legendum.GetProperty("minūtal").GetInt32(),
                                legendum.GetProperty("scrīptum").GetString());
    private Praepositiō(in int minūtal, in string scrīptum)
                        : base(minūtal, Catēgoria.Praepositiō, scrīptum) { }
  }
}
