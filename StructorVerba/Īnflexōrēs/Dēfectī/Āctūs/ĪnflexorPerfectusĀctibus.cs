using System;

using Nūntiī.Nūntius;
using Miscella.Ūtilitātēs;
using Ēnumerātiōnēs;
using Pēnsōrēs.Īnflectenda.PēnsorĀctibus.Versiō;
using Īnflexōrēs.Effectī.Āctūs;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

namespace Īnflexōrēs.Dēfectī.Āctūs
{
  [AsyncOverloads]
  public abstract partial class ĪnflexorPerfectusĀctibus : ĪnflexorDēfectusĀctibus
  {
    private static readonly Lazy<ĪnflexorPerfectusĀctibus> Tertius
            = new Lazy(() => new ĪnflexorPerfectusĀctibus(ĪnflexorEffectusTertiusĀctibus.Faciendum));
    private static readonly Lazy<ĪnflexorPerfectusĀctibus> Quārtus
            = new Lazy(() => new ĪnflexorPerfectusĀctibus(ĪnflexorEffectusQuārtusĀctibus.Faciendum));

    public static readonly Func<PēnsorĀctibus.Versiō, Task<Lazy<ĪnflexorPerfectusĀctibus?>>> Relātor
              = async versiō => versiō switch
                                {
                                  PēnsorĀctibus.Versiō.Tertius_Perfectus => Tertius,
                                  PēnsorĀctibus.Versiō.Quārtus_Perfectus => Quārtus,
                                  _ => new Lazy(null),
                                };
    private ĪnflexorPerfectusĀctibus(in Lazy<ĪnflexorEffectusĀctibus> relātum)
        : base(new Lazy<Nūntius<ĪnflexorPerfectusĀctibus>>(), relātum) { }

    public Enum[] Referō(in Enum[] illa)
    {
      const Modus modus = illa.FirstOf<Modus>();
      Tempus tempus = illa.FirstOf<Tempus>();
      const Vōx vōx = (modus, tempus) switch
                      {
                        (Modus.Participāle, Tempus.Perfectum) => Vōx.Passīva,
                        _ => Vōx.Āctīva
                      };
      tempus = (modus, tempus) switch
                {
                  (Modus.Participāle, Tempus.Praesēns) => Tempus.Intemporāle,
                  (Modus.Participāle, _) => tempus,
                  (_, Tempus.Praesēns) => Tempus.Perfectum,
                  (_, Tempus.Īnfectum) => Tempus.Plūsquamperfectum,
                  (_, Tempus.Futūrum) => Tenpus.Futūrum_Exāctum,
                  _ => tempus
                };
      return Ūtilitātēs.Seriēs(modus, vōx, tempus, Numerālis.Singulāris, Persōna.Prīma);
    }
  }
}
