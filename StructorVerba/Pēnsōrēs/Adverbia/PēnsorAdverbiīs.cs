using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;
using Pēnsōrēs.Pēnsor.Tabula;
using Īnflexōrēs.ĪnflexorAdverbiīs.Versiō;

namespace Pēnsōrēs.Adverbia
{
  public abstract partial class PēnsorAdverbiīs<Hoc> : PēnsorĪnflectendīs<Hoc, Multiplex.Adverbium>
  {
    private static readonly Func<Versiō, Tabula?> Tabulātor =
              versiō => versiō switch
            {
              Versiō.Exāctum => Tabula.Adverbia_Exācta,
              Versiō.Incomparātīvum => Tabula.Adverbia_Incomparātīvum,
              _ => null
            };

    public static readonly Func<Ēnumerātiōnēs.Catēgoria, Versiō, Lazy<PēnsorAdverbiīs?>> Relātor =
              versiō => versiō switch
            {
              Versiō.Exāctum => PēnsorAdverbiīsExāctīs.Faciendum,
              Versiō.Incomparātīvum => PēnsorAdverbiīsIncomparātīvīs.Faciendum,
              _ => new Lazy(null)
            };

    protected PēnsorAdverbiīs(in Versiō versiō, in string quaerendī,
                              in Lazy<Nūntius<PēnsorAdverbiīs<Hoc>>> nūntius,
                              in Func<JsonElement, Task<Hoc>> lēctor)
                                 : base(versiō, quaerendī, Tabulātor.Invoke(versiō), nūntius, lēctor) { }

  }
}
