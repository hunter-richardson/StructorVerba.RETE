using System;
using System.ComponentModel.DataAnnotations.StringLength;
using System.Collections.Generic.KeyNotFoundException;
using System.Linq;
using System.Text.Json.JsonElement;
using System.Threading.Tasks.Task;

using Nūntiī.Nūntius;
using Miscella;
using Pēnsōrēs;
using Pēnsōrēs.Īnflectenda;
using Praebeunda.Interfecta.Pēnsābile;

using Amazon.RegionEndpoint;
using Amazon.DynamoDBv2.AmazonDynamoDB;
using Amazon.Runtime;
using Linq2DynamoDb.DataContext;
using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

namespace Pēnsōrēs
{
  [AsyncOverloads]
  public abstract partial class Pēnsor<Hoc> where Hoc : Pēnsābile<Hoc>
  {
    public enum Tabula
    {
      Lemmae, Verba, Adverbia, Nōmina, Nōmina_Facta, Adiectīva, Āctūs, Numerāmina
    }

    public static readonly Func<Tabula, string> Nōminātor = tabula => tabula.ToString().ToLower();

    public static readonly Lazy<AmazonDynamoDBClient> Cliēns = new Lazy(() =>
    {
      const AmazonDynamoDBClient cliēns = new AmazonDynamoDBClient();
      cliens.BufferSize = 4096;
      cliens.LogMetrics = true;
      cliens.LogResponse = true;
      cliens.Protocol = NetworkProtocol.HTTPS;
      cliens.ReadEntireResponse = true;
      cliens.RegionEndpoint = RegionEndpoint.USWest2;
      cliens.SignatureMethod = SigningAlgorithm.HmacSHA256;
      cliens.UserAgent = "structor";
      cliens.UseSecureStringForAwsSecretKey = true;
      return cliēns;
    });

    public static Func<string, Task<string>> NōmenātorColumnae
        = async columna => await Ūtilitātēs.ApicumAbditor.Invoke(columna.ToLowerInvariant());

    private readonly Func<Task<Enumerable<JsonElement>>> Tabulātor = async () =>
    {
      Nūntius.GarriōAsync("Tabulam aperiō");
      return Contextus.Value.GetTable<JsonElement>();
    };

    public readonly Func<Task<Enumerable<Hoc>>> Omnia
          = async () => (from linea in (await Tabulātor.Invoke())
                         from hoc in await LegamAsync(legendum: linea)
                         where hoc is not null
                         select hoc);
    public readonly Func<Task<Hoc?>> FortisPēnsor = async () => Omnia.Invoke().Random();

    protected readonly string Nōmen { get; }
    protected readonly Lazy<DataContext> Contextus { get; }
    protected readonly Nūntius<Pēnsor<Hoc>> Nūntius { get; }
    protected readonly Func<JsonElement, Task<Hoc>> Lēctor { get; }

    [StringLength(15, MinimumLength = 4)]
    protected readonly string Quaerendī { get; }

    protected Pēnsor(in string quaerendī, in Tabula tabula,
                     in Lazy<Nūntius<Pēnsor<Hoc>>> nūntius,
                     in Func<JsonElement, Task<Hoc>> lēctor)
    {
      Quaerendī = NōmenātorColumnae.Invoke(quaerendī);
      Nōmen = Nōminātor.Invoke(Tabula);
      Nūntius = nūntius.Value;
      Lēctor = lēctor;

      Contextus = new Lazy(() => new DataContext(Cliēns.Value, Nōmen));
    }

    private async Hoc? Legam(in JsonElement legendum)
    {
      try
      {
        const Hoc? hoc = await Lēctor.Invoke(legendum);
        if (hoc is null)
        {
          Nūntius.MoneōAsync("Nīl advenī");
        }
        else
        {
          Nūntius.GarriōAsync("Advenī hoc:", hoc);
        }

        return hoc;
      }
      catch (SystemException error) when (error is InvalidOperationException or KeyNotFoundException)
      {
        Nūntius.TerreōAsync(error: error);
        return null;
      }
    }

    public sealed Hoc? Pendam(in int minūtal)
        => (from linea in await Tabulātor.Invoke()
            from numerus in linea.GetProperty(NōmenātorColumnae.Invoke(nameof(minūtal)))?.GetInt32()
            where minūtal == numerus
            select await LegamAsync(legendum: linea)).FirstOrDefault();

    public sealed Hoc? Pendam(in string quaerendum)
        => (from linea in await Tabulātor.Invoke()
            where linea.HasProperty(quaerendī)
            from valor in linea.GetProperty(quaerendī)?.GetString()
            where !string.IsNullOrWhitespace(valor)
            where string.Equals(valor, quaerendum, StringComparison.OrdinalIgnoreCase)
            select await LegamAsync(legendum: linea)).FirstOrDefault();

    public sealed Hoc? Pendam(in string quaerendum, in Catēgoria catēgoria)
        => (from linea in await Tabulātor.Invoke()
            where linea.HasProperty(quaerendī)
            from valor in linea.GetProperty(quaerendī)?.GetString()
            where !string.IsNullOrWhitespace(valor)
            where string.Equals(valor, quaerendum, StringComparison.OrdinalIgnoreCase)
            where string.Equals(catēgoria.ToString(), linea.GetProperty(nameof(catēgoria))?.GetString())
            select await LegamAsync(legendum: linea)).FirstOrDefault();

    public sealed Hoc? ForsPendat()
        => (await LegamAsync(legendum: await Tabulātor.Invoke()).Random());

    public sealed Hoc? ForsPendat(in Catēgoria catēgoria)
        => (from linea in await Tabulātor.Invoke()
            where string.Equals(catēgoria.ToString(), linea.GetProperty(NōmenātorColumnae.Invoke(nameof(catēgoria)))?.GetString())
            select await LegamAsync(legendum: linea)).Random();
  }
}
