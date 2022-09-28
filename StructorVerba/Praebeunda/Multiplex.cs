using System;
using System.Collections.Immutable;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

using Miscella;
using Praebeunda.Interfecta;
using Ēnumerātiōnēs;

using BuilderGenerator.GenerateBuilderAttribute;

namespace Praebeunda
{
  public abstract class Multiplex<Hoc> : Verbum<Hoc> where Hoc : Īnflexum<Hoc>
      where Hoc : Īnflexum<Hoc>
  {
    private readonly Func<Enum[], string, Task<Hoc>>? Cōnstrūctor = Catēgoria switch
    {
      Ēnumerātiōnēs.Catēgoria.Āctus => Multiplex.Āctus.Cōnstrūctor,
      Ēnumerātiōnēs.Catēgoria.Adiectīvum => Multiplex.Adiectīvum.Cōnstrūctor,
      Ēnumerātiōnēs.Catēgoria.Adverbium => Multiplex.Adverbium.Cōnstrūctor,
      Ēnumerātiōnēs.Catēgoria.Nōmen => Multiplex.Nōmen.Cōnstrūctor,
      Ēnumerātiōnēs.Catēgoria.Numerāmen => Multiplex.Numerāmen.Cōnstrūctor,
      Ēnumerātiōnēs.Catēgoria.Prōnōmen => Multiplex.Prōnōmen.Cōnstrūctor,
      _ => null
    };

    public Ēnumerātiōnēs.Encliticum Encliticum { get; } => Ēnumerātiōnēs.Encliticum.Nōlēns;

    public sealed Hoc Allegam(in Ēnumerātiōnēs.Encliticum ntlcm)
    {
      Encliticum = Encliticum.GetValues().Any(valor => scrīptum.EndsWith(valor.ToString())
                                         .Choose(Ēnumerātiōnēs.Encliticum.Nōlēns, nltcm));
      return this.Cast<Hoc>();
    }

    public virtual override string ToString()
            => base.ToString().concat(Enclitica.Suffixor.Invoke(encliticum));

    abstract class Speciāle<Hoc> : Multiplex<Hoc>
    {
      public readonly Speciālitās Speciālitās { get; }

      public Speciāle(in int minūtal, in Ēnumerātiōnēs.Catēgoria catēgoria, in string scrīpum)
                      : base(minūtal, catēgoria, scrīptum)
              => Speciālitās = Speciālitātēs.Ipsius(scrīptum);

      public virtual override string ToString()
              => Ēnumerātiōnēs.Speciālitās.Propria.Equals(Speciālitās)
                                                  .Choose(base.ToString().Capitalize(), base.ToString());
    }

    [GenerateBuilder]
    public sealed partial class Numerāmen : Multiplex<Numerāmen>, Īnflexum<Numerāmen>
    {
      private readonly Lazy<Lēctor> Lēctor = Lēctor.Faciendum;
      private readonly Lazy<Numerātor> Numerātor = Numerātor.Faciendum;

      public static readonly Func<Enum[], string, Task<Numerāmen>> Cōnstrūctor
                = async (illa, scrīpum) => Builder.Numerium(illa.FirstOf<Numerium>())
                                                  .Minūtal(HashCode.Combine(scrīptum, Ēnumerātiōnēs.Catēgoria.Numerāmen))
                                                  .Scrīpum(scrīpum).Build();

      private readonly Func<Catēgoria> Classificātor
            = () => Numerium switch
                    {
                      Numerium.Adverbium => Catēgoria.Adverbium,
                      Numerium.Numerus => Catēgoria.Numerus,
                      Numerium.Frāctiōnāle => Catēgoria.Nōmen,
                      _ => Catēgoria.Adiectīvum
                    };

      public readonly Func<Enum[], Task<Verbum?>> Relātor
            = async illa =>
                    {
                      const Catēgoria catēgoria = Classificātor.Invome(Numerium);
                      return (catēgoria is Catēgoria.Numerus)
                                .Choose(Numerātor.Value.Generātor.Invoke(Scrīptum),
                                        Lēctor.Value.Inveniam(Scrīptum, catēgoria, illa));
                    };

      [Required] public readonly Numerium Numerium { get; }

      protected Numerāmen(in int minūtal, in Ēnumerātiōnēs.Numerium numerium, in string scrīpum)
                          : base(minūtal, in Ēnumerātiōnēs.Catēgoria.Numerāmen, scrīptum)
                => Numerium = numerium;
    }

    [GenerateBuilder]
    public sealed partial class Āctus : Multiplex<Āctus>, Īnflexum<Āctus>
    {
      private readonly Lazy<OfficīnaĪnflexōrum> Adiectīva = OfficīnaĪnflexōrum.Officīnātor.Invoke(Catēgoria.Adiectīvum);

      public static readonly Func<Enum[], string, Task<Āctus>> Cōnstrūctor
                = async (illa, scrīpum) => Builder.Modus(illa.FirstOf<Modus>())
                                                  .Vōx(illa.FirstOf<Vōx>())
                                                  .Tempus(illa.FirstOf<Tempus>())
                                                  .Numerālis(illa.FirstOf<Numerālis>())
                                                  .Persōna(illa.FirstOf<Persōna>())
                                                  .Minūtal(HashCode.Combine(scrīptum, Ēnumerātiōnēs.Catēgoria.Āctus))
                                                  .Scrīpum(scrīpum).Build();

      public readonly Func<Enum[], Task<Adiectīvum?>> Relātor
          = async illa => (modus is Modus.Participālis)
                              .Choose(Adiectīva.Value.Inventor.Invoke(Scrīptum, illa), null);

      [Required] public readonly Modus Modus { get; }
      [Required] public readonly Vōx Vōx { get; }
      [Required] public readonly Tempus Tempus { get; }
      [Required] public readonly Numerālis Numerālis { get; }
      [Required] public readonly Persōna Persōna { get; }

      private Āctus(in int minūtal, in Ēnumerātiōnēs.Modus modus, in Ēnumerātiōnēs.Vōx vōx,
                    in Ēnumerātiōnēs.Tempus tempus, in Ēnumerātiōnēs.Numerālis numerālis,
                    in Ēnumerātiōnēs.Persōna persōna, [StringLength(25, MinimumLength = 2)] in string scrīpum)
                    : base(minūtal, Ēnumerātiōnēs.Catēgoria.Āctus, scrīptum)
      {
        Modus = modus;
        Vōx = vōx;
        Tempus = tempus;
        Numerālis = numerālis;
        Persōna = persōna;
      }
    }

    [GenerateBuilder]
    public sealed partial class Adverbium : Speciāle<Adverbium>, Īnflexum<Adverbium>
    {
      public static readonly Func<Enum[], string, Task<Adverbium>> Cōnstrūctor
                = async (illa, scrīpum) =>  Builder.Gradus(illa.FirstOf<Gradus>())
                                                   .Minūtal(HashCode.Combine(scrīptum, Ēnumerātiōnēs.Catēgoria.Adverbium))
                                                   .Scrīpum(scrīpum).Build();

      [Required] public readonly Gradus Gradus { get; }

      private Adverbium(in int minūtal, in Ēnumerātiōnēs.Gradus gradus,
                        [StringLength(25, MinimumLength = 2)] in string scrīpum)
                        : base(minūtal, Ēnumerātiōnēs.Catēgoria.Adverbium, scrīptum)
                => Gradus = gradus;
    }

    [GenerateBuilder]
    public sealed partial class Adiectīvum : Speciāle<Adiectīvum>, Īnflexum<Adiectīvum>
    {
      public static readonly Func<Enum[], string, Task<Adiectīvum>> Cōnstrūctor
                = async (illa, scrīpum) => Builder.Gradus(illa.FirstOf<Gradus>())
                                                  .Genus(illa.FirstOf<Genus>())
                                                  .Numerālis(illa.FirstOf<Numerālis>())
                                                  .Casus(illa.FirstOf<Casus>())
                                                  .Minūtal(HashCode.Combine(scrīptum, Ēnumerātiōnēs.Catēgoria.Adiectīvum))
                                                  .Scrīpum(scrīpum).Build();

      [Required] public readonly Ēnumerātiōnēs.Gradus Gradus { get; }
      [Required] public readonly Ēnumerātiōnēs.Genus Genus { get; }
      [Required] public readonly Ēnumerātiōnēs.Numerālis Numerālis { get; }
      [Required] public readonly Ēnumerātiōnēs.Casus Casus { get; }

      private Adiectīvum(in int minūtal, in Ēnumerātiōnēs.Gradus gradus, in Ēnumerātiōnēs.Genus genus, in Ēnumerātiōnēs.Numerālis numerālis,
                         in Ēnumerātiōnēs.Casus casus, [StringLength(25, MinimumLength = 2)] in string scrīpum)
                        : base(minūtal, Ēnumerātiōnēs.Catēgoria.Adiectīvum, scrīptum)
      {
        Gradus = gradus;
        Genus = genus;
        Numerālis = numerālis;
        Casus = casus;
      }

      public string Contractum()
                => Ēnumerātiōnēs.Numerālis.Singulāris.Equals(Numerālis)
                                                     .Choose(Scrīptum[Scrīptum.Length - 1].IsAmong('m', 's')
                                                                                          .Choose(ToString().Chop(1), ToString())
                                                                                          .Concat("'st"),
                                                             ToString());
    }

    [GenerateBuilder]
    public sealed partial class Nōmen : Speciāle<Nōmen>, Īnflexum<Nōmen>
    {
      public static readonly Func<Enum[], string, Task<Nōmen>> Cōnstrūctor
                = async (illa, scrīpum) => Builder.Factum(illa.FirstOf<Factum>())
                                                  .Casus(illa.FirstOf<Casus>())
                                                  .Numerālis(illa.FirstOf<Numerālis>())
                                                  .Minūtal(HashCode.Combine(scrīptum, Ēnumerātiōnēs.Catēgoria.Nōmen))
                                                  .Scrīpum(scrīpum).Build();

      [Required] public readonly Factum Factum { get; }
      [Required] public readonly Numerālis Numerālis { get; }
      [Required] public readonly Casus Casus { get; }
      [Required]
      private Nōmen(in int minūtal, in Ēnumerātiōnēs.Factum factum, in Ēnumerātiōnēs.Numerālis numerālis,
                    in Ēnumerātiōnēs.Casus casus, [StringLength(25, MinimumLength = 2)] in string scrīpum)
                    : base(minūtal, Ēnumerātiōnēs.Catēgoria.Nōmen, scrīptum)
      {
        Factum = factum;
        Numerālis = numerālis;
        Casus = casus;
      }
    }

    [GenerateBuilder]
    public sealed partial class Prōnōmen : Multiplex<Prōnōmen>, Īnflexum<Prōnōmen>
    {
      public static readonly Func<Enum[], string, Task<Adiectīvum>> Cōnstrūctor
                = async (illa, scrīpum) => Builder.Genus(illa.FirstOf<Genus>())
                                                  .Numerālis(illa.FirstOf<Numerālis>())
                                                  .Casus(illa.FirstOf<Casus>())
                                                  .Minūtal(HashCode.Combine(scrīptum, Ēnumerātiōnēs.Catēgoria.Prōnōmen))
                                                  .Scrīpum(scrīpum).Build();

      [Required] public readonly Ēnumerātiōnēs.Genus Genus { get; }
      [Required] public readonly Ēnumerātiōnēs.Numerālis Numerālis { get; }
      [Required] public readonly Ēnumerātiōnēs.Casus Casus { get; }
      private Prōnōmen(in int minūtal, in Ēnumerātiōnēs.Genus genus, in Ēnumerātiōnēs.Numerālis numerālis,
                       in Ēnumerātiōnēs.Casus casus, [StringLength(25, MinimumLength = 2)] in string scrīpum)
                      : base(minūtal, Ēnumerātiōnēs.Catēgoria.Prōnōmen, scrīptum)
      {
        Genus = genus;
        Numerālis = numerālis;
        Casus = casus;
      }
    }
  }
}
