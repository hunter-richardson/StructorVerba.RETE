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
  public abstract partial class ĪnflexorEffectusNōminibusFactīs : ĪnflexorEffectusNōminibus<Īnflectendum.NōmenFactum>
  {
    public enum Versiō
    {
      Prīmus, Secundus, Tertius, Quārtus
    }

    public static readonly Func<Versiō, Task<Lazy<ĪnflexorEffectusNōminibusFactīs?>>> Versor = async versiō => versiō switch
      {
        Versiō.Prīmus => null,
        Versiō.Secundus => null,
        Versiō.Tertius => null,
        Versiō.Quārtus => null,
        _ => new Lazy(null),
      };

    protected ĪnflexorEffectusNōminibusFactīs(in Versiō versiō, in Lazy<Nūntius<ĪnflexorEffectusNōminibusFactīs>> nūntius,
                                              in Func<Īnflectendum.NōmenFactum, Enum[], string> rādīcātor)
                                                 : base(versiō, nūntius, nameof(Īnflectendum.NōmenFactum.Īnfīnītum), rādīcātor,
                                                        Ūtilitātēs.Colligō(Factum.Īnfīnītīvum.SingleItemSet(),
                                                        Ūtilitātēs.Combīnō(Factum.Gerundātīvum.SingleItemSet(),
                                                                           new SortedSet<Casus>() { Casus.Genitīvus, Casus.Datīvus, Casus.Accūsātīvus, Casus.Ablātīvus }),
                                                        Ūtilitātēs.Combīnō(Factum.Supīnum.SingleItemSet(),
                                                                           new SortedSet<Casus>() { Casus.Accūsātīvus, Casus.Ablātīvus }))) { }
    protected abstract string Īnfīnītīvum();
    protected abstract string? Gerundīvum(in Casus casus);
    protected abstract string? Supīnum(in Casus casus);
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
        var īnscītum when default(Factum).Equals(factum).Or(default(Casus).Equals(casus))
                                => Task.CompletedTask,
        (Factum.Īnfīnītīvum, _) => ĪnfīnfītīvumAsync(),
        (Factum.Gerundīvum, _) => GerundīvumAsync(casus),
        (Factum.Supīnum, _) => SupīnumAsync(casus)
      };
    }
  }
}
