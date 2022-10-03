using System;
using System.Collections.Generic.HashSet;
using System.Collections.Immutable;
using System.Threading.Tasks.Task;

using Miscella;
using Praebeunda.Multiplex;
using Praebeunda.Īnflectendum;
using Pēnsōrēs.Īnflectenda.PēnsorĀctibus.Versio;
using Ēnumerātiōnēs;
using Īnflexōrēs.Effectī;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

namespace Īnflexōrēs.Effectī.Āctūs
{
  [AsyncOverloads]
  public abstract partial class ĪnflexorEffectusĀctibus : ĪnflexorEffectus<Īnflectendum.Āctus, Multiplex.Āctus>
  {
    public static readonly Func<PēnsorĀctibus.Versiō, Task<Lazy<ĪnflexorEffectusĀctibus?>>> Relātor
              = async versiō => versiō switch
                                {
                                  PēnsorĀctibus.Versiō.Prīmus => ĪnflexorEffectusPrīmusĀctibus.Lazy,
                                  PēnsorĀctibus.Versiō.Prīmus_Varius => ĪnflexorEffectusPrīmusVariusĀctibus.Lazy,
                                  PēnsorĀctibus.Versiō.Secundus => ĪnflexorEffectusSecundusĀctibus.Lazy,
                                  PēnsorĀctibus.Versiō.Tertius => ĪnflexorEffectusTertiusĀctibus.Lazy,
                                  PēnsorĀctibus.Versiō.Tertius_Varius => ĪnflexorEffectusTertiusVariusĀctibus.Lazy,
                                  PēnsorĀctibus.Versiō.Tertius_Cum_Imperātīvō_Brevī => ĪnflexorEffectusTertiusĀctibusCumImperātīvōBrevī.Lazy,
                                  PēnsorĀctibus.Versiō.Quārtus => ĪnflexorEffectusQuārtusĀctibus.Lazy,
                                  _ => new Lazy(null)
                                };

    protected ĪnflexorEffectusĀctibus(in Lazy<Nūntius<ĪnflexōrēsEffectusĀctibus<Hoc>>> nūntius)
                                                                                : base(nūntius, nameof(Īnflectendum.ĀctusEffectus.Īnfīnītīvum),
                                                                                       (āctus, illa) => (illa.FirstOf<Modus>(), illa.FirstOf<Vōx>(), illa.FirstOf<Tempus>()) switch
                                                                                       {
                                                                                         var īnscītum when (modus is default(Modus)) || (tempus is default(Tempus)) || (vōx is default(Vōx))
                                                                                                                          => string.Empty,
                                                                                         (Modus.Participāle, Vōx.Passīva, Tempus.Futūrum) => āctus.Supīnum.Chop(2),
                                                                                         (Modus.Participāle, _, Tempus.Perfectum) => āctus.Supīnum.Chop(2),
                                                                                         (_, _, Tempus.Perfectum or Tempus.Plūsquamperfectum or Tempus.Futūrum_Exāctum)
                                                                                                                          => āctus.Perfectum.Chop(4),
                                                                                         _ => āctus.Īnfīnītīvum.Chop(3),
                                                                                       }, Ūtilitātēs.Colligō(Modus.Īnfīnītīvus, Tempus.Perfectum),
                                                                                          Ūtilitātēs.Combīnō(Modus.Īnfīnītīvus.SingleItemSet(), Tempus.Praesēns.SingleItemSet(),
                                                                                                             Vōx.GetValues().Except(default(Vōx))).ToHashSet(),
                                                                                          Ūtilitātēs.Combīnō(Modus.Imperātīvus.SingleItemSet(),
                                                                                                             new HashSet<Tempus>() { Tempus.Praesēns, Tempus.Perfectum },
                                                                                                             Vōx.GetValues().Except(default(Vōx)).ToHashSet(),
                                                                                                             Numerālis.GetValues().Except(default(Numerālis)).ToHashSet()),
                                                                                          Ūtilitātēs.Combīnō(Modus.Participālis.SingleItemSet(),
                                                                                                             new HashSet<Tempus>() { Tempus.Praesēns, Tempus.Perfectum }),
                                                                                          Ūtilitātēs.Combīnō(Modus.Participālis.SingleItemSet(), Tempus.Futūrum.SingleItemSet(),
                                                                                                             Vōx.GetValues().Except(default(Vōx)).ToHashSet()),
                                                                                          Ūtilitātēs.Combīnō(new HashSet<Modus>() { Modus.Indicātīvus, Modus.Subiūnctīvus },
                                                                                                             Vōx.GetValues().Except(default(Vōx)).ToHashSet(),
                                                                                                             Tempus.GetValues().Except(default(Tempus)).ToHashSet(),
                                                                                                             Numerālis.GetValues().Except(default(Numerālis)).ToHashSet(),
                                                                                                             Persōna.GetValues().Except(default(Persōna)).ToHashSet())
                                                                                                    .Except(illa => Ūtilitātēs.Ūlla(illa.ContainsAll(Modus.Subiūnctīvus, Tempus.Futūrum),
                                                                                                                                    illa.ContainsAll(Modus.Subiūnctīvus, Tempus.FutūrumExāctum)))) { }

