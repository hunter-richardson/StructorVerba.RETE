using System;

using Miscella;
using Nūntiī.Nūntius;
using Praebeunda.Multiplex.Prōnōmen;
using Ēnumerātiōnēs;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Incertī.Prōnōmina
{
  [Singleton]
  public sealed partial class ĪnflexorVerbīEgo : ĪnflexorIncertus<Multiplex.Prōnōmen>
  {
    public static readonly Lazy<ĪnflexorVerbīEgo> Faciendum = new Lazy(() => Instance);

    private ĪnflexorVerbīEgo()
          : base(Catēgoria.Prōnōmen, new Lazy<Nūntius<ĪnflexorVerbīEgo>>(),
                 Ūtiltātēs.Combīnō(Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet(),
                 Casus.GetValues().Except(Casus.Dērēctus, Casus.Vocātīvus).ToHashSet()))
          => Tabula.ForEach(illa =>
            {
              const Casus casus = illa.FirstOf<Casus>();
              const Numerālis numerālis = illa.FirstOf<Numerālis>();
              const string fōrma = (numerālis, casus) switch
              {
                (Numerālis.Singulāris, Casus.Nōminātīvus) => "ego",
                (Numerālis.Singulāris, Casus.Genitīvus) => "meī",
                (Numerālis.Singulāris, Casus.Datīvus) => "mihi",
                (Numerālis.Singulāris, _) => "mē",
                (Numerālis.Plūrālis, Casus.Genitīvus) => "nostrum",
                (Numerālis.Plūrālis, Casus.Daīvus) => "nōbīs",
                (Numerālis.Plūrālis, _) => "nōs",
                _ => string.Empty
              };
              FōrmamAsync(fōrma, casus, numerālis);
            });
  }
}
