using System;
using System.ComponentModel.DataAnnotations.StringLength;
using System.Security.AccessControl;
using System.Text.Json.JsonElement;
using System.Threading.Tasks.Task;

namespace Praebeunda.Simplicia {
  public sealed class Interiectiō : Verbum<Interiectiō>, Pēnsābile<Interiectiō>
  {
    public static readonly Func<JsonElement, Task<Interiectiō>> Lēctor = async legendum
             => new Interiectiō(minūtal: legendum.GetProperty(nameof(Minūtal).ToLower()).GetInt32(),
                                scrīptum: legendum.GetProperty(nameof(Scrīpum).ToLower()).GetString());
    private Interiectiō(in int minūtal, [StringLength(25, MinimumLength = 2)] in string scrīptum)
                        : base(minūtal, Ēnumerātiōnēs.Catēgoria.Interiectiō, scrīptum) { }
  }
}
