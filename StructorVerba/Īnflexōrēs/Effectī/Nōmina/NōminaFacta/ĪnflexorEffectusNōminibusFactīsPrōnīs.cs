using System;
using System.Linq;
using System.Collections.Generic.SortedSet;

using Nūntiī.Nūntius;
using Miscella;
using Praebeunda.Īnflectendum;
using Ēnumerātiōnēs;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

namespace Īnfexōrēs.Nōmina.NōminaFacta
{
  [AsyncOverloads]
  public abstract partial class ĪnflexorEffectusNōminibusFactīsPrōnīs : ĪnflexorEffectusNōminibus<Īnflectendum.NōmenFactumPrōnum>
  {
    public enum Versiō
    {
      Prīmus, Secundus, Tertius, Quārtus
    }

    public static readonly Func<Versiō, Task<Lazy<ĪnflexorEffectusNōminibusFactīsPrōnīs?>>> Versor = async versiō => versiō switch
      {
        Versiō.Prīmus => null,
        Versiō.Secundus => null,
        Versiō.Tertius => null,
        Versiō.Quārtus => null,
        _ => new Lazy(null),
      };

    protected ĪnflexorEffectusNōminibusFactīsPrōnīs(in ĪnflexorNumerāmibus.Versiō versiō, in Lazy<Nūntius<ĪnflexorEffectusNōminibusFactīsPrōnīs>> nūntius,
                                                    in Func<Īnflectendum.NōmenFactumPrōnum, Enum[], string> rādīcātor)
                                                                           : base(versiō, nūntius, nameof(Īnflectendum.NōmenFactumPrōnum.Īnfīnītum), rādīcātor,
                                                                                  Ūtilitātēs.Colligō(Factum.Īnfīnītīvum.SingleItemSet(),
                                                                                  Ūtilitātēs.Combīnō(Factum.Gerundātīvum.SingleItemSet(),
                                                                                                     new SortedSet<Casus>() { Casus.Genitīvus, Casus.Datīvus, Casus.Accūsātīvus, Casus.Ablātīvus }))) { }
    protected abstract string Īnfīnītīvum();
    protected abstract string? Gerundīvum(in Casus casus);
    public sealed string? Suffixum(in Enum[] illa)
    {
      const Factum factum = Facta.Iactor.Invoke((from illud in illa
                                                 where illud is Factum
                                                 select illud).First());
      const Casus casus = Casūs.Iactor.Invoke((from illud in illa
                                               where illud is Casus
                                               select illud).First());
      return await (factum, casus) switch
      {
        var īnscītum when factum.IsAmong(Factum.Nūllum, Factum.Supīnum).Or(default(Casus).Equals(casus))
                                => Task.CompletedTask,
        (Factum.Īnfīnītīvum, _) => ĪnfīnfītīvumAsync(),
        (Factum.Gerundīvum, _) => GerundīvumAsync(casus),
      };
    }
  }
}
