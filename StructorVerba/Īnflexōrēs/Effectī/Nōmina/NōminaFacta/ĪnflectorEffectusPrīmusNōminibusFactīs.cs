using System;

using Nūntiī.Nūntius;
using Miscella.Extensions;
using Praebeunda.Īnflectendum;
using Īnflexōrēs.Effectī.Nōmina.ĪnflexorEffectusNōminibusFactīs.Versiō;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflectōrēs.Effectī.Nōmina.NōminaFacta
{
  [Singleton]
  public sealed partial class ĪnflexorEffectusPrīmusNōminibusFactīs : ĪnflexorEffectusNōminibusFactīs
  {
    public static readonly Lazy<ĪnflexorEffectusPrīmusNōminibusFactīs> Faciendum
                     = new Lazy<ĪnflexorEffectusPrīmusNōminibusFactīs>(() => Instance);
    private ĪnflectorEffectusPrīmusNōminibusFactīs()
        : base(NūntiusĪnflexōrīEffectōPrīmōNōminibusFactīs.Faciendum,
               "āre", "and") { }

    [Singleton]
    private sealed class NūntiusĪnflexōrīEffectōPrīmōNōminibusFactīs : Nūntius<ĪnflexorEffectusPrīmusNōminibusFactīs>
    {
      public static readonly Lazy<NūntiusĪnflexōrīEffectōPrīmōNōminibusFactīs> Faciendum
                       = new Lazy<NūntiusĪnflexōrīEffectōPrīmōNōminibusFactīs>(() => Instance);
    }
  }
}
