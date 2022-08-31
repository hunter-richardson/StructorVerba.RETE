using System;
using System.Reflection;
using System.Text.Json.JsonElement;
using System.Threading.Tasks.Task;

using Pēnsōrēs;

using Lombok.NET.ConstructorGenerators.AllArgsConstructorAttribute;

namespace Praebeunda.Simplicia
{
  [AllArgsConstructor(MemberTypes.Property, AccessType.Private)]
  public sealed partial class Lemma : Verbum<Lemma>, Pēnsābile<Lemma>
  {
    private readonly Func<Task<Īnflectendum>> Relātor = async () => PēnsorĪnflectendīs.Relātor.Invoke(Catēgoria, Versiō);

    public readonly Enum? Versiō { get; }

    // TODO: convert Versiō from JsonElement
    public static readonly Func<JsonElement, Lemma> Lēctor = legendum =>
       new Lemma(legendum.GetProperty(nameof(Minūtal).ToLower()).GetInt32(),
                 Ēnumerātiōnēs.Catēgoriae.Dēfīnītor.Invoke(legendum.GetProperty(nameof(Catēgoria).ToLower())),
                 legendum.GetProperty(nameof(Scrīpum).ToLower()).GetString(),
                 legendum.GetProperty(nameof(Versiō).ToLower()));
  }
}
