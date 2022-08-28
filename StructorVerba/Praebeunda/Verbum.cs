namespace Praebeunda
{
  [AllArgsConstructor(MemberType.Property, AccessType.Public)]
  public abstract partial class Verbum<Hoc> where Hoc : Verbum<Hoc>
  {
    public readonly int Minūtal { get; }
    public readonly Catēgoria Catēgoria { get; }

    [StringLength(25, MinimumLength = 1)]
    public readonly string Scrīpum { get; }

    public static readonly Func<JsonElement, Verbum> Lēctor = legendum =>
       new Verbum(legendum.GetProperty("minūtal").GetInt32(),
                  Catēgoriae.Dēfīnītor.Invoke(legendum.GetProperty("catēgoria")),
                  legendum.GetProperty("scrīptum").GetString());
    public virtual string ToString() => Scrīptum;
  }
}
