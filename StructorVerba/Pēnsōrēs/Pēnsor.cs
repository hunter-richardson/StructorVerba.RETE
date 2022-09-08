using System;
using System.ComponentModel.DataAnnotations.StringLength;
using System.Collections.Generic.KeyNotFoundException;
using System.Linq;
using System.Text.Json.JsonElement;
using System.Threading.Tasks.Task;

using Nūntiī.Nūntius;
using Miscella.Extensions;
using Pēnsōrēs.Simplicia;
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
      Lemmae, Verba, Adverbia, Nōmina, Nōmina_Facta, Āctūs,
      Adiectīva_Aut_Prīma_Aut_Secunda_Aut_Tertia, Adiectīva_Aut_Tertia_Aut_Prīma_Aut_Secunda,
      Numerāmina_Cardinālium_Solōrum, Numerāmina_Cardinālium_Ōrdināliumque,
      Numerāmina_Cardinālium_Et_Ōrdinālium_Et_Adverbiōrum,
      Numerāmina_Cardinālium_Et_Ōrdinālium_Et_Distribūtīvōrum,
      Numerāmina_Cardinālium_Et_Ōrdinālium_Et_Adverbiōrum_Et_Distribūtīvōrum,
      Numerāmina_Omnium_Praeter_Multiplicātīva, Numerāmina_Omnium_Praeter_Frāctiōnēs, Numerāmina_Omnium
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
      return Contextus.Value.GetTable<JsonElement>();
    };

    public readonly Func<Task<Enumerable<Hoc>>> Omnēs = async () => (from linea in Tabulātor.Invoke()
                                                                     select await LegamAsync(linea))
                                                                        .Where(hoc => hoc is not null);
    public readonly Func<Task<Hoc?>> FortisPēnsor = async () => Omnēs.Invoke().Random();

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
      Quaerendī = quaerendī.ToLower();
      Nōmen = Nōminātor.Invoke(Tabula);
      Nūntius = nūntius.Value;
      Lēctor = lēctor;

      Contextus = new Lazy(() => new DataContext(Cliēns.Value, Nōmen));
    }

    public readonly Func<int, Task<Hoc?>> PēnsorNumerius
        = async minūtal => (from linea in Tabulātor.Invoke()
                            where minūtal == linea.GetProperty(nameof(minūtal)).GetInt32()
                            select await LegamAsync(linea)).FirstOrDefault(null);

    public readonly Func<string, Task<Hoc?>> PēnsorVerbālis
        = async scrīptum => (from linea in Tabulātor.Invoke()
                             where string.Equals(scrīptum, linea.GetProperty(Quaerendī).GetString(),
                                                 StringComparison.OrdinalIgnoreCase)
                             select await LegamAsync(linea)).FirstOrDefault(null);

    public readonly Func<string, Task<Hoc?>> PēnsorVerbālisSineApicibus
        = async scrīptum => (from linea in Tabulātor.Invoke()
                             where string.Equals(scrīptum, await Ūtilitātēs.ApicumAbditor.Invoke(linea.GetProperty(Quaerendī).GetString()),
                                                 StringComparison.OrdinalIgnoreCase)
                             select await LegamAsync(linea)).FirstOrDefault(null);

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
      catch (SystemException error) when (error is InvalidOperationException || error is KeyNotFoundException)
      {
        Nūntius.TerreōAsync(error);
        return null;
      }
    }
  }
}
