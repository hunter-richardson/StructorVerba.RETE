using System;
using System.ComponentModel.DataAnnotations.StringLength;
using System.Linq;
using System.Text.Json.JsonElement;
using System.Threading.Tasks.Task;

using Nūntiī.Nūntius;
using Miscella.Extensions;
using Praebeunda.Interfecta.Pēnsābile;

using Amazon.RegionEndpoint;
using Amazon.DynamoDBv2.AmazonDynamoDB;
using Amazon.Runtime;
using Linq2DynamoDb.DataContext;
using Lombok.NET.MethodGenerators.AsyncGenerator;

namespace Pēnsōrēs
{
  public abstract class Pēnsor<Hoc> where Hoc : Pēnsābile<Hoc>
  {
    public enum Tabula
    {
      Lemmae, Verba, Adiectīva_Aut_Prīma_Aut_Secunda
    }

    //TODO: public static Tabula? Tabula(in Catēgoria catēgoria, in Enum versiō);
    public static Func<Tabula, string> Nōminātor = tabula => tabula.ToString().ToLower();

    public static Func<AmazonDynamoDBClient> Cliēns = () =>
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
    };

    private Func<Task<Enumerable<JsonElement>>> Tabulātor = async () => Contextus.GetTable<JsonElement>();
    public Func<Task<Enumerable<Hoc>>> Omnēs = async () => (from linea in Tabulātor.Invoke()
                                                            select Lēctor.Invoke(linea)).Where(hoc => hoc is not null);
    public Func<Task<Hoc?>> ForsPēnset = async () => Omnēs.Invoke().Random();

    protected readonly string Nōmen { get; }
    protected readonly DataContext Contextus { get; }
    protected readonly Nūntius<Pēnsor<Hoc>> Nūntius { get; }
    protected readonly Func<JsonElement, Task<Hoc?>> Lēctor { get; }

    [StringLength(15, MinimumLength = 4)]
    protected readonly string VersiculumPrīmum { get; }

    protected Pēnsor(in string versiculumPrīmum, in Tabula tabula,
                     in Func<Nūntius<Pēnsor<Hoc>>> nūntius,
                     in Func<JsonElement, Task<Hoc?>> lēctor)
    {
      VersiculumPrīmum = versiculumPrīmum;
      Nōmen = Nōminātor.Invoke(Tabula);
      Nūntius = nūntius.Invoke();
      Lēctor = lēctor;

      Contextus = new DataContext(Cliēns.Invoke(), Nōmen);
    }

    [Async]
    public Hoc? Pēnsem(in int minūtal) => (from linea in Tabulātor.Invoke()
                                           where minūtal.Equals(linea.GetInt32(nameof(minūtal)))
                                           select Lēctor.Invoke(linea)).FirstOrDefault(null);
    [Async]
    public Hoc? Pēnsem(in string scrīptum) => (from linea in Tabulātor.Invoke()
                                               where scrīptum.Equals(linea.GetString(versiculumPrīmum))
                                               select Lēctor.Invoke(linea)).FirstOrDefault(null);
  }
}
