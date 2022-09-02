using System;

using Nūntiī.Nūntius;
using Miscella.Extensions;
using Praebeunda.Īnflectendum;
using Īnflexōrēs.Effectī.Nōmina.ĪnflexorEffectusNōminibusFactīs.Versiō;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflectōrēs.Effectī.Nōmina.NōminaFacta
{
  [Singleton]
  [AsyncOverloads]
  public sealed partial class ĪnflexorEffectusTertiusNōminibusFactīs : ĪnflexorEffectusNōminibusFactīs
  {
    public static readonly Lazy<ĪnflexorEffectusTertiusNōminibusFactīs> Faciendum
                     = new Lazy<ĪnflexorEffectusTertiusNōminibusFactīs>(() => Instance);
    private ĪnflectorEffectusTertiusNōminibusFactīs()
        : base(Versiō.Nōmen_Factum_Tertium,
               NūntiusĪnflexōrīEffectōTertiōNōminibusFactīs.Faciendum,
               "ere", "end") { }

    [Singleton]
    private sealed class NūntiusĪnflexōrīEffectōTertiōNōminibusFactīs : Nūntius<ĪnflexorEffectusTertiusNōminibusFactīs>
    {
      public static readonly Lazy<NūntiusĪnflexōrīEffectōTertiōNōminibusFactīs> Faciendum
                       = new Lazy<NūntiusĪnflexōrīEffectōTertiōNōminibusFactīs>(() => Instance);
    }
  }
}
