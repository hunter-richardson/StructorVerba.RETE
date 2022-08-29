using Praebeunda.Simplicia;
namespace Pēnsōrēs
{
  public sealed class Lemmīs : Pēnsor<Lemma> {
    private Lemmīs() : base(nameof(Lemma.scrīptum), Tabula.Lemmae, () => null, Lemma.Lēctor) {  }
  }
}
