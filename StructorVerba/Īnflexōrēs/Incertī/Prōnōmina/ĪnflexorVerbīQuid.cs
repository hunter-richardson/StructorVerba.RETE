using System;

using Miscella.Extensions;
using Dictionāria.DictionāriumPrōnōminibus;
using Nūntiī.Nūntius;
using Praebeunda.Multiplex.Prōnōmen;
using Ēnumerātiōnēs;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Incertī.Prōnōmina
{
  [Singleton]
  public sealed partial class ĪnflexorVerbīQuid : ĪnflexorIncertus<Multiplex.Prōnōmen>
  {
    public static readonly Lazy<ĪnflexorVerbīQuid> Faciendum = new Lazy(() => Instance);

    private readonly Lazy<ĪnflexorRescrīptus> Relātus
     = new Lazy(() => new ĪnflexorRescrīptus(ĪnflexorVerbīId.Faciendum,
                                             scrīptum => scrīptum.ReplaceFirst("e", "qu")));

    private ĪnflexorVerbīQuid()
          : base(Catēgoria.Prōnōmen, new Lazy<Nūntius<ĪnflexorVerbīQuid>>(),
                 DictionāriumPrōnōminibus.Praegenerātor.Invoke())
    {
      FōrmamAsync("quae", Genus.Neutrum, Casus.Nōminātīvus, Numerālis.Plūrālis);
      FōrmamAsync("quae", Genus.Neutrum, Casus.Accūsātīvus, Numerālis.Plūrālis);
      FōrmamAsync("quae", Genus.Neutrum, Casus.Vocātīvus, Numerālis.Plūrālis);
      FōrmamAsync("quae", Genus.Fēminīnum, Casus.Nōminātīvus, Numerālis.Singulāris);
      FōrmamAsync("quem", Genus.Masclīnum, Casus.Accūsātīvus, Numerālis.Singulāris);
      FōrmamAsync("quae", Genus.Fēminīnum, Casus.Nōminātīvus, Numerālis.Plūrālis);
      FōrmamAsync("quae", Genus.Fēminīnum, Casus.Vocātīvus, Numerālis.Singulāris);
      FōrmamAsync("quae", Genus.Fēminīnum, Casus.Vocātīvus, Numerālis.Plūrālis);
      FōrmamAsync("cuius", Casus.Genitīvus, Numerālis.Singulāris);
      FōrmamAsync("cui", Casus.Datīvus, Numerālis.Singulāris);

      (from valōrēs in Tabula
       where !Fōrmae.Keys.ContainsAll(valōrēs)
       select valōrēs).ForEach(illa => FōrmamAsync(await Relātus.Value.ScrībamAsync(illa), illa));
    }
  }
}
