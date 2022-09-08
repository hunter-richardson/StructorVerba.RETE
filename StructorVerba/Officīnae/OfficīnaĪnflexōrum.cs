using System;
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
           = new Lazy(() => new OfficīnaĪnflexōrum<Multiplex.Āctus>(Catēgoria.Āctus));
    public static readonly Lazy<OfficīnaĪnflexōrum<Multiplex.Adiectīvum>> Adiectīvātor
           = new Lazy(() => new OfficīnaĪnflexōrum<Multiplex.Adiectīvum>(Catēgoria.Adiectīvum));
    public static readonly Lazy<OfficīnaĪnflexōrum<Multiplex.Adverbium>> Adverbiātor
           = new Lazy(() => new OfficīnaĪnflexōrum<Multiplex.Adverbium>(Catēgoria.Adverbium));
    public static readonly Lazy<OfficīnaĪnflexōrum<Multiplex.Nōmen>> Nōminātor
           = new Lazy(() => new OfficīnaĪnflexōrum<Multiplex.Nōmen>(Catēgoria.Nōmen));
    public static readonly Lazy<OfficīnaĪnflexōrum<Multiplex.Numerāmen>> Numerātor
           = new Lazy(() => new OfficīnaĪnflexōrum<Multiplex.Numerāmen>(Catēgoria.Numerāmen));
    public static readonly Lazy<OfficīnaĪnflexōrum<Multiplex.Prōnōmen>> Prōnōminātor
           = new Lazy(() => new OfficīnaĪnflexōrum<Multiplex.Prōnōmen>(Catēgoria.Prōnōmen));

    private readonly Nūntius nūntius = new Nūntius<OfficīnaĪnflexōrum>();

    private readonly OfficīnaPēnsābilium<Hoc> Relātum { get; }
    private readonly Dictionārium<Hoc>? Dictionārium { get; }
    public readonly Func<string, Enum[], Task<Hoc?>> Inventor
        = async (lemma, illa) => Ūtilitātēs.Seriēs(await Dictionārium?.FeramĪnflectemqueAsync(lemma, illa),
                                                   (await (await Relātum.Inventor.Invoke(lemma))
                                                            ?.Relātor.Invoke())?.ĪnflectemAsync(illa))
                                           .FirstNonNull();

    public readonly Func<string, Task<Hoc?>> FortisĪnflexor
        = async lemma => Ūtilitātēs.Seriēs(await Dictionārium?.ĪnflexōrīFortisFeramAsync(lemma),
                                           (await (await Relātum.Inventor.Invoke(lemma))
                                                       ?.Relātor.Invoke())?.FortisĪnflexor.Invoke())
                                   .FirstNonNull();

    public readonly Func<Task<Hoc?>> FortisInventor
        = async () => Ūtilitātēs.Seriēs(await Dictionārium?.ForsFeratĪnflectetqueAsync(),
                                        (await (await Relātum.FortisInventor.Invoke())
                                                    ?.Relator.Invoke())?.FortisĪnflexor.Invoke())
                                .FirstNonNull();

    private OfficīnaĪnflexōrum(in Catēgoria? catēgoria)
    {
      Relātum = OfficīnaPēnsābilium.Officīnātor.Invoke(catēgoria).Value;
      Dictionārium = Dictionārium.Lēctor.Invoke(catēgoria).Value;
    }
  }
}
