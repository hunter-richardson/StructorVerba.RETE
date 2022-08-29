using System;
using System.Collections.Generic.IEnumerable;
using System.Linq;
namespace Miscella
{
  public static sealed class Extensions
  {
    private static readonly Random random => new Random();

    public static Predicate<T> Negate<T>(this in Predicate<T> predicate)
    {
      return item => !predicate.Invoke(item);
    }

    public static void ForEach<T>(this in IEnumerable<T> enumerable, in Action<T> action)
    {
      foreach (T item in enumerable)
      {
        action(item);
      }
    }

    private static IEnumerable<T> Enumerate<T>(in params T items) => items;

    public static T? Random<T>(this in IEnumerable<T> enumerable, in T? or = default)
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

    public static T? Choose<T>(this in Boolean boolean,
                               in T? first, in T? second) => boolean ? first : second;

    public static T? Choose<T, U>(this in Predicate<U> predicate,
                                  in U param, in T? first, in T? second)
            => predicate.Invoke(param).Choose(first, second);

    public static R? Choose<T, U, R>(this in Predicate<T, U> predicate,
                                     in T param1, in T param2,
                                     in R? first, in R? second)
            => predicate.Invoke(param1, param2).Choose(first, second);

    public static Boolean ContainsAll<T>(this in IEnumerable<T> enumerable, in params T subarray)
            => subarray.All(item => enumerable.Contains(item));

    public static Boolean ContainsAny<T>(this in IEnumerable<T> enumerable, in params T subarray)
            => subarray.Any(item => enumerable.Contains(item));

    public static Boolean NoneNull<T>(this in IEnumerable<T> enumerable)
            => enumerable.All(item => item is not null);

    public static Boolean SomeNotNull<T>(this in IEnumerable<T> enumerable)
            => enumerable.Any(item => item is not null);

    public static T FirstNonNull<T>(this in IEnumerable<T> enumerable, in T? or = default)
            => enumerable.NoneNull().choose((from item in enumerable
                                             where item is not null
                                             select item).First(), or);

    public static IEnumerable<T> Except<T>(this in IEnumerable<T> enumerable, in Predicate<T> predicate)
            => from item in enumerable
               where predicate.Negate().Invoke(item)
               select item;

    public static Boolean isAmong<T>(this in T obj, in params T array)
            => array.Contains(obj);

    public static R ApplyOr<T, R>(this in Func<T, R> function,
                                  in T? obj, in R? or = default)
            => (obj is not null).Choose(function.Invoke(obj), or);

    public static R ApplyOr<T, U, R>(this in Func<T, U, R> function,
                                     in T? obj1, in U? obj2, in R? or = default)
            => Enumerate(obj1, obj2).AllNotNull().choose(function.Invoke(obj1, obj2), or);

    public static string Capitalize(this in string source)
            => source.ReplaceFirst(source.ElementAt(0).ToString(),
                                   char.ToUpper(source.ElementAt(0).ToString()));

    public static string Chop(this in string source, in int length)
            => source.Substring(source.Length - length);

    public static Boolean And(this in Boolean first, in Boolean second)
            => first && second;

    public static Boolean Or(this in Boolean first, in Boolean second)
            => first || second;

    public static Boolean Xor(this in Boolean first, in Boolean second)
            => first ^ second;

    public static Boolean All(this in IEnumerable<Boolean> enumerable)
            => enumerable.All(item => item);

    public static Boolean Any(this in IEnumerable<Boolean> enumerable)
            => enumerable.Any(item => item);

    public static Boolean None(this in IEnumerable<Boolean> enumerable)
            => enumerable.All(item => !item);

    public static T Cast<T>(this in object obj, in T? or = default)
            => type.Equals(T).And(obj is T).Choose(obj as T, or);
  }
}
