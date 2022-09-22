using System.Reflection.Metadata;
using System.Collections.Immutable;
using System;
using System.Reflection;
using System.Text.Json.JsonElement;
using System.Threading.Tasks.Task;

using Praebeunda.Interfecta;
using Praebeunda.Multiplex;
using Pēnsōrēs.Numerāmina.PēnsorNumerāminibus.Versiō;
using Pēnsōrēs.Īnflectenda;
using Ēnumerātiōnēs;
using Īnflexōrēs.Incertī.ĪnflexorIncertus;

using BuilderGenerator.GenerateBuilderAttribute;
using Lombok.NET.ConstructorGenerators.AllArgsConstructorAttribute;
using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.SingletonsAttribute;

namespace Praebeunda
{
  [AsyncOverloads]
  [AllArgsConstructor(MemberTypes.Property, Access.Protected)]
  public abstract partial class Īnflectendum<Hoc, Illud> : Pēnsābile<Hoc>, Īnflexiblis<Hoc>
            where Hoc : Īnflectendum<Hoc, Illud> where Illud : Īnflexum<Illud>
  {
    public readonly int Minūtal { get; }
    public readonly Catēgoria Catēgoria { get; }
    private readonly Lazy<Īnflexor<Hoc, Illud>?> Īnflexor { get; }
    public readonly Func<ISet<Enum[]>> Tabulātor = () => Īnflexor.Value.Tabulātor.Invoke();
    public readonly Func<Īnflectendum<Task<Illud?>>> FortisĪnflexor = async () => Īnflexor.Value?.FortisĪnflexor.Invoke(this);

    protected Īnflectendum(in int minūtal, in Catēgoria catēgoria, in Enum versiō)
          : this(minūtal, catēgoria, Īnflexōrēs.Īnflexor.Relātor.Invoke(catēgoria, versiō)) { }

    public sealed Illud? Īnflectem(in params Enum illa)
          => Īnflexor.Value?.ĪnflectemAsync(this, illa)
                           ?.Allegam(illa.FirstOf<Encliticum>());

    [Singleton]
    public sealed partial class Nūllum<Hoc> : Īnflectendum<Nūllum, Hoc>
    {
      public static readonly Lazy<Nūllum> Faceindum = new Lazy(() => Instance);
      private Nūllum() : base(0, null, null) { }
    }

    public sealed class Adverbium : Īnflectendum<Adverbium, Multiplex.Adverbium>
    {
      public static readonly Func<JsonElement, Enum, Task<Adverbium>> Lēctor
                = async (legendum, valor) => new Adverbium(minūtal: legendum.GetProperty(nameof(Minūtal).ToLower()).GetInt32(), valor,
                                                           positīvum: legendum.GetProperty(nameof(Positīvum).ToLower()).GetString(),
                                                           comparātīvum: legendum.GetProperty(nameof(Comparātīvum).ToLower()).GetString(),
                                                           superlātīvum: legendum.GetProperty(nameof(Superlātīvum).ToLower()).GetString());

      private Adverbium(in int minūtal, in string positīvum,
                        in string comparātīvum, in string superlātīvum)
                        : base(minūtal, Ēnumerātiōnēs.Catēgoria.Adverbium, PēnsorAdverbiīs.Versiō.Exāctum)
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

    public sealed class Āctus : Īnflectendum<Āctus, Multiplex.Āctus>
    {
      public static readonly Func<JsonElement, Enum, Task<Āctus>> Lēctor
                = async (legendum, valor) => new Āctus(minūtal: legendum.GetProperty(nameof(Minūtal).ToLower()).GetInt32(),
                                                       īnfīnītīvum: legendum.GetProperty(nameof(Īnfīnītīvum).ToLower()).GetString(),
                                                       perfectum: legendum.GetProperty(nameof(Perfectum).ToLower()).GetString() ?? string.Empty,
                                                       supīnum: legendum.GetProperty(nameof(Supīnum).ToLower()).GetString() ?? string.Empty,
                                                       versiō: valor);

      private Āctus(in int minūtal, in string īnfīnītīvum,
                    in string perfectum, in string supīnum,
                    in Enum versiō)
                     : base(minūtal, Ēnumerātiōnēs.Catēgoria.Āctus, versiō)
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

    public sealed class Nōmen : Īnflectendum<Nōmen, Multiplex.Nōmen>
    {
      public static readonly Func<JsonElement, Enum, Task<Nōmen>> Lēctor
                = async (legendum, valor) => new Nōmen(minūtal: legendum.GetProperty(nameof(Minūtal).ToLower()).GetInt32(),
                                                       nōminātīvum: legendum.GetProperty(nameof(Nōminātīvum).ToLower()).GetString(),
                                                       genitīvum: legendum.GetProperty(nameof(Genitīvum).ToLower()).GetString() ?? string.Empty,
                                                       versiō: valor);

      private Nōmen(in int minūtal, in string nōminātīvum,
                    in string genitīvum, in Enum versiō)
                    : base(minūtal, Ēnumerātiōnēs.Catēgoria.Nōmen, versiō)
      {
        Nōminātīvum = nōminātīvum;
        Genitīvum = genitīvum;
      }

      public readonly string Nōminātīvum { get; }
      public readonly string Genitīvum { get; }
      public string ToString() => Nōminātīvum;
    }

    public sealed class NōmenFactum : Īnflectendum<NōmenFactum, Multiplex.Nōmen>
    {
      public static readonly Func<JsonElement, Enum, Task<NōmenFactum>> Lēctor
                = async (legendum, valor) => new NōmenFactum(minūtal: legendum.GetProperty(nameof(Minūtal).ToLower()).GetInt32(),
                                                             īnfīnītīvum: legendum.GetProperty(nameof(Īnfīnītīvum).ToLower()).GetString(),
                                                             supīnum: legendum.GetProperty(nameof(Supīnum).ToLower()).GetString() ?? string.Empty,
                                                             versiō: valor);
      private NōmenFactum(in int minūtal, in string īnfīnītīvum,
                          in string supīnum, in Enum versiō)
                          : base(minūtal, Ēnumerātiōnēs.Catēgoria.Nōmen, versiō)
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
      public static readonly Func<JsonElement, Enum, Task<AdiectīvumAutPrīmumAutSecundumAutTertium>> Lēctor
                = async (legendum, valor) => new AdiectīvumAutPrīmumAutSecundumAutTertium(minūtal: legendum.GetProperty(nameof(Minūtal).ToLower()).GetInt32(),
                                                                                          positīvum: legendum.GetProperty(nameof(Positīvum).ToLower()).GetString(),
                                                                                          comparātīvum: legendum.GetProperty(nameof(Comparātīvum).ToLower()).GetString() ?? string.Empty,
                                                                                          superlātīvum: legendum.GetProperty(nameof(Superlātīvum).ToLower()).GetString() ?? string.Empty,
                                                                                          versiō: valor);

      private AdiectīvumAutPrīmumAutSecundumAutTertium(in int minūtal, in string positīvum, in string comparātīvum,
                                                       in string superlātīvum, in Enum versiō)
                                                       : base(minūtal, Ēnumerātiōnēs.Catēgoria.Adiectīvum, versiō)
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
      public static readonly Func<JsonElement, Enum, Task<AdiectīvumTertiumAutPrīmumAutSecundum>> Lēctor
                = async (legendum, valor) => new AdiectīvumTertiumAutPrīmumAutSecundum(minūtal: legendum.GetProperty(nameof(Minūtal).ToLower()).GetInt32(),
                                                                                       nōminātīvum: legendum.GetProperty(nameof(Nōminātīvum).ToLower()).GetString(),
                                                                                       genitīvum: legendum.GetProperty(nameof(Genitīvum).ToLower()).GetString(),
                                                                                       versiō: valor);

      private AdiectīvumTertiumAutPrīmumAutSecundum(in int minūtal, in string nōminātīvum,
                                                    in string genitīvum, in Enum versiō)
                                                    : base(minūtal, Ēnumerātiōnēs.Catēgoria.Adiectīvumm, versiō)
      {
        Nōminātīvum = nōminātīvum;
        Genitīvum = genitīvum;
      }

      public readonly string Nominātīvum { get; }
      public readonly string Genitīvum { get; }
      public string ToString() => Nominātīvum;
    }

    public sealed class NumerāmenOmnium : Īnflectendum<NumerāmenOmnium, Multiplex.Numerāmen>
    {
      public static readonly Func<JsonElement, Enum, Task<NumerāmenOmnium>> Lēctor
                = async (legendum, valor) => new NumerāmenOmnium(minūtal: legendum.GetProperty(nameof(Minūtal).ToLower()).GetInt32(),
                                                                 numerus: legendum.GetProperty(nameof(Numerus).ToLower()).GetString(),
                                                                 cardināle: legendum.GetProperty(nameof(Cardināle).ToLower()).GetString(),
                                                                 ōrdināle: legendum.GetProperty(nameof(Ōrdināle).ToLower()).GetString(),
                                                                 adverbium: legendum.GetProperty(nameof(Adverbium).ToLower()).GetString(),
                                                                 multiplicātīvum: legendum.GetProperty(nameof(Multiplicātīvum).ToLower()).GetString(),
                                                                 distribūtīvum: legendum.GetProperty(nameof(Distribūtīvum).ToLower()).GetString(),
                                                                 frāctiōnāle: legendum.GetProperty(nameof(Frāctiōnāle).ToLower()).GetString());

      private NumerāmenOmnium(in int minūtal, in string numerus, in string cardināle, in string ōrdināle,
                              in string adverbium, in string multiplicātīvum, in string distribūtīvum, in string frāctiōnāle)
                              : base(minūtal, Ēnumerātiōnēs.Catēgoria.Numerāmen, PēnsorNumerāminibus.Versiō.Omnium)
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
      public static readonly Func<JsonElement, Enum, Task<NumerāmenCardinālumSōlōrum>> Lēctor
                = async (legendum, valor) => new NumerāmenCardinālumSōlōrum(minūtal: legendum.GetProperty(nameof(Minūtal).ToLower()).GetInt32(),
                                                                            numerus: legendum.GetProperty(nameof(Numerus).ToLower()).GetString(),
                                                                            cardināle: legendum.GetProperty(nameof(Cardināle).ToLower()).GetString());

      private NumerāmenCardinālumSōlōrum(in int minūtal, in string numerus, in string cardināle)
                                        : base(minūtal, Ēnumerātiōnēs.Catēgoria.Numerāmen,
                                               PēnsorNumerāminibus.Versiō.Cardinālium_Sōlōrum)
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
      public static readonly Func<JsonElement, Enum, Task<NumerāmenCardinālumŌrdinālumque>> Lēctor
                = async (legendum, valor) => new NumerāmenCardinālumŌrdinālumque(minūtal: legendum.GetProperty(nameof(Minūtal).ToLower()).GetInt32(),
                                                                                 numerus: legendum.GetProperty(nameof(Numerus).ToLower()).GetString(),
                                                                                 cardināle: legendum.GetProperty(nameof(Cardināle).ToLower()).GetString(),
                                                                                 ōrdināle: legendum.GetProperty(nameof(Ōrdināle).ToLower()).GetString());

      private NumerāmenCardinālumŌrdinālumque(in int minūtal, in string numerus, in string cardināle, in string ōrdināle)
                                              : base(minūtal, Ēnumerātiōnēs.Catēgoria.Numerāmen,
                                                     PēnsorNumerāminibus.Versiō.Cardinālium_Ōrdināliumque)
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
      public static readonly Func<JsonElement, Enum, Task<NumerāmenCardinālumEtŌrdinālumEtAdverbiōrum>> Lēctor
                = async (legendum, valor) => new NumerāmenCardinālumEtŌrdinālumEtAdverbiōrum(minūtal: legendum.GetProperty(nameof(Minūtal).ToLower()).GetInt32(),
                                                                                             numerus: legendum.GetProperty(nameof(Numerus).ToLower()).GetString(),
                                                                                             cardināle: legendum.GetProperty(nameof(Cardināle).ToLower()).GetString(),
                                                                                             ōrdināle: legendum.GetProperty(nameof(Ōrdināle).ToLower()).GetString(),
                                                                                             adverbium: legendum.GetProperty(nameof(Adverbium).ToLower()).GetString());

      private NumerāmenCardinālumEtŌrdinālumEtAdverbiōrum(in int minūtal, in string numerus, in string cardināle,
                                                          in string ōrdināle, in string adverbium)
                                                          : base(minūtal, Ēnumerātiōnēs.Catēgoria.Numerāmen,
                                                                 PēnsorNumerāminibus.Versiō.Cardinālium_Et_Ōrdinālium_Et_Adverbiōrum)
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
      public static readonly Func<JsonElement, Enum, Task<NumerāmenCardinālumEtŌrdinālumEtDistribūtīvōrum>> Lēctor
                = async (legendum, valor) => new NumerāmenCardinālumEtŌrdinālumEtDistribūtīvōrum(minūtal: legendum.GetProperty(nameof(Minūtal).ToLower()).GetInt32(),
                                                                                                 numerus: legendum.GetProperty(nameof(Numerus).ToLower()).GetString(),
                                                                                                 cardināle: legendum.GetProperty(nameof(Cardināle).ToLower()).GetString(),
                                                                                                 ōrdināle: legendum.GetProperty(nameof(Ōrdināle).ToLower()).GetString(),
                                                                                                 distribūtīvum: legendum.GetProperty(nameof(Distribūtīvum).ToLower()).GetString());

      private NumerāmenCardinālumEtŌrdinālumEtDistribūtīvōrum(in int minūtal, in string numerus, in string cardināle,
                                                              in string ōrdināle, in string distribūtīvum)
                                                              : base(minūtal, Ēnumerātiōnēs.Catēgoria.Numerāmen,
                                                                     PēnsorNumerāminibus.Versiō.Cardinālium_Et_Ōrdinālium_Et_Distribūtīvōrum)
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
      public static readonly Func<JsonElement, Enum, Task<NumerāmenCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum>> Lēctor
                = async (legendum, valor) => new NumerāmenCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum(minūtal: legendum.GetProperty(nameof(Minūtal).ToLower()).GetInt32(),
                                                                                                              numerus: legendum.GetProperty(nameof(Numerus).ToLower()).GetString(),
                                                                                                              cardināle: legendum.GetProperty(nameof(Cardināle).ToLower()).GetString(),
                                                                                                              ōrdināle: legendum.GetProperty(nameof(Ōrdināle).ToLower()).GetString(),
                                                                                                              adverbium: legendum.GetProperty(nameof(Adverbium).ToLower()).GetString(),
                                                                                                              distribūtīvum: legendum.GetProperty(nameof(Distribūtīvum).ToLower()).GetString());

      private NumerāmenCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum(in int minūtal, in string numerus, in string cardināle,
                                                                           in string ōrdināle, in string adverbium, in string distribūtīvum)
                                                                           : base(minūtal, Ēnumerātiōnēs.Catēgoria.Numerāmen,
                                                                                  PēnsorNumerāminibus.Versiō.Cardinālium_Et_Ōrdinālium_Et_Adverbiōrum_Et_Distribūtīvōrum)
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
      public static readonly Func<JsonElement, Enum, Task<NumerāmenOmniumPraeterMultiplicātīva>> Lēctor
                = async (legendum, valor) => new NumerāmenOmniumPraeterMultiplicātīva(minūtal: legendum.GetProperty(nameof(Minūtal).ToLower()).GetInt32(),
                                                                                      numerus: legendum.GetProperty(nameof(Numerus).ToLower()).GetString(),
                                                                                      cardināle: legendum.GetProperty(nameof(Cardināle).ToLower()).GetString(),
                                                                                      ōrdināle: legendum.GetProperty(nameof(Ōrdināle).ToLower()).GetString(),
                                                                                      adverbium: legendum.GetProperty(nameof(Adverbium).ToLower()).GetString(),
                                                                                      distribūtīvum: legendum.GetProperty(nameof(Distribūtīvum).ToLower()).GetString(),
                                                                                      frāctiōnāle: legendum.GetProperty(nameof(Frāctiōnāle).ToLower()).GetString());

      private NumerāmenOmniumPraeterMultiplicātīva(in int minūtal, in string numerus, in string cardināle, in string ōrdināle,
                                                   in string adverbium, in string distribūtīvum, in string frāctiōnāle)
                                                   : base(minūtal, Ēnumerātiōnēs.Catēgoria.Numerāmen,
                                                          PēnsorNumerāminibus.Versiō.Omnium_Praeter_Multiplicātīva)
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
      public static readonly Func<JsonElement, Enum, Task<NumerāmenOmniumPraeterFrāctiōnēs>> Lēctor
                = async (legendum, valor) => new NumerāmenOmniumPraeterFrāctiōnēs(minūtal: legendum.GetProperty(nameof(Minūtal).ToLower()).GetInt32(),
                                                                                  numerus: legendum.GetProperty(nameof(Numerus).ToLower()).GetString(),
                                                                                  cardināle: legendum.GetProperty(nameof(Cardināle).ToLower()).GetString(),
                                                                                  ōrdināle: legendum.GetProperty(nameof(Ōrdināle).ToLower()).GetString(),
                                                                                  adverbium: legendum.GetProperty(nameof(Adverbium).ToLower()).GetString(),
                                                                                  multiplicātīvum: legendum.GetProperty(nameof(Multiplicātīvum).ToLower()).GetString(),
                                                                                  distribūtīvum: legendum.GetProperty(nameof(Distribūtīvum).ToLower()).GetString());

      private NumerāmenOmniumPraeterFrāctiōnēs(in int minūtal, in string numerus, in string cardināle, in string ōrdināle,
                                               in string adverbium, in string multiplicātīvum, in string distribūtīvum)
                                               : base(minūtal, Ēnumerātiōnēs.Catēgoria.Numerāmen,
                                                      PēnsorNumerāminibus.Versiō.Omnium_Praeter_Frāctiōnēs)
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
