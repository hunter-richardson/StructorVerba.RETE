using System.Threading.Tasks;
using System;

using Miscella;
using Nūntiī.Nuntius;
using Praebeunda.Multiplex.Nōmen;
using Praebeunda.Īnflectendum.Nōmen;
using Ēnumerātiōnēs;
using Īnflexōrēs.Effectī.Nōmen;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Incertī.Nōmina
{
  [Singleton]
  public sealed partial class ĪnflexorVerbīSapphō : ĪnflexorIncertus<Īnflectendum.Nōmen, Multiplex.Nōmen>
  {
    public static readonly Lazy<ĪnflexorVerbīSapphō> Faciendum = new Lazy(() => Instance);
    private ĪnflexorVerbīSapphō()
        : base(Catēgoria.Nōmen, new Lazy<Nūntius<ĪnflexorVerbīSapphō>>(),
               Casus.GetValues().Except(Casus.Dērēctus, Casus.Datīvus))
    => Tabula.ForEach(illa =>
        {
          const Task<string> suffixum = illa.FirstOf<Casus>() switch
          {
            Casus.Genitīvus => ĪnflexorEffectusQuārtusNōminibus.Faciendum.Value.SuffixumAsync(casus, Numerālis.Singulāris),
            _ => ĪnflexorEffectusSecundusNeuterNōminibus.Faciendum.Value.SuffixumAsync(Casus.Ablātīvus, Numerālis.Singulāris)
          };
          FōrmamAsync("Sapph".Concat(await suffixum), illa);
        });
  }
}
