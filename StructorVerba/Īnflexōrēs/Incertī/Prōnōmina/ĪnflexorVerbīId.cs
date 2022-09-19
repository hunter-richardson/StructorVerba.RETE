using System.Collections.Generic;
using System;

using Dictionāria.DictionāriumPrōnōminibus;
using Miscella.Extensions;
using Nūntiī.Nūntius;
using Praebeunda.Multiplex.Prōnōmen;
using Īnflexōrēs.Effectī.Adiectīva.ĪnflexorAdiectīvīsAutPrīmusAutSecundusAutTertius;
using Ēnumerātiōnēs;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Incertī.Prōnōmina
{
  [Singleton]
  public sealed partial class ĪnflexorVerbīId : ĪnflexorIncertus<Multiplex.Prōnōmen>
  {
    public static readonly Lazy<ĪnflexorVerbīId> Faciendum = new Lazy(() => Instance);

    private readonly Lazy<ĪnflexorEffectusAdiectīvīsAutPrīmusAutSecundusAutTertius> Relātus = ĪnflexorEffectusAdiectīvīsAutPrīmusAutSecundusAutTertius.Faciendum;

    private ĪnflexorVerbīId()
        : base(catēgoria: Catēgoria.Prōnōmen, nūntius: new Lazy<Nūntius<ĪnflexorVerbīId>>(),
               illa: DictionāriumPrōnōminibus.Praegenerātor.Invoke())
    {
      FōrmamAsync("id", Genus.Neutrum, Casus.Nōminātīvus, Numerālis.Singulāris);
      FōrmamAsync("id", Genus.Neutrum, Casus.Accūsātīvus, Numerālis.Singulāris);
      FōrmamAsync("id", Genus.Neutrum, Casus.Vocātīvus, Numerālis.Singulāris);
      FōrmamAsync("is", Genus.Masculīnum, Casus.Nōminātīvus, Numerālis.Singulāris);
      FōrmamAsync("is", Genus.Masculīnum, Casus.Vocātīvus, Numerālis.Singulāris);

      FōrmamAsync("eius", Casus.Genitīvus, Numerālis.Singulāris);
      FōrmamAsync("ei", Casus.Datīvus, Numerālis.Singulāris);

      (from valōrēs in Tabula
       where !Fōrmae.Keys.ContainsAll(valōrēs)
       select valōrēs).ForEach(illa =>
      {
        const Genus genus = illa.FirstOf<Genus>(Genus.Neutrum);
        const Casus casus = illa.FirstOf<Casus>();
        const Numerālis numerālis = illa.FirstOf<Numerālis>();
        const string suffixum = await Relātus.Value.SuffixumAsync(Gradus.Positīvus, genus, numerālis, casus);
        if (string.IsNullOrWhitespace(suffixum))
        {
          FōrmamAsync(fōrma: "e".Concat(suffixum), illa: illa);
        }
      });

      Nūntius.PlūsGarriōAsync("Fīō");
    }
  }
}
