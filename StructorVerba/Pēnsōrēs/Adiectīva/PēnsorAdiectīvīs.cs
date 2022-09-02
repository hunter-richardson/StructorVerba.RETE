using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;
using Pēnsōrēs.Pēnsor.Tabula;
using Īnflexōrēs.ĪnflexorNumerāmibus.Versiō;

namespace Pēnsōrēs.Adiectiva
{
  public abstract class PēnsorAdiectīvīs<Hoc> : PēnsorĪnflectendīs<Hoc, Multiplex.Adiectīvum>
  {
    private static readonly Func<ĪnflexorEffectusĀctibus.Versiō, Tabula?> Tabulātor =
              versiō => versiō switch
            {
              Versiō.Aut_Prīma_Aut_Secunda_Aut_Tertia or
              Versiō.Aut_Prīma_Aut_Secunda_Aut_Tertia_Cum_Litterā_E or
              Versiō.Aut_Prīma_Aut_Secunda_Aut_Tertia_Sine_Litterā_E or
              Versiō.Prōnōminālis or Versiō.Prōnōminālis_Varius
                        => Tabula.Adiectīva_Aut_Prīma_Aut_Secunda_Aut_Tertia,
              Versiō.Aut_Tertia_Aut_Prīma_Aut_Secunda or
              Versiō.Aut_Tertia_Aut_Prīma_Aut_Secunda_Cum_Genitīvō_Variō or
              Versiō.Aut_Tertia_Aut_Prīma_Aut_Secunda_Cum_Ablātīvō_Variō or
              Versiō.Aut_Tertia_Aut_Prīma_Aut_Secunda_Cum_Genitīvō_Ablātīvōque_Variō
                        => Tabula.Adiectīva_Aut_Tertia_Aut_Prīma_Aut_Secunda,
              _ => null
            };

    public static readonly Func<Ēnumerātiōnēs.Catēgoria, ĪnflexorEffectusĀctibus.Versiō, Lazy<PēnsorAdiectīvīs?>> Relātor =
              versiō => versiō switch
            {
              Versiō.Aut_Prīma_Aut_Secunda_Aut_Tertia => null,
              Versiō.Aut_Prīma_Aut_Secunda_Aut_Tertia_Cum_Litterā_E => null,
              Versiō.Aut_Prīma_Aut_Secunda_Aut_Tertia_Sine_Litterā_E => null,
              Versiō.Prōnōminālis => null,
              Versiō.Prōnōminālis_Varius => null,
              Versiō.Aut_Tertia_Aut_Prīma_Aut_Secunda => null,
              Versiō.Aut_Tertia_Aut_Prīma_Aut_Secunda_Cum_Genitīvō_Variō => null,
              Versiō.Aut_Tertia_Aut_Prīma_Aut_Secunda_Cum_Ablātīvō_Variō => null,
              Versiō.Aut_Tertia_Aut_Prīma_Aut_Secunda_Cum_Genitīvō_Ablātīvōque_Variō => null,
              _ => new Lazy(null)
            };

    protected PēnsorAdiectīvīs(in ĪnflexorEffectusĀctibus.Versiō versiō, in string quaerendī,
                                  in Lazy<Nūntius<PēnsorAdiectīvīs<Hoc>>> nūntius,
                                  in Func<JsonElement, Task<Hoc>> lēctor)
                                     : base(versiō, quaerendī, Tabulātor.Invoke(versiō), nūntius, lēctor) { }
  }
}
