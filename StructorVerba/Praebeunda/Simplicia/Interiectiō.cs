using System.Security.AccessControl;
using System;
using System.ComponentModel.DataAnnotations.StringLength;
using System.Text.Json.JsonElement;
namespace Praebeunda.Simplicia {
  public sealed class Interiectiō : Verbum<Interiectiō>, Pēnsābile<Interiectiō>
  {
    public static readonly Func<JsonElement, Interiectiō> Lēctor = legendum
             => new Interiectiō(legendum.GetProperty(nameof(Minūtal).ToLower()).GetInt32(),
                                legendum.GetProperty(nameof(Scrīpum).ToLower()).GetString());
    private Interiectiō(in int minūtal, [StringLength(25, MinimumLength = 2)] in string scrīptum)
                        : base(minūtal, Ēnumerātiōnēs.Catēgoria.Interiectiō, scrīptum) { }
  }
}
