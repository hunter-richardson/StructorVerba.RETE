using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks.Task;

using Nūntiī.Nūntius;
using Miscella;
using Praebeunda.Interfecta;
using Praebeunda.Multiplex;
using Ēnumerātiōnēs;
using Ēnumerātiōnēs.Comparātōrēs;
using Pēnsōrēs.Īnflectenda.PēnsorAdiectīvīs;
using Pēnsōrēs.Īnflectenda.PēnsorAdverbiīs;
using Pēnsōrēs.Īnflectenda.PēnsorĀctibus;
using Pēnsōrēs.Nōmina.PēnsorNōminibus;
using Pēnsōrēs.Nōmina.PēnsorNōminibusFactīs;
using Pēnsōrēs.Numerāmina.PēnsorNumerāminibus;
using Īnflexōrēs.Effectī.Āctūs.ĪnflexōrēsEffectusĀctibus;
using Īnflexōrēs.Effectī.Adiectīva.ĪnflexorEffectusAdiectīvīs;
using Īnflexōrēs.Effectī.Nōmina.ĪnflexorEffectusNōminibus;
using Īnflexōrēs.Effectī.Nōmina.NōminaFacta.ĪnflexorEffectusNōminibusFactīs;
using Īnflexōrēs.Effectī.Numerāmina.ĪnflexorNumerāminibus;
using Īnflexōrēs.Dēfectī.Adiectīva;
using Īnflexōrēs.Dēfectī.Nōmina;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using BuilderCommon.BuilderException;

