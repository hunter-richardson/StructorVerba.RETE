using System;
using System.Collections.Immutable;
using System.Threading.Tasks.Task;

using Miscella.Ūtilitātēs;
using Praebeunda.Multiplex;
using Ēnumerātiōnēs;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

namespace Īnflexōrēs.Effectī.Āctūs
{
  [AsyncOverloads]
  public abstract partial class ĪnflexorEffectusĀctibus<Hoc> : ĪnflexorEffectus<Hoc, Multiplex.Āctus>
  {
    public enum Versiō
    {
      Prīmus, Prīmus_Varius, Secundus, Tertius, Tertius_Varius, Tertius_Cum_Imperātīvō_Brevī, Quārtus
    }

    public static readonly Func<Versiō, Task<Lazy<ĪnflexorEffectusĀctibus?>>> Relātor = async versiō => versiō switch
    {
      Versiō.Prīmus => null,
      Versiō.Prīmus_Varius => null,
      Versiō.Secundus => null,
      Versiō.Tertius => null,
      Versiō.Tertius_Varius => null,
      Versiō.Tertius_Cum_Imperātīvō_Brevī => null,
      Versiō.Quārtus => null,
      _ => new Lazy(null)
    };

    private static readonly IEnumerable<Enum[]>[] Praegenerāta
                = Ūtilitātēs.Seriēs(Ūtilitātēs.Colligō(Modus.Īnfīnītīvus, Tempus.Perfectum),
                                    Ūtilitātēs.Combīnō(Modus.Īnfīnītīvus.SingleItemSet(), Tempus.Praesēns.SingleItemSet(),
                                                       Vōx.GetValues().Except(default(Vōx))).ToHashSet(),
                                    Ūtilitātēs.Combīnō(Modus.Imperātīvus.SingleItemSet(),
                                                       new SortedSet<Tempus>() { Tempus.Praesēns, Tempus.Perfectum },
                                                       Vōx.GetValues().Except(default(Vōx)).ToHashSet(),
                                                       Numerālis.GetValues().Except(default(Numerālis)).ToHashSet()),
                                    Ūtilitātēs.Combīnō(Modus.Participālis.SingleItemSet(),
                                                       new SortedSet<Tempus>() { Tempus.Praesēns, Tempus.Perfectum }),
                                    Ūtilitātēs.Combīnō(Modus.Participālis.SingleItemSet(), Tempus.Futūrum.SingleItemSet(),
                                                       Vōx.GetValues().Except(default(Vōx)).ToHashSet()),
                                    Ūtilitātēs.Combīnō(new SortedSet<Modus>() { Modus.Indicātīvus, Modus.Subiūnctīvus },
                                                       Vōx.GetValues().Except(default(Vōx)).ToHashSet(),
                                                       Tempus.GetValues().Except(default(Tempus)).ToHashSet(),
                                                       Numerālis.GetValues().Except(default(Numerālis)).ToHashSet(),
                                                       Persōna.GetValues().Except(default(Persōna)).ToHashSet())
                                              .Except(illa => Ūtilitātēs.Ūlla(illa.ContainsAll(Modus.Subiūnctīvus, Tempus.Futūrum),
                                                                              illa.ContainsAll(Modus.Subiūnctīvus, Tempus.FutūrumExāctum))));

    protected ĪnflexorEffectusĀctibus(in Versiō versiō,
                                      in Lazy<Nūntius<ĪnflexōrēsEffectusĀctibus<Hoc>>> nūntius,
                                      in string quaerendī, in Func<Hoc, Enum[], string> rādīcātor,
                                      in params IEnumerable<Enum[]> illa)
                                         : base(versiō, nūntius, quaerendī, rādīcātor, Praegenerāta) { }

    public abstract string? IndicātīvumĀctīvum(in Tempus tempus, in Numerālis numerālis, in Persōna persōna);
    public abstract string? IndicātīvumPassīvum(in Tempus tempus, in Numerālis numerālis, in Persōna persōna);
    public abstract string? SubiūnctīvumĀctīvum(in Tempus tempus, in Numerālis numerālis, in Persōna persōna);
    public abstract string? SubiūnctīvumPassīvum(in Tempus tempus, in Numerālis numerālis, in Persōna persōna);
    public abstract string? Imperātīvum(in Vōx vōx, in Tempus tempus, in Numerālis numerālis);
    public abstract string? Īnfīnītīvum(in Vōx vōx, in Tempus tempus);
    public abstract string? Participāle(in Vōx vōx, in Tempus tempus);
    public sealed string? Suffixum(in Enum[] illa)
              => await(illa.FirstOf<Modus>(), illa.FirstOf<Vōx>(), illa.FirstOf<Tempus>(),
                       illa.FirstOf<Numerālis>(), illa.FirstOf<Persōna>()) switch
              {
                var īnscītum when (modus is default(Modus)) || (tempus is default(Tempus)) || (vōx is default(Vōx))
                                                              => Task.FromResult<string?>(null),
                var īnscītum when (numerālis is default(Numerālis)) && (modus is Modus.Indicātīvus or Modus.Subiūnctīvus or Modus.Imperātīvus)
                                                              => Task.FromResult<string?>(null),
                var īnscītum when (persōna is default(Persōna)) && (modus is Modus.Indicātīvus or Modus.Subiūnctīvus)
                                                              => Task.FromResult<string?>(null),
                var īnscītum when (modus is Modus.Participālis) && (tempus is Tempus.Praesēns or Tempus.Futūrum or Tempus.Perfectum)
                                                              => ParticipāleAsync(vōx, tempus),
                var īnscītum when (modus is Modus.Imperātīvus) && (tempus is Tempus.Praesēns or Tempus.Futūrum)
                                                              => ImperātīvumAsync(vōx, tempus, numerālis),
                var īnscītum when (modus is Modus.Īnfīnītīvus) && (tempus is Tempus.Praesēns or Tempus.Perfectum)
                                                              => ĪnfīnītīvumAsync(vōx, tempus),
                var īnscītum when (modus is Modus.Indicātīvus) && (vōx is Vōx.Āctīva)
                                                              => IndicātīvumĀctīvumAsync(tempus, numerālis, persōna),
                var īnscītum when (modus is Modus.Indicātīvus) && (vōx is Vōx.Passīva)
                                                              => IndicātīvumPassīvumAsync(tempus, numerālis, persōna),
                var īnscītum when (modus is Modus.Subiūnctīvus) && (vōx is Vōx.Āctīva)
                                                              => SubiūnctīvumĀctīvumAsync(tempus, numerālis, persōna),
                var īnscītum when (modus is Modus.Subiūnctīvus) && (vōx is Vōx.Passīva)
                                                              => SubiūnctīvumPassīvumAsync(tempus, numerālis, persōna),
                _ => null
              };
  }
}
