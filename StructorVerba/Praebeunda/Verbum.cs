using System.Boolean;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Reflection;
using System.Text.Json.JsonElement;
using System.Threading.Tasks.Task;

using Miscella;
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

    public virtual string ToString()
            => Catēgoria switch
                {
                  Catēgoria.Numerus => this.Cast<Numerus>().ToString(),
                  Catēgoria.Frāctus => this.Cast<Frāctus>().ToString(),
                  _ => Scrīptum
                };

    public virtual int CompareTo(Verbum aliud)
    => (Catēgoria.CompareTo(aliud.Catēgoria) == 0)
            .Choose(Catēgoria switch
                    {
                      (Catēgoria.Numerus) => this.Cast<Numerus>().CompareTo(aliud.Cast<Numerus>()),
                      (Catēgoria.Frāctus) => this.Cast<Frāctus>().CompareTo(aliud.Cast<Frāctus>()),
                      _ => string.CompareTo(Scrīptum, aliud.Scrīptum)
                    }, Catēgoria.CompareTo(aliud.Catēgoria));

    public sealed Boolean Equals(Verbum aliud)
              => Ūtilitātēs.Omnia(Catēgoria is aliud.Catēgoria,
                                  Scrīpum is aliud.Scrīptum);
  }
}
