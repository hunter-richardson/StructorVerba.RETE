using System;
using System.Linq;
using System.Threading.Tasks.Task;

using Dictionāria.Dictionārium;
using Miscella;
using Nūntiī.Nūntius;
using Praebeunda.Interfecta.Īnflexum;
using Praebeunda.Multiplex;
using Ēnumerātiōnēs.Catēgoria;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Officīnae
{
  public sealed class OfficīnaĪnflexōrum<Hoc> where Hoc : Īnflexum<Hoc>
  {
    public static readonly Lazy<OfficīnaĪnflexōrum<Multiplex.Āctus>> Āctor
           = new Lazy(() => new OfficīnaĪnflexōrum<Multiplex.Āctus>(catēgoria: Catēgoria.Āctus));
    public static readonly Lazy<OfficīnaĪnflexōrum<Multiplex.Adiectīvum>> Adiectīvātor
           = new Lazy(() => new OfficīnaĪnflexōrum<Multiplex.Adiectīvum>(catēgoria: Catēgoria.Adiectīvum));
    public static readonly Lazy<OfficīnaĪnflexōrum<Multiplex.Adverbium>> Adverbiātor
           = new Lazy(() => new OfficīnaĪnflexōrum<Multiplex.Adverbium>(catēgoria: Catēgoria.Adverbium));
    public static readonly Lazy<OfficīnaĪnflexōrum<Multiplex.Nōmen>> Nōminātor
           = new Lazy(() => new OfficīnaĪnflexōrum<Multiplex.Nōmen>(catēgoria: Catēgoria.Nōmen));
    public static readonly Lazy<OfficīnaĪnflexōrum<Multiplex.Numerāmen>> Numerātor
           = new Lazy(() => new OfficīnaĪnflexōrum<Multiplex.Numerāmen>(catēgoria: Catēgoria.Numerāmen));
    public static readonly Lazy<OfficīnaĪnflexōrum<Multiplex.Prōnōmen>> Prōnōminātor
           = new Lazy(() => new OfficīnaĪnflexōrum<Multiplex.Prōnōmen>(catēgoria: Catēgoria.Prōnōmen));

    private readonly Nūntius nūntius = new Nūntius<OfficīnaĪnflexōrum>();

    private readonly OfficīnaPēnsābilium<Hoc>? Relāta { get; }
    private readonly Dictionārium<Hoc>? Dictionārium { get; }
    public readonly Func<string, Enum[], Task<Hoc?>> Inventor
        = async (lemma, illa) => (await Dictionārium?.FeramĪnflectemqueAsync(lemma, illa)) ??
                                 (await (await Relāta?.Inventor.Invoke(lemma))?.Īnflexor.Invoke(illa));

    public readonly Func<string, Enum[], Task<Hoc?>> InventorSineApicibus
        = async (lemma, illa) => (await Dictionārium?.SineApicibusFeramĪnflectemqueAsync(lemma, illa)) ??
                                 (await (await Relāta?.InventorSineApicibus.Invoke(lemma))?.Īnflexor.Invoke(illa));

    public readonly Func<string, Task<Hoc?>> FortisĪnflexor
        = async lemma => (await Dictionārium?.ĪnflexōrīFortisFeramAsync(lemma)) ??
                         (await (await Relāta?.Inventor.Invoke(lemma))
                                ?.FortisĪnflexor.Invoke());

    public readonly Func<string, Task<Hoc?>> FortisĪnflexorSineApicibus
        = async lemma => (await Dictionārium?.ĪnflexōrīFortisSineApicibusFeramAsync(lemma)) ??
                         (await (await Relāta?.InventorSineApicibus.Invoke(lemma))
                                ?.FortisĪnflexor.Invoke());

    public readonly Func<Task<Hoc?>> FortisInventor
        = async () => Ūtilitātēs.Seriēs(await Dictionārium?.ForsFeratĪnflectetqueAsync(),
                                       (await (await Relāta?.FortisInventor.Invoke())
                                              ?.FortisĪnflexor.Invoke()))
                                .Random();

    public readonly Func<Task<IEnumerable<string>>> Lemmae
        = async () => Enumerable.Union(await Dictionārium?.Lemmae.Invoke(),
                                       await Relāta?.Lemmae.Invoke());
    public readonly Func<Task<IEnumerable<string>>> LemmaeSineApicibus
        = async () => Enumerable.Union(await Dictionārium?.LemmaeSineApicibus.Invoke(),
                                       await Relāta?.LemmaeSineApicibus.Invoke());

    private OfficīnaĪnflexōrum(in Catēgoria? catēgoria)
    {
      Relāta = OfficīnaPēnsābilium.Officīnātor.Invoke(catēgoria).Value;
      Dictionārium = Dictionārium.Lēctor.Invoke(catēgoria).Value;
      Nūntius.PlūsGarriōAsync("Fīō");
    }
  }
}
