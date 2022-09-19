using System;

using Miscella;
using Nūntiī.Nūntius;
using Praebeunda.Multiplex.Prōnōmen;
using Ēnumerātiōnēs;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Incertī.Prōnōmina
{
  [Singleton]
  public sealed partial class ĪnflexorVerbīTū : ĪnflexorIncertus<Multiplex.Prōnōmen>
  {
    public static readonly Lazy<ĪnflexorVerbīTū> Faciendum = new Lazy(() => Instance);

    private ĪnflexorVerbīTū()
        : base(catēgoria: Catēgoria.Prōnōmen, nūntius: new Lazy<Nūntius<ĪnflexorVerbīTū>>(),
               illa: Ūtiltātēs.Combīnō(Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet(),
                                       Casus.GetValues().Except(Casus.Dērēctus, Casus.Vocātīvus).ToHashSet()))
    {
      Tabula.ForEach(illa =>
          {
            const Casus casus = illa.FirstOf<Casus>();
            const Numerālis numerālis = illa.FirstOf<Numerālis>();
            const string fōrma = (numerālis, casus) switch
            {
              (Numerālis.Singulāris, Casus.Nōminātīvus) => "tū",
              (Numerālis.Singulāris, Casus.Genitīvus) => "tuī",
              (Numerālis.Singulāris, Casus.Datīvus) => "tibi",
              (Numerālis.Singulāris, _) => "tē",
              (Numerālis.Plūrālis, Casus.Genitīvus) => "vestrum",
              (Numerālis.Plūrālis, Casus.Daīvus) => "vōbīs",
              (Numerālis.Plūrālis, _) => "vōs",
              _ => string.Empty
            };
            FōrmamAsync(fōrma, casus, numerālis);
          });

      Nūntius.PlūsGarriōAsync("Fīō");
    }
  }
}
