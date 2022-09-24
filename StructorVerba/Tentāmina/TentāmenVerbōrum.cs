using System;
using System.Linq;
using System.Threading.Tasks.Task;

using Miscella.Scrīptor;
using Praebeunda.Verbum;

namespace Tentāmina
{
  public sealed partial class TentāmenVerbōrum
  {
    public static Task<Action> Agō(in Enumerable<Verbum?>? verba,
                                   in string locūtiō, in string nōmen = string.Empty)
              => await new TentāmenVerbōrum(verba, locūtiō, nōmen).Tentātor.Invoke();

    private readonly Lazy<Scrīptor> Scrīptor = Scrīptor.Faciendum;

    private readonly Task<Action> Prīmum
              = async () =>
                      {
                        const string error = $"Verba prōducta {Nōmen} vacat";
                        await TentāmenReī.SupersitAsync(0, Verba?.Count(), error);
                        await TentāmenReī.SupersitAsync(0, Locūtiō.Length, error);
                        await TentāmenReī.AequāturAsync(Locūtiō.Length, Verba.Count(), Error);
                      };

    private readonly Task<Action> Ultimum
                = async () =>
                        {
                          Verba.ForEach(verbum => await Scrīptor.Additor.Invoke(verbum));
                          await TentāmenReī.AequāturAsync(Locūtiō, Scrīptor.ToString(), Error);
                        };

    private readonly Task<Action<Verbum?, string>> Ullum
                = async (verbum, prōductum) =>
                        {
                          const string error = $"Prōducta {Nōmen} relica'st prōductiō verbī {prōductum}";
                          const TentāmenVerbī tentāmen = new TentāmenVerbī(verbum);
                          await tentāmen.ExsistatAsync(error);
                          await tentāmen.AequāturAsync(prōductum, error);
                        };

    public readonly Task<Func<string>> Tentātor
                = async () =>
                        {
                          await Prīmum.Invoke();
                          const string[] scrīpta = Locūtiō.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                          for (int i = 0; i < Verba.Count(); i++)
                          {
                            await Ullum.Invoke(Verba.ElementAt(i), scrīpta[i].ToLowerInvariant());
                          }
                          await Ultimum.Invoke();
                          return $"Prōducta {Nōmen}: {Verba}";

                        };
    private readonly Enumerable<Verbum?>? Verba { get; }
    private readonly string Locūtiō { get; }
    private readonly string Nōmen { get; }
    private readonly string Error => $"Verba prōducta {Nōmen} exspectātiōne eius differt";
    private TentāmenVerbōrum(in Enumerable<Verbum?>? verba,
                            in string locūtiō, in string nōmen = string.Empty)
    {
      Verba = verba;
      Locūtiō = locūtiō;
      Nōmen = nōmen;
    }
  }
}
