using System;

using Nūntiī.Nūntius;
using Miscella.Extensions;
using Ēnumerātiōnēs.Casus;
using Īnflexōrēs.Effectī.Nōmina.ĪnflexorEffectusNōminibus.Versiō;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Effectī.Nōmina
{
  [Singleton]
  [AsyncOverloads]
  public sealed partial class ĪnflexorEffectusPrīmusNōminibus : ĪnflexorEffectusNōminibus
  {
    public static readonly Lazy<ĪnflexorEffectusPrīmusNōminibus> Faciendum
                     = new Lazy<ĪnflexorEffectusPrīmusNōminibus>(() => Instance);
    private ĪnflexorEffectusPrīmusNōminibus()
        : base(new Lazy<Nūntius<ĪnflexorEffectusPrīmusNōminibus>>(() => new Nūntius<ĪnflexorEffectusPrīmusNōminibus>()),
               (nōmen, illa) => nōmen.Nominātīvum.Chop(1)) { }

    public sealed string Singulāre(in Casus casus) => casus switch
    {
      Casus.Nominātīvus or Casus.Vocātīvus => "a",
      Casus.Genitīvus or Casus.Datīvus or Casus.Locātīvus => "ae",
      Casus.Accusātīvus => "am",
      _ => "ā"
    };

    public sealed string Plūrāle(in Casus casus) => casus switch
    {
      Casus.Nominātīvus or Casus.Vocātīvus => "ae",
      Casus.Genitīvus => "ārum",
      Casus.Accusātīvus => "ās",
      _ => "īs"
    };
  }
}
