using System;
using System.Reflection;
using System.Text.Json.JsonElement;
using System.Threading.Tasks.Task;

using Pēnsōrēs.PēnsorĪnflectendīs;
using Praebeunda.Īnflectendum;
using Ēnumerātiōnēs;

using BuilderGenerator.GenerateBuilderAttribute;
using Lombok.NET.ConstructorGenerators.AllArgsConstructorAttribute;

namespace Praebeunda.Simplicia
{
  [GenerateBuilder]
  [AllArgsConstructor(MemberTypes.Property, AccessType.Private)]
  public sealed partial class Lemma : Verbum<Lemma>, Pēnsābile<Lemma>
  {
    public static readonly Func<JsonElement, Lemma> Lēctor
              = legendum => Buidler.WithCatēgoria(Catēgoriae.Dēfīnītor.Invoke(legendum.GetProperty(Ēnumerātiōnēs.Catēgoriae.Columna())))
                                   .WithScrīptum(legendum.GetProperty(Pēnsor.NōmenātorColumnae.Invoke(nameof(Scrīptum))).GetString())
                                   .WithValor(PēnsorĪnflectendīs.Versor.Invoke(legendum.GetProperty(PēnsorĪnflectendīs.ColumnaVersiōnis).GetString()))
                                   .Build();

    private readonly Func<Task<PēnsorĪnflectendīs?>> Pēnsor
              = async () => PēnsorĪnflectendīs.Relātor.Invoke(Catēgoria, Versiō).Value;
    private readonly Func<Task<Īnflectendum?>> Relātum
              = async () => (await Pēnsor.Invoke())?.Pendam(quaerendum: Scrīptum);

    private readonly Func<Task<Verbum?>> Cōnstrūctor
              = async () => await (this.Catēgoria switch
                                  {
                                    Catēgoria.Adiectīvum => Multiplex.Adiectīvum.Cōnstrūctor,
                                    Catēgoria.Adverbium => Multiplex.Adverbium.Cōnstrūctor,
                                    Catēgoria.Nōmen => Multiplex.Nōmen.Cōnstrūctor,
                                    Catēgoria.Prōnōmen => Multiplex.Prōnōmen.Cōnstrūctor,
                                    _ => null
                                  })?.Invoke(Array.Empty, Scrīptum);

    public readonly Func<ISet<Enum[]>> Tabulātor = () => (await Relātum.Invoke()).Tabulātor.Invoke();

    public readonly Func<Enum[], Task<Verbum?>> Īnflexor = async () =>
    {
      const Īnflectendum? īnflectendum = await Relātum.Invoke();
      return await (īnflectendum is null ? Cōnstrūctor.Invoke()
                                         : īnflectendum.ĪnflectemAsync(illa));
    };

    public readonly Func<Enum[], Task<Verbum?>> FortisĪnflexor = async () =>
    {
      const Īnflectendum? īnflectendum = await Relātum.Invoke();
      return await (īnflectendum is null ? Cōnstrūctor.Invoke()
                                         : īnflectendum.FortisĪnflexor.Invoke());
    };

    public readonly Enum? Versiō { get; }

    public int CompareTo(Verbum aliud)
        => Catēgoria.Equals(aliud.Catēgoria)
                    .Choose(string.Equals(Scrīptum, aliud.Scrīptum, StringComparison.Ordinal)
                                  .Choose((Versiō is null)
                                              .Choose((aliud.Versiō is null).Choose(0, -1),
                                                      Versiō.CompareTo(aliud.Versiō)),
                                          string.CompareTo(Scrīptum, aliud.Scrīptum),
                            Catēgoria.CompareTo(aliud.Catēgoria)));
  }
}
