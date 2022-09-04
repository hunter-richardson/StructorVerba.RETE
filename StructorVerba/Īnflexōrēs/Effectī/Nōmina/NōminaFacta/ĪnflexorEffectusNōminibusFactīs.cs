using System;
using System.Linq;
using System.Collections.Generic.SortedSet;

using Nūntiī.Nūntius;
using Miscella;
using Praebeunda.Īnflectendum;
using Pēnsōrēs.Nōmina.PēnsorNōminibusFactīs.Versiō;
using Ēnumerātiōnēs;
using Īnflexōrēs.Effectī.Āctūs.ĪnflexōrēsEffectusĀctibus.Versiō;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

namespace Īnfexōrēs.Effectī.Nōmina.NōminaFacta
{
  [AsyncOverloads]
  public abstract partial class ĪnflexorEffectusNōminibusFactīs : ĪnflexorEffectusNōminibus<Īnflectendum.NōmenFactum>
  {
    public static readonly Func<PēnsorNōminibusFactīs.Versiō, Task<Lazy<ĪnflexorEffectusNōminibusFactīs?>>> Relātor = async versiō => versiō switch
      {
        Versiō.Nōmen_Factum_Prīmum => ĪnflexorEffectusPrīmusNōminibusFactīs.Faciendum,
        Versiō.Nōmen_Factum_Secundum => ĪnflexorEffectusSecundusNōminibusFactīs.Faciendum,
        Versiō.Nōmen_Factum_Tertium => ĪnflexorEffectusTertiusNōminibusFactīs.Faciendum,
        Versiō.Nōmen_Factum_Quārtum => ĪnflexorEffectusQuārtusNōminibusFactīs.Faciendum,
        _ => new Lazy(null),
      };

    private readonly string SuffixumĪnfīnītīvum { get; }
    private readonly string ĪnfixumGerundīvum { get; }

    protected ĪnflexorEffectusNōminibusFactīs(in Lazy<Nūntius<ĪnflexorEffectusNōminibusFactīs>> nūntius,
                                              in string īnfīnītīvum, in string gerundīvum)
                                                                       : base(versiō, nūntius, nameof(Īnflectendum.NōmenFactum.Īnfīnītum),
                                                                              (nōmen, illa) =>  Factum.Supīnum.Equals(illa.FirstOf<Factum>())
                                                                                                              .Choose(nōmen.Supīnum.Chop(2), nōmen.Īnfīnītīvum.Chop(3)),
                                                                              Ūtilitātēs.Colligō(Factum.Īnfīnītīvum.SingleItemSet()),
                                                                              Ūtilitātēs.Combīnō(Factum.Gerundātīvum.SingleItemSet(),
                                                                                                 new SortedSet<Casus>() { Casus.Genitīvus, Casus.Datīvus, Casus.Accūsātīvus, Casus.Ablātīvus }),
                                                                              Ūtilitātēs.Combīnō(Factum.Supīnum.SingleItemSet(),
                                                                                                 new SortedSet<Casus>() { Casus.Accūsātīvus, Casus.Ablātīvus }))
    {
      SuffixumĪnfīntītīvum = īnfīnītīvum;
      ĪnfixumGerundīvum = gerundīvum;
    }

    public sealed string? Suffixum(in Enum[] illa)
    {
      return (illa.FirstOf<Factum>(), illa.FirstOf<Casus>()) switch
      {
        (Factum.Īnfīnītīvum, _) => SuffixumĪnfīnfītīvum,
        (_, Casus.Genitīvus) => ĪnfixumGerundīvum.Concat("ī"),
        (_, Casus.Datīvus) => ĪnfixumGerundīvum.Concat("ō"),
        (Factum.Gerundīvum, Casus.Accusātīvus) => ĪnfixumGerundīvum.Concat("um"),
        (Factum.Gerundīvum, Casus.Ablātīvus) => ĪnfixumGerundīvum.Concat("ō"),
        (Factum.Supīnum, Casus.Accusātīvus) => "um",
        (Factum.Supīnum, Casus.Ablātīvus) => "ū",
        _ => null
      };
    }
  }
}
