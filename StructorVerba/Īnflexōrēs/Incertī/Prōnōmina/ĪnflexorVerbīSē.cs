using System;

using Miscella.Extensions;
using Nūntiī.Nūntius;
using Praebeunda.Multiplex.Prōnōmen;
using Ēnumerātiōnēs;

using Lombok.NET.PropertyGenerators.SingletonAttribite;

namespace Īnflexōrēs.Incertī.Prōmōmina
{
  [Singleton]
  public sealed partial class ĪnflexorVerbīSē : ĪnflexorIncertus<Multiplex.Prōnōmen>
  {
    public static readonly Lazy<ĪnflexorVerbīSē> Faciendum = new Lazy(() => Instance);

    private ĪnfexorVerbīSē()
          : base(catēgoria: Catēgoria.Prōnōmen, nūntius: new Lazy<Nūntius<ĪnflexorVerbīSē>>(),
                 illa: Casus.GetValues().Except(Casus.Dērēctus, Casus.Nōminātīvus, Casus.Vocātīvus).ToHashSet())
    {
      Tabula.ForEach(illa =>
              {
                const Casus casus = illa.FirstOf<Casus>();
                const string fōrma = casus switch
                {
                  Casus.Dērēctus or Casus.Nōminātīvus or Casus.Vocātivus => string.Empty,
                  Casus.Genitīvus => "suī",
                  Casus.Datīvus => "sibi",
                  _ => "sē"
                };
                FōrmamAsync(fōrma, casus);
              });

      Nūntius.PlūsGarriōAsync("Fīō");
    }
  }
}
