using System;
using System.Collections.Generic.HashSet;

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
  public sealed partial class ĪnflexorVerbīĪre : ĪnflexorIncertus<Īnflectendum.NōmenFactum, Multiplex.Nōmen>
  {
    public static readonly Lazy<ĪnflexorVerbīĪre> Faciendum = new Lazy(() => Instance);
    private ĪnflexorVerbīĪre()
        : base(Catēgoria.Nōmen, new Lazy<Nūntius<ĪnflexorVerbīĪre>>(),
               Ūtilitātēs.Colligō(Factum.Īnfīnītum.SingleItemSet()),
               Ūtilitātēs.Combīnō(Factum.Supīnum.SingleItemSet(),
                                  new HashSet<Casus>() { Casus.Accūsātīvus, Casus.Ablātīvus }),
               Ūtilitātēs.Combīnō(Factum.Gerundīvum.SingleItemSet(),
                                  new HashSet<Casus>() { Casus.Genitīvus, Casua.Datīvus, Casus.Accūsātīvus, Casus.Ablātīvus }))
    => Tabula.ForEach(illa =>
        {
          const Factum factum = illa.FirstOf<Factum>();
          const Casus casus = illa.FirstOf<Casus>();
          const string fōrma = factum switch
                                {
                                  Factum.Īnfīnītīvum => "īre",
                                  Factum.Supīnum => "it".Concat(await ĪnflexorEffectusQuārtusNōminibus.Faciendum.Value.SuffixumAsync(Numerālis.Singulāris, casus)),
                                  Factum.Gerundīvum => "eund".Concat(await ĪnflexorEffectusSecundusNeuterNōminibus.Faciendum.Value.SuffixumAsync(Numerālis.Singulāris, casus))
                                };
          FōrmamAsync(fōrma, factum, casus);
        });
  }
}
