using Praebeunda.Simplicia;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Pēnsōrēs.Simplicia
{
  [Singleton]
  public sealed partial class PēnsorLemmīs : Pēnsor<Lemma>
  {
    public static readonly Lazy<PēnsorLemmīs> Faciendum = new Lazy<PēnsorLemmīs>(() => Instance);
    private PēnsorLemmīs() : base(nameof(Lemma.Scrīptum), Tabula.Lemmae,
                                  NūntiusPēnsōrīLemmīs.Faciendum,
                                  Lemma.Lēctor)
    {
      Nūntius.PlūsGarriōAsync("Fīō");
    }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīLemmīs : Nūntius<PēnsōrLemmīs>
    {
      public static readonly Lazy<NūntiusPēnsōrīLemmīs> Faciendum = new Lazy<NūntiusPēnsōrīLemmīs>(() => Instance);
    }
  }
}
