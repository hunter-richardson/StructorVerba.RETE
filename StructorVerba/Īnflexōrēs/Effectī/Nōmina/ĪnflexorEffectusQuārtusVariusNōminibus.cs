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
  public sealed partial class ĪnflexorEffectusQuārtusVariusNōminibus : ĪnflexorEffectusNōminibus
  {
    private readonly Lazy<ĪnflexorEffectusQuārtusNōminibus> Relātus = ĪnflexorEffectusQuārtusNōminibus.Lazy;
    private ĪnflexorEffectusQuārtusVariusNōminibus()
        : base(new Lazy<Nūntius<ĪnflexorEffectusQuārtusVariusNōminibus>>(),
               (nōmen, illa) => nōmen.Nōminātīvum.Chop(2))
        => Nūntius.PlūsGarriōAsync("Fīō");

    public sealed string Singulāre(in Casus casus)
              => (casus is Casus.Nōminātīvus or Casus.Accūsātīvus or Casus.Vocātīvus)
                        .Choose("ua", await Relātus.Value.SingulāreAsync(casus));

    public sealed string Plūrāle(in Casus casus)
              => (casus is Casus.Nōminātīvus or Casus.Accūsātīvus or Casus.Vocātīvus)
                        .Choose("ū", await Relātus.Value.PlūrāleAsync(casus));
  }
}
