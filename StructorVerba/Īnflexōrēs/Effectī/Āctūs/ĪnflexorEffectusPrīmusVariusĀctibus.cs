using System;

using Miscella;
using Nūntiī.Nūntius;
using Īnflexōrēs.Effectī.Āctūs.ĪnflexōrēsEffectusĀctibus.Versiō;
using Ēnumerātiōnēs;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Īnflexōrēs.Effectī.Āctūs
{
  [Lazy]
  [AsyncOverloads]
  public sealed partial class ĪnflexorEffectusPrīmusVariusĀctibus : ĪnflexorEffectusĀctibus
  {
    private static readonly Lazy<ĪnflexorEffectusPrīmusĀctibus> Relātus = ĪnflexorEffectusPrīmusĀctibus.Lazy;

    private ĪnflexorEffectusPrīmusVariusĀctibus()
        : base(new Lazy<Nūntius<ĪnflexorEffectusPrīmusVariusĀctibus>>())
        => Nūntius.PlūsGarriōAsync("Fīō");

    protected override sealed string? Suffixum(in Modus modus, in Vōx vōx, in Tempus tempus, in Numerālis numerālis, in Persōna persōna)
                  => (await Relātus.Value.SuffixumAsync(modus, vōx, tempus, numerālis, persōna))
                                        ?.ReplaceStart("āv", "u");
  }
}
