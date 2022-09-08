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
  public sealed partial class ĪnflexorEffectusQuārtusNōminibus : ĪnflexorEffectusNōminibus
  {
    public static readonly Lazy<ĪnflexorEffectusQuārtusNōminibus> Faciendum = new Lazy(() => Instance);
    private ĪnflexorEffectusQuārtusNōminibus()
        : base(new Lazy<Nūntius<ĪnflexorEffectusQuārtusNōminibus>>(),
               (nōmen, illa) => nōmen.Nōminātīvum.Chop(2)) { }

    public sealed string Singulāre(in Casus casus) => casus switch
    {
      Casus.Nōminātīvus or Casus.Vocātīvus => "us",
      Casus.Genitīvus => "ūs",
      Casus.Datīvus => "uī",
      Casus.Accūsātīvus => "um",
      Casus.Locātīvus => "ī",
      _ => "ū"
    };

    public sealed string Plūrāle(in Casus casus) => casus switch
    {
      Casus.Nōminātīvus or Casus.Accūsātīvus or Casus.Vocātīvus => "ūs",
      Casus.Genitīvus => "uum",
      _ => "ibus"
    };
  }
}
