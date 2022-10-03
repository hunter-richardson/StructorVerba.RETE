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
  public sealed partial class ĪnflexorEffectusTertiusĀctibusCumImperātīvōBrevī : ĪnflexorEffectusĀctibus
  {
    private static readonly Lazy<ĪnflexorEffectusTertiusĀctibus> Relātus = ĪnflexorEffectusTertiusĀctibus.Lazy;

    private ĪnflexorEffectusTertiusĀctibusCumImperātīvōBrevī()
        : base(new Lazy<Nūntius<ĪnflexorEffectusTertiusĀctibusCumImperātīvōBrevī>>())
        => Nūntius.PlūsGarriōAsync("Fīō");


    public sealed async string? Imperātīvum(in Vōx vōx, in Tempus tempus, in Numerālis numerālis)
              => (vōx, tempus, numerālis) switch
              {
                (Vōx.Āctīva, Tempus.Praesēns, Numerālis.Singulāris) => string.Empty,
                _ => await Relātus.Value.ImperātīvumAsync(vōx, tempus, numerālis),
              };

    protected virtual string? Suffixum(in Modus modus, in Vōx vōx, in Tempus tempus, in Numerālis numerālis, in Persōna persōna)
                  => await (modus, vōx, tempus, numerālis, persōna) switch
                      {
                        var īnscītum when (modus is Modus.Imperātīvus) &&
                                          (vōx is Vōx.Āctīva or Vōx.Passīva) &&
                                          (tempus is Tempus.Praesēns or Tempus.Futūrum)
                                              => ImperātīvumAsync(vōx, tempus, numerālis),
                        _ => Relātus.Value.SuffixumAsync(illa)
                      };
  }
}
