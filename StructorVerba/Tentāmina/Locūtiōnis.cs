using System;
using System.Collections.Generic;
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
  public sealed partial class Locūtiōnis
  {
    private readonly Lazy<Lēctor> Lēctor = Lēctor.Lazy;
    private readonly Lazy<Scrīptor> Scrīptor = Scrīptor.Lazy;

    public static Task Agō(in Enumerable<Verbum?>? verba,
                             in string locūtiō, in string nōmen = string.Empty)
              => () => await new TentāmenVerbōrum(verba, locūtiō, nōmen).Tentātor.Invoke();

    public static Task Vērificem(in Dictionary<string, Catēgoria> verba)
              => () => verba.ForEach(linea =>
                                      {
                                        await Necesse.Quod.FalsustAsync(string.IsNullOrWhiteSpace(linea.Key), "Valor quaestiōnis vacat");
                                        const string error = $"Quaestiō relicta'st valōribus {linea.Key} et {linea.Value}";
                                        const IEnumerable<Verbum?>? seriēs = await Lēctor.Value.QuaerōAsync(linea.Key, linea.Value);
                                        await Necesse.Quod.ExsistitAsync(prōductum: seriēs, error: error);
                                        await Necesse.Quod.SuperestAsync(tendandum: 0, prōductum: seriēs.Count(), error: error);
                                      });

    private readonly Task<string[]> Prīmum
              = async () =>
                      {
                        const string error = $"Verba prōducta{Nōmen} vacat";
                        Verba.ForEach(verbum => await Scrīptor.Value.Additor.Invoke(verbum));
                        await Necesse.Quod.SuperestAsync(tendandum: 0, prōductum: Verba?.Count(), error);
                        await Necesse.Quod.SuperestAsync(tendandum: 0, prōductum: Scrīptor.Value.Mēnsura, error);
                        await Necesse.Quod.AequāturAsync(tendandum: Verba.Count(), prōductum: Scrīptor.Value.Mēnsura, Error);

                        const string[] scrīpta = Locūtiō.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        await Necesse.Quod.SuperestAsync(tendandum: 0, prōductum: scrīpta.Length, error);
                        await Necesse.Quod.AequāturAsync(tendandum: scrīpta.Length, prōductum: Verba.Count(), Error);
                        return scrīpta;
                      };

    private readonly Task<Action<Verbum?, string>> Quidque
                = async (verbum, prōductum) =>
                        {
                          const string error = $"Prōducta{Nōmen} relica'st prōductiō verbī {prōductum}";
                          await Necesse.Quod.ExsistitAsync(verbum: verbum, error);
                          await Necesse.Quod.AequāturAsync(tendendum: prōductum, prōductum: verbum, error);
                        };

    private readonly Task<string> Ultimum
                = async () =>
                        {
                          const string scrīptum = await Scrīptor.Value.ScrīptumAsync();
                          await Necesse.Quod.AequāturAsync(tendandum: Locūtiō, prōductum: scrīptum, Error);
                          return scrīptum;
                        };

    public readonly Task<string> Tentātor
                = async () =>
                        {
                          const string[] scrīpta = await Prīmum.Invoke();
                          for (int i = 0; i < Verba.Count(); i++)
                          {
                            await Quidque.Invoke(Verba.ElementAt(i), scrīpta[i].ToLowerInvariant());
                          }
                          const string ēventus = $"Prōducta{Nōmen}: {await Ultimum.Invoke()}";
                          Scrīptor.Value.Purgātor.Invoke();
                          return ēventus;
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
