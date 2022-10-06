using System;
using System.Collections.Generic;
using System.Collections.IComparer;
using System.Collections.Generic.SortedDictionary;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

namespace Miscella
{
  [AsyncOverloads]
  public sealed class PredicatedSortedDictionary<TKey, TValue> : SortedDictionary<TKey, TValue>
  {
    private readonly Predicate<TKey> KeyPredicate { get; }
    private readonly string OnKeyFailed { get; }
    private readonly Predicate<TValue> ValuePredicate { get; }
    private readonly string OnValueFailed { get; }
    public PredicatedSortedDictionary(in IComparer<TKey> comparer,
                                      in Predicate<TKey>? keyPredicate = null, in string? onKeyFailed = null,
                                      in Predicate<TValue>? valuePredicate = null, in string? onValueFailed = null)
                                                  : base(comparer)
    {
      KeyPredicate = keyPredicate ?? (key => true);
      ValuePredicate = valuePredicate ?? (value => true);
      OnKeyFailed = onKeyFailed ?? "Key must match KeyPredicate!";
      OnValueFailed = onValueFailed ?? "Value must match ValuePredicate!";
    }

    public PredicatedSortedDictionary(in Predicate<TKey>? keyPredicate = null, in string? onKeyFailed = null,
                                      in Predicate<TValue>? valuePredicate = null, in string? onValueFailed = null)
    : base()
    {
      KeyPredicate = keyPredicate ?? (key => true);
      ValuePredicate = valuePredicate ?? (value => true);
      OnKeyFailed = onKeyFailed ?? "Key must match KeyPredicate!";
      OnValueFailed = onValueFailed ?? "Value must match ValuePredicate!";
    }

    public PredicatedSortedDictionary(in IDictionary<TKey, TValue> dictionary, in IComparer<TKey> comparer,
                                      in Predicate<TKey>? keyPredicate = null, in string? onKeyFailed = null,
                                      in Predicate<TValue>? valuePredicate = null, in string? onValueFailed = null)
                                                            : base(dictionary, comparer)
    {
      KeyPredicate = keyPredicate ?? (key => true);
      ValuePredicate = valuePredicate ?? (value => true);
      OnKeyFailed = onKeyFailed ?? "Key must match KeyPredicate!";
      OnValueFailed = onValueFailed ?? "Value must match ValuePredicate!";

      this.ForEach(keyValuePair => Validate(keyValuePair.Key, keyValuePair.Value));
    }

    public PredicatedSortedDictionary(in IDictionary<TKey, TValue> dictionary,
                                      in Predicate<TKey>? keyPredicate = null, in string? onKeyFailed = null,
                                      in Predicate<TValue>? valuePredicate = null, in string? onValueFailed = null)
                                                            : base(dictionary)
    {
      KeyPredicate = keyPredicate ?? (key => true);
      ValuePredicate = valuePredicate ?? (value => true);
      OnKeyFailed = onKeyFailed ?? "Key must match KeyPredicate!";
      OnValueFailed = onValueFailed ?? "Value must match ValuePredicate!";

      this.ForEach(keyValuePair => Validate(keyValuePair.Key, keyValuePair.Value));
    }

    public void Add(in TKey key, in TValue value)
    {
      Validate(key, value);
      base.Add(key, value);
    }

    public void TryAdd(in TKey key, in TValue value)
    {
      try
      {
        Validate(key, value);
        base.Add(key, value);
      }
      catch (ArgumentException error) { }
    }

    private void Validate(in TKey key, in TValue value)
    {
      if (!KeyPredicate.Invoke(key))
      {
        throw new ArgumentException(OnKeyFailed);
      }
      else if (!ValuePredicate.Invoke(value))
      {
        throw new ArgumentException(OnValueFailed);
      }
    }
  }
}
