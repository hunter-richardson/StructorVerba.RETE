namespace Miscella
{
  public static sealed class Ūtilitātēs
  {
    private static Dictionary<char, char> Apicēs = new Dictionary<char, char>() {
                                                          { 'ā', 'a' }, { 'ē', 'e' }, { 'ī', 'i' }, { 'ō', 'o' },
                                                          { 'ū', 'u' }, { 'ȳ', 'y' }, { 'Ā', 'A' }, { 'Ē', 'E' },
                                                          { 'Ī', 'I' }, { 'Ō', 'O' }, { 'Ū', 'U' }, { 'Ȳ', 'Y' } };

    public static readonly Func<string, string> ApicumAbditor = scrīptum =>
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

    public static IEnumerable<T> Seriēs<T>([NotNull] in params T seriēs)
    {
      return seriēs;
    }
  }
}
