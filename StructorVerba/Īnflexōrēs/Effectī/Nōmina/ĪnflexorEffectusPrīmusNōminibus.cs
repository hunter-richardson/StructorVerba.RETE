using System;

using Nūntiī.Nūntius;
using Miscella.Extensions;
using Ēnumerātiōnēs.Casus;
using Īnflexōrēs.Effectī.Nōmina.ĪnflexorEffectusNōminibus.Versiō;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Īnflexōrēs.Effectī.Nōmina
{
  [Lazy]
  [AsyncOverloads]
  public sealed partial class ĪnflexorEffectusPrīmusNōminibus : ĪnflexorEffectusNōminibus
  {
    private ĪnflexorEffectusPrīmusNōminibus()
        : base(new Lazy<Nūntius<ĪnflexorEffectusPrīmusNōminibus>>(),
               (nōmen, illa) => nōmen.Nōminātīvum.Chop(1))
        => Nūntius.PlūsGarriōAsync("Fīō");

    public sealed string Singulāre(in Casus casus) => casus switch
    {
      Casus.Nōminātīvus or Casus.Vocātīvus => "a",
      Casus.Genitīvus or Casus.Datīvus or Casus.Locātīvus => "ae",
      Casus.Accūsātīvus => "am",
      _ => "ā"
    };

    public sealed string Plūrāle(in Casus casus) => casus switch
    {
      Casus.Nōminātīvus or Casus.Vocātīvus => "ae",
      Casus.Genitīvus => "ārum",
      Casus.Accūsātīvus => "ās",
      _ => "īs"
    };
  }
}
