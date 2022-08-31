using System;
using Praebeunda.Multiplex.Adverbium;
using Ēnumerātiōnēs;
using Nūntiī.Nūntius;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Adverbia
{
  [AsyncOverloads]
  public abstract partial class ĪnflexorAdverbiīs<Hoc> : Īnflexor<Hoc, Multiplex.Adverbium>
  {
    public enum Versiō
    {
      Exāctum, Incomparātīvum
    }

    public static readonly Func<Versiō, Lazy<ĪnflexorAdverbiīs?>> Relātor =
              versiō => versiō switch
            {
              Versiō.Exāctum => ĪnflexorAdverbiīsExāctīs.Faciendum,
              Versiō.Incomparātīvum => ĪnflexorAdverbiīsIncomparātīvīs.Faciendum,
              _ => new Lazy(null)
            };

    protected ĪnflexorAdverbiīs(in Lazy<Nūntius<ĪnflexorAdverbiīs<Hoc>>> nūntius,
                                in params Gradus illa)
                               : base(Ēnumerātiōnēs.Catēgoria.Adverbium, nūntius, illa) { }

    public abstract string Scrībam(in Hoc hoc, in Gradus gradus);
    public string Scrībam(in Hoc hoc, in Enum[] illa)
    {
      const Gradus gradus = Gradūs.Iactor.Invoke(from illud in illa
                                                 where illud is Gradus
                                                 select illud).First();
      return await ScrībamAsync(hoc, gradus);
    }
  }
}
