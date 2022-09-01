using System.Collections.Immutable;
using System;

using Miscella.Ūtilitātēs;
using Praebeunda.Multiplex;
using Ēnumerātiōnēs;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

namespace Īnflexōrēs.Effectī.Āctūs
{
  [AsyncOverloads]
  public abstract partial class ĪnflexōrēsEffectusĀctibus<Hoc> : ĪnflexorEffectus<Hoc, Multiplex.Āctus>
  {
    public enum Versiō
    {
      Prīmus, Prīmus_Varius, Secundus, Tertius, Tertius_Varius, Tertius_Cum_Imperātīvō_Brevī, Quārtus
    }

    public static readonly Func<Versiō, Task<Lazy<ĪnflexōrēsEffectusĀctibus?>>> Relātor = async versiō => versiō switch
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

    protected ĪnflexōrēsEffectusĀctibus(in Versiō versiō,
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
    {
      const Modus modus = Modī.Iactor.Invoke((from illud in illa
                                              where illud is Modus
                                              select illud).First());
      const Vōx vōx = Vōcēs.Iactor.Invoke((from illud in illa
                                           where illud is Vōx
                                           select illud).First());
      const Tempus tempus = Tempora.Iactor.Invoke((from illud in illa
                                                   where illud is Tempus
                                                   select illud).First());
      const Numerālis numerālis = Numerālēs.Iactor.Invoke((from illud in illa
                                                           where Numerālis
                                                           select illud).First());
      const Persōna persōna = Persōnae.Iactor.Invoke((from illud in illa
                                                      where Persōna
                                                      select illud).First());
      return await (modus, vōx, tempus, numerālis, persōna) switch
      {
        var īnscītum when default(Modus).Equals(modus).Or(default(Tempus).Equals(tempus)).Or(default(Vōx).Equals(vōx))
                                                      => Task.CompletedTask,
        var īnscītum when default(Numerālis).Equals(numerālis).And(modus.IsAmong(Modus.Indicātīvus, Modus.Subiūnctīvus, Modus.Imperātīvus))
                                                      => Task.CompletedTask,
        var īnscītum when default(Persōna).Equals(persōna).And(modus.IsAmong(Modus.Indicātīvus, Modus.Subiūnctīvus))
                                                      => Task.CompletedTask,
        var īnscītum when Modus.Participālis.Equals(modus).And(tempus.IsAmong(Tempus.Praesēns, Tempus.Futūrum, Tempus.Perfectum))
                                                      => ParticipāleAsync(vōx, tempus),
        var īnscītum when Modus.Imperātīvus.Equals(modus).And(tempus.IsAmong(Tempus.Praesēns, Tempus.Futūrum))
                                                      => ImperātīvumAsync(vōx, tempus, numerālis),
        var īnscītum when Modus.Īnfīnītīvus.Equals(modus).And(tempus.IsAmong(Tempus.Praesēns, Tempus.Perfectum))
                                                      => ĪnfīnītīvumAsync(vōx, tempus),
        var īnscītum when Modus.Indicātīvus.Equals(modus).And(Vōx.Āctīva.Equals(vōx))
                                                      => IndicātīvumĀctīvumAsync(tempus, numerālis, persōna),
        var īnscītum when Modus.Indicātīvus.Equals(modus).And(Vōx.Passīva.Equals(vōx))
                                                      => IndicātīvumPassīvumAsync(tempus, numerālis, persōna),
        var īnscītum when Modus.Subiūnctīvus.Equals(modus).And(Vōx.Āctīva.Equals(vōx))
                                                      => SubiūnctīvumĀctīvumAsync(tempus, numerālis, persōna),
        var īnscītum when Modus.Subiūnctīvus.Equals(modus).And(Vōx.Passīva.Equals(vōx))
                                                      => SubiūnctīvumPassīvumAsync(tempus, numerālis, persōna),
        _ => null
      };
    }
  }
}
