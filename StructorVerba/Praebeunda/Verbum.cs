using System;
using System.ComponentModel.DataAnnotations.StringLength;
using System.Reflection;
using System.Text.Json.JsonElement;
using System.Threading.Tasks.Task;

using Praebeunda.Interfecta.Pēnsābile;
using Miscella.Ūtilitātēs;

using Lombok.NET.ConstructorGenerators.AllArgsConstructorAttribute;

namespace Praebeunda
{
  [AllArgsConstructor(MemberTypes.Property, AccessType.Protected)]
  public abstract partial class Verbum<Hoc> : Pēnsābile<Hoc>, IComparable<Verbum>, IEquatable<Verbum>
      where Hoc : Verbum<Hoc>
  {
    public static readonly Func<JsonElement, Task<Verbum>> Lēctor = async legendum
              => Ēnumerātiōnēs.Catēgoriae.Dēfīnītor.Invoke(legendum.GetProperty(nameof(Catēgoria).ToLower()).GetString()) switch
              {
                Cōniūnctiō  => Coniūnctiō.Lēctor.Invoke(legendum),
                Interiectiō => Interiectiō.Lēctor.Invoke(legendum),
                Praepositiō => Praepositiō.Lēctor.Invoke(legendum),
                _           => Lemma.Lēctor.Invoke(legendum)
              };

    public readonly int Minūtal { get; }
    public readonly Ēnumerātiōnēs.Catēgoria Catēgoria { get; }

    [StringLength(25, MinimumLength = 1)]
    public readonly string Scrīpum { get; }

    public virtual string ToString() => Scrīptum;

    public virtual int CompareTo(Verbum aliud)
              => (this is Simplicia.Numerus).And(aliud is Simplicia.Numerus)
                                            .Choose(this.Cast<Simplicia.Numerus>().CompareTo(aliud.Cast<Simplicia.Numerus>()),
                                                    (from comparātiō in Ūtilitātēs.Seriēs(Scrīpum.CompareTo(aliud.Scrīptum),
                                                                                          Minūtal.CompareTo(aliud.Minūtal))
                                                     where !comparātiō.Equals(0)
                                                     select comparātiō).FirstOrDefault(0));

    public sealed Boolean Equals(Verbum aliud)
              => Ūtilitātēs.Omnēs(Minūtal.CompareTo(aliud.Minūtal),
                                  Scrīpum.CompareTo(aliud.Scrīptum));
  }
}
