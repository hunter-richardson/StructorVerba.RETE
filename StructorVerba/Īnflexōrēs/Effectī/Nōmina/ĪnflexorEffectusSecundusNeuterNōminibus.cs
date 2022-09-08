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
  public sealed partial class ĪnflexorEffectusSecundusNeuterNōminibus : ĪnflexorEffectusNōminibus
  {
    public static readonly Lazy<ĪnflexorEffectusSecundusNeuterNōminibus> Faciendum = new Lazy(() => Instance);
    private ĪnflexorEffectusSecundusNeuterNōminibus()
        : base(new Lazy<Nūntius<ĪnflexorEffectusSecundusNeuterNōminibus>>(),
               (nōmen, illa) => nōmen.Nōminātīvum.Chop(2)) { }

    public sealed string Singulāre(in Casus casus) => casus switch
    {
      Casus.Nōminātīvus or Casus.Accūsātīvus or Casus.Vocātīvus => "um",
      Casus.Genitīvus => "ī",
      _ => "ō"
    };

    public sealed string Plūrāle(in Casus casus) => casus switch
    {
      Casus.Nōminātīvus or Casus.Accūsātīvus or Casus.Vocātīvus => "a",
      Casus.Genitīvus => "ōrum",
      _ => "īs"
    };
  }
}
