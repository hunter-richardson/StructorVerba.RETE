using System.Data;
using System;
using System.ComponentModel.DataAnnotations.StringLength;
using System.Reflection;
using System.Text.Json.JsonElement;
using System.Threading.Tasks.Task;

using Miscella.Ūtilitātēs;
using Praebeunda.Interfecta.Pēnsābile;
using Miscella.Ūtilitātēs;

using Lombok.NET.ConstructorGenerators.AllArgsConstructorAttribute;

namespace Praebeunda
{
  [AllArgsConstructor(MemberTypes.Property, AccessType.Protected)]
  public partial class Verbum<Hoc> : Pēnsābile<Hoc>, IComparable<Verbum>, IEquatable<Verbum>
                        where Hoc : Verbum<Hoc>
  {
    public static readonly Func<JsonElement, Task<Verbum>> LēctorSimplicibus = async legendum
              => Ēnumerātiōnēs.Catēgoriae.Dēfīnītor.Invoke(legendum.GetProperty(nameof(Catēgoria).ToLower()).GetString()) switch
              {
                Catēgoria.Coniūnctiō  => Coniūnctiō.Lēctor.Invoke(legendum),
                Catēgoria.Interiectiō => Interiectiō.Lēctor.Invoke(legendum),
                Catēgoria.Praepositiō => Praepositiō.Lēctor.Invoke(legendum),
                _ => Lemma.Lēctor.Invoke(legendum)
              };

    public static readonly Func<JsonElement, Task<Verbum>> Lēctor = async legendum
              => new Verbum(legendum.GetProperty(nameof(Minūtal).ToLower()).GetInt32(),
                            Ēnumerātiōnēs.Catēgoriae.Dēfīnītor.Invoke(legendum.GetProperty(nameof(Catēgoria).ToLower())),
                            legendum.GetProperty(nameof(Scrīptum).ToLower()).GetString());

    public readonly int Minūtal { get; }
    public readonly Ēnumerātiōnēs.Catēgoria Catēgoria { get; }

    [StringLength(25, MinimumLength = 1)]
    public readonly string Scrīpum { get; }

    public virtual string ToString() => Scrīptum;

    public virtual int CompareTo(Verbum aliud)
              => Ūtilitātēs.Omnia(this is Simplicia.Numerus, aliud is Simplicia.Numerus)
                           .Choose(this.Cast<Simplicia.Numerus>().CompareTo(aliud.Cast<Simplicia.Numerus>()),
                                   (from comparātiō in Ūtilitātēs.Seriēs(Scrīpum.CompareTo(aliud.Scrīptum),
                                                                         Minūtal.CompareTo(aliud.Minūtal))
                                     where comparātiō is not 0
                                     select comparātiō).FirstOrDefault(0));

    public sealed Boolean Equals(Verbum aliud)
              => Ūtilitātēs.Omnia(Minūtal is aliud.Minūtal,
                                  Catēgoria is aliud.Catēgoria,
                                  Scrīpum is aliud.Scrīptum);
  }
}
