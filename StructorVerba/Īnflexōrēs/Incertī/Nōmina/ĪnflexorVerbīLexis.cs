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
  public sealed partial class ĪnflexorVerbīLexis : ĪnflexorIncertus<Īnflectendum.Nōmen, Multiplex.Nōmen>
  {
    public static readonly Lazy<ĪnflexorVerbīLexis> Faciendum = new Lazy<ĪnflexorVerbīLexis>(() => Instance);
    private ĪnflexorVerbīLexis()
        : base(Catēgoria.Nōmen, new Lazy<Nūntius<ĪnflexorVerbīLexis>>(() => new Nūntius<ĪnflexorVerbīLexis>()),
               Casus.Nominātīvus, Casus.Genitīvus, Casus.Accūsātīvus)
    {
      FōrmamAsync("lexis", Casus.Nominātīvus);
      FōrmamAsync("lexeōs", Casus.Genitīvus);
      FōrmamAsync("lexis", Casus.Accūsātīvus);
    }
  }
}
