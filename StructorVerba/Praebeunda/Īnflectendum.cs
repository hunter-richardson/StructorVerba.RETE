using System;
using System.Reflection;
using System.Text.Json.JsonElement;
using System.Threading.Tasks.Task;

using Praebeunda.Interfecta;
using Praebeunda.Multiplex;

using Lombok.NET.ConstructorGenerators.AllArgsConstructorAttribute;
using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

namespace Praebeunda
{
  [AsyncOverloads]
  [AllArgsConstructor(MemberTypes.Property, Access.Protected)]
  public abstract partial class Īnflectendum<Hoc, Illud> : Pēnsābile<Hoc>, Īnflexiblis<Hoc>
            where Hoc : Īnflectendum<Hoc, Illud> where Illud : Īnflexum<Illud>
  {
    public readonly int Minūtal { get; }
    public readonly Ēnumerātiōnēs.Catēgoria Catēgoria { get; }
    public readonly Enum Versiō { get; }

    private readonly Īnflexor<Hoc, Illud>? Īnflexor => Īnflexōrēs.Īnflexor.Relātor.Invoke(Catēgoria, Versiō).Value;
    public readonly Func<Īnflectendum<Task<Illud?>>> FortisĪnflexor = async () => Īnflexor?.FortisĪnflexor.Invoke(this);

    public sealed Illud? Īnflectem(in params Enum illa)
    {
      return Īnflexor?.ĪnflectemAsync(this, illa);
    }

    public sealed class Adverbium : Īnflectendum<Adverbium, Multiplex.Adverbium>
    {
      public static readonly Func<JsonElement, Enum, Task<Adverbium>> Lēctor =
                async (legendum, valor) => new Adverbium(legendum.GetProperty(nameof(Minūtal).ToLower()).GetInt32(), valor,
                                                         legendum.GetProperty(nameof(Positīvum).ToLower()).GetString(),
                                                         legendum.GetProperty(nameof(Comparātīvum).ToLower()).GetString(),
                                                         legendum.GetProperty(nameof(Superlātīvum).ToLower()).GetString());

      private AdverbiumExāctum(in int minūtal, in string positīvum,
                               in string comparātīvum, in string superlātīvum)
                               : base(minūtal, Ēnumerātiōnēs.Catēgoria.Adverbium)
      {
        Positīvum = positīvum;
        Comparātīvum = comparātīvum;
        Superlātīvum = superlātīvum;
      }

      public readonly string Positīvum { get; }
      public readonly string Comparātīvum { get; }
      public readonly string Superlātīvum { get; }
      public string ToString() => Positīvum;
    }

    [AllArgsConstructor(MemberTypes.Property, Access.Private)]
    public sealed class Āctus : Īnflectendum<Āctus, Multiplex.Āctus>
    {
      public static readonly Func<JsonElement, Enum, Task<Āctus>> Lēctor =
                async (legendum, valor) => new Āctus(legendum.GetProperty(nameof(Minūtal).ToLower()).GetInt32(), valor,
                                                     legendum.GetProperty(nameof(Īnfīnītīvum).ToLower()).GetString(),
                                                     legendum.GetProperty(nameof(Perfectum).ToLower()).GetString() ?? string.Empty,
                                                     legendum.GetProperty(nameof(Supīnum).ToLower()).GetString() ?? string.Empty);
      private Āctus(in int minūtal, in string īnfīnītīvum,
                    in string perfectum, in string supīnum)
                     : base(minūtal, Ēnumerātiōnēs.Catēgoria.Āctus)
      {
        Īnfīnītīvum = īnfīnītīvum;
        Perfectum = perfectum;
        Supīnum = supīnum;
      }

      public readonly string Īnfīnītīvum { get; }
      public readonly string Perfectum { get; }
      public readonly string Supīnum { get; }
      public string ToString() => Īnfīnītīvum;
    }

    public sealed class Prōnōmen : Īnflectendum<Prōnōmen, Multiplex.Prōnōmen>
    {
      public static readonly Func<JsonElement, Enum, Task<Prōnōmen>> Lēctor =
                async (legendum, valor) => new Nōmen(legendum.GetProperty(nameof(Minūtal).ToLower()).GetInt32(), valor,
                                                     legendum.GetProperty(nameof(Nominātīvum).ToLower()).GetString(),
                                                     legendum.GetProperty(nameof(Genitīvum).ToLower()).GetString());
      private Prōnōmen(in int minūtal, in string nōminātīvum, in string genitīvum)
                       : base(minūtal, Ēnumerātiōnēs.Catēgoria.Nōmen)
      {
        Nominātīvum = nōminātīvum;
        Genitīvum = genitīvum;
      }

      public readonly string Nominātīvum { get; }
      public readonly string Genitīvum { get; }
      public string ToString() => Nominātīvum;
    }

    public sealed class Nōmen : Īnflectendum<Nōmen, Multiplex.Nōmen>
    {
      public static readonly Func<JsonElement, Enum, Task<Nōmen>> Lēctor =
                async (legendum, valor) => new Nōmen(legendum.GetProperty(nameof(Minūtal).ToLower()).GetInt32(), valor,
                                                     legendum.GetProperty(nameof(Nominātīvum).ToLower()).GetString(),
                                                     legendum.GetProperty(nameof(Genitīvum).ToLower()).GetString());
      private Nōmen(in int minūtal, in string nōminātīvum, in string genitīvum)
                    : base(minūtal, Ēnumerātiōnēs.Catēgoria.Nōmen)
      {
        Nominātīvum = nōminātīvum;
        Genitīvum = genitīvum;
      }

      public readonly string Nominātīvum { get; }
      public readonly string Genitīvum { get; }
      public string ToString() => Nominātīvum;
    }

    public sealed class NōmenFactum : Īnflectendum<NōmenFactum, Multiplex.Nōmen>
    {
      public static readonly Func<JsonElement, Enum, Task<NōmenFactum>> Lēctor =
                async (legendum, valor) => new NōmenFactum(legendum.GetProperty(nameof(Minūtal).ToLower()).GetInt32(), valor,
                                                           legendum.GetProperty(nameof(Īnfīnītīvum).ToLower()).GetString(),
                                                           legendum.GetProperty(nameof(Supīnum).ToLower()).GetString() ?? string.Empty);
      private NōmenFactum(in int minūtal, in string īnfīnītīvum, in string supīnum)
                          : base(minūtal, Ēnumerātiōnēs.Catēgoria.Nōmen)
      {
        Īnfīnītīvum = īnfīnītīvum;
        Supīnum = supīnum;
      }

      public readonly string Īnfīnītīvum { get; }
      public readonly string Supīnum { get; }
      public string ToString() => Īnfīnītīvum;
    }

    public sealed class AdiectīvumAutPrīmumAutSecundumAutTertium : Īnflectendum<AdiectīvumAutPrīmumAutSecundumAutTertium, Multiplex.Adiectīvum>
    {
      public static readonly Func<JsonElement, Enum, Task<AdiectīvumAutPrīmumAutSecundumAutTertium>> Lēctor =
                async (legendum, valor) => new AdiectīvumAutPrīmumAutSecundumAutTertium(legendum.GetProperty(nameof(Minūtal).ToLower()).GetInt32(), valor,
                                                                                        legendum.GetProperty(nameof(Positīvum).ToLower()).GetString(),
                                                                                        legendum.GetProperty(nameof(Comparātīvum).ToLower()).GetString() ?? string.Empty,
                                                                                        legendum.GetProperty(nameof(Superlātīvum).ToLower()).GetString() ?? string.Empty);
      private AdiectīvumAutPrīmumAutSecundumAutTertium(in int minūtal, in string positīvum, in string comparātīvum, in string superlātīvum)
                                                       : base(minūtal, Ēnumerātiōnēs.Catēgoria.Adiectīvum)
      {
        Positīvum = positīvum;
        Comparātīvum = comparātīvum;
        Superlātīvum = superlātīvum;
      }

      public readonly string Positīvum { get; }
      public readonly string Comparātīvum { get; }
      public readonly string Superlātīvum { get; }
      public string ToString() => Positīvum;
    }

    public sealed class AdiectīvumTertiumAutPrīmumAutSecundum : Īnflectendum<AdiectīvumTertiumAutPrīmumAutSecundum, Multiplex.Adiectīvum>
    {
      public static readonly Func<JsonElement, Enum, Task<AdiectīvumTertiumAutPrīmumAutSecundum>> Lēctor =
                async (legendum, valor) => new AdiectīvumTertiumAutPrīmumAutSecundum(legendum.GetProperty(nameof(Minūtal).ToLower()).GetInt32(), valor,
                                                                                     legendum.GetProperty(nameof(Nominātīvum).ToLower()).GetString(),
                                                                                     legendum.GetProperty(nameof(Genitīvum).ToLower()).GetString());
      private AdiectīvumTertiumAutPrīmumAutSecundum(in int minūtal, in string nominātīvum, in string genitīvum)
                                                    : base(minūtal, Ēnumerātiōnēs.Catēgoria.Adiectīvum)
      {
        Nominātīvum = nominātīvum;
        Genitīvum = genitīvum;
      }

      public readonly string Nominātīvum { get; }
      public readonly string Genitīvum { get; }
      public string ToString() => Nominātīvum;
    }

    public sealed class NumerāmenOmnium : Īnflectendum<NumerāmenOmnium, Multiplex.Numerāmen>
    {
      public static readonly Func<JsonElement, Enum, Task<NumerāmenOmnium>> Lēctor =
                async (legendum, valor) => new NumerāmenOmnium(legendum.GetProperty(nameof(Minūtal).ToLower()).GetInt32(), valor,
                                                               legendum.GetProperty(nameof(Numerus).ToLower()).GetString(),
                                                               legendum.GetProperty(nameof(Cardināle).ToLower()).GetString(),
                                                               legendum.GetProperty(nameof(Ōrdināle).ToLower()).GetString(),
                                                               legendum.GetProperty(nameof(Adverbium).ToLower()).GetString(),
                                                               legendum.GetProperty(nameof(Multiplicātīvum).ToLower()).GetString(),
                                                               legendum.GetProperty(nameof(Distribūtīvum).ToLower()).GetString(),
                                                               legendum.GetProperty(nameof(Frāctiōnāle).ToLower()).GetString());

      private NumerāmenOmnium(in int minūtal, in string numerus, in string cardināle, in string ōrdināle,
                              in string adverbium, in string multiplicātīvum, in string distribūtīvum, in string frāctiōnāle)
                              : base(minūtal, Ēnumerātiōnēs.Catēgoria.Numerāmen)
      {
        Numerus = numerus;
        Cardināle = cardināle;
        Ōrdināle = ōrdināle;
        Adverbium = adverbium;
        Multiplicātīvum = multiplicātīvum;
        Distribūtīvum = distribūtīvum;
        Frāctiōnāle = frāctiōnāle;
      }

      public readonly string Numerus { get; }
      public readonly string Cardināle { get; }
      public readonly string Ōrdināle { get; }
      public readonly string Adverbium { get; }
      public readonly string Multiplicātīvum { get; }
      public readonly string Distribūtīvum { get; }
      public readonly string Frāctiōnāle { get; }
      public string ToString() => Numerus;
    }

    public sealed class NumerāmenCardinālumSōlōrum : Īnflectendum<NumerāmenCardinālumSōlōrum, Multiplex.Numerāmen>
    {
      public static readonly Func<JsonElement, Enum, Task<NumerāmenCardinālumSōlōrum>> Lēctor =
                async (legendum, valor) => new NumerāmenCardinālumSōlōrum(legendum.GetProperty(nameof(Minūtal).ToLower()).GetInt32(), valor,
                                                                          legendum.GetProperty(nameof(Numerus).ToLower()).GetString(),
                                                                          legendum.GetProperty(nameof(Cardināle).ToLower()).GetString());

      private NumerāmenCardinālumSōlōrum(in int minūtal, in string numerus, in string cardināle)
                                        : base(minūtal, Ēnumerātiōnēs.Catēgoria.Numerāmen)
      {
        Numerus = numerus;
        Cardināle = cardināle;
      }

      public readonly string Numerus { get; }
      public readonly string Cardināle { get; }
      public string ToString() => Numerus;
    }

    public sealed class NumerāmenCardinālumŌrdinālumque : Īnflectendum<NumerāmenCardinālumŌrdinālumque, Multiplex.Numerāmen>
    {
      public static readonly Func<JsonElement, Enum, Task<NumerāmenCardinālumŌrdinālumque>> Lēctor =
                async (legendum, valor) => new NumerāmenCardinālumŌrdinālumque(legendum.GetProperty(nameof(Minūtal).ToLower()).GetInt32(), valor,
                                                                              legendum.GetProperty(nameof(Numerus).ToLower()).GetString(),
                                                                              legendum.GetProperty(nameof(Cardināle).ToLower()).GetString(),
                                                                              legendum.GetProperty(nameof(Ōrdināle).ToLower()).GetString());

      private NumerāmenCardinālumŌrdinālumque(in int minūtal, in string numerus, in string cardināle, in string ōrdināle)
                                              : base(minūtal, Ēnumerātiōnēs.Catēgoria.Numerāmen)
      {
        Numerus = numerus;
        Cardināle = cardināle;
        Ōrdināle = ōrdināle;
      }

      public readonly string Numerus { get; }
      public readonly string Cardināle { get; }
      public readonly string Ōrdināle { get; }
      public string ToString() => Numerus;
    }

    public sealed class NumerāmenCardinālumEtŌrdinālumEtAdverbiōrum : Īnflectendum<NumerāmenCardinālumEtŌrdinālumEtAdverbiōrum, Multiplex.Numerāmen>
    {
      public static readonly Func<JsonElement, Enum, Task<NumerāmenCardinālumEtŌrdinālumEtAdverbiōrum>> Lēctor =
                async (legendum, valor) => new NumerāmenCardinālumEtŌrdinālumEtAdverbiōrum(legendum.GetProperty(nameof(Minūtal).ToLower()).GetInt32(), valor,
                                                                                          legendum.GetProperty(nameof(Numerus).ToLower()).GetString(),
                                                                                          legendum.GetProperty(nameof(Cardināle).ToLower()).GetString(),
                                                                                          legendum.GetProperty(nameof(Ōrdināle).ToLower()).GetString(),
                                                                                          legendum.GetProperty(nameof(Adverbium).ToLower()).GetString());

      private NumerāmenCardinālumEtŌrdinālumEtAdverbiōrum(in int minūtal, in string numerus, in string cardināle,
                                                          in string ōrdināle, in string adverbium)
                                                          : base(minūtal, Ēnumerātiōnēs.Catēgoria.Numerāmen)
      {
        Numerus = numerus;
        Cardināle = cardināle;
        Ōrdināle = ōrdināle;
        Adverbium = adverbium;
      }

      public readonly string Numerus { get; }
      public readonly string Cardināle { get; }
      public readonly string Ōrdināle { get; }
      public readonly string Adverbium { get; }
      public string ToString() => Numerus;
    }

    public sealed class NumerāmenCardinālumEtŌrdinālumEtDistribūtīvōrum
              : Īnflectendum<NumerāmenCardinālumEtŌrdinālumEtDistribūtīvōrum, Multiplex.Numerāmen>
    {
      public static readonly Func<JsonElement, Enum, Task<NumerāmenCardinālumEtŌrdinālumEtDistribūtīvōrum>> Lēctor =
                async (legendum, valor) => new NumerāmenCardinālumEtŌrdinālumEtDistribūtīvōrum(legendum.GetProperty(nameof(Minūtal).ToLower()).GetInt32(), valor,
                                                                                              legendum.GetProperty(nameof(Numerus).ToLower()).GetString(),
                                                                                              legendum.GetProperty(nameof(Cardināle).ToLower()).GetString(),
                                                                                              legendum.GetProperty(nameof(Ōrdināle).ToLower()).GetString(),
                                                                                              legendum.GetProperty(nameof(Distribūtīvum).ToLower()).GetString());

      private NumerāmenCardinālumEtŌrdinālumEtDistribūtīvōrum(in int minūtal, in string numerus, in string cardināle,
                                                              in string ōrdināle, in string distribūtīvum)
                                                              : base(minūtal, Ēnumerātiōnēs.Catēgoria.Numerāmen)
      {
        Numerus = numerus;
        Cardināle = cardināle;
        Ōrdināle = ōrdināle;
        Distribūtīvum = distribūtīvum;
      }

      public readonly string Numerus { get; }
      public readonly string Cardināle { get; }
      public readonly string Ōrdināle { get; }
      public readonly string Distribūtīvum { get; }
      public string ToString() => Numerus;
    }

    public sealed class NumerāmenCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum
              : Īnflectendum<NumerāmenCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum, Multiplex.Numerāmen>
    {
      public static readonly Func<JsonElement, Enum, Task<NumerāmenCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum>> Lēctor =
                async (legendum, valor) => new NumerāmenCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum(legendum.GetProperty(nameof(Minūtal).ToLower()).GetInt32(), valor,
                                                                                                            legendum.GetProperty(nameof(Numerus).ToLower()).GetString(),
                                                                                                            legendum.GetProperty(nameof(Cardināle).ToLower()).GetString(),
                                                                                                            legendum.GetProperty(nameof(Ōrdināle).ToLower()).GetString(),
                                                                                                            legendum.GetProperty(nameof(Adverbium).ToLower()).GetString(),
                                                                                                            legendum.GetProperty(nameof(Distribūtīvum).ToLower()).GetString());

      private NumerāmenCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum(in int minūtal, in string numerus, in string cardināle,
                                                                          in string ōrdināle, in string adverbium, in string distribūtīvum)
                                                                          : base(minūtal, Ēnumerātiōnēs.Catēgoria.Numerāmen)
      {
        Numerus = numerus;
        Cardināle = cardināle;
        Ōrdināle = ōrdināle;
        Adverbium = adverbium;
        Distribūtīvum = distribūtīvum;
      }

      public readonly string Numerus { get; }
      public readonly string Cardināle { get; }
      public readonly string Ōrdināle { get; }
      public readonly string Adverbium { get; }
      public readonly string Distribūtīvum { get; }
      public string ToString() => Numerus;
    }

    public sealed class NumerāmenOmniumPraeterMultiplicātīva : Īnflectendum<NumerāmenOmniumPraeterMultiplicātīva, Multiplex.Numerāmen>
    {
      public static readonly Func<JsonElement, Enum, Task<NumerāmenOmniumPraeterMultiplicātīva>> Lēctor =
                async (legendum, valor) => new NumerāmenOmniumPraeterMultiplicātīva(legendum.GetProperty(nameof(Minūtal).ToLower()).GetInt32(), valor,
                                                                                    legendum.GetProperty(nameof(Numerus).ToLower()).GetString(),
                                                                                    legendum.GetProperty(nameof(Cardināle).ToLower()).GetString(),
                                                                                    legendum.GetProperty(nameof(Ōrdināle).ToLower()).GetString(),
                                                                                    legendum.GetProperty(nameof(Adverbium).ToLower()).GetString(),
                                                                                    legendum.GetProperty(nameof(Distribūtīvum).ToLower()).GetString(),
                                                                                    legendum.GetProperty(nameof(Frāctiōnāle).ToLower()).GetString());

      private NumerāmenOmniumPraeterMultiplicātīva(in int minūtal, in string numerus, in string cardināle, in string ōrdināle,
                                                  in string adverbium, in string distribūtīvum, in string frāctiōnāle)
                                                  : base(minūtal, Ēnumerātiōnēs.Catēgoria.Numerāmen)
      {
        Numerus = numerus;
        Cardināle = cardināle;
        Ōrdināle = ōrdināle;
        Adverbium = adverbium;
        Distribūtīvum = distribūtīvum;
        Frāctiōnāle = frāctiōnāle;
      }

      public readonly string Numerus { get; }
      public readonly string Cardināle { get; }
      public readonly string Ōrdināle { get; }
      public readonly string Adverbium { get; }
      public readonly string Distribūtīvum { get; }
      public readonly string Frāctiōnāle { get; }
      public string ToString() => Numerus;
    }

    public sealed class NumerāmenOmniumPraeterFrāctiōnēs : Īnflectendum<NumerāmenOmniumPraeterFrāctiōnēs, Multiplex.Numerāmen>
    {
      public static readonly Func<JsonElement, Enum, Task<NumerāmenOmniumPraeterFrāctiōnēs>> Lēctor =
                async (legendum, valor) => new NumerāmenOmniumPraeterFrāctiōnēs(legendum.GetProperty(nameof(Minūtal).ToLower()).GetInt32(), valor,
                                                                                legendum.GetProperty(nameof(Numerus).ToLower()).GetString(),
                                                                                legendum.GetProperty(nameof(Cardināle).ToLower()).GetString(),
                                                                                legendum.GetProperty(nameof(Ōrdināle).ToLower()).GetString(),
                                                                                legendum.GetProperty(nameof(Adverbium).ToLower()).GetString(),
                                                                                legendum.GetProperty(nameof(Multiplicātīvum).ToLower()).GetString(),
                                                                                legendum.GetProperty(nameof(Distribūtīvum).ToLower()).GetString());

      private NumerāmenOmniumPraeterFrāctiōnēs(in int minūtal, in string numerus, in string cardināle, in string ōrdināle,
                                              in string adverbium, in string multiplicātīvum, in string distribūtīvum)
                                              : base(minūtal, Ēnumerātiōnēs.Catēgoria.Numerāmen)
      {
        Numerus = numerus;
        Cardināle = cardināle;
        Ōrdināle = ōrdināle;
        Adverbium = adverbium;
        Multiplicātīvum = multiplicātīvum;
        Distribūtīvum = distribūtīvum;
      }

      public readonly string Numerus { get; }
      public readonly string Cardināle { get; }
      public readonly string Ōrdināle { get; }
      public readonly string Adverbium { get; }
      public readonly string Multiplicātīvum { get; }
      public readonly string Distribūtīvum { get; }
      public string ToString() => Numerus;
    }
  }
}