namespace Īnflexōrēs
{
  [AsyncOverloads]
  public abstract partial class Īnflexor<Hoc, Illud>
            where Hoc : Īnflexibilis<Hoc, Illud>
            where Illud : Īnflexum<Illud>
  {
    public static readonly Func<Ēnumerātiōnēs.Catēgoria, Enum, Lazy<Īnflexor?>> Relātor =
            async (catēgoria, versiō) => (catēgoria, versiō) switch
            {
              var īnscītum when Ūtilitātēs.Omnia(catēgoria is Ēnumerātiōnēs.Catēgoria.Nōmen,
                                                 versiō is PēnsorNōminibusFactīs.Versiō)
                                                     => ĪnflexorEffectusNōminibusFactīs.Lazy,
              var īnscītum when Ūtilitātēs.Omnia(catēgoria is Ēnumerātiōnēs.Catēgoria.Nōmen,
                                                 versiō.ToString().EndsWith("_Singulāris"))
                                                     => ĪnflexorSingulārisNōminibus.Relātor.Invoke(versiō),
              var īnscītum when Ūtilitātēs.Omnia(catēgoria is Ēnumerātiōnēs.Catēgoria.Adiectīvum,
                                                 versiō.ToString().StartsWith("Incomparābilis_"))
                                                     => ĪnflexorIncomparābilisAdiectīvīs.Relātor.Invoke(versiō),
              (Ēnumerātiōnēs.Catēgoria.Adverbium, _) => ĪnflexorAdverbiīs.Lazy,
              (Ēnumerātiōnēs.Catēgoria.Numerāmen, _) => ĪnflexorNumerāminibus.Relātor.Invoke(versiō),
              (Ēnumerātiōnēs.Catēgoria.Adiectīvum, PēnsorAdiectīvīs.Versiō.Incomparābilis_Plūrālis_Aut_Prīmus_Aut_Secundus)
                                                     => ĪnflexorIncomparābilisPlūrālisAdiectīvīsAutPrīmusAutSecundus.Lazy,
              (Ēnumerātiōnēs.Catēgoria.Adiectīvum, _) => ĪnflexorEffectusAdiectīvīs.Relātor.Invoke(versiō),
              (Ēnumerātiōnēs.Catēgoria.Āctus, PēnsorĀctibus.Versiō.Prīmus or PēnsorĀctibus.Versiō.Prīmus_Varius or
                                              PēnsorĀctibus.Versiō.Secundus or PēnsorĀctibus.Versiō.Quārtus or
                                              PēnsorĀctibus.Versiō.Tertius or PēnsorĀctibus.Versiō.Tertius_Varius or
                                              PēnsorĀctibus.Versiō.Tertius_Cum_Imperātīvō_Brevī)
                                                     => ĪnflexorEffectusĀctibus.Relātor.Invoke(versiō),
              (Ēnumerātiōnēs.Catēgoria.Āctus, _) => ĪnflexorDēfectusĀctibus.Relātor.Invoke(versiō),
              (Ēnumerātiōnēs.Catēgoria.Nōmen, PēnsorNōminibus.Versiō.Nōmen_Prīmum_Plūrālis)
                                                     => ĪnflexorPrīmusPlūrālisNōminibus.Lazy,
              (Ēnumerātiōnēs.Catēgoria.Nōmen, _) => ĪnflexorEffectusNōminibus.Relātor.Invoke(versiō),
              _ => new Lazy(null)
            };

    protected readonly Comparer<Enum[]> ComparātorSeriērum = ComparātorSeriērum.Lazy.Value;
    protected readonly Comparer<Enum> ComparātorValōrum = ComparātorValōrum.Lazy.Value;
    protected SortedSet<Enum[]> Tabula = new SortedSet<>(ComparātorSeriērum);
    public readonly Func<ISet<Enum[]>> Tabulātor => () => Tabula.ToImmutableSortedSet(Tabula.Comparer);
    private readonly Func<string, Enum[], Task<Hoc>>? Cōnstrūctor = Muliplex.Cōnstrūctor.Invoke(Catēgoria);
    public readonly Func<Hoc, Task<Illud?>> FortisĪnflexor => hoc => ĪnflectemAsync(hoc, await Tabula.Random());

    protected readonly Nūntius<Īnflexor<Hoc>> Nūntius { get; }
    public readonly Ēnumerātiōnēs.Catēgoria Catēgoria { get; }
    public String prīmum = string.Empty;

    protected Īnflexor(in Ēnumerātiōnēs.Catēgoria catēgoria,
                       in Lazy<Nūntius<Īnflexor<Hoc, Illud>>> nūntius,
                       in params Enum illa)
    {
      Catēgoria = catēgoria;
      Nūntius = nūntius.Value;

      Array.Sort(illa, Comparātor);
      illa.ForEach(illud => Tabula.Add(new[] { illud }));
    }

    protected Īnflexor(in Ēnumerātiōnēs.Catēgoria catēgoria,
                       in Lazy<Nūntius<Īnflexor<Hoc, Illud>>> nūntius,
                       in params IEnumerable<Enum> illa)
    {
      Catēgoria = catēgoria;
      Nūntius = nūntius.Value;
      illa.ForEach(haec => Tabula.Add(haec.ToArray().OrderBy(illud => illud, Comparātor)));
    }

    private Hoc? Cōnstruam(in Hoc hoc, in Enum[] illa)
    {
      const string scrīpum = await ScrībamAsync(hoc: hoc, illa: illa);
      try
      {
        return string.IsNullOrWhitespace(scrīptum)
                     .Choose(null, await Cōnstrūctor?.Invoke(illa, scrīptum));
      }
      catch (BuilderException error)
      {
        Nūntius.TerreōAsync(error: error);
        return null;
      }
    }

    public virtual Illud? Īnflectem(in Hoc hoc, in Enum[] illa)
    {
      if (Tabula.Contains(illa))
      {
        const Illud illud = await CōnstruamAsync(hoc: hoc, illa: illa);
        if (illud is null)
        {
          Nūntius.MoneōAsync("Īnflexiō dēfēcit");
        }
        else
        {
          Nūntius.NōtōAsync("Verbum īnflexu'st ut", illud);
        }

        return illud;
      }
      else
      {
        return null;
      }
    }

    public abstract string Scrībam(in Hoc hoc, in Enum[] illa);
  }
}
