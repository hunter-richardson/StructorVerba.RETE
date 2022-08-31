using System;
using System.ComponentModel.DataAnnotations.StringLength;
using System.Text.Json.JsonElement;
using System.Threading.Tasks.Task;

namespace Praebeunda.Simplicia {
public sealed class Coniūnctiō : Verbum<Coniūnctiō>, Pēnsābile<Coniūnctiō>
  {
    public static readonly Func<JsonElement, Task<Coniūnctiō>> Lēctor = async legendum
               => new Coniūnctiō(legendum.GetProperty(nameof(Minūtal).ToLower()).GetInt32(),
                                 legendum.GetProperty(nameof(Scrīpum).ToLower()).GetString());
    private Coniūnctiō(in int minūtal, [StringLength(25, MinimumLength = 2)] in string scrīptum)
                       : base(minūtal, Ēnumerātiōnēs.Catēgoria.Coniūnctiō, scrīptum) { }
  }
}
