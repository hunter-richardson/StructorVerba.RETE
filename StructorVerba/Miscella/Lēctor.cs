using System;
using System.Collections.Generic.IEnumerable;
using System.Linq;

using Dictionāria;
using Pēnsōrēs;
using Praebeunda.Verbum;
using Praebeunda.Simplicia.Lemma;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.Property.Generators.LazyAttribute;
using BuilderGenerator.GenerateBuilderAttribute;

namespace Miscella
{
  [Lazy]
  [AsyncOverloads]
  public sealed partial class Lēctor
  {
    [GenerateBuilder]
    public sealed partial struct Percōlātūrum
    {
      public readonly string Quaerendum { get; }
      public readonly Catēgoria? Catēgoria { get; }
      public readonly Enum? Versiō { get; }

      private Percōlātūrum(in Catēgoria? catēgoria, in Enum? versiō, in string quaerendum = string.Empty)
      {
        Quaerendum = quaerendum;
        Catēgoria = catēgoria;
        Versiō = versiō;
      }
    }

    private readonly Lazy<PēnsorVerbīs> Lemmae = PēnsorVerbīs.Relātor.Invoke(true);
    private readonly Lazy<PēnsorVerbīs> Verba = PēnsorVerbīs.Relātor.Invoke(false);
    private readonly Lazy<Dictionārium> Āctūs = DictionāriumĀctibus.Lazy;
    private readonly Lazy<Dictionārium> Adiectīva = DictionāriumAdiectīvīs.Lazy;
    private readonly Lazy<Dictionārium> Nōmina = DictionāriumNōminibus.Lazy;
    private readonly Lazy<Dictionārium> Prōnōmina = DictionāriumPrōnōminibus.Lazy;
    private readonly Lazy<Nūntius> Nūntius = new Lazy<Nūntius<Lēctor>>();

    private readonly Func<Task<IEnumerable<Verbum>>> Omnia
        = async () => IEnumerable.Union(await Verba.Value.Omnia.Invoke(),
                                        await Lemmae.Value.Omnia.Invoke(),
                                        await Āctūs.Value.Lemmae.Invoke(),
                                        await Adiectīva.Value.Lemmae.Invoke(),
                                        await Nōmina.Value.Lemmae.Invoke(),
                                        await Prōnōmina.Value.Lemmae.Invoke());

    public IEnumerable<Verbum> Quaerō(in string quaerendum)
        => from verbum in await Omnia.Invoke()
           where (await Ūtilitātēs.ApicumAbditor.Invoke(verbum.Scrīptum))
                                  .Contains(await Ūtilitātēs.ApicumAbditor.Invoke(quaerendum),
                                            StringComparison.OrdinalIgnoreCase)
           select verbum;

    public IEnumerable<Verbum> Quaerō(in Catēgoria catēgoria)
        => from verbum in await Omnia.Invoke()
           where verbum.Catēgoria is catēgoria
           select verbum;

    public IEnumerable<Verbum> Quaerō(in string quaerendum, in Catēgoria catēgoria)
        => from verbum in await QuaerōAsync(quaerendum: quaerendum)
           where verbum.Catēgoria is catēgoria
           select verbum;

    public IEnumerable<Lemma> Quaerō(in string quaerendum, in Catēgoria catēgoria, in Enum versiō)
        => from verbum in await QuaerōAsync(quaerendum: quaerendum, catēgoria: catēgoria)
           where verbum is Lemma
           from lemma in verbum.Cast<Lemma>()
           where lemma.Versiō is versiō
           select lemma;

    public IEnumerable<Lemma> Quaerō(in Catēgoria catēgoria, in Enum versiō)
        => from verbum in await QuaerōAsync(catēgoria: catēgoria)
           where verbum is Lemma
           from lemma in verbum.Cast<Lemma>()
           where lemma.Catēgoria is catēgoria
           where lemma.Versiō is versiō
           select lemma;

    public IEnumerable<Verbum> Quaerō(in Percōlātūrum percōlātūrum)
    {
      return (string.IsNullOrWhiteSpace(percōlātūrum.Quaerendum),
              percōlātūrum.Catēgoria is null,
              percōlātūrum.Versiō is null) switch
              {
                (true, true, _) => Omnia.Invoke(),
                (false, true, true) => Quaerō(quaerendum: percōlātūrum.Quaerendum),
                (true, false, true) => Quaerō(catēgoria: percōlātūrum.Catēgoria),
                (false, false, true) => Quaerō(quaerendum: percōlātūrum.Quaerendum,
                                               catēgoria: percōlātūrum.Catēgoria),
                (true, false, false) => Quaerō(catēgoria: percōlātūrum.Catēgoria,
                                               versiō: percōlātūrum.Versiō),
                (false, false, false) => Quaerō(quaerendum: percōlātūrum.Quaerendum,
                                                catēgoria: percōlātūrum.Catēgoria,
                                                versiō: percōlātūrum.Versiō)
              };
    }

    public Verbum? Inveniam(in string quaerendum, in Catēgoria catēgoria)
        => (from verbum in await Omnia.Invoke()
            where string.Equals(verbum.Scrīptum, quaerendum, StringComparison.OrdinalIgnoreCase)
            where verbum.Catēgoria is catēgoria
            select verbum).FirstOrDefault();

    public Verbum Inveniam(in string quaerendum, in Catēgoria catēgoria, in Enum[] illa)
        => Catēgoria.Īnflexa.Choose(await (await InveniamAsync(quaerendum: quaerendum, catēgoria: catēgoria))?.Īnflexor.Invoke(illa),
                                           await InveniamAsync(quaerendum: quaerendum, catēgoria: catēgoria));

    public Verbum ForsInveniat(in Catēgoria catēgoria)
    {
      const Verbum verbum = await (await QuaerōAsync(catēgoria: catēgoria)).Random();
      return Catēgoria.Īnflexa.Choose(await verbum.FortisĪnflexor.Invoke(), verbum);
    }

    public Verbum ForsInveniat()
        => await ForsInveniatAsync(catēgoria: Catēgoria.GetValues().Except(Catēgoria.Numerus).Random());
  }
}
