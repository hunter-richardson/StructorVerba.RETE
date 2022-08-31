using System;
using System.Collections.Generic;
using System.Threading.Tasks.Task;

using Miscella;
using Ēnumerātiōnēs.Comparātōrēs;
using Nūntiī.Nūntius;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

namespace Īnflexōrēs.Incertī
{
  [AsyncOverloads]
  public abstract partial class ĪnflexorIncertus<Hoc>
  {
    private readonly ComparātorSeriērum ComparātorSeriērum = ComparātorSeriērum.Faciendum.Value;
    private readonly ComparātorValōrum ComparātorValōrum = ComparātorValōrum.Faciendum.Value;
    private readonly IDictionary<Enum[], string> Fōrmae = new PredicatedSortedDictionary<Enum[], string>(ComparātorSeriērum,
                                                                                                         Tabula.Contains, "Ēnumerātiō scīta'stō",
                                                                                                         string.IsNullOrWhiteSpace, "Fōrma invacua'stō");
    public readonly Func<IDictionary<Enum[], string>> Fōrmātor = () => Fōrmae.ToImmutableSortedDictionary();
    private readonly Func<string, Enum[], Task<Hoc>>? Cōnstrūctor = Catēgoria switch
    {
      Ēnumerātiōnēs.Catēgoria.Āctus => Multiplex.Āctus.Cōnstrūctor,
      Ēnumerātiōnēs.Catēgoria.Adiectīvum => Multiplex.Adiectīvum.Cōnstrūctor,
      Ēnumerātiōnēs.Catēgoria.Adverbium => Multiplex.Adverbium.Cōnstrūctor,
      Ēnumerātiōnēs.Catēgoria.Nōmen => Multiplex.Nōmen.Cōnstrūctor,
      Ēnumerātiōnēs.Catēgoria.Numerāmen => Multiplex.Numerāmen.Cōnstrūctor,
      Ēnumerātiōnēs.Catēgoria.Prōnōmen => Multiplex.Prōnōmen.Cōnstrūctor,
      _ => null
    };

    private readonly Task? Restitūtor = Catēgoria switch
    {
      Ēnumerātiōnēs.Catēgoria.Āctus => Multiplex.Āctus.Restitūtor,
      Ēnumerātiōnēs.Catēgoria.Adiectīvum => Multiplex.Adiectīvum.Restitūtor,
      Ēnumerātiōnēs.Catēgoria.Adverbium => Multiplex.Adverbium.Restitūtor,
      Ēnumerātiōnēs.Catēgoria.Nōmen => Multiplex.Nōmen.Restitūtor,
      Ēnumerātiōnēs.Catēgoria.Numerāmen => Multiplex.Numerāmen.Restitūtor,
      Ēnumerātiōnēs.Catēgoria.Prōnōmen => Multiplex.Prōnōmen.Restitūtor,
      _ => null
    };

    private readonly SortedSet<Enum[]> Tabula = new SortedSet<Enum[]>(ComparātorSeriērum);
    public readonly Func<IEnumerable<Enum[]>> Tabulātor = () => Tabula.ToImmutableSortedSet();
    private readonly Ēnumerātiōnēs.Catēgoria Catēgoria { get; }
    protected readonly Nūntius<ĪnflexorIncertus> Nūntius { get; }
    protected ĪnflexorIncertus(in Ēnumerātiōnēs.Catēgoria catēgoria, in Lazy<Nūntius<ĪnflexorIncertus>> nūntius,
                               in params IEnumerable<Enum[]> illa)
    {
      Catēgoria = catēgoria;
      Nūntius = nūntius.Value;
      illa.ForEach(haec => Tabula.Add(haec.Sort(ComparātorValōrum)));
    }

    public sealed void Fōrmam(in string fōrma, in params Enum illa)
    {
      Array.Sort(illa, ComparātorValōrum);
      try
      {
        Fōrmae.AddAsync(illa, fōrma);
      }
      catch (ArgumentException error)
      {
        Nūntius.TerreōAsync(error);
      }
    }

    public virtual string? Scrībam(in params Enum illa)
              => await Ūtilitātēs.Seriēs((from linea in Fōrmae
                                          where ComparātorSeriērum.Equals(linea.Key, illa.Sort(ComparātorValōrum))
                                          select linea.Value).First(),
                                        (from linea in Fōrmae
                                         where illa.ContainsAll(linea.Key)
                                         select linea.Value).Single(),
                                        Fōrmae.Item[illa])
                                 .FirstNonNull();

    private Hoc? Cōnstruam(in Enum[] illa)
    {
      const string scrīpum = await ScrībamAsync(illa);
      try
      {
        return string.IsNullOrWhitespace(scrīptum)
                     .Choose(null, await Cōnstrūctor?.Invoke(illa, scrīptum));
      }
      catch (BuilderException error)
      {
        Nūntius.TerreōAsync(error);
        return null;
      }
    }

    public sealed Hoc? Īnflectem(in Enum[] illa)
    {
      if (Tabula.Contains(illa))
      {
        const Illud illud = await CōnstruamAsync(illa);
        if (illud is null)
        {
          Nūntius.MoneōAsync("Īnflexiō dēfēcit");
        }
        else
        {
          Nūntius.NōtōAsync("Verbum īnflexu'st ut", illud);
        }

        await Restitūtor?.Invoke();
        return illud;
      }
      else
      {
        return null;
      }
    }
  }
}
