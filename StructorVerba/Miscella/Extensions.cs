using System;
namespace Miscella {
  public static sealed class Extensions {
    private static readonly Random random => new Random();

    private static IEnumerable<T> Enumerate<T>([NotNull] in params T items) {
      return items;
    }

    public static T? Random<T>([NotNull] this in IEnumerable<T> enumerable, in T? or = default) {
      return enumerable.NoneNull()
                       .Choose((from item in enumerable
                                where item is not null
                                select item).Distinct()
                                            .ElementAt(random.Next(enumerable.Count())),
                               or);
    }

    public static T? Choose<T>([NotNull] this in Boolean boolean, in T? first, in T? second) {
      return boolean ? first : second;
    }

    public static T? Choose<T, U>([NotNull] this in Predicate<U> predicate, [NotNull] in U param,
                                  in T? first, in T? second) {
      return predicate.Invoke(param).Choose(first, second);
    }

    public static R? Choose<T, U, R>([NotNull] this in Predicate<T, U> predicate,
                                     [NotNull] in T param1, [NotNull] in T param2,
                                     in R? first, in R? second) {
      return predicate.Invoke(param1, param2).Choose(first, second);
    }

    public static void ForEach<T>([NotNull] this in IEnumerable<T> enumerable,
                                  [NonNull] in Action<T> action) {
      foreach(T item in enumerable) {
        action(item);
      }
    }

    public static Boolean ContainsAll<T>([NotNull] this in IEnumerable<T> enumerable,
                                         [NotNull] in params T subarray) {
      return subarray.All(item => enumerable.Contains(item));
    }

    public static Boolean ContainsAny<T>([NotNull] this in IEnumerable<T> enumerable,
                                         [NotNull] in params T subarray) {
      return subarray.Any(item => enumerable.Contains(item));
    }

    public static Boolean NoneNull<T>([NotNull] this in IEnumerable<T> enumerable) {
      return enumerable.All(item => item is not null);
    }

    public static Boolean SomeNotNull<T>([NotNull] this in IEnumerable<T> enumerable) {
      return enumerable.Any(item => item is not null);
    }

    public static T FirstNonNull<T>([NotNull] this in IEnumerable<T> enumerable, in T? or = default) {
      return enumerable.NoneNull().choose((from item in enumerable
                                           where item is not null
                                           select item).First(), or);
    }

    public static Predicate<T> Negate<T>([NonNull] this in Predicate<T> predicate) {
      return item => !predicate.Invoke(item);
    }

    public static IEnumerable<T> Except<T>([NonNull] this in IEnumerable<T> enumerable,
                                           [NotNull] in Predicate<T> predicate) {
      return from item in enumerable
             where predicate.Negate().Invoke(item)
             select item;
    }

    public static Boolean isAmong<T>([NotNull] this in T obj, [NotNull] in params T array) {
      return array.Contains(obj);
    }

    public static R ApplyOr<T, R>([NotNull] this in Func<T, R> function,
                                  in T? obj, in R? or = default) {
      return (obj is not null).Choose(function.Invoke(obj), or);
    }

    public static R ApplyOr<T, U, R>([NotNull] this in Func<T, U, R> function,
                                     in T? obj1, in U? obj2, in R? or = default) {
      return Enumerate(obj1, obj2).AllNotNull().choose(function.Invoke(obj1, obj2), or);
    }

    public static string ReplaceLast([NotNull] this in string source, [NotNull] in string toReplace,
                                     [NotNull] in string replacement) {
      const int place = source.LastIndexOf(toReplace);
      return (place < 0).Choose(source, source.Remove(place, toReplace.Length)
                                              .Insert(place, replacement));
    }

    public static string ReplaceFirst([NotNull] this in string source, [NotNull] in string toReplace,
                                      [NotNull] in string replacement) {
      const int place = source.IndexOf(toReplace);
      return (place < 0).Choose(source, source.Substring(0, place).Concat(replacement)
                                              .Concat(source.Substring(place.Add(replacement.Length))));
    }

    public static string Capitalize([NotNull] this in string source) {
      return source.ReplaceFirst(source.ElementAt(0).ToString(),
                                 char.ToUpper(source.ElementAt(0).ToString()));
    }

    public static string Chop([NotNull] this in string source, in int length) {
      return source.Substring(source.Length - length);
    }

    public static Boolean And([NotNull] this in Boolean first, [NotNull] in Boolean second) {
      return first && second;
    }

    public static Boolean Or([NotNull] this in Boolean first, [NotNull] in Boolean second) {
      return first || second;
    }

    public static Boolean Xor([NotNull] this in Boolean first, [NotNull] in Boolean second) {
      return first ^ second;
    }

    public static Boolean All([NotNull] this in IEnumerable<Boolean> enumerable) {
      return enumerable.All(item => item);
    }

    public static Boolean Any([NotNull] this in IEnumerable<Boolean> enumerable) {
      return enumerable.Any(item => item);
    }

    public static Boolean None([NotNull] this in IEnumerable<Boolean> enumerable) {
      return enumerable.All(item => !item);
    }

    public static T Cast<T>([NotNull] this in object obj, [NotNull] in Type<T> type, in T? or = default) {
      return type.Equals(T).And(obj is T).Choose(obj as T, or);
    }
  }
}
