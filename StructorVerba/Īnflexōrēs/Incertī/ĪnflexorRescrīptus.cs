using System;
using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

namespace Īnflexor.Incertī
{
  [AsyncOverloads]
  public sealed partial class ĪnflexorRescrīptus<Hoc> : Īnflexor<Hoc>
  {
    private readonly Func<string, string> Rescrīptor { get; }
    private readonly ĪnflexorIncertus<Hoc> Relātus { get; }

    public ĪnflexorRescrīptus(in Lazy<ĪnflexorIncertus<Hoc>> relātus, in Func<string, string> rescrīptor)
        : base(relātus.Catēgoria, new Lazy<Nūntius<ĪnflexorRescrīptus>>(), relātus.Tabulātor.Invoke())
    {
      Relātus = relātus.Value;
      Rescrīptor = rescrīptor;
    }

    public sealed string Scrībam(in Enum[] illa)
        => Rescrīptor.Invoke(await Relātus.ScrībamAsync(illa));
  }
}
