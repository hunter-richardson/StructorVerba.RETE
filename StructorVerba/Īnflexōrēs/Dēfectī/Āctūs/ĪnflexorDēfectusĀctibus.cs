using System;
using System.Collections.Generic.IEnumerable;

using Nūntiī.Nūntius;
using Praebeunda.Multiplex;
using Ēnumerātiōnēs.Catēgoria;
using Īnflexōrēs.Effectī.Āctūs.ĪnflexorEffectusĀctibus;

namespace Īnflexōrēs.Dēfectī.Āctūs
{
  public abstract class ĪnflexorDēfectusĀctibus : ĪnflexorDēfectus<Īnflectendum.Āctus, Multiplex.Āctus>
  {
    public static readonly Func<Enum, Lazy<Īnflexor?>> Relātor =
            async versiō => versiō switch
            {
              var īnscītum when versiō.ToString().EndsWith("_Dēpōnēns")
                                                 => ĪnflexorDēpōnēnsĀctibus.Relātor.Invoke(versiō),
              var īnscītum when versiō.ToString().EndsWith("_Semidēpōnēns")
                                                => ĪnflexorSemidēpōnēnsĀctibus.Relātor.Invoke(versiō),
              var īnscītum when versiō.ToString().EndsWith("_Impersōnālis")
                                                => ĪnflexorImpersōnālisĀctibus.Relātor.Invoke(versiō),
              var īnscītum when versiō.ToString().EndsWith("_Impersōnālis_Semidēpōnēns")
                                                => ĪnflexorImpersōnālisSemidēpōnēnsĀctibus.Relātor.Invoke(versiō),
              var īnscītum when versiō.ToString().EndsWith("_Impersōnālis_Semidēpōnēns_Imperfectus")
                                                => ĪnflexorImpersōnālisSemidēpōnēnsImperfectusĀctibus.Relātor.Invoke(versiō),
              var īnscītum when versiō.ToString().EndsWith("_Impersōnālis_Perfectō")
                                                => ĪnflexorImpersōnālisPerfectōĀctibus.Relātor.Invoke(versiō),
              _ => new Lazy(null)
            };
    protected ĪnflexorDēfectusĀctibus(in Lazy<Nūntius<ĪnflexorDēfectusĀctibus>> nūntius,
                                      in Lazy<ĪnflexorEffectusĀctibus> relātus)
                                             : base(catēgoria: Catēgoria.Āctus, nūntius: nūntius, relātus: relātus) { }
  }
}
