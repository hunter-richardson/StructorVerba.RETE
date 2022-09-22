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

    private readonly Lazy<PēnsorLemmīs> Lemmae = PēnsorLemmīs.Faciendum;
    private readonly Lazy<PēnsorVerbīs> Verba = PēnsorVerbīs.Faciendum;
    private readonly Lazy<Dictionārium> Āctūs = DictionāriumĀctibus.Faciendum;
    private readonly Lazy<Dictionārium> Adiectīva = DictionāriumAdiectīvīs.Faciendum;
    private readonly Lazy<Dictionārium> Nōmina = DictionāriumNōminibus.Faciendum;
    private readonly Lazy<Dictionārium> Prōnōmina = DictionāriumPrōnōminibus.Faciendum;
    private readonly Lazy<Nūntius> Nūntius = new Lazy<Nūntius<Lēctor>>();

    private readonly Func<Task<IEnumerable<(string, Catēgoria)>>> Omnia
        = async () => IEnumerable.Union(from verbum in IEnumerable.Union(await Verba.Value.Omnia.Invoke(),
                                                                         await Lemmae.Value.Omnia.Invoke())
                                        select (verbum.Scrīptum, verbum.Catēgoria),
                                        from valōrēs in IEnumerable.Union(await Āctūs.Value.Lemmae.Invoke(),
                                                                          await Adiectīva.Value.Lemmae.Invoke(),
                                                                          await Nōmina.Value.Lemmae.Invoke(),
                                                                          await Prōnōmina.Value.Lemmae.Invoke())
                                        select valōrēs);

    public IEnumerable<(string, Catēgoria)> Quaerō(in string quaerendum)
        => from valōrēs in await Omnia.Invoke()
           where (await Ūtilitātēs.ApicumAbditor.Invoke(valōrēs.Item1))
                                  .Contains(await Ūtilitātēs.ApicumAbditor.Invoke(quaerendum),
                                            StringComparison.OrdinalIgnoreCase)
           select valōrēs;

    public IEnumerable<(string, Catēgoria)> Quaerō(in string quaerendum, in Catēgoria catēgoria)
        => from verbum in await QuaerōAsync(quaerendum: quaerendum)
           where verbum.Item2 is catēgoria
           select verbum;
  }
}
