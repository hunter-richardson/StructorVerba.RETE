using System;
using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

namespace Īnflexor.Incertī
{
  [AsyncOverloads]
  public sealed partial class ĪnflexorRescrīptus<Hoc> : Īnflexor<Hoc>
  {
    private readonly Func<string, string> Rescrīptor { get; }
    private readonly Īnflexor<Hoc> Relātus { get; }

    public ĪnflexorRescrīptus(in Lazy<Īnflexor<Hoc>> relātus,
                              in Func<string, string> rescrīptor = (scrīptum => scrīptum))
        : base(catēgoria: relātus.Value.Catēgoria,
               nūntius: new Lazy<Nūntius<ĪnflexorRescrīptus>>(),
               illa: relātus.Tabulātor.Invoke())
    {
      Relātus = relātus.Value;
      Rescrīptor = rescrīptor;
      Nūntius.PlūsGarriōAsync("Fīō");
    }

    public sealed string Scrībam(in Enum[] illa)
        => Rescrīptor.Invoke(await Relātus.ScrībamAsync(illa: illa));
  }
}
