using System;
using System.Reflection;
using System.Text.Json.JsonElement;
using System.Threading.Tasks.Task;

using Pēnsōrēs.PēnsorĪnflectendīs;
using Īnflexōrēs.Īnflexor;

using Lombok.NET.ConstructorGenerators.AllArgsConstructorAttribute;

namespace Praebeunda.Simplicia
{
  [AllArgsConstructor(MemberTypes.Property, AccessType.Private)]
  public sealed partial class Lemma : Verbum<Lemma>, Pēnsābile<Lemma>
  {
    private readonly Func<Task<PēnsorĪnflectendīs?>> Pēnsor = async () => PēnsorĪnflectendīs.Relātor.Invoke(Catēgoria, Versiō).Value;
    public readonly Func<Task<Īnflectendum?>> Relātum = async () => (await Pēnsor.Invoke())?.PēnsorVerbālis.Invoke(Scrīptum);

    public readonly Enum? Versiō { get; }

    // TODO: convert Versiō from JsonElement
    public static readonly Func<JsonElement, Lemma> Lēctor = legendum =>
       new Lemma(legendum.GetProperty(nameof(Minūtal).ToLower()).GetInt32(),
                 Ēnumerātiōnēs.Catēgoriae.Dēfīnītor.Invoke(legendum.GetProperty(nameof(Catēgoria).ToLower())),
                 legendum.GetProperty(nameof(Scrīptum).ToLower()).GetString(),
                 Īnflexor.Versor.Invoke(legendum.GetProperty(nameof(Versiō).ToLower())));
  }
}
