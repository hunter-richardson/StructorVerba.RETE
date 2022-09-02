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
  public sealed partial class ĪnflexorEffectusQuārtusVariusNōminibus : ĪnflexorEffectusNōminibus
  {
    public static readonly Lazy<ĪnflexorEffectusQuārtusVariusNōminibus> Faciendum
                     = new Lazy<ĪnflexorEffectusQuārtusVariusNōminibus>(() => Instance);
    private readonly ĪnflexorEffectusQuārtusNōminibus Relātum = ĪnflexorEffectusQuārtusNōminibus.Faciendum.Value;
    private ĪnflexorEffectusQuārtusVariusNōminibus()
        : base(Versiō.Nōmen_Quārtum_Varium, NūntiusĪnflexōrīEffectōQuārtōVariōNōminibus.Faciendum,
               (nōmen, illa) => nōmen.Nominātīvum.Chop(2)) { }

    public sealed string Singulāre(in Casus casus)
              => (casus is Casus.Nominātīvus or Casus.Accusātīvus or Casus.Vocātīvus)
                        .Choose("ua", await Relātum.SingulāreAsync(casus));

    public sealed string Plūrāle(in Casus casus)
              => (casus is Casus.Nominātīvus or Casus.Accusātīvus or Casus.Vocātīvus)
                        .Choose("ū", await Relātum.PlūrāleAsync(casus));

    [Singleton]
    private sealed class NūntiusĪnflexōrīEffectōQuārtōVariōNōminibus : Nūntius<ĪnflexorEffectusQuārtusVariusNōminibus>
    {
      public static readonly Lazy<NūntiusĪnflexōrīEffectōQuārtōVariōNōminibus> Faciendum
                       = new Lazy<NūntiusĪnflexōrīEffectōQuārtōVariōNōminibus>(() => Instance);
    }
  }
}
