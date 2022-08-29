using System;
using System.Text.Json.JsonElement;
using System.ComponentModel.DataAnnotations.StringLength;

using Ēnumerātiōnēs.Catēgoria;

namespace Praebeunda.Simplicia {
public sealed class Coniūnctiō : Verbum<Coniūnctiō>
  {
    public static readonly Func<JsonElement, Coniūnctiō> Lēctor = legendum
               => new Coniūnctiō(legendum.GetProperty("minūtal").GetInt32(),
                                 legendum.GetProperty("scrīptum").GetString());
    private Coniūnctiō(in int minūtal, [StringLength(25, MinimumLength = 2)] in string scrīptum)
                       : base(minūtal, Catēgoria.Coniūnctiō, scrīptum) { }
  }
}
