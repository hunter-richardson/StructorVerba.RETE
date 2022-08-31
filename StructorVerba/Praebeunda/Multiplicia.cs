using System.Collections.Immutable;
using System;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

using Ēnumerātiōnēs;
using Miscella;
using Praebeunda.Interfecta;

using BuilderGenerator.GenerateBuilderAttribute;

namespace Praebeunda
{
  public abstract class Multiplex<Hoc> : Verbum<Hoc> where Hoc : Īnflexum<Hoc>
      where Hoc : Īnflexum<Hoc>
  {
    public Ēnumerātiōnēs.Encliticum Encliticum { get; } => Ēnumerātiōnēs.Encliticum.Nōlēns;

    public sealed void allegam(in Ēnumerātiōnēs.Encliticum ntlcm)
            => Enum.GetValues<Encliticum>().Any(valor => scrīptum.EndsWith(Enclitica.Suffixor.Invoke(valor))
                                           .Choose(Ēnumerātiōnēs.Encliticum.Nōlēns, nltcm));

    public virtual override string ToString()
            => base.ToString().concat(Enclitica.Suffixor.Invoke(encliticum));

    abstract class Speciāle<Hoc> : Multiplex<Hoc>
    {
      public readonly Speciālitās Speciālitās { get; }

      public Speciāle(in int minūtal, in Ēnumerātiōnēs.Catēgoria catēgoria, in string scrīpum)
                      : base(minūtal, catēgoria, scrīptum)
      {
        Speciālitās = Speciālitātēs.Ipsius(scrīptum);
      }

      public virtual override string ToString()
              => Ēnumerātiōnēs.Speciālitās.Propria.Equals(Speciālitās)
                                                  .Choose(base.ToString().Capitalize(), base.ToString());
    }

    [GenerateBuilder]
    public sealed partial class Numerāmen : Multiplex<Numerāmen>, Īnflexum<Numerāmen>
    {
      public static readonly Func<Task> Restitūtor = async () => Builder.WithNumerium(default).WithScrīpum(string.Empty);

      public static readonly Func<Enum[], string, Task<Numerāmen>> Cōnstrūctor = async (illa, scrīpum) =>
      {
        const Numerium numerium = Gradūs.Iactor.Invoke((from illud in illa
                                                        where illud is Ēnumerātiōnēs.Numerium
                                                        select illud).First());
        return Builder.WithNumerium(numerium).WithScrīpum(scrīpum).Build();
      };

      [Required] public readonly Numerium Numerium { get; }

      protected Numerāmen(in int minūtal, in Ēnumerātiōnēs.Numerium numerium, in string scrīpum)
                          : base(minūtal, Ēnumerātiōnēs.Catēgoria.Numerāmen, scrīptum)
      {
        Numerium = numerium;
      }
    }

    [GenerateBuilder]
    public sealed partial class Āctus : Multiplex<Āctus>, Īnflexum<Āctus>
    {
      public static readonly Func<Task> Restitūtor = async () => Builder.WithModus(default).WithVōx(default).WithTempus(default)
                                                                        .WithNumerālis(default).WithPersōna(default).WithScrīpum(string.Empty);

      public static readonly Func<Enum[], string, Task<Āctus>> Cōnstrūctor = async (illa, scrīpum) =>
      {
        const Enum modus = Modī.Iactor.Invoke((from illud in illa
                                               where illud is Ēnumerātiōnēs.Modus
                                               select illud).First()),
                   vōx = Vōcēs.Iactor.Invoke((from illud in illa
                                              where illud is Ēnumerātiōnēs.Vōx
                                              select illud).First()),
                   tempus = Tempora.Iactor.Invoke((from illud in illa
                                                   where illud is Ēnumerātiōnēs.Tempus
                                                   select illud).First()),
                   numerālis = Numerālēs.Iactor.Invoke((from illud in illa
                                                        where Ēnumerātiōnēs.Numerālis
                                                        select illud).First()),
                   persōna = Numerālēs.Iactor.Invoke((from illud in illa
                                                      where Ēnumerātiōnēs.Persōna
                                                      select illud).First());
        return Builder.WithModus(modus).WithVōx(vōx).WithTempus(tempus)
                      .WithNumerālis(numerālis).WithPersōna(persōna)
                      .WithScrīpum(scrīpum).Build();
      };

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
      public static readonly Func<Task> Restitūtor = async () => Builder.WithGradus(default).WithScrīpum(string.Empty);

      public static readonly Func<Enum[], string, Task<Adverbium>> Cōnstrūctor = async (illa, scrīpum) =>
      {
        const Gradus gradus = Gradūs.Iactor.Invoke((from illud in illa
                                                    where illud is Ēnumerātiōnēs.Gradus
                                                    select illud).First());
        return Builder.WithGradus(gradus).WithScrīpum(scrīpum).Build();
      };

      [Required] public readonly Gradus Gradus { get; }

      private Adverbium(in int minūtal, in Ēnumerātiōnēs.Gradus gradus, [StringLength(25, MinimumLength = 2)] in string scrīpum)
                        : base(minūtal, Ēnumerātiōnēs.Catēgoria.Adverbium, scrīptum)
      {
        Gradus = gradus;
      }
    }

    [GenerateBuilder]
    public sealed partial class Adiectīvum : Speciāle<Adiectīvum>, Īnflexum<Adiectīvum>
    {
      public static readonly Func<Task> Restitūtor = async () => Builder.WithGradus(default).WithGenus(default)
                                                              .WithNumerālis(default).WithCasus(default)
                                                              .WithScrīpum(string.Empty);

      public static readonly Func<Enum[], string, Task<Adiectīvum>> Cōnstrūctor = async (illa, scrīpum) =>
      {
        const Enum gradus = Gradūs.Iactor.Invoke((from illud in illa
                                                  where illud is Ēnumerātiōnēs.Gradus
                                                  select illud).First()),
                   genus = Genera.Iactor.Invoke((from illud in illa
                                                 where illud is Ēnumerātiōnēs.Genus
                                                 select illud).First()),
                   numerālis = Numerālēs.Iactor.Invoke((from illud in illa
                                                        where Ēnumerātiōnēs.Numerālis
                                                        select illud).First()),
                   casus = Casūs.Iactor.Invoke((from illud in illa
                                                where Ēnumerātiōnēs.Casus
                                                select illud).First());
        return Builder.WithGradus(gradus).WithGenus(genus)
                      .WithNumerālis(numerālis).WithCasus(casus)
                      .WithScrīpum(scrīpum).Build();
      };

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
      public static readonly Func<Task> Restitūtor = async () => Builder.WithFactum(default).WithGenus(default)
                                                                        .WithNumerālis(default).WithCasus(default)
                                                                        .WithScrīpum(string.Empty);

      public static readonly Func<Enum[], string, Task<Nōmen>> Cōnstrūctor = async (illa, scrīpum) =>
      {
        const Enum factum = Facta.Iactor.Invoke((from illud in illa
                                                 where illud is Ēnumerātiōnēs.Factum
                                                 select illud).First()),
                   numerālis = Numerālēs.Iactor.Invoke((from illud in illa
                                                        where Ēnumerātiōnēs.Numerālis
                                                        select illud).First()),
                   casus = Casūs.Iactor.Invoke((from illud in illa
                                                where Ēnumerātiōnēs.Casus
                                                select illud).First());
        return Builder.WithFactum(factum).WithCasus(casus)
                      .WithNumerālis(numerālis)
                      .WithScrīpum(scrīpum).Build();
      };

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
      public static readonly Func<Task> Restitūtor = async () => Builder.WithGenus(default).WithCasus(default)
                                                                        .WithNumerālis(default).WithScrīpum(string.Empty);

      public static readonly Func<Enum[], string, Task<Adiectīvum>> Cōnstrūctor = async (illa, scrīpum) =>
      {
        const Enum genus = Genera.Iactor.Invoke((from illud in illa
                                                 where illud is Ēnumerātiōnēs.Genus
                                                 select illud).First()),
                   numerālis = Numerālēs.Iactor.Invoke((from illud in illa
                                                        where Ēnumerātiōnēs.Numerālis
                                                        select illud).First()),
                   casus = Casūs.Iactor.Invoke((from illud in illa
                                                where Ēnumerātiōnēs.Casus
                                                select illud).First());
        return Builder.WithGenus(genus).WithCasus(casus)
                      .WithNumerālis(numerālis)
                      .WithScrīpum(scrīpum).Build();
      };

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
