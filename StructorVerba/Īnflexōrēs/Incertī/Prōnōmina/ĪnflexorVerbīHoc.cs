using System;

using Miscella.Extensions;
using Dictionāria.DictionāriumPrōnōminibus;
using Nūntiī.Nūntius;
using Praebeunda.Multiplex.Prōnōmen;
using Īnflexōrēs.Effectī.Adiectīva.ĪnflexorAdiectīvīsAutPrīmusAutSecundusAutTertius;
using Ēnumerātiōnēs;

using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Īnflexōrēs.Incertī.Prōnōmina
{
  [Lazy]
  public sealed partial class ĪnflexorVerbīHoc : ĪnflexorIncertus<Multiplex.Prōnōmen>
  {
    private readonly Lazy<ĪnflexorEffectusAdiectīvīsAutPrīmusAutSecundusAutTertius> Relātus
                        = ĪnflexorEffectusAdiectīvīsAutPrīmusAutSecundusAutTertius.Lazy;

    private ĪnflexorVerbīHoc()
          : base(catēgoria: Catēgoria.Prōnōmen, nūntius: new Lazy<Nūntius<ĪnflexorVerbīHoc>>(),
                 illa: DictionāriumPrōnōminibus.Praegenerātor.Invoke())
    {
      FōrmamAsync("hoc", Genus.Neutrum, Casus.Nōminātīvus, Numerālis.Singulāris);
      FōrmamAsync("hoc", Genus.Neutrum, Casus.Accūsātīvus, Numerālis.Singulāris);
      FōrmamAsync("hoc", Genus.Neutrum, Casus.Vocātīvus, Numerālis.Singulāris);
      FōrmamAsync("haec", Genus.Neutrum, Casus.Nōminātīvus, Numerālis.Plūrālis);
      FōrmamAsync("haec", Genus.Neutrum, Casus.Accūsātīvus, Numerālis.Plūrālis);
      FōrmamAsync("haec", Genus.Neutrum, Casus.Vocātīvus, Numerālis.Plūrālis);
      FōrmamAsync("hic", Genus.Masculīnum, Casus.Nōminātīvus, Numerālis.Singulāris);
      FōrmamAsync("hunc", Genus.Masculīnum, Casus.Accūsātīvus, Numerālis.Singulāris);
      FōrmamAsync("hic", Genus.Fēminīnum, Casus.Vocātīvus, Numerālis.Singulāris);
      FōrmamAsync("haec", Genus.Fēminīnum, Casus.Nōminātīvus, Numerālis.Singulāris);
      FōrmamAsync("hanc", Genus.Fēminīnum, Casus.Accūsātīvus, Numerālis.Singulāris);
      FōrmamAsync("haec", Genus.Fēminīnum, Casus.Vocātīvus, Numerālis.Singulāris);
      FōrmamAsync("hōc", Genus.Neutrum, Casus.Ablātīvus, Numerālis.Singulāris);
      FōrmamAsync("hōc", Genus.Neutrum, Casus.Locātīvus, Numerālis.Singulāris);
      FōrmamAsync("hōc", Genus.Neutrum, Casus.Instrumentālis, Numerālis.Singulāris);
      FōrmamAsync("hōc", Genus.Masculīnum, Casus.Ablātīvus, Numerālis.Singulāris);
      FōrmamAsync("hōc", Genus.Masculīnum, Casus.Locātīvus, Numerālis.Singulāris);
      FōrmamAsync("hōc", Genus.Masculīnum, Casus.Instrumentālis, Numerālis.Singulāris);
      FōrmamAsync("hāc", Genus.Fēminīnum, Casus.Ablātīvus, Numerālis.Singulāris);
      FōrmamAsync("hāc", Genus.Fēminīnum, Casus.Locātīvus, Numerālis.Singulāris);
      FōrmamAsync("hāc", Genus.Fēminīnum, Casus.Instrumentālis, Numerālis.Singulāris);

      FōrmamAsync("huius", Casus.Genitīvus, Numerālis.Singulāris);
      FōrmamAsync("huic", Casus.Datīvus, Numerālis.Singulāris);

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
          FōrmamAsync(fōrma: "h".Concat(suffixum), illa: illa);
        }
      });

      Nūntius.PlūsGarriōAsync("Fīō");
    }
  }
}
