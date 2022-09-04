using System;

using Miscella;
using Nūntiī.Nūntius;
using Īnflexōrēs.Effectī.Āctūs.ĪnflexōrēsEffectusĀctibus.Versiō;
using Ēnumerātiōnēs;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Effectī.Āctūs
{
  [Singleton]
  [AsyncOverloads]
  public sealed partial class ĪnflexorEffectusPrīmusVariusĀctibus : ĪnflexorEffectusĀctibus
  {
    public static readonly Lazy<ĪnflexorEffectusPrīmusVariusĀctibus> Faciendum
                     = new Lazy<ĪnflexorEffectusPrīmusVariusĀctibus>(() => Instance);

    private static readonly ĪnflexorEffectusPrīmusĀctibus Relātum = ĪnflexorEffectusPrīmusĀctibus.Faciendum.Value;

    private ĪnflexorEffectusPrīmusVariusĀctibus()
        : base(NūntiusĪnflexōrīEffectōPrīmōVariōĀctibus.Faciendum) { }

    protected override sealed string? Suffixum(in Modus modus, in Vōx vōx, in Tempus tempus, in Numerālis numerālis, in Persōna persōna)
                  => (await Relātum.SuffixumAsync(modus, vōx, tempus, numerālis, persōna))
                                  ?.ReplaceStart("āv", "u");

    [Singleton]
    private sealed partial class NūntiusĪnflexōrīEffectōPrīmōVariōĀctibus
                : Nūntius<ĪnflexorEffectusPrīmusVariusĀctibus>
    {
      public static readonly Lazy<NūntiusĪnflexōrīEffectōPrīmōVariōĀctibus> Faciendum
                       = new Lazy<NūntiusĪnflexōrīEffectōPrīmōVariōĀctibus>(() => Instance);
    }
  }
}
