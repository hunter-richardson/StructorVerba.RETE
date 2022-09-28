using System;
using System.Linq;
using System.Threading.Tasks.Task;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Miscella;
using Praebeunda.Verbum;
using Ēnumerātiōnēs.Catēgoria;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

namespace Tentāmina
{
  [AsyncOverloads]
  public sealed partial class TentāmenVerbōrum
  {
    private readonly Lazy<Lēctor> Lēctor = Lēctor.Faciendum;
    private readonly Lazy<Scrīptor> Scrīptor = Scrīptor.Faciendum;

    public static Action Agō(in Enumerable<Verbum?>? verba,
                             in string locūtiō, in string nōmen = string.Empty)
              => () => await new TentāmenVerbōrum(verba, locūtiō, nōmen).Tentātor.Invoke();

    public static Action Vērificem(in Dictionary<string, Catēgoria> verba)
              => () => verba.ForEach(linea =>
                                      {
                                        Assert.That.IsFalse(string.IsNullOrWhiteSpace(linea.Key), "Valor quaestiōnis vacat");
                                        const string error = $"Quaestiō relicta'st valōribus {linea.Key} et {linea.Value}";
                                        const IEnumerable<Verbum?>? seriēs = await Lēctor.Value.QuaerōAsync(linea.Key, linea.Value);
                                        await TentāmenReī.ExsistatAsync(prōductum: seriēs, error: error);
                                        await TentāmenReī.SupersitAsync(tendandum: 0, prōductum: seriēs.Count(), error: error);
                                      });

    private readonly Task<string[]> Prīmum
              = async () =>
                      {
                        const string error = $"Verba prōducta{Nōmen} vacat";
                        Verba.ForEach(verbum => await Scrīptor.Value.Additor.Invoke(verbum));
                        await TentāmenReī.SupersitAsync(tendandum: 0, prōductum: Verba?.Count(), error);
                        await TentāmenReī.SupersitAsync(tendandum: 0, prōductum: Scrīptor.Value.Mēnsura, error);
                        await TentāmenReī.AequāturAsync(tendandum: Verba.Count(), prōductum: Scrīptor.Value.Mēnsura, Error);

                        const string[] scrīpta = Locūtiō.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        await TentāmenReī.SupersitAsync(tendandum: 0, prōductum: scrīpta.Length, error);
                        await TentāmenReī.AequāturAsync(tendandum: scrīpta.Length, prōductum: Verba.Count(), Error);
                        return scrīpta;
                      };

    private readonly Task<Action<Verbum?, string>> Quidque
                = async (verbum, prōductum) =>
                        {
                          const string error = $"Prōducta{Nōmen} relica'st prōductiō verbī {prōductum}";
                          const TentāmenVerbī tentāmen = new TentāmenVerbī(verbum);
                          await tentāmen.ExsistatAsync(error);
                          await tentāmen.AequāturAsync(prōductum: prōductum, error);
                        };

    private readonly Task<string> Ultimum
                = async () =>
                        {
                          const string scrīptum = await Scrīptor.Value.ScrīptumAsync();
                          await TentāmenReī.AequāturAsync(tendandum: Locūtiō, prōductum: scrīptum, Error);
                          return scrīptum;
                        };

    public readonly Task<Func<string>> Tentātor
                = async () =>
                        {
                          const string[] scrīpta = await Prīmum.Invoke();
                          for (int i = 0; i < Verba.Count(); i++)
                          {
                            await Quidque.Invoke(Verba.ElementAt(i), scrīpta[i].ToLowerInvariant());
                          }
                          return $"Prōducta{Nōmen}: {await Ultimum.Invoke()}";
                        };
    private readonly Enumerable<Verbum?>? Verba { get; }
    private readonly string Locūtiō { get; }
    private readonly string Nōmen { get; }
    private readonly string Error => $"Verba prōducta {Nōmen} exspectātiōne differt";

    private TentāmenVerbōrum(in Enumerable<Verbum?>? verba,
                             in string locūtiō, in string nōmen = string.Empty)
    {
      Verba = verba;
      Locūtiō = locūtiō;
      Nōmen = " ".Concat(nōmen);
    }
  }
}
