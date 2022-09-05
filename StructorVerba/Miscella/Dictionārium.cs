using System;
using System.Collections.Generic.IEnumerable;
using System.Threading.Tasks.Task;

using Miscella.Extensions;
using Nūntiī.Nūntius;
using Praebeunda.Interfecta.Īnflexum;
using Praebeunda.Multiplex;
using Ēnumerātiōnēs.Catēgora;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Miscella
{
  public sealed class Dictionārium<Hoc> where Hoc : Īnflexum<Hoc>
  {
    private static readonly Lazy<Dictionārium<Multiplex.Āctus>> Āctūs
            = new Lazy(() => new Dictionārium<Multiplex.Āctus>(Catēgoria.Āctus));
    private static readonly Lazy<Dictionārium<Multiplex.Adiectīvum>> Adiectīva
            = new Lazy(() => new Dictionārium<Multiplex.Adiectīvum>(Catēgoria.Adiectīvum));
    private static readonly Lazy<Dictionārium<Multiplex.Nōmen>> Nōmina
            = new Lazy(() => new Dictionārium<Multiplex.Nōmen>(Catēgoria.Nōmen));
    private static readonly Lazy<Dictionārium<Multiplex.Prōnōmen>> Prōnōmina
            = new Lazy(() => new Dictionārium<Multiplex.Prōnōmen>(Catēgoria.Prōnōmen));

    public static readonly Func<Catēgoria, Lazy<Dictionārium>> Lēctor
            = catēgoria => catēgoria switch
                          {
                            Catēgoria.Āctus => Āctūs,
                            Catēgoria.Adiectīvum => Adiectīva,
                            Catēgoria.Nōmen => Nōmina,
                            Catēgoria.Prōnōmen => Prōnōmina,
                            _ => new Lazy(null)
                          };

    private readonly string? Locus { get; }
    private readonly NūntiusDictionāriō nūntius = NūntiusDictionāriō.Faciendum;

    private readonly Task<IEnumerable<Type?>> Classificātor
          = async () => from illud in Assembly.GetExecutingAssembly().GetTypes()
                        where string.Equals(illud.Namespace, Locus, StringComparison.Ordinal)
                        select illd;

    public readonly IEnumerable<string> Lemmātor
          = () => from istud in (await Classificātor.Invoke())
                  select istud.Name?.RemoveStart("ĪnflexorVerbī").ToLower();

    private readonly Func<string, Task<Type?>> Lātor
          = async lemma => (from istud in (await Classificātor.Invoke())
                            where string.Equals(istud?.Name, "ĪnflexorVerbī".Concat(lemma.Capitalize()), StringComparison.Ordinal)
                            select istud).First();

    public readonly Func<string, Enum[], Task<Hoc?>> Īnflexor
          = async (lemma, illa) => (await Lātor.Invoke(lemma))
                                      ?.GetProperty("Faciendum")?.GetMethod
                                      ?.Invoke().Value.Īnflectem(illa);

    public readonly Func<string, Task<Hoc?>> FortisĪnflexor
          = async lemma => (await Lātor.Invoke(lemma))
                              ?.GetProperty("Faciendum")?.GetMethod
                              ?.Invoke().Value.FortisĪnflexor.Invoke();

    public readonly Func<Task<Hoc?>> FortisInventor
          = async () => (await Classificātor.Invoke()).Random()
                            ?.GetProperty("Faciendum")?.GetMethod
                            ?.Invoke().Value.FortisĪnflexor.Invoke();

    protected Dictionārium(in Catēgoria catēgoria)
    {
      const string? loculus = catēgoria switch
                              {
                                Catēgoria.Āctus => "Āctibus",
                                Catēgoria.Adiectīva => "Adiectīvs",
                                Catēgoria.Nōmen => "Nōmina",
                                Catēgoria.Prōnōmen => "Prōnōmina",
                                _ => null
                              };
      Locus = (loculus is not null)
      .Choose("Īnflexōrēs.Incertī.".Concat(loculus), null);
    }

    [Singleton]
    private sealed partial class NūntiusDictionāriō : Nūntius<Dictionārium>
    {
      public static readonly Lazy<NūntiusDictionāriō> Faciendum = new Lazy<NūntiusDictionāriō>(() => Instance);
    }
  }
}
