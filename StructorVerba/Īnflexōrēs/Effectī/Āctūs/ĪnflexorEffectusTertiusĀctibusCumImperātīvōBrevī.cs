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
  public sealed partial class ĪnflexorEffectusTertiusĀctibusCumImperātīvōBrevī : ĪnflexorEffectusĀctibus
  {
    public static readonly Lazy<ĪnflexorEffectusTertiusĀctibusCumImperātīvōBrevī> Faciendum
                     = new Lazy<ĪnflexorEffectusTertiusĀctibusCumImperātīvōBrevī>(() => Instance);

    private static readonly ĪnflexorEffectusTertiusĀctibus Relātum = ĪnflexorEffectusTertiusĀctibus.Faciendum.Value;

    private ĪnflexorEffectusTertiusĀctibusCumImperātīvōBrevī()
        : base(Versiō.Tertius, NūntiusĪnflexōrīEffectōTertiōĀctibusCumImperātīvōBrevī.Faciendum) { }


    public sealed async string? Imperātīvum(in Vōx vōx, in Tempus tempus, in Numerālis numerālis)
              => (vōx, tempus, numerālis) switch
              {
                (Vōx.Āctīva, Tempus.Praesēns, Numerālis.Singulāris) => string.Empty,
                _ => await Relātum.ImperātīvumAsync(vōx, tempus, numerālis),
              };
    public virtual string? Suffixum(in Modus modus, in Vōx vōx, in Tempus tempus, in Numerālis numerālis, in Persōna persōna)
              => await (modus, vōx, tempus, numerālis, persōna) switch
                  {
                    var īnscītum when (modus is Modus.Imperātīvus) &&
                                      (vōx is Vōx.Āctīva or Vōx.Passīva) &&
                                      (tempus is Tempus.Praesēns or Tempus.Futūrum)
                                          => ImperātīvumAsync(vōx, tempus, numerālis),
                    _ => Relātum.SuffixumAsync(illa)
                  };

    [Singleton]
    private sealed partial class NūntiusĪnflexōrīEffectōTertiōĀctibusCumImperātīvōBrevī
                : Nūntius<ĪnflexorEffectusTertiusĀctibusCumImperātīvōBrevī>
    {
      public static readonly Lazy<NūntiusĪnflexōrīEffectōTertiōĀctibusCumImperātīvōBrevī> Faciendum
                       = new Lazy<NūntiusĪnflexōrīEffectōTertiōĀctibusCumImperātīvōBrevī>(() => Instance);
    }
  }
}
