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
  public sealed partial class ĪnflexorEffectusQuārtusNōminibusFactīs : ĪnflexorEffectusNōminibusFactīs
  {
    public static readonly Lazy<ĪnflexorEffectusQuārtusNōminibusFactīs> Faciendum
                     = new Lazy<ĪnflexorEffectusQuārtusNōminibusFactīs>(() => Instance);
    private ĪnflexorEffectusQuārtusNōminibusFactīs()
       : base(NūntiusĪnflexōrīEffectōQuārtōNōminibusFactīs.Faciendum,
              "īre", "iend") { }

    [Singleton]
    private sealed class NūntiusĪnflexōrīEffectōQuārtōNōminibusFactīs : Nūntius<ĪnflexorEffectusQuārtusNōminibusFactīs>
    {
      public static readonly Lazy<NūntiusĪnflexōrīEffectōQuārtōNōminibusFactīs> Faciendum
                       = new Lazy<NūntiusĪnflexōrīEffectōQuārtōNōminibusFactīs>(() => Instance);
    }
  }
}
