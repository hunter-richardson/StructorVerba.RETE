using System;
using System.ComponentModel.DataAnnotations.StringLength;
using System.Collections.Generic.KeyNotFoundException;
using System.Linq;
using System.Text.Json.JsonElement;
using System.Threading.Tasks.Task;

using Nūntiī.Nūntius;
using Miscella.Extensions;
using Pēnsōrēs.Simplicibus;
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
      Lemmae, Verba, Adiectīva_Aut_Prīma_Aut_Secunda
    }

    public static readonly Func<Tabula, string> Nōminātor = tabula => tabula.ToString().ToLower();

    public static readonly Lazy<AmazonDynamoDBClient> Cliēns = new Lazy<AmazonDynamoDbClient>(() =>
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

    private readonly Func<Task<Enumerable<JsonElement>>> Tabulātor = async () =>
    {
      Nūntius.Garriō("Tabulam aperiō");
      return Contextus.GetTable<JsonElement>();
    };

    public readonly Func<Task<Enumerable<Hoc>>> Omnēs = async () => (from linea in Tabulātor.Invoke()
                                                                     select await LegamAsync(linea))
                                                                        .Where(hoc => hoc is not null);
    public readonly Func<Task<Hoc?>> FortisPēnsor = async () => Omnēs.Invoke().Random();

    protected readonly string Nōmen { get; }
    protected readonly DataContext Contextus { get; }
    protected readonly Nūntius<Pēnsor<Hoc>> Nūntius { get; }
    protected readonly Func<JsonElement, Task<Hoc>> Lēctor { get; }

    [StringLength(15, MinimumLength = 4)]
    protected readonly string Quaerendī { get; }

    protected Pēnsor(in string quaerendī, in Tabula tabula,
                     in Lazy<Nūntius<Pēnsor<Hoc>>> nūntius,
                     in Func<JsonElement, Task<Hoc>> lēctor)
    {
      Quaerendī = quaerendī.ToLower();
      Nōmen = Nōminātor.Invoke(Tabula);
      Nūntius = nūntius.Value;
      Lēctor = lēctor;

      Contextus = new DataContext(Cliēns.Value, Nōmen);
    }

    public readonly Func<int, Task<Hoc?>> PēnsorNumerius = minūtal =>
    {
      try
      {
        const Hoc? hoc = (from linea in Tabulātor.Invoke()
                          where minūtal.Equals(linea.GetProperty(nameof(minūtal)).GetInt32())
                          select await LegamAsync(linea)).FirstOrDefault(null);
        if (hoc == null)
        {
          Nūntius.MoneōAsync("Nīl advenī");
        }
        else
        {
          Nūntius.GarriōAsync("Advenī hoc:", hoc);
        }

        return hoc;
      }
      catch (SystemException error) when (error is InvalidOperationException || error is KeyNotFoundException)
      {
        Nūntius.TerreōAsync(error);
        return null;
      }
    };

    public readonly Func<int, Task<Hoc?>> PēnsorVerbālis = scrīptum =>
    {
      try
      {
        const Hoc? hoc = (from linea in Tabulātor.Invoke()
                          where scrīptum.Equals(linea.GetProperty(Quaerendī).GetString())
                          select await LegamAsync(linea)).FirstOrDefault(null);
        if (hoc == null)
        {
          Nūntius.MoneōAsync("Nīl advenī");
        }
        else
        {
          Nūntius.GarriōAsync("Advenī hoc:", hoc);
        }

        return hoc;
      }
      catch (SystemException error) when (error is InvalidOperationException || error is KeyNotFoundException)
      {
        Nūntius.TerreōAsync(error);
        return null;
      }
    };

    private Hoc? Legam(in JsonElement legendum)
    {
      try
      {
        return await Lēctor.Invoke(legendum);
      }
      catch (SystemException error) when (error is InvalidOperationException || error is KeyNotFoundException)
      {
        Nūntius.TerreōAsync(error);
        return null;
      }
    }
  }
}
