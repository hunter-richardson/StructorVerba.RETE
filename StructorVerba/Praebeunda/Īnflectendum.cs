using System;
using System.Collections.Immutable;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text.Json.JsonElement;
using System.Threading.Tasks.Task;

using Praebeunda.Interfecta;
using Praebeunda.Multiplex;
using Pēnsōrēs.Numerāmina.PēnsorNumerāminibus.Versiō;
using Pēnsōrēs.Pēnsor;
using Pēnsōrēs.Īnflectenda;
using Ēnumerātiōnēs;
using Īnflexōrēs.Incertī.ĪnflexorIncertus;

using BuilderGenerator.GenerateBuilderAttribute;
using Lombok.NET.ConstructorGenerators.AllArgsConstructorAttribute;
using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Praebeunda
{
  [AsyncOverloads]
  [AllArgsConstructor(MemberTypes.Property, Access.Protected)]
  public abstract partial class Īnflectendum<Hoc, Illud> : Pēnsābile<Hoc>, Īnflexiblis<Hoc>
            where Hoc : Īnflectendum<Hoc, Illud> where Illud : Īnflexum<Illud>
  {
    public readonly Catēgoria Catēgoria { get; }
    private readonly Lazy<Īnflexor<Hoc, Illud>?> Īnflexor { get; }
    public readonly Func<ISet<Enum[]>> Tabulātor = () => Īnflexor.Value.Tabulātor.Invoke();
    public readonly Func<Īnflectendum<Task<Illud?>>> FortisĪnflexor = async () => Īnflexor.Value?.FortisĪnflexor.Invoke(this);

    protected Īnflectendum(in Catēgoria catēgoria, in Enum versiō)
    {
      Catēgoria = catēgoria;
      Īnflexor = Īnflexōrēs.Īnflexor.Relātor.Invoke(catēgoria, versiō);
    }

    public sealed Illud? Īnflectem(in params Enum illa)
          => Īnflexor.Value?.ĪnflectemAsync(this, illa)
                           ?.Allegam(illa.FirstOf<Encliticum>());

    [Lazy]
    public sealed partial class Nūllum<Hoc> : Īnflectendum<Nūllum, Hoc>
    {
      private Nūllum() : base(0, null, null) { }
    }

    public sealed class Adverbium : Īnflectendum<Adverbium, Multiplex.Adverbium>
    {
      public static readonly Func<JsonElement, Enum, Task<Adverbium>> Lēctor
                = async (legendum, valor) => new Adverbium(positīvum: legendum.GetProperty(Gradus.Positīvum.Columna()).GetString(),
                                                           comparātīvum: legendum.GetProperty(Gradus.Comparātīvum.Columna()).GetString(),
                                                           superlātīvum: legendum.GetProperty(Gradus.Superlātīvum.Columna()).GetString());

      private Adverbium(in string positīvum, in string comparātīvum, in string superlātīvum)
          : base(Ēnumerātiōnēs.Catēgoria.Adverbium, PēnsorAdverbiīs.Versiō.Exāctum)
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
      private Lazy<OfficīnaĪnflexōrum> Nōmina = OfficīnaĪnflexōrum.Officīnātor.Invoke(Catēgoria.Nōmen);
      public static readonly Func<JsonElement, Enum, Task<Āctus>> Lēctor
                = async (legendum, valor) => new Āctus(īnfīnītīvum: legendum.GetProperty(Factum.Īnfīnītīvum.Columna()).GetString(),
                                                       perfectum: legendum.GetProperty(Tempus.Perfectum.Columna()).GetString() ?? string.Empty,
                                                       supīnum: legendum.GetProperty(Factum.Supīnum.Columna()).GetString() ?? string.Empty,
                                                       versiō: valor);

      private Func<Enum[], Task<NōmenFactum?>> Nōminātor = async illa => Nōmina.Value.Inventor.Invoke(Supīnum, illa);

      private Func<Enum[], Task<Nōmen?>> Āctor
          = async illa =>
                  {
                    const Genus genus = illa.FirstOf<Genus>();
                    if (genus is default(Genus) or Genus.Neutrum)
                    {
                      return null;
                    }
                    else
                    {
                      const string rādīx = Supīnum.Chop(2);
                      const string suffīxum = (genus is Genus.Masculīnum)
                                                  .Choose("or", rādīx.EndsWith('t').Choose("rīx", "trīx"));
                      return Nōmina.Value.Inventor.Invoke(rādīx.Concat(suffīxum), illa);
                    }
                  };

      private Āctus(in string īnfīnītīvum, in string perfectum, in string supīnum, in Enum versiō)
                                                     : base(Ēnumerātiōnēs.Catēgoria.Āctus, versiō)
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
                = async (legendum, valor) => new Nōmen(nōminātīvum: legendum.GetProperty(Casus.Nōminātīvum.Columna()).GetString(),
                                                       genitīvum: legendum.GetProperty(Casus.Genitīvum.Columna()).GetString() ?? string.Empty,
                                                       versiō: valor);

      private Nōmen(in string nōminātīvum, in string genitīvum, in Enum versiō)
                                  : base(Ēnumerātiōnēs.Catēgoria.Nōmen, versiō)
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
                = async (legendum, valor) => new NōmenFactum(īnfīnītīvum: legendum.GetProperty(Factum.Īnfīnītīvum.Columna()).GetString(),
                                                             supīnum: legendum.GetProperty(Factum.Supīnum.Columna()).GetString() ?? string.Empty,
                                                             versiō: valor);
      private NōmenFactum(in string īnfīnītīvum, in string supīnum, in Enum versiō)
                                      : base(Ēnumerātiōnēs.Catēgoria.Nōmen, versiō)
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
                = async (legendum, valor) => new AdiectīvumAutPrīmumAutSecundumAutTertium(positīvum: legendum.GetProperty(Gradus.Positīvum.Columna()).GetString(),
                                                                                          comparātīvum: legendum.GetProperty(Gradus.Comparātīvum.Columna()).GetString() ?? string.Empty,
                                                                                          superlātīvum: legendum.GetProperty(Gradus.Superlātīvum.Columna()).GetString() ?? string.Empty,
                                                                                          versiō: valor);

      private AdiectīvumAutPrīmumAutSecundumAutTertium(in string positīvum, in string comparātīvum,
                                                       in string superlātīvum, in Enum versiō)
                                            : base(Ēnumerātiōnēs.Catēgoria.Adiectīvum, versiō)
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
                = async (legendum, valor) => new AdiectīvumTertiumAutPrīmumAutSecundum(nōminātīvum: legendum.GetProperty(Casus.Nōminātīvum.Columna()).GetString(),
                                                                                       genitīvum: legendum.GetProperty(Casus.Genitīvum.Columna()).GetString(),
                                                                                       versiō: valor);

      private AdiectīvumTertiumAutPrīmumAutSecundum(in string nōminātīvum, in string genitīvum, in Enum versiō)
                                                            : base(Ēnumerātiōnēs.Catēgoria.Adiectīvumm, versiō)
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
                = async (legendum, valor) => new NumerāmenOmnium(numerus: legendum.GetProperty(Numerium.Numerus.Columna()).GetString(),
                                                                 cardināle: legendum.GetProperty(Numerium.Cardināle.Columna()).GetString(),
                                                                 ōrdināle: legendum.GetProperty(Numerium.Ōrdināle.Columna()).GetString(),
                                                                 adverbium: legendum.GetProperty(Numerium.Adverbium.Columna()).GetString(),
                                                                 multiplicātīvum: legendum.GetProperty(Numerium.Multiplicātīvum.Columna()).GetString(),
                                                                 distribūtīvum: legendum.GetProperty(Numerium.Distribūtīvum.Columna()).GetString(),
                                                                 frāctiōnāle: legendum.GetProperty(Numerium.Frāctiōnāle.Columna()).GetString());

      private NumerāmenOmnium(in string numerus, in string cardināle, in string ōrdināle,
                              in string adverbium, in string multiplicātīvum, in string distribūtīvum, in string frāctiōnāle)
          : base(Ēnumerātiōnēs.Catēgoria.Numerāmen, PēnsorNumerāminibus.Versiō.Omnium)
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
                = async (legendum, valor) => new NumerāmenCardinālumSōlōrum(numerus: legendum.GetProperty(Numerium.Numerus.Columna()).GetString(),
                                                                            cardināle: legendum.GetProperty(Numerium.Cardināle.Columna()).GetString());

      private NumerāmenCardinālumSōlōrum(in string numerus, in string cardināle)
          : base(Ēnumerātiōnēs.Catēgoria.Numerāmen, PēnsorNumerāminibus.Versiō.Cardinālium_Sōlōrum)
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
                = async (legendum, valor) => new NumerāmenCardinālumŌrdinālumque(numerus: legendum.GetProperty(Numerium.Numerus.Columna()).GetString(),
                                                                                 cardināle: legendum.GetProperty(Numerium.Cardināle.Columna()).GetString(),
                                                                                 ōrdināle: legendum.GetProperty(Numerium.Ōrdināle.Columna()).GetString());

      private NumerāmenCardinālumŌrdinālumque(in string numerus, in string cardināle, in string ōrdināle)
          : base(Ēnumerātiōnēs.Catēgoria.Numerāmen, PēnsorNumerāminibus.Versiō.Cardinālium_Ōrdināliumque)
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
                = async (legendum, valor) => new NumerāmenCardinālumEtŌrdinālumEtAdverbiōrum(numerus: legendum.GetProperty(Numerium.Numerus.Columna()).GetString(),
                                                                                             cardināle: legendum.GetProperty(Numerium.Cardināle.Columna()).GetString(),
                                                                                             ōrdināle: legendum.GetProperty(Numerium.Ōrdināle.Columna()).GetString(),
                                                                                             adverbium: legendum.GetProperty(Numerium.Adverbium.Columna()).GetString());

      private NumerāmenCardinālumEtŌrdinālumEtAdverbiōrum(in string numerus, in string cardināle,
                                                          in string ōrdināle, in string adverbium)
          : base(Ēnumerātiōnēs.Catēgoria.Numerāmen, PēnsorNumerāminibus.Versiō.Cardinālium_Et_Ōrdinālium_Et_Adverbiōrum)
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
                = async (legendum, valor) => new NumerāmenCardinālumEtŌrdinālumEtDistribūtīvōrum(numerus: legendum.GetProperty(Numerium.Numerus.Columna()).GetString(),
                                                                                                 cardināle: legendum.GetProperty(Numerium.Cardināle.Columna()).GetString(),
                                                                                                 ōrdināle: legendum.GetProperty(Numerium.Ōrdināle.Columna()).GetString(),
                                                                                                 distribūtīvum: legendum.GetProperty(Numerium.Distribūtīvum.Columna()).GetString());

      private NumerāmenCardinālumEtŌrdinālumEtDistribūtīvōrum(in string numerus, in string cardināle,
                                                              in string ōrdināle, in string distribūtīvum)
          : base(Ēnumerātiōnēs.Catēgoria.Numerāmen, PēnsorNumerāminibus.Versiō.Cardinālium_Et_Ōrdinālium_Et_Distribūtīvōrum)
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
                = async (legendum, valor) => new NumerāmenCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum(numerus: legendum.GetProperty(Numerium.Numerus.Columna()).GetString(),
                                                                                                              cardināle: legendum.GetProperty(Numerium.Cardināle.Columna()).GetString(),
                                                                                                              ōrdināle: legendum.GetProperty(Numerium.Ōrdināle.Columna()).GetString(),
                                                                                                              adverbium: legendum.GetProperty(Numerium.Adverbium.Columna()).GetString(),
                                                                                                              distribūtīvum: legendum.GetProperty(Numerium.Distribūtīvum.Columna()).GetString());

      private NumerāmenCardinālumEtŌrdinālumEtAdverbiōrumEtDistribūtīvōrum(in string numerus, in string cardināle,
                                                                           in string ōrdināle, in string adverbium, in string distribūtīvum)
          : base(Ēnumerātiōnēs.Catēgoria.Numerāmen, PēnsorNumerāminibus.Versiō.Cardinālium_Et_Ōrdinālium_Et_Adverbiōrum_Et_Distribūtīvōrum)
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
                = async (legendum, valor) => new NumerāmenOmniumPraeterMultiplicātīva(numerus: legendum.GetProperty(Numerium.Numerus.Columna()).GetString(),
                                                                                      cardināle: legendum.GetProperty(Numerium.Cardināle.Columna()).GetString(),
                                                                                      ōrdināle: legendum.GetProperty(Numerium.Ōrdināle.Columna()).GetString(),
                                                                                      adverbium: legendum.GetProperty(Numerium.Adverbium.Columna()).GetString(),
                                                                                      distribūtīvum: legendum.GetProperty(Numerium.Distribūtīvum.Columna()).GetString(),
                                                                                      frāctiōnāle: legendum.GetProperty(Numerium.Frāctiōnāle.Columna()).GetString());

      private NumerāmenOmniumPraeterMultiplicātīva(in string numerus, in string cardināle, in string ōrdināle,
                                                   in string adverbium, in string distribūtīvum, in string frāctiōnāle)
          : base(Ēnumerātiōnēs.Catēgoria.Numerāmen, PēnsorNumerāminibus.Versiō.Omnium_Praeter_Multiplicātīva)
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
                = async (legendum, valor) => new NumerāmenOmniumPraeterFrāctiōnēs(numerus: legendum.GetProperty(Numerium.Numerus.Columna()).GetString(),
                                                                                  cardināle: legendum.GetProperty(Numerium.Cardināle.Columna()).GetString(),
                                                                                  ōrdināle: legendum.GetProperty(Numerium.Ōrdināle.Columna()).GetString(),
                                                                                  adverbium: legendum.GetProperty(Numerium.Adverbium.Columna()).GetString(),
                                                                                  multiplicātīvum: legendum.GetProperty(Numerium.Multiplicātīvum.Columna()).GetString(),
                                                                                  distribūtīvum: legendum.GetProperty(Numerium.Distribūtīvum.Columna()).GetString());

      private NumerāmenOmniumPraeterFrāctiōnēs(in string numerus, in string cardināle, in string ōrdināle,
                                               in string adverbium, in string multiplicātīvum, in string distribūtīvum)
          : base(Ēnumerātiōnēs.Catēgoria.Numerāmen, PēnsorNumerāminibus.Versiō.Omnium_Praeter_Frāctiōnēs)
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
