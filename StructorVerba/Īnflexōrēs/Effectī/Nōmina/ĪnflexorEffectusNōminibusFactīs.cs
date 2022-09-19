using System;
using System.Collections.Generic.HashSet;
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
    private static readonly Lazy<ĪnflexorEffectusNōminibusFactīs> Prīmus = new Lazy(() => ĪnflexorEffectusNōminibusFactīs("āre", "and"));
    private static readonly Lazy<ĪnflexorEffectusNōminibusFactīs> Secundus = new Lazy(() => ĪnflexorEffectusNōminibusFactīs("ēre", "end"));
    private static readonly Lazy<ĪnflexorEffectusNōminibusFactīs> Tertius = new Lazy(() => ĪnflexorEffectusNōminibusFactīs("ere", "end"));
    private static readonly Lazy<ĪnflexorEffectusNōminibusFactīs> TertiusVarius = new Lazy(() => ĪnflexorEffectusNōminibusFactīs("ere", "iend"));
    private static readonly Lazy<ĪnflexorEffectusNōminibusFactīs> Quārtus = new Lazy(() => ĪnflexorEffectusNōminibusFactīs("īre", "iend"));

    public static readonly Func<PēnsorNōminibusFactīs.Versiō, Task<Lazy<ĪnflexorEffectusNōminibusFactīs?>>> Relātor
        = async versiō => versiō switch
                          {
                            Versiō.Nōmen_Factum_Prīmum => Prīmus,
                            Versiō.Nōmen_Factum_Secundum => Secundus,
                            Versiō.Nōmen_Factum_Tertium => Tertius,
                            Versiō.Nōmen_Factum_Tertium_Varium => TertiusVarius,
                            Versiō.Nōmen_Factum_Quārtum => Quārtus,
                            _ => new Lazy(null),
                          };

    private readonly string SuffixumĪnfīnītīvum { get; }
    private readonly string ĪnfixumGerundīvum { get; }

    protected ĪnflexorEffectusNōminibusFactīs(in string īnfīnītīvum, in string gerundīvum)
          : base(new Lazy<Nūntius<ĪnflexorEffectusNōminibusFactīs>>(),
                 nameof(Īnflectendum.NōmenFactum.Īnfīnītum),
                 (nōmen, illa) =>  Factum.Supīnum.Equals(illa.FirstOf<Factum>())
                                                 .Choose(nōmen.Supīnum.Chop(2), nōmen.Īnfīnītīvum.Chop(3)),
                 Ūtilitātēs.Colligō(Factum.Īnfīnītīvum.SingleItemSet()),
                 Ūtilitātēs.Combīnō(Factum.Gerundātīvum.SingleItemSet(),
                                    new HashSet<Casus>() { Casus.Genitīvus, Casus.Datīvus, Casus.Accūsātīvus, Casus.Ablātīvus }),
                 Ūtilitātēs.Combīnō(Factum.Supīnum.SingleItemSet(),
                                    new HashSet<Casus>() { Casus.Accūsātīvus, Casus.Ablātīvus }))
    {
      SuffixumĪnfīntītīvum = īnfīnītīvum;
      ĪnfixumGerundīvum = gerundīvum;
      Nūntius.PlūsGarriōAsync("Fīō");
    }

    public sealed string? Suffixum(in Enum[] illa)
    {
      return (illa.FirstOf<Factum>(), illa.FirstOf<Casus>()) switch
      {
        (Factum.Īnfīnītīvum, _) => SuffixumĪnfīnfītīvum,
        (_, Casus.Genitīvus or Casus.Datīvus) => ĪnfixumGerundīvum.Concat(await ĪnflexorEffectusQuārtusNōminibus.Faciendum.Value.SuffixumAsync(Numerālis.Singulāris, casus)),
        (Factum.Gerundīvum, _) => ĪnfixumGerundīvum.Concat(await ĪnflexorEffectusQuārtusNōminibus.Faciendum.Value.SuffixumAsync(Numerālis.Singulāris, casus)),
        (Factum.Supīnum, _) => await ĪnflexorEffectusSecundusNeuterNōminibus.Faciendum.Value.SuffixumAsync(Numerālis.Singulāris, casus),
        _ => null
      };
    }
  }
}
