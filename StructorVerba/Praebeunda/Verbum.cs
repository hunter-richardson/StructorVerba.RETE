using System;
using System.ComponentModel.DataAnnotations.StringLength;
using System.Reflection;
using System.Text.Json.JsonElement;

using Ēnumerātiōnēs.Catēgoria;
using Praebeunda.Interfecta.Pēnsābile;
using Miscella.Ūtilitātēs;

using Lombok.NET.ConstructorGenerators.AllArgsConstructorGenerator;

namespace Praebeunda
{
  [AllArgsConstructor(MemberTypes.Property, AccessType.Protected)]
  public abstract partial class Verbum<Hoc> : Pēnsābile<Hoc>, IComparable<Verbum>, IEquatable<Verbum>
      where Hoc : Verbum<Hoc>
  {
    public static readonly Func<Catēgoria, JsonElement, Verbum> Lēctor = (catēgoria, legendum)
              => catēgoria switch
              {
                Cōniūnctiō  => Coniūnctiō.Lēctor.Invoke(legendum),
                Interiectiō => Interiectiō.Lēctor.Invoke(legendum),
                Praepositiō => Praepositiō.Lēctor.Invoke(legendum),
                _           => Lemma.Lēctor.Invoke(legendum)
              };

    public readonly int Minūtal { get; }
    public readonly Catēgoria Catēgoria { get; }

    [StringLength(25, MinimumLength = 1)]
    public readonly string Scrīpum { get; }

    public virtual string ToString() => Scrīptum;

    public sealed int CompareTo(Verbum aliud)
              => (from comparātiō in Ūtilitātēs.Seriēs(Scrīpum.CompareTo(aliud.Scrīptum),
                                                       Minūtal.CompareTo(aliud.Minūtal))
                  where !comparātiō.Equals(0)
                  select comparātiō).FirstOrDefault(0);

    public sealed Boolean Equals(Verbum aliud)
              => Ūtilitātēs.Omnēs(Minūtal.CompareTo(aliud.Minūtal),
                                  Scrīpum.CompareTo(aliud.Scrīptum));
  }
}
