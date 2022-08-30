using System;
using System.Text.Json.JsonElement;

using Ēnumerātiōnēs.Catēgoria;

namespace Praebeunda.Simplicia {
  public sealed class Praepositiō : Verbum<Praepositiō>, Pēnsābile<Praepositiō>
  {
    public static readonly Func<JsonElement, Praepositiō> Lēctor = legendum
             => new Praepositiō(legendum.GetProperty(nameof(Minūtal).ToLower()).GetInt32(),
                                legendum.GetProperty(nameof(Scrīpum).ToLower()).GetString());
    private Praepositiō(in int minūtal, in string scrīptum)
                        : base(minūtal, Catēgoria.Praepositiō, scrīptum) { }
  }
}
