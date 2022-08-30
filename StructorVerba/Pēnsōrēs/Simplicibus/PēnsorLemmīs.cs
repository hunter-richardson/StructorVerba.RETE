using Praebeunda.Simplicia;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Pēnsōrēs.Simplicibus
{
  public sealed class PēnsorLemmīs : Pēnsor<Lemma>
  {
    private PēnsorLemmīs() : base(nameof(Lemma.Scrīptum), Tabula.Lemmae, NūntiusPēnsōrīLemmīs.Instance, Lemma.Lēctor)
    {
      Nūntius.PlūsGarriōAsync("Fīō");
    }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīLemmīs : Nūntius<PēnsōrLemmīs> {  }
  }
}
