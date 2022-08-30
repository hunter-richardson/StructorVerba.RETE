using System.Collections.Immutable;
using System.Collections;
using System.Collections.Generic;
using System;

using Nūntiī.Nūntius;
using Miscella.Extensions;
using Praebeunda.Interfecta.Īnflexiblis;
using Ēnumerātiōnēs;
using Ēnumerātiōnēs.Comparātōrēs;

namespace Īnflexōrēs
{
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
              Ēnumerātiōnēs.Catēgoria.Prōnōmen => null
            };

    public readonly Func<ImmutableSortedSet<Enum[]>> Tabulātor => () => Tabula.ToImmutableSortedSet(Tabula.Comparer);
    protected readonly SortedSet<Enum[]> Tabula = new SortedSet<>(ComparātorSeriērum.Instance);
    protected readonly Comparer<Enum> Comparātor = ComparātorValōrum.Instance;
    protected readonly Func<Enum[], string, Task>? Cōnstrūctor = Catēgoria switch
    {
      Catēgoria.Āctus => Multiplex.Āctus.Cōnstrūctor,
      Catēgoria.Adiectīvum => Multiplex.Adiectīvum.Cōnstrūctor,
      Catēgoria.Adverbium => Multiplex.Adverbium.Cōnstrūctor,
      Catēgoria.Nōmen => Multiplex.Nōmen.Cōnstrūctor,
      Catēgoria.Numerāmen => Multiplex.Numerāmen.Cōnstrūctor,
      Catēgoria.Prōnōmen => Multiplex.Prōnōmen.Cōnstrūctor,
      _ => null
    };

    protected readonly Func<Enum[], string, Task<Illud>>? Restitūtor = Catēgoria switch
    {
      Catēgoria.Āctus => Multiplex.Āctus.Restitūtor,
      Catēgoria.Adiectīvum => Multiplex.Adiectīvum.Restitūtor,
      Catēgoria.Adverbium => Multiplex.Adverbium.Restitūtor,
      Catēgoria.Nōmen => Multiplex.Nōmen.Restitūtor,
      Catēgoria.Numerāmen => Multiplex.Numerāmen.Restitūtor,
      Catēgoria.Prōnōmen => Multiplex.Prōnōmen.Restitūtor,
      _ => null
    };

    public readonly Func<Hoc, Task<Illud?>> FortisĪnflexor => async hoc => Īnflectem(hoc, Tabula.Random());

    protected readonly Nūntius<Īnflexor<Hoc>> Nūntius { get; }
    protected readonly Catēgoria Catēgoria { get; }
    public String prīmum = string.Empty;

    protected Īnflexor(in Catēgoria catēgoria, in Func<Nūntius<Īnflexor<Hoc>>> nūntius,
                       in params Enum illa)
    {
      Catēgoria = catēgoria;
      Nūntius = nūntius.Invoke();
      Tabula.AddAll(illa);
    }

    protected Īnflexor(in Catēgoria catēgoria, in Func<Nūntius<Īnflexor<Hoc>>> nūntius,
                       in params IEnumerable<Enum> illa)
    {
      Catēgoria = catēgoria;
      Nūntius = nūntius.Invoke();
      Tabula.AddAll(from haec in illa
                    select haec);
    }

    public async sealed Illud? Īnflectem(in Hoc hoc, in Enum[] illa)
    {
      if (Tabula.Contains(illa))
      {
        const string scrīptum = Scrībam(hoc, illa);
        const Illud illud = string.IsNullOrEmpty(scrīptum)
                                  .Choose(null, Cōnstrūctor?.Invoke(illa, scrīptum));
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
