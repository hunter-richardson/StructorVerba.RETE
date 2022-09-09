using System;

using Miscella.Ūtilitātēs;
using Praebeunda.Īnflectendum;
using Praebeunda.Multiplex;
using Īnflexōrēs.Incertī;
using Īnflexōrēs.Incertī.Nōmina;

namespace Dictionāria
{
  [Singleton]
  public sealed partial class DictionāriumNōminibus : Dictionārium<DictionāriumNōminibus, Multiplex.Nōmen>
  {
    public static readonly Lazy<DictionāriumNōminibus> Faciendum = new Lazy<DictionāriumNōminibus>(() => Instance);

    protected readonly Lazy<ĪnflexorIncertus> Athōs = ĪnflexorVerbīAthōs.Faciendum;
    protected readonly Lazy<ĪnflexorIncertus> Balneum = ĪnflexorVerbīBalneum.Faciendum;
    protected readonly Lazy<ĪnflexorIncertus> Dea = ĪnflexorVerbīDea.Faciendum;
    protected readonly Lazy<ĪnflexorIncertus> Domus = ĪnflexorVerbīDomus.Faciendum;
    protected readonly Lazy<ĪnflexorIncertus> Iēsūs = ĪnflexorVerbīIēsūs.Faciendum;
    protected readonly Lazy<ĪnflexorIncertus> Iūgerum = ĪnflexorVerbīIūgerum.Faciendum;
    protected readonly Lazy<ĪnflexorIncertus> Lexis = ĪnflexorVerbīLexis.Faciendum;
    protected readonly Lazy<ĪnflexorIncertus> Rēspūblica = ĪnflexorVerbīRēspublica.Faciendum;
    protected readonly Lazy<ĪnflexorIncertus> Sapphō = ĪnflexorVerbīSapphō.Faciendum;
    protected readonly Lazy<ĪnflexorIncertus> Vicis = ĪnflexorVerbīVicis.Faciendum;
    protected readonly Lazy<ĪnflexorIncertus> Vīs = ĪnflexorVerbīVīs.Faciendum;
    protected readonly Lazy<ĪnflexorIncertus> Ēthos = ĪnflexorVerbīĒthos.Faciendum;
    protected readonly Lazy<ĪnflexorIncertus> Īre = ĪnflexorVerbīĪre.Faciendum;

    private DictionāriumNōminibus()
        : base(new Lazy<Nūntius<DictionāriumNōminibus>>()) { }
  }
}
