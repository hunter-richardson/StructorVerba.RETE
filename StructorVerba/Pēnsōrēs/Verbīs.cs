using Praebeunda;
namespace Pēnsōrēs
{
  public sealed class Verbīs : Pēnsor<Verbum>
  {
    private Verbīs() : base(nameof(Verbum.scrīptum), Tabula.Verba, () => null, Verbum.Lēctor) { }
  }
}
