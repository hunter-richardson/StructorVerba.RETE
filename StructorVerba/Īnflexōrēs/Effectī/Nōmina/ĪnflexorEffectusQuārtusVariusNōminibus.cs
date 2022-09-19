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
    public static readonly Lazy<ĪnflexorEffectusQuārtusVariusNōminibus> Faciendum = new Lazy(() => Instance);
    private readonly ĪnflexorEffectusQuārtusNōminibus Relātus = ĪnflexorEffectusQuārtusNōminibus.Faciendum.Value;
    private ĪnflexorEffectusQuārtusVariusNōminibus()
        : base(new Lazy<Nūntius<ĪnflexorEffectusQuārtusVariusNōminibus>>(),
               (nōmen, illa) => nōmen.Nōminātīvum.Chop(2))
        => Nūntius.PlūsGarriōAsync("Fīō");

    public sealed string Singulāre(in Casus casus)
              => (casus is Casus.Nōminātīvus or Casus.Accūsātīvus or Casus.Vocātīvus)
                        .Choose("ua", await Relātus.SingulāreAsync(casus));

    public sealed string Plūrāle(in Casus casus)
              => (casus is Casus.Nōminātīvus or Casus.Accūsātīvus or Casus.Vocātīvus)
                        .Choose("ū", await Relātus.PlūrāleAsync(casus));
  }
}
