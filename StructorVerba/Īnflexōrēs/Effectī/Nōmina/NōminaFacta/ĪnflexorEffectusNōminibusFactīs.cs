using System;
using System.Linq;
using System.Collections.Generic.SortedSet;

using Nūntiī.Nūntius;
using Miscella;
using Praebeunda.Īnflectendum;
using Ēnumerātiōnēs;
using Īnflexōrēs.Effectī.Āctūs.ĪnflexōrēsEffectusĀctibus.Versiō;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

namespace Īnfexōrēs.Effectī.Nōmina.NōminaFacta
{
  [AsyncOverloads]
  public abstract partial class ĪnflexorEffectusNōminibusFactīs : ĪnflexorEffectusNōminibus<Īnflectendum.NōmenFactum>
  {
    public enum Versiō
    {
      Nōmen_Prīmus = ĪnflexōrēsEffectusĀctibus.Versiō.Prīmus,
      Nōmen_Secundus = ĪnflexōrēsEffectusĀctibus.Versiō.Secundus,
      Nōmen_Tertius = ĪnflexōrēsEffectusĀctibus.Versiō.Tertius,
      Nōmen_Quārtus = ĪnflexōrēsEffectusĀctibus.Versiō.Quārtus
    }

    public static readonly Func<Versiō, Task<Lazy<ĪnflexorEffectusNōminibusFactīs?>>> Versor = async versiō => versiō switch
      {
        Versiō.Nōmen_Prīmus => null,
        Versiō.Nōmen_Secundus => null,
        Versiō.Nōmen_Tertius => null,
        Versiō.Nōmen_Quārtus => null,
        _ => new Lazy(null),
      };

    private readonly string SuffixumĪnfīnītīvum { get; }
    private readonly string ĪnfixumGerundīvum { get; }

    protected ĪnflexorEffectusNōminibusFactīs(in Versiō versiō, in Lazy<Nūntius<ĪnflexorEffectusNōminibusFactīs>> nūntius,
                                              in strin īnfīnītīvum, in string gerundīvum)
                                                 : base(versiō, nūntius, nameof(Īnflectendum.NōmenFactum.Īnfīnītum),
                                                        (nōmen, illa) =>
                                                        {
                                                          const Factum factum = Facta.Iactor.Invoke((from illud in illa
                                                                                                     where illud is Factum
                                                                                                     select illud).First());
                                                          const Casus casus = Casūs.Iactor.Invoke((from illud in illa
                                                                                                   where illud is Casus
                                                                                                   select illud).First());
                                                          return Factum.Supīnum.Equals(factum)
                                                                               .Choose(nōmen.Supīnum.Chop(2), nōmen.Īnfīnītīvum.Chop(3));
                                                        }, Ūtilitātēs.Colligō(Factum.Īnfīnītīvum.SingleItemSet(),
                                                           Ūtilitātēs.Combīnō(Factum.Gerundātīvum.SingleItemSet(),
                                                                              new SortedSet<Casus>() { Casus.Genitīvus, Casus.Datīvus, Casus.Accūsātīvus, Casus.Ablātīvus }),
                                                           Ūtilitātēs.Combīnō(Factum.Supīnum.SingleItemSet(),
                                                                              new SortedSet<Casus>() { Casus.Accūsātīvus, Casus.Ablātīvus })))
    {
      SuffixumĪnfīntītīvum = īnfīnītīvum;
      ĪnfixumGerundīvum = gerundīvum;
    }

    protected abstract string? Gerundīvum(in Casus casus);
    protected sealed string? Supīnum(in Casus casus)
                 => casus switch
                    {
                      Casus.Accusātīvus => "um",
                      Casus.Ablātīvus => "ū"
                    };

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
        (_, default(Casus)) => Task.CompletedTask,
        (Factum.Īnfīnītīvum, _) => SuffixumĪnfīnfītīvum,
        (Factum.Gerundīvum, _) => ĪnfixumGerundīvum.Concat(casus switch
        {
          Casus.Genitīvus => "ī",
          Casus.Accusātīvus => "um",
          Casus.Datīvus or Casus.Ablātīvus => "ō"
        }),
        (Factum.Supīnum, Casus.Accusātīvus) => "um",
        (Factum.Supīnum, Casus.Ablātīvus) => "ū"
      };
    }
  }
}
