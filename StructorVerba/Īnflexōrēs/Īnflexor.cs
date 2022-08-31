using System.Collections.Immutable;
using System.Collections;
using System.Collections.Generic;
using System;

using Nūntiī.Nūntius;
using Miscella.Extensions;
using Praebeunda.Interfecta;
using Praebeunda.Multiplex;
using Ēnumerātiōnēs;
using Ēnumerātiōnēs.Comparātōrēs;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using BuilderCommon.BuilderException;

namespace Īnflexōrēs
{
  [AsyncOverloads]
  public abstract class Īnflexor<Hoc, Illud>
            where Hoc : Īnflexibilis<Hoc, Illud>
            where Illud : Īnflexum<Illud>
  {
    public static readonly Func<Catēgoria, Enum, Īnflexor> Relātor =
            (catēgoria, versiō) => catēgoria switch
            {
              Ēnumerātiōnēs.Catēgoria.Āctus => null,
              Ēnumerātiōnēs.Catēgoria.Adiectīvum => null,
              Ēnumerātiōnēs.Catēgoria.Adverbium => null,
              Ēnumerātiōnēs.Catēgoria.Nōmen => null,
              Ēnumerātiōnēs.Catēgoria.Numerāmen => null,
              Ēnumerātiōnēs.Catēgoria.Prōnōmen => null,
              _ => null
            };

    public readonly Func<ImmutableSortedSet<Enum[]>> Tabulātor => () => Tabula.ToImmutableSortedSet(Tabula.Comparer);
    protected readonly SortedSet<Enum[]> Tabula = new SortedSet<>(ComparātorSeriērum.Faciendum.Value);
    private readonly Comparer<Enum> Comparātor = ComparātorValōrum.Faciendum.Value;
    private readonly Func<string, Enum[], Task<Hoc>>? Cōnstrūctor = Muliplex.Cōnstrūctor.Invoke(Catēgoria);
    private readonly Task? Restitūtor = Muliplex.Restitūtor.Invoke(Catēgoria);

    public readonly Func<Hoc, Task<Illud?>> FortisĪnflexor => hoc => ĪnflectemAsync(hoc, await Tabula.Random());

    protected readonly Nūntius<Īnflexor<Hoc>> Nūntius { get; }
    protected readonly Catēgoria Catēgoria { get; }
    public String prīmum = string.Empty;

    protected Īnflexor(in Catēgoria catēgoria, in Lazy<Nūntius<Īnflexor<Hoc>>> nūntius,
                       in params Enum illa)
    {
      Catēgoria = catēgoria;
      Nūntius = nūntius.Value;

      Array.Sort(illa, Comparātor);
      illa.ForEach(illud => Tabula.Add(new[] { illud }));
    }

    protected Īnflexor(in Catēgoria catēgoria, in Lazy<Nūntius<Īnflexor<Hoc>>> nūntius,
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
        return string.IsNullOrWhitespace(scrīptum).Choose(null, await Cōnstrūctor?.Invoke(illa, scrīptum));
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

        Restitūtor?.Invoke();
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
