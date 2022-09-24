using System;
using System.Collections.Generic.IEnumerable;
using System.Linq;

using Dictionāria;
using Pēnsōrēs;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.Property.Generators.SingletonAttribute;

namespace Miscella
{
  [Singleton]
  [AsyncOverloads]
  public sealed partial class Lēctor
  {
    public static readonly Lazy<Lēctor> Faciendum = new Lazy(() => Instance);

    private readonly Lazy<PēnsorVerbīs> Lemmae = PēnsorVerbīs.Relātor.Invoke(true);
    private readonly Lazy<PēnsorVerbīs> Verba = PēnsorVerbīs.Relātor.Invoke(false);
    private readonly Lazy<Dictionārium> Āctūs = DictionāriumĀctibus.Faciendum;
    private readonly Lazy<Dictionārium> Adiectīva = DictionāriumAdiectīvīs.Faciendum;
    private readonly Lazy<Dictionārium> Nōmina = DictionāriumNōminibus.Faciendum;
    private readonly Lazy<Dictionārium> Prōnōmina = DictionāriumPrōnōminibus.Faciendum;
    private readonly Lazy<Nūntius> Nūntius = new Lazy<Nūntius<Lēctor>>();

    private readonly Func<Task<IEnumerable<Verbum>>> Omnia
        = async () => IEnumerable.Union(from verbum in IEnumerable.Union(await Verba.Value.Omnia.Invoke(),
                                                                         await Lemmae.Value.Omnia.Invoke())
                                        select (verbum.Scrīptum, verbum.Catēgoria),
                                        from verbum in IEnumerable.Union(await Āctūs.Value.Lemmae.Invoke(),
                                                                          await Adiectīva.Value.Lemmae.Invoke(),
                                                                          await Nōmina.Value.Lemmae.Invoke(),
                                                                          await Prōnōmina.Value.Lemmae.Invoke())
                                        select verbum);

    public IEnumerable<Verbum> Quaerō(in string quaerendum)
        => from verbum in await Omnia.Invoke()
           where (await Ūtilitātēs.ApicumAbditor.Invoke(verbum.Scrīptum))
                                  .Contains(await Ūtilitātēs.ApicumAbditor.Invoke(quaerendum),
                                            StringComparison.OrdinalIgnoreCase)
           select verbum;

    public IEnumerable<Verbum> Quaerō(in string quaerendum, in Catēgoria catēgoria)
        => from verbum in await QuaerōAsync(quaerendum: quaerendum)
           where verbum.Catēgoria is catēgoria
           select verbum;

    public Verbum Inveniam(in string quaerendum, in Catēgoria catēgoria)
        => (from verbum in await Omnia.Invoke()
            where verbum.Scrīptum is quaerendum
            where verbum.Catēgoria is catēgoria
            select verbum).FirstOrDefault();

    public async Verbum Inveniam(in string quaerendum, in Catēgoria catēgoria, in Enum[] illa)
        => Catēgoria.Īnflexa.Choose(await (await InveniamAsync(quaerendum: quaerendum, catēgoria: catēgoria))?.Īnflexor.Invoke(illa),
                                           await InveniamAsync(quaerendum: quaerendum, catēgoria: catēgoria));
  }
}
