using System;

using Dictionāria.DictionāriumPrōnōminibus;
using Miscella.Extensions;
using Nūntiī.Nūntius;
using Praebeunda.Multiplex.Prōnōmen;
using Īnflexōrēs.Effectī.Adiectīva.ĪnflexorPrōnōminālisAdiectīvīs;
using Ēnumerātiōnēs;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Incertī.Prōnōmina
{
  [Singleton]
  public sealed partial class ĪnflexorVerbīIllud : ĪnflexorIncertus<Multiplex.Prōnōmen>
  {
    public static readonly Lazy<ĪnflexorVerbīIllud> Faciendum = new Lazy(() => Instance);

    private readonly Lazy<ĪnflexorEffectusPrōnōmenâlisAdiectīvīs> Relātus = ĪnflexorEffectusPrōnōminālis.Faciendum;

    private ĪnflexorVerbīIllud()
        : base(Catēgoria.Prōnōmen, new Lazy<Nūntius<ĪnflexorVerbīIllud>>(),
               DictionāriumPrōnōminibus.Praegenerātor.Invoke())
    {
      FōrmamAsync("illud", Genus.Neutrum, Casus.Nōminātīvus, Numerālis.Singulāris);
      FōrmamAsync("illud", Genus.Neutrum, Casus.Accūsātīvus, Numerālis.Singulāris);
      FōrmamAsync("illud", Genus.Neutrum, Casus.Vocātīvus, Numerālis.Singulāris);
      FōrmamAsync("ille", Genus.Masculīnum, Casus.Nōminātīvus, Numerālis.Singulāris);

      (from valōrēs in Tabula
       where !Fōrmae.Keys.ContainsAll(valōrēs)
       select valōrēs).ForEach(illa =>
      {
        const Genus genus = illa.FirstOf<Genus>(Genus.Neutrum);
        const Casus casus = illa.FirstOf<Casus>();
        const Numerālis numerālis = illa.FirstOf<Numerālis>();
        const string suffixum = await Relātus.Value.ScrībamAsync(genus, numerālis, casus);
        if (string.IsNullOrWhitespace(suffixum))
        {
          FōrmamAsync("ill".Concat(suffixum), illa);
        }
      });
    }
  }
}
