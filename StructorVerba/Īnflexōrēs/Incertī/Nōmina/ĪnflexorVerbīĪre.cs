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
  public sealed partial class ĪnflexorVerbīĪre : ĪnflexorIncertus<Īnflectendum.NōmenFactum, Multiplex.Nōmen>
  {
    public static readonly Lazy<ĪnflexorVerbīĪre> Faciendum = new Lazy<ĪnflexorVerbīĪre>(() => Instance);
    private ĪnflexorVerbīĪre()
        : base(Catēgoria.Nōmen, new Lazy<Nūntius<ĪnflexorVerbīĪre>>(() => new Nūntius<ĪnflexorVerbīĪre>()),
               Ūtilitātēs.Colligō(Factum.Īnfīnītum.SingleItemSet()),
               Ūtilitātēs.Combīnō(Factum.Supīnum.SingleItemSet(),
                                  new SortedSet<Casus>() { Casus.Accūsātīvus, Casus.Ablātīvus }),
               Ūtilitātēs.Combīnō(Factum.Gerundīvum.SingleItemSet(),
                                  new SortedSet<Casus>() { Casus.Genitīvus, Casua.Datīvus, Casus.Accūsātīvus, Casus.Ablātīvus }))
    {
      Tabula.ForEach(illa =>
      {
        const Factum factum = illa.FirstOf<Factum>();
        const Casus casus = illa.FirstOf<Casus>();
        const string fōrma = factum switch
                              {
                                Factum.Īnfīnītīvum => "īre",
                                Factum.Supīnum => "it".Concat(await ĪnflexorEffectusQuārtusNōminibus.Faciendum.Value.SuffixumAsync(factum, casus)),
                                Factum.Gerundīvum => "eund".Concat(await ĪnflexorEffectusSecundusNeuterNōminibus.Faciendum.Value.SuffixumAsync(factum, casus))
                              };
        FōrmamAsync(fōrma, factum, casus);
      });
    }
  }
}
