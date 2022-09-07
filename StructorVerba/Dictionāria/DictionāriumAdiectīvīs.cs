using System;

using Miscella.Ūtilitātēs;
using Praebeunda.Īnflectendum;
using Praebeunda.Multiplex;
using Īnflexōrēs.Incertī.Nōmina;

namespace Dictionāria
{
  [Singleton]
  public sealed partial class DictionāriumAdiectīvīs : Dictionārium<DictionāriumAdiectīvīs, Multiplex.Adiectīvum>
  {
    public static readonly Lazy<DictionāriumAdiectīvīs> Faciendum = new Lazy<DictionāriumAdiectīvīs>(() => Instance);

    protected readonly Īnflectendum.Nōmen Multum
          = await Īnflectendum.Nōmen.Aedificātor.Invoke(ĪnflexorVerbīAthōs.Faciendum,
                                                        Ūtilitātēs.Seriēs("multum", "plūs", "plūrimum"));
    protected readonly Īnflectendum.Nōmen Balneum
          = await Īnflectendum.Nōmen.Aedificātor.Invoke(ĪnflexorVerbīBalneum.Faciendum,
                                                        Ūtilitātēs.Seriēs("balneum", "balneī"));
    protected readonly Īnflectendum.Nōmen Dea
          = await Īnflectendum.Nōmen.Aedificātor.Invoke(ĪnflexorVerbīDea.Faciendum,
                                                        Ūtilitātēs.Seriēs("dea", "dea"));
    protected readonly Īnflectendum.Nōmen Domus
          = await Īnflectendum.Nōmen.Aedificātor.Invoke(ĪnflexorVerbīDomus.Faciendum,
                                                        Ūtilitātēs.Seriēs("domus", "domūs"));
    protected readonly Īnflectendum.Nōmen Ēthos
          = await Īnflectendum.Nōmen.Aedificātor.Invoke(ĪnflexorVerbīĒthos.Faciendum,
                                                        Ūtilitātēs.Seriēs("ēthos", "ētheos"));
    protected readonly Īnflectendum.Nōmen Iēsūs
          = await Īnflectendum.Nōmen.Aedificātor.Invoke(ĪnflexorVerbīIēsūs.Faciendum,
                                                        Ūtilitātēs.Seriēs("Iēsūs", "Iēsūs"));
    protected readonly Īnflectendum.Nōmen Iūgerum
          = await Īnflectendum.Nōmen.Aedificātor.Invoke(ĪnflexorVerbīIūgerum.Faciendum,
                                                        Ūtilitātēs.Seriēs("iūgerum", "iūgerī"));
    protected readonly Īnflectendum Lexis
          = await Īnflectendum.Nōmen.Aedificātor.Invoke(ĪnflexorVerbīLexis.Faciendum,
                                                        Ūtilitātēs.Seriēs("lexis", "lexeōs"));
    protected readonly Īnflectendum Sapphō
          = await Īnflectendum.Nōmen.Aedificātor.Invoke(ĪnflexorVerbīSapphō.Faciendum,
                                                        Ūtilitātēs.Seriēs("Sapphō", "Sapphūs"));
    protected readonly Īnflectendum.Nōmen Vicis
          = await Īnflectendum.Nōmen.Aedificātor.Invoke(ĪnflexorVerbīVicis.Faciendum,
                                                        Ūtilitātēs.Seriēs(string.Empty, "vicis"));
    protected readonly Īnflectendum.Nōmen Vīs
          = await Īnflectendum.Nōmen.Aedificātor.Invoke(ĪnflexorVerbīVīs.Faciendum,
                                                        Ūtilitātēs.Seriēs("vīs", "viris"));
    protected readonly Īnflectendum.NōmenFactum Īre
          = await Īnflectendum.NōmenFactum.Aedificātor.Invoke(ĪnflexorVerbīĪre.Faciendum,
                                                              Ūtilitātēs.Seriēs("īre", "itum"));

    private DictionāriumNōminibus()
        : base(new Lazy<Nūntius<DictionāriumAdiectīvīs>>(() => new Nūntius<DictionāriumAdiectīvīs>())) { }
  }
}
