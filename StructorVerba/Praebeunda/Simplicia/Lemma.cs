using System;
using System.Reflection;
using System.Text.Json.JsonElement;

using Ēnumerātiōnēs.Catēgoriae;

using Lombok.NET.ConstructorGenerators.AllArgsConstructorGenerator;

namespace Praebeunda.Simplicia
{
  [AllArgsConstructor(MemberTypes.Property, AccessType.Private)]
  public sealed partial class Lemma : Verbum<Lemma>
  {
    public readonly Enum? Versiō { get; }

    // TODO: convert Versiō from JsonElement
    public static readonly Func<JsonElement, Lemma> Lēctor = legendum =>
       new Lemma(legendum.GetProperty("minūtal").GetInt32(),
                 Catēgoriae.Dēfīnītor.Invoke(legendum.GetProperty("catēgoria")),
                 legendum.GetProperty("scrīptum").GetString(),
                 legendum.GetProperty("versiō"));
  }
}
