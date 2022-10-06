using System.Lazy;

using Miscella.Ūtilitātēs;
using Praebeunda.Īnflectendum;
using Praebeunda.Multiplex;
using Īnflexōrēs.Exāctī.ĪnflexorExactusNōminibus;
using Īnflexōrēs.Incertī;
using Īnflexōrēs.Incertī.Nōmina;

using Lombok.NET.MethodGenerators.LazyAttribute;

namespace Dictionāria
{
  [Lazy]
  public sealed partial class DictionāriumNōminibus : Dictionārium<DictionāriumNōminibus, Multiplex.Nōmen>
  {
    protected readonly Lazy<ĪnflexorIncertus> Athōs = ĪnflexorVerbīAthōs.Lazy;
    protected readonly Lazy<ĪnflexorIncertus> Balneum = ĪnflexorVerbīBalneum.Lazy;
    protected readonly Lazy<ĪnflexorIncertus> Dea = ĪnflexorVerbīDea.Lazy;
    protected readonly Lazy<ĪnflexorIncertus> Domus = ĪnflexorVerbīDomus.Lazy;
    protected readonly Lazy<ĪnflexorIncertus> Iēsūs = ĪnflexorVerbīIēsūs.Lazy;
    protected readonly Lazy<ĪnflexorIncertus> Iūgerum = ĪnflexorVerbīIūgerum.Lazy;
    protected readonly Lazy<ĪnflexorIncertus> Lexis = ĪnflexorVerbīLexis.Lazy;
    protected readonly Lazy<ĪnflexorIncertus> Rēspūblica = ĪnflexorVerbīRēspublica.Lazy;
    protected readonly Lazy<ĪnflexorIncertus> Vicis = ĪnflexorVerbīVicis.Lazy;
    protected readonly Lazy<ĪnflexorIncertus> Vīs = ĪnflexorVerbīVīs.Lazy;
    protected readonly Lazy<ĪnflexorIncertus> Ēthos = ĪnflexorVerbīĒthos.Lazy;
    protected readonly Lazy<ĪnflexorIncertus> Īre = ĪnflexorVerbīĪre.Lazy;

    private DictionāriumNōminibus()
        : base(new Lazy<Nūntius<DictionāriumNōminibus>>())
        => Nūntius.PlūsGarriōAsync("Fīō");
  }
}
