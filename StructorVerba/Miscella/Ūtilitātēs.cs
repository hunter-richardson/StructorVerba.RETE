using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
namespace Miscella
{
  public static sealed class Ūtilitātēs
  {
    //TODO: Register CultureInfo; https://docs.microsoft.com/en-us/dotnet/api/system.globalization.cultureandregioninfobuilder
    //public static Func<CultureInfo> Cultūra = CultureInfo.CreateSpecificCulture("la-US");

    private static Dictionary<char, char> Apicēs = new Dictionary<char, char>() {
                                                          { 'ā', 'a' }, { 'ē', 'e' }, { 'ī', 'i' }, { 'ō', 'o' },
                                                          { 'ū', 'u' }, { 'ȳ', 'y' }, { 'Ā', 'A' }, { 'Ē', 'E' },
                                                          { 'Ī', 'I' }, { 'Ō', 'O' }, { 'Ū', 'U' }, { 'Ȳ', 'Y' } };

    public static readonly Func<string, Task<string>> ApicumAbditor = async scrīptum =>
     {
       foreach (KeyValuePair<string, string> litterae in Apicēs)
       {
         if (scrīptum.Contains(litterae.Key))
         {
           scrīptum = scrīptum.Replace(litterae.Key, litterae.Value);
         }
       }
       return scriptum;
     };

    public static IEnumerable<T> Seriēs<T>(in params T seriēs) => seriēs;

    public static Boolean Omnia(in params Boolean seriēs) => seriēs.All();
    public static Boolean Ūlla(in params Boolean seriēs) => seriēs.Any();
    public static Boolean Nūlla(in params Boolean seriēs) => seriēs.None();

    public static async IEnumerable<Hoc> Complānō(in params IEnumerable<Hoc> haec) => from illa in haec
                                                                                      from illud in illa
                                                                                      select illud;

    public static async IEnumerable<Hoc> Complānō(in IComparer<Hoc> comparātor, in params IEnumerable<Hoc> haec)
                => Complānō(haec).OrderBy(hoc => hoc, comparātor);

    public static async IEnumerable<Enum[]> Colligō(in ISet<Enum> seriēs) => IEnumerable.Repeat(seriēs, 1);

    public static async IEnumerable<Enum[]> Combīnō(in ISet<Enum> prīma, in ISet<Enum> secunda) => from prīmum in prīma
                                                                                                   from secundum in secunda
                                                                                                   select new[] { prīmum, secundum };

    public static async IEnumerable<Enum[]> Combīnō(in ISet<Enum> prīma, in ISet<Enum> secunda,
                                                    in ISet<Enum> tertia) => (from prīmum in prīma
                                                                              from secundum in secunda
                                                                              from tertium in tertia
                                                                              select new[] { prīmum, secundum, tertium });

    public static async IEnumerable<Enum[]> Combīnō(in ISet<Enum> prīma, in ISet<Enum> secunda, in ISet<Enum> tertia,
                                                    in ISet<Enum> quārta) => from prīmum in prīma
                                                                             from secundum in secunda
                                                                             from tertium in tertia
                                                                             from quārtum in quārta
                                                                             select new[] { prīmum, secundum, tertium, quārtum };

    public static async IEnumerable<Enum[]> Combīnō(in ISet<Enum> prīma, in ISet<Enum> secunda, in ISet<Enum> tertia,
                                                    in ISet<Enum> quārta, in ISet<Enum> quīnta) => from prīmum in prīma
                                                                                                   from secundum in secunda
                                                                                                   from tertium in tertia
                                                                                                   from quārtum in quārta
                                                                                                   from quīntum in quīnta
                                                                                                   select new[] { prīmum, secundum, tertium, quārtum, quīntum };
  }
}
