namespace Praebeunda
{
  [AllArgsConstructor(MemberType.Property, AccessType.Protected)]
  public abstract partial class Verbum<Hoc>
      where Hoc : Verbum<Hoc>, IComparable<Verbum>, IEquatable<Verbum>
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

    public sealed int CompareTo(Verbum aliud)
              => (from comparātiō in Enumerate(Scrīpum.CompareTo(aliud.Scrīptum),
                                               Minūtal.CompareTo(aliud.Minūtal))
                  where !comparātiō.Equals(0)
                  select comparātiō).FirstOrDefault(0);

    public sealed Boolean Equals(Verbum aliud)
              => Ūtilitātēs.Omnēs(Minūtal.CompareTo(aliud.Minūtal),
                                  Scrīpum.CompareTo(aliud.Scrīptum));
  }
}
