using System.Security.AccessControl;
using System;
using System.ComponentModel.DataAnnotations.StringLength;
using System.Text.Json.JsonElement;
namespace Praebeunda.Simplicia {
  public sealed class Interiectiō : Verbum<Interiectiō>
  {
    public static readonly Func<JsonElement, Interiectiō> Lēctor = legendum
             => new Interiectiō(legendum.GetProperty("minūtal").GetInt32(),
                                legendum.GetProperty("scrīptum").GetString());
    private Interiectiō(in int minūtal, [StringLength(25, MinimumLength = 2)] in string scrīptum)
                        : base(minūtal, Catēgoria.Interiectiō, scrīptum) { }
  }
}
