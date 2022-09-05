using System;

using Nūntiī.Nūntius;
using Miscella.Ūtilitātēs;
using Ēnumerātiōnēs;
using Pēnsōrēs.Īnflectenda.PēnsorĀctibus.Versiō;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

namespace Īnflexōrēs.Dēfectī.Āctūs.ImpersōnālēsPerfectō
{
  [AsyncOverloads]
  public abstract partial class ĪnflexorImpersōnālisPerfectōĀctibus : ĪnflexorDēfectusĀctibus
  {
    public static readonly Func<PēnsorĀctibus.Versiō, Task<Lazy<ĪnflexorImpersōnālisPerfectōĀctibus?>>> Relātor = async versiō => versiō switch
    {
      PēnsorĀctibus.Versiō.Secundus_Impersōnālis_Perfectō => ĪnflexorImpersōnālisSecundusĀctibusPerfectō.Faciendum,
      PēnsorĀctibus.Versiō.Tertius_Impersōnālis_Perfectō => ĪnflexorImpersōnālisTertiusĀctibusPerfectō.Faciendum,
      _ => new Lazy(null),
    };

    protected ĪnflexorImpersōnālisPerfectōĀctibus(in Lazy<Nūntius<ĪnflexorImpersōnālisPerfectōĀctibus>> nūntius,
                                                  in Lazy<ĪnflexorEffectusĀctibus> relātum)      : base(nūntius, relātum) { }

    public sealed Enum[] Referō(in Enum[] illa)
    {
      const Tempus tempus = illa.FirstOf<Tempus>();
      const Numerālis numerālis = (tempus is Tempus.Praesēns or Tempus.Infectum or Tempus.Futūrum)
                                       .Choose(illa.FirstOf<Numerālis>(), Numerālis.Singulāris);
      const Persōna persōna = (tempus is Tempus.Praesēns or Tempus.Infectum or Tempus.Futūrum)
                                       .Choose(illa.FirstOf<Persōna>(), Persōna.Prīma);
      return Ūtilitātēs.Seriēs(illa.FirstOf<Modus>(), illa.FirstOf<Vōx>(),
                               tempus, numerālis, persōna);
    }
  }
}
