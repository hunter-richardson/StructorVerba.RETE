using System;

using Dictionāria.DictionāriumPrōnōminibus;
using Miscella.Extensions;
using Nūntiī.Nūntius;
using Praebeunda.Multiplex.Prōnōmen;
using Īnflexōrēs.Effectī.Adiectīva.ĪnflexorPrōnōminālisAdiectīvīs;
using Ēnumerātiōnēs;

using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Īnflexōrēs.Incertī.Prōnōmina
{
  [Lazy]
  public sealed partial class ĪnflexorVerbīIpsum : ĪnflexorIncertus<Multiplex.Prōnōmen>
  {
    private readonly Lazy<ĪnflexorEffectusPrōnōminālisAdiectīvīs> Relātus = ĪnflexorEffectusPrōnōminālisAdiectīvīs.Lazy;

    private ĪnflexorVerbīIpsum()
        : base(catēgoria: Catēgoria.Prōnōmen, nūntius: new Lazy<Nūntius<ĪnflexorVerbīIpsum>>(),
               illa: DictionāriumPrōnōminibus.Praegenerātor.Invoke())
    {
      FōrmamAsync("ipse", Genus.Masculīnum, Casus.Nōminātīvus, Numerālis.Singulāris);
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
          FōrmamAsync(fōrma: "ips".Concat(suffixum), illa: illa);
        }
      });

      Nūntius.PlūsGarriōAsync("Fīō");
    }
  }
}
