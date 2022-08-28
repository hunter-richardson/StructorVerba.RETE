namespace Praebeunda.Simplicia {
  public sealed class Praepositiō : Verbum<Praepositiō>
  {
    public static readonly Func<JsonElement, Interiectiō> Lēctor = legendum
             => new Praepositiō(legendum.GetProperty("minūtal").GetInt32(),
                                legendum.GetProperty("scrīptum").GetString());
    private Praepositiō(in int minūtal, [StringLength(25, MinimumLength = 2)] in string scrīptum)
                        : base(minūtal, Catēgoria.Praepositiō, scrīptum) { }
  }
}
