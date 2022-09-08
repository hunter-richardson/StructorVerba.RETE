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
  public sealed partial class ĪnflexorVerbīĒthos : ĪnflexorIncertus<Īnflectendum.Nōmen, Multiplex.Nōmen>
  {
    public static readonly Lazy<ĪnflexorVerbīĒthos> Faciendum = new Lazy(() => Instance);
    private ĪnflexorVerbīĒthos()
        : base(Catēgoria.Nōmen, new Lazy<Nūntius<ĪnflexorVerbīĒthos>>(),
               Ūtilitātēs.Combīnō(Casus.GetValues().Except(Casus.Dērēctus).ToHashSet(),
                                  Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet()))
    => Tabula.ForEach(illa =>
        {
          const Numerālis numerālis = illa.FirstOf<Numerālis>();
          const Casus casus = illa.FirstOf<Casus>();
          const string fōrma = (numerālis, casus) switch
                                {
                                  (Numerālis.Singulāris, Casus.Nōminātīvus or Casus.Vocātīvus) => "os",
                                  (Numerālis.Singulāris, Casus.Genitīvus or Casus.Accūsātīvus) => "eos",
                                  (Numerālis.Plūrālis, Casus.Nōminātīvus or Casus.Vocātīvus) => "ea",
                                  (Numerālis.Plūrālis, Casus.Genitīvus) => "ōn",
                                  (Numerālis.Plūrālis, Casus.Accūsātīvus) => "ōs",
                                  (Numerālis.Singulāris, _) => "ī",
                                  (Numerālis.Plūrālis, _) => "esī"
                                };
          FōrmamAsync("ēth".Concat(fōrma), numerālis, casus);
        });
  }
}
