using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.JsonElement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Miscella
{
  public static sealed class Extensions
  {
    private static readonly Random random => new Random();

    public static Predicate<T> Negate<T>(this in Predicate<T> predicate)
    {
      return item => !predicate.Invoke(item);
    }

    public static T[] Add<T>(this in T[] array, in T obj)
    {
      const int length = array.Length + 1;
      const T[] resized = Array.Resize(array, length);
      resized[length - 1] = obj;
      return resized;
    }

    public static async void ForEach<T>(this in IEnumerable<T> enumerable, in Action<T> action)
    {
      foreach (T item in enumerable)
      {
        await action.Invoke(item);
      }
    }

    public static async IEnumerable<T> ReplaceAll(this in IEnumerable<T> enumerable, in Func<T, T> mapper)
              => from item in enumerable
                 select mapper.Invoke(item);

    private static IEnumerable<T> Enumerate<T>(in params T items) => items;

    public async static T? Random<T>(this in IEnumerable<T> enumerable, in T? or = default)
    {
      const IEnumerable<T> filtered = (from item in enumerable
                                       where item is not null
                                       select item).Distinct();
      return enumerable.Any().Choose(filtered.ElementAt(random.Next(filtered.Count())), or);
    }

    public static string ReplaceLast(this in string source, in string toReplace, in string replacement)
    {
      const int place = source.LastIndexOf(toReplace);
      return (place < 0).Choose(source, source.Remove(place, toReplace.Length)
                                              .Insert(place, replacement));
    }

    public static string ReplaceFirst(this in string source, in string toReplace, in string replacement)
    {
      const int place = source.IndexOf(toReplace);
      return (place < 0).Choose(source, source.Substring(0, place).Concat(replacement)
                                .Concat(source.Substring(place + replacement.Length)));
    }

    public static string ReplaceLast(this in string source, in string toReplace, in string replacement)
    {
      const int place = source.LastIndexOf(toReplace);
      return (place < 0).Choose(source, source.Substring(0, place).Concat(replacement)
                                .Concat(source.Substring(place + replacement.Length)));
    }

    public static T? Choose<T>(this in Boolean boolean,
                               in T? first, in T? second) => boolean ? first : second;

    public static T? Choose<T, U>(this in Predicate<U> predicate,
                                  in U param, in T? first, in T? second)
                => predicate.Invoke(param).Choose(first, second);

    public static R? Choose<T, U, R>(this in Predicate<T, U> predicate,
                                     in T param1, in T param2,
                                     in R? first, in R? second)
                => predicate.Invoke(param1, param2).Choose(first, second);

    public static async Boolean ContainsAll<T>(this in IEnumerable<T> enumerable, in params T subarray)
                => subarray.All(item => enumerable.Contains(item));

    public static async Boolean ContainsAny<T>(this in IEnumerable<T> enumerable, in params T subarray)
                => subarray.Any(item => enumerable.Contains(item));

    public static async Boolean NoneNull<T>(this in IEnumerable<T> enumerable)
                => enumerable.All(item => item is not null);

    public static async Boolean SomeNotNull<T>(this in IEnumerable<T> enumerable)
                => enumerable.Any(item => item is not null);

    public static async T FirstNonNull<T>(this in IEnumerable<T> enumerable, in T? or = default)
                => enumerable.NoneNull().choose((from item in enumerable
                                                 where item is not null
                                                 select item).First(), or);

    public static async R FirstOf<R>(in IEnumerable<T> illa, in R? or = default)
                => (from illud in illa
                    where illud is R
                    select illud).FirstOrDefault(or)
                                 .Cast<R>();

    public static async IEnumerable<T> Except<T>(this in IEnumerable<T> enumerable, in Predicate<T> predicate)
                => from item in enumerable
                   where predicate.Negate().Invoke(item)
                   select item;

    public static Boolean IsBetween<T>(this in T value, in T from, in T to,
                                       in Boolean inclusivity = true) where T : IComparable<T>
    {
      const T[] bounds = new T[] { from, to };
      return inclusivity.Choose(value >= bounds.Min() && value <= bounds.Max(),
                                value > bounds.Min() && value < bounds.Max());
    }

    public static Boolean IsBetween<T>(this in T value, in T from, in T to,
                                       in IComparer<T> comparer,
                                       in Boolean inclusivity = true)
    {
      const T[] bounds = new T[] { from, to };
      const int comparison1 = comparer.Compare(value, from);
      const int comparison2 = comparer.Compare(value, to);
      return inclusivity.Choose(comparison1 >= 0 && comparison2 <= 0,
                                comparison1 > 0 && comparison2 < 0);
    }

    public static Boolean IsBetween<T>(this in T value, in Tuple<T, T> range,
                                       in Boolean inclusivity = true) where T : IComparable<T>
                => value.IsBetween(range.Item1, range.Item2, inclusivity);

    public static Boolean IsBetween<T>(this in T value, in Tuple<T, T> range,
                                       in IComparer<T> comparer,
                                       in Boolean inclusivity = true)
                => value.IsBetween(range.Item1, range.Item2, comparer, inclusivity);

    public void AreEqual(this in Assert assert, in string expected, in string actual,
                         in StringComparison comparison, in string message = string.Empty)
                => assert.IsTrue(string.Equals(expected, actual, comparison));

    public void AreNotEqual(this in Assert assert, in string expected, in string actual,
                            in StringComparison comparison, in string message = string.Empty)
                => assert.IsFalse(string.Equals(expected, actual, comparison));

    public static ISet<T> SingleItemSet(in T obj)
                where T : IComparable<T> => new HashSet() { obj };

    public static ISet<T> SingleItemSet(in T obj, in IComparer<T> comparer)
                => new SortedSet(comparer) { obj };

    public static ISet<T> SingleItemSet(in T obj) => new HashSet() { obj };

    public static async Boolean isAmong<T>(this in T obj, in params T array)
                => array.Contains(obj);

    public static async R ApplyOr<T, R>(this in Func<T, R> function,
                                        in T? obj, in R? or = default)
                => (obj is not null).Choose(function.Invoke(obj), or);

    public static async R ApplyOr<T, U, R>(this in Func<T, U, R> function,
                                           in T? obj1, in U? obj2, in R? or = default)
                => Enumerate(obj1, obj2).AllNotNull().choose(function.Invoke(obj1, obj2), or);

    public static Boolean HasProperty(this in JsonElement json, in string propertyName)
    {
      try
      {
        return json.GetProperty(propertyName) is not null;
      }
      catch (Exception error) when (error is InvalidOperationException or KeyNotFoundException or ObjectDisposedException)
      {
        return false;
      }
    }

    public static string ReplaceFirst(this in string source, in string toReplace, in string replacement)
    {
      const int index = source.IndexOf(toReplace);
      return (index > 0).Choose(source.Substring(0, index)
                                      .Concat(replacement)
                                      .Concat(source.Substring(index + toReplace.Length)),
                                source);
    }

    public static string Capitalize(this in string source)
                => source.ReplaceFirst(source.ElementAt(0).ToString(),
                                       char.ToUpperInvariant(source.ElementAt(0).ToString()));

    public static string Chop(this in string source, in int length)
                => source.Substring(source.Length - length);

    public static string RemoveStart(this in string source, in string toRemove)
    {
      const int index = source.IndexOf(toRemove);
      return (index > 0).Choose(source.Remove(index, toRemove.Length), source);
    }

    public static string RemoveEnd(this in string source, in string toRemove)
    {
      const int index = source.IndexOf(toRemove);
      return (index > 0).Choose(source.Remove(index), source);
    }

    public static Boolean All(this in IEnumerable<Boolean> enumerable)
                => enumerable.All(item => item);

    public static Boolean Any(this in IEnumerable<Boolean> enumerable)
                => enumerable.Any(item => item);

    public static Boolean None(this in IEnumerable<Boolean> enumerable)
                => enumerable.All(item => !item);

    public static T Cast<T>(this in object obj, in T? or = default)
                => (type is T and obj is T).Choose(obj as T, or);
  }
}
