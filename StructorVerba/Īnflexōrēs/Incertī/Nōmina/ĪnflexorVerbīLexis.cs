using System;

using Miscella;
using Nūntiī.Nuntius;
using Praebeunda.Multiplex.Nōmen;
using Praebeunda.Īnflectendum.Nōmen;
using Ēnumerātiōnēs;
using Īnflexōrēs.Effectī.Nōmen;

using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Īnflexōrēs.Incertī.Nōmina
{
  [Lazy]
  public sealed partial class ĪnflexorVerbīLexis : ĪnflexorIncertus<Īnflectendum.Nōmen, Multiplex.Nōmen>
  {
    private ĪnflexorVerbīLexis()
        : base(Catēgoria.Nōmen, new Lazy<Nūntius<ĪnflexorVerbīLexis>>(),
               Casus.Nōminātīvus, Casus.Genitīvus, Casus.Accūsātīvus)
    {
      FōrmamAsync("lexis", Casus.Nōminātīvus);
      FōrmamAsync("lexeōs", Casus.Genitīvus);
      FōrmamAsync("lexis", Casus.Accūsātīvus);
      Nūntius.PlūsGarriōAsync("Fīō");
    }
  }
}
