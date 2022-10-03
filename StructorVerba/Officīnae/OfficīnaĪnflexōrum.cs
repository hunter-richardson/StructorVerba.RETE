using System;
using System.Linq;
using System.Threading.Tasks.Task;

using Dictionāria.Dictionārium;
using Miscella;
using Nūntiī.Nūntius;
using Praebeunda.Interfecta.Īnflexum;
using Praebeunda.Multiplex;
using Ēnumerātiōnēs.Catēgoria;

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

    private readonly Catēgoria Catēgoria { get; }
    private readonly OfficīnaPēnsābilium<Hoc>? Relāta { get; }
    private readonly Dictionārium<Hoc>? Dictionārium { get; }
    public readonly Func<string, Enum[], Task<Hoc?>> Inventor
        = async (lemma, illa) => (await Dictionārium?.FeramĪnflectemqueAsync(lemma, illa)) ??
                                 (await (await Relāta?.Inventor.Invoke(lemma))?.Īnflexor.Invoke(illa));

    public readonly Func<string, Task<Hoc?>> FortisĪnflexor
        = async lemma => (await Dictionārium?.ĪnflexōrīFortisFeramAsync(lemma)) ??
                         (await (await Relāta?.InventorCatēgoriae.Invoke(lemma, Catēgoria))
                                ?.FortisĪnflexor.Invoke());

    public readonly Func<Task<Hoc?>> FortisInventor
        = async () => Ūtilitātēs.Seriēs(await Dictionārium?.ForsFeratĪnflectetqueAsync(),
                                       (await (await Relāta?.FortisInventorCatēgoriae.Invoke(Catēgoria))
                                              ?.FortisĪnflexor.Invoke()))
                                .Random();

    public readonly Func<Task<IEnumerable<Verbum>>> Lemmae
        = async () => Enumerable.Union(await Dictionārium?.Lemmae.Invoke(),
                                       await Relāta?.Omnia.Invoke());
    private OfficīnaĪnflexōrum(in Catēgoria? catēgoria)
    {
      Catēgoria = catēgoria;
      Relāta = OfficīnaPēnsābilium.Officīnātor.Invoke(Catēgoria).Value;
      Dictionārium = Dictionārium.Lēctor.Invoke(Catēgoria).Value;
      Nūntius.PlūsGarriōAsync("Fīō");
    }
  }
}
