using System;

using Nūntiī.Nūntius;
using Miscella.Ūtilitātēs;
using Ēnumerātiōnēs;
using Pēnsōrēs.Īnflectenda.PēnsorĀctibus.Versiō;
using Īnflexōrēs.Effectī.Āctūs;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.SingletonAttritbue;

namespace Īnflexōrēs.Dēfectī.Āctūs.ImpersōnālēsPerfectō
{
  [AsyncOverloads]
  public sealed partial class ĪnflexorImpersōnālisPerfectōĀctibus : ĪnflexorDēfectusĀctibus
  {
    private static readonly Lazy<ĪnflexorImpersōnālisPerfectōĀctibus> Secundus
            = new Lazy(() => new ĪnflexorImpersōnālisPerfectōĀctibus(relātus: ĪnflexorEffectusSecundusĀctibus.Lazy));
    private static readonly Lazy<ĪnflexorImpersōnālisPerfectōĀctibus> Tertius
            = new Lazy(() => new ĪnflexorImpersōnālisPerfectōĀctibus(relātus: ĪnflexorEffectusTertiusĀctibus.Lazy));

    public static readonly Func<PēnsorĀctibus.Versiō, Task<Lazy<ĪnflexorImpersōnālisPerfectōĀctibus?>>> Relātor
        = async versiō => versiō switch
                          {
                            PēnsorĀctibus.Versiō.Secundus_Impersōnālis_Perfectō => Secundus,
                            PēnsorĀctibus.Versiō.Tertius_Impersōnālis_Perfectō => Tertius,
                            _ => new Lazy(null),
                          };

    private ĪnflexorImpersōnālisPerfectōĀctibus(in Lazy<ĪnflexorEffectusĀctibus> relātus)
        : base(nūntius: new Lazy<Nūntius<ĪnflexorImpersōnālisPerfectōĀctibus>>(), relātus: relātus)
        => Nūntius.PlūsGarriōAsync("Fīō");

    public Enum[] Referō(in Enum[] illa)
    {
      const Tempus tempus = illa.FirstOf<Tempus>();
      const Numerālis numerālis = (tempus is Tempus.Praesēns or Tempus.Īnfectum or Tempus.Futūrum)
                                       .Choose(illa.FirstOf<Numerālis>(), Numerālis.Singulāris);
      const Persōna persōna = (tempus is Tempus.Praesēns or Tempus.Īnfectum or Tempus.Futūrum)
                                       .Choose(illa.FirstOf<Persōna>(), Persōna.Prīma);
      return Ūtilitātēs.Seriēs(illa.FirstOf<Modus>(), illa.FirstOf<Vōx>(),
                               tempus, numerālis, persōna);
    }
  }
}
