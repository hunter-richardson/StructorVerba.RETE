using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Reflection;
using System.Text.Json.JsonElement;
using System.Threading.Tasks.Task;

using Miscella.Ūtilitātēs;
using Praebeunda.Interfecta.Pēnsābile;
using Praebeunda.Simplicia;
using Miscella.Ūtilitātēs;

using BuilderGenerator.GenerateBuilderAttribute;
using Lombok.NET.ConstructorGenerators.AllArgsConstructorAttribute;

namespace Praebeunda
{
  [GenerateBuilder]
  [AllArgsConstructor(MemberTypes.Property, AccessType.Protected)]
  public partial class Verbum<Hoc> : Pēnsābile<Hoc>, IComparable<Verbum>, IEquatable<Verbum>
                        where Hoc : Verbum<Hoc>
  {
    public static readonly Func<JsonElement, Task<Verbum>> LēctorSimplicibus = async legendum
              => Ēnumerātiōnēs.Catēgoriae.Dēfīnītor.Invoke(legendum.GetProperty(Ēnumerātiōnēs.Catēgoriae.Columna()).GetString()) switch
              {
                Catēgoria.Coniūnctiō  => Coniūnctiō.Lēctor.Invoke(legendum),
                Catēgoria.Interiectiō => Interiectiō.Lēctor.Invoke(legendum),
                Catēgoria.Praepositiō => Praepositiō.Lēctor.Invoke(legendum),
                _ => Lemma.Lēctor.Invoke(legendum)
              };

    public static readonly Func<JsonElement, Task<Verbum>> Lēctor = async legendum
              => Builder.Catēgoria(Ēnumerātiōnēs.Catēgoriae.Dēfīnītor.Invoke(legendum.GetProperty(Ēnumerātiōnēs.Catēgoriae.Columna()).GetString()))
                        .Scrīptum(legendum.GetProperty(Pēnsor.NōmenātorColumnae.Invoke(nameof(Scrīptum))).GetString().ToLowerInvariant())
                        .Build();

    public static readonly Func<string, Catēgoria, Task<Adverbium>> Cōnstrūctor
              = async (scrīpum, catēgoria) => Builder.Catēgoria(catēgoria)
                                                     .Scrīptum(scrīptum).Build();
    [Required]
    public readonly Ēnumerātiōnēs.Catēgoria Catēgoria { get; }
    [Required]
    [StringLength(25, MinimumLength = 1)]
    public readonly string Scrīptum { get; }

    public virtual string ToString() => (Catēgoria is Catēgoria.Numerus).Choose(Scrīptum, this.Cast<Numerus>().ToString());

    public virtual int CompareTo(Verbum aliud)
              => Ūtilitātēs.Omnia(this is Simplicia.Numerus, aliud is Simplicia.Numerus)
                           .Choose(this.Cast<Simplicia.Numerus>().CompareTo(aliud.Cast<Simplicia.Numerus>()),
                                   (from comparātiō in Ūtilitātēs.Seriēs(Scrīptum.CompareTo(aliud.Scrīptum),
                                                                         Catēgoria.CompareTo(aliud.Catēgoria))
                                     where comparātiō is not 0
                                     select comparātiō).FirstOrDefault(0));

    public sealed Boolean Equals(Verbum aliud)
              => Ūtilitātēs.Omnia(Catēgoria is aliud.Catēgoria,
                                  Scrīpum is aliud.Scrīptum);
  }
}
