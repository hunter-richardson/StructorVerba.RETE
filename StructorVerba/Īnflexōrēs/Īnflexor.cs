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
using Īnflexōrēs.Effectī.Āctūs;
using Īnflexōrēs.Effectī.Adiectīva;
using Īnflexōrēs.Effectī.Nōmina;
using Īnflexōrēs.Effectī.Numerāmina;

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
            (catēgoria, versiō) => await catēgoria switch
            {
              Ēnumerātiōnēs.Catēgoria.Adverbium => ĪnflexorAdverbiīs.Faciendum,
              Ēnumerātiōnēs.Catēgoria.Āctus => ĪnflexorEffectusĀctibus.Relātor.Invoke(versiō),
              Ēnumerātiōnēs.Catēgoria.Adiectīvum => ĪnflexorAdiectīvīs.Relātor.Invoke(versiō),
              Ēnumerātiōnēs.Catēgoria.Nōmen => ĪnflexorEffectusNōminibus.Versor.Invoke(versiō),
              Ēnumerātiōnēs.Catēgoria.Numerāmen => ĪnflexorNumerāminibus.Relātor.Invoke(versiō),
              _ => new Lazy(null)
            };

    public readonly Func<string, Task<Enum?>> Versor
              = async versiō => (from valor in Ūtilitātēs.Complānō(Comparātor,
                                                                   ĪnflexorAdverbiīs.Versiō.GetValues(),
                                                                   ĪnflexorEffectusĀctibus.Versiō.GetValues(),
                                                                   ĪnflexorEffectusAdiectīvīs.Versiō.GetValues(),
                                                                   ĪnflexorEffectusNōminibus.Versiō.GetValues(),
                                                                   ĪnflexorNumerāminibus.Versiō.GetValues())
                                 where valor.ToString().Equals(versiō, StringComparison.OrdinalIgnoreCase)
                                 select valor).FirstNonNull(null);

    public readonly Func<ISet<Enum[]>> Tabulātor => () => Tabula.ToImmutableSortedSet(Tabula.Comparer);
    protected readonly SortedSet<Enum[]> Tabula = new SortedSet<>(ComparātorSeriērum.Faciendum.Value);
    private readonly Comparer<Enum> Comparātor = ComparātorValōrum.Faciendum.Value;
    private readonly Func<string, Enum[], Task<Hoc>>? Cōnstrūctor = Muliplex.Cōnstrūctor.Invoke(Catēgoria);
    public readonly Func<Hoc, Task<Illud?>> FortisĪnflexor => hoc => ĪnflectemAsync(hoc, await Tabula.Random());

    protected readonly Nūntius<Īnflexor<Hoc>> Nūntius { get; }
    protected readonly Ēnumerātiōnēs.Catēgoria Catēgoria { get; }
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
      const string scrīpum = await ScrībamAsync(hoc, illa);
      try
      {
        return string.IsNullOrWhitespace(scrīptum)
                     .Choose(null, await Cōnstrūctor?.Invoke(illa, scrīptum));
      }
      catch (BuilderException error)
      {
        Nūntius.Terreō(error);
        return null;
      }
    }

    public sealed Illud? Īnflectem(in Hoc hoc, in Enum[] illa)
    {
      if (Tabula.Contains(illa))
      {
        const Illud illud = await CōnstruamAsync(hoc, illa);
        if (illud is null)
        {
          Nūntius.Moneō("Īnflexiō dēfēcit");
        }
        else
        {
          Nūntius.Nōtō("Verbum īnflexu'st ut", illud);
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
