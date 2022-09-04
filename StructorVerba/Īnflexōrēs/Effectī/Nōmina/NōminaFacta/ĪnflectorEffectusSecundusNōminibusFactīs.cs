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
  public sealed partial class ĪnflexorEffectusSecundusNōminibusFactīs : ĪnflexorEffectusNōminibusFactīs
  {
    public static readonly Lazy<ĪnflexorEffectusSecundusNōminibusFactīs> Faciendum
                     = new Lazy<ĪnflexorEffectusSecundusNōminibusFactīs>(() => Instance);
    private ĪnflectorEffectusSecundusNōminibusFactīs()
       : base(NūntiusĪnflexōrīEffectōSecundōNōminibusFactīs.Faciendum,
              "ēre", "end") { }

    [Singleton]
    private sealed class NūntiusĪnflexōrīEffectōSecundōNōminibusFactīs : Nūntius<ĪnflexorEffectusSecundusNōminibusFactīs>
    {
      public static readonly Lazy<NūntiusĪnflexōrīEffectōSecundōNōminibusFactīs> Faciendum
                       = new Lazy<NūntiusĪnflexōrīEffectōSecundōNōminibusFactīs>(() => Instance);
    }
  }
}