    public abstract string? IndicātīvumĀctīvum(in Tempus tempus, in Numerālis numerālis, in Persōna persōna);
    public abstract string? IndicātīvumPassīvum(in Tempus tempus, in Numerālis numerālis, in Persōna persōna);
    public abstract string? SubiūnctīvumĀctīvum(in Tempus tempus, in Numerālis numerālis, in Persōna persōna);
    public abstract string? SubiūnctīvumPassīvum(in Tempus tempus, in Numerālis numerālis, in Persōna persōna);
    public abstract string? Imperātīvum(in Vōx vōx, in Tempus tempus, in Numerālis numerālis);
    public abstract string? Īnfīnītīvum(in Vōx vōx, in Tempus tempus);
    public abstract string? Participāle(in Vōx vōx, in Tempus tempus);

    public sealed string? Suffixum(in Enum[] illa)
              => await Suffixum(illa.FirstOf<Modus>(), illa.FirstOf<Vōx>(), illa.FirstOf<Tempus>(),
                                illa.FirstOf<Numerālis>(), illa.FirstOf<Persōna>());

    protected virtual string? Suffixum(in Modus modus, in Vōx vōx, in Tempus tempus, in Numerālis numerālis, in Persōna persōna)
              => await (modus, vōx, tempus, numerālis, persōna) switch
                        {
                          var īnscītum when Ūtilitātēs.Ūlla(modus is default(Modus), tempus is default(Tempus), vōx is default(Vōx))
                                                                        => Task.FromResult<string?>(null),
                          var īnscītum when Ūtilitātēs.Omnia(numerālis is default(Numerālis), modus is Modus.Indicātīvus or Modus.Subiūnctīvus or Modus.Imperātīvus)
                                                                        => Task.FromResult<string?>(null),
                          var īnscītum when Ūtilitātēs.Omnia(persōna is default(Persōna), modus is Modus.Indicātīvus or Modus.Subiūnctīvus)
                                                                        => Task.FromResult<string?>(null),
                          var īnscītum when Ūtilitātēs.Omnia(modus is Modus.Participālis, tempus is Tempus.Praesēns or Tempus.Futūrum or Tempus.Perfectum)
                                                                        => ParticipāleAsync(vōx, tempus),
                          var īnscītum when Ūtilitātēs.Omnia(modus is Modus.Imperātīvus, tempus is Tempus.Praesēns or Tempus.Futūrum)
                                                                        => ImperātīvumAsync(vōx, tempus, numerālis),
                          var īnscītum when Ūtilitātēs.Omnia(modus is Modus.Īnfīnītīvus, tempus is Tempus.Praesēns or Tempus.Perfectum)
                                                                        => ĪnfīnītīvumAsync(vōx, tempus),
                          var īnscītum when Ūtilitātēs.Omnia(modus is Modus.Indicātīvus, vōx is Vōx.Āctīva)
                                                                        => IndicātīvumĀctīvumAsync(tempus, numerālis, persōna),
                          var īnscītum when Ūtilitātēs.Omnia(modus is Modus.Indicātīvus, vōx is Vōx.Passīva)
                                                                        => IndicātīvumPassīvumAsync(tempus, numerālis, persōna),
                          var īnscītum when Ūtilitātēs.Omnia(modus is Modus.Subiūnctīvus, vōx is Vōx.Āctīva)
                                                                        => SubiūnctīvumĀctīvumAsync(tempus, numerālis, persōna),
                          var īnscītum when Ūtilitātēs.Omnia(modus is Modus.Subiūnctīvus, vōx is Vōx.Passīva)
                                                                        => SubiūnctīvumPassīvumAsync(tempus, numerālis, persōna),
                          _ => null
                        };
  }
}
