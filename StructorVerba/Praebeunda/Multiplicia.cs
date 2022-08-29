using System;
using System.ComponentModel.DataAnnotations;

using Ēnumerātiōnēs;
using Miscella;
using Praebeunda.Interfecta;

using BuilderGenerator;

namespace Praebeunda
{
  public abstract class Multiplex<Hoc> : Verbum<Hoc>
      where Hoc : Īnflexum<Hoc>
  {
    public Encliticum encliticum { get; } => Encliticum.Nōlēns;

    public sealed void allegam(in Encliticum ntlcm)
            => Enum.GetValues<Encliticum>().Any(valor => scrīptum.EndsWith(Enclitica.Suffixor.Invoke(valor))
                                           .Choose(Encliticum.Nōlēns, nltcm));

    public virtual override string ToString()
            => base.ToString().concat(Enclitica.Suffixor.Invoke(encliticum));

    abstract class Speciāle<Hoc> : Multiplex<Hoc>
    {
      public readonly Speciālitās Speciālitās { get; }

      public Speciāle(in int minūtal, in Catēgoria catēgoria, in string scrīpum)
                      : base(minūtal, catēgoria, scrīptum)
      {
        Speciālitās = Speciālitātēs.Ipsius(scrīptum);
      }

      public virtual override string ToString()
              => Speciālitās.Propria.Equals(Speciālitās)
                                    .Choose(base.ToString().Capitalize(), base.ToString());
    }

    [GenerateBuilder]
    public sealed partial class Numerāmen : Multiplex<Numerāmen>, Īnflexum<Numerāmen>
    {
      [Required] public readonly Numerium Numerium { get; }

      protected Numerāmen(in int minūtal, in Numerium numerium, in string scrīpum)
                          : base(minūtal, Catēgoria.Numerāmen, scrīptum)
      {
        Numerium = numerium;
      }
    }

    [GenerateBuilder]
    public sealed partial class Āctus : Multiplex<Āctus>, Īnflexum<Āctus>
    {
      [Required] public readonly Modus Modus { get; }
      [Required] public readonly Vōx Vōx { get; }
      [Required] public readonly Tempus Tempus { get; }
      [Required] public readonly Numerālis Numerālis { get; }
      [Required] public readonly Persōna Persōna { get; }

      private Āctus(in int minūtal, in Modus modus, in Vōx vōx, in Tempus tempus, in Numerālis numerālis,
                    in Persōna persōna, [StringLength(25, MinimumLength = 2)] in string scrīpum)
                    : base(minūtal, Catēgoria.Āctus, scrīptum)
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
      [Required] public readonly Gradus Gradus { get; }

      private Adverbium(in int minūtal, in Gradus gradus, [StringLength(25, MinimumLength = 2)] in string scrīpum)
                        : base(minūtal, Catēgoria.Adverbium, scrīptum)
      {
        Gradus = gradus;
      }
    }

    [GenerateBuilder]
    public sealed partial class Adiectīvum : Speciāle<Adiectīvum>, Īnflexum<Adiectīvum>
    {
      [Required] public readonly Gradus Gradus { get; }
      [Required] public readonly Genus Genus { get; }
      [Required] public readonly Numerālis Numerālis { get; }
      [Required] public readonly Casus Casus { get; }

      private Adiectīvum(in int minūtal, in Gradus gradus, in Genus genus, in Numerālis numerālis,
                         in Casus casus, [StringLength(25, MinimumLength = 2)] in string scrīpum)
                        : base(minūtal, Catēgoria.Adiectīvum, scrīptum)
      {
        Gradus = gradus;
        Genus = genus;
        Numerālis = numerālis;
        Casus = casus;
      }

      public string Contractum()
                => Numerālis.Singulāris.Equals(Numerālis)
                                      .Choose(Scrīptum[Scrīptum.Length - 1].IsAmong('m', 's')
                                                                            .Choose(ToString().Chop(1), ToString())
                                                                            .Concat("'st"),
                                              ToString());
    }

    [GenerateBuilder]
    public sealed partial class Nōmen : Speciāle<Nōmen>, Īnflexum<Nōmen>
    {
      [Required] public readonly Factum Factum { get; }
      [Required] public readonly Numerālis Numerālis { get; }
      [Required] public readonly Casus Casus { get; }
      [Required]
      private Nōmen(in int minūtal, in Factum factum, in Numerālis numerālis,
                    in Casus casus, [StringLength(25, MinimumLength = 2)] in string scrīpum)
                    : base(minūtal, Catēgoria.Nōmen, scrīptum)
      {
        Factum = factum;
        Numerālis = numerālis;
        Casus = casus;
      }
    }

    [GenerateBuilder]
    public sealed partial class Prōnōmen : Multiplex<Prōnōmen>, Īnflexum<Prōnōmen>
    {
      [Required] public readonly Genus Genus { get; }
      [Required] public readonly Numerālis Numerālis { get; }
      [Required] public readonly Casus Casus { get; }
      private Prōnōmen(in int minūtal, in Genus genus, in Numerālis numerālis,
                       in Casus casus, [StringLength(25, MinimumLength = 2)] in string scrīpum)
                      : base(minūtal, Catēgoria.Prōnōmen, scrīptum)
      {
        Genus = genus;
        Numerālis = numerālis;
        Casus = casus;
      }
    }
  }
}
