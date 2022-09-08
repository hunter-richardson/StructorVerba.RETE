using System;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

namespace Īnflexor.Incertī
{
  [AsyncOverloads]
  public sealed partial class ĪnflexorŌrnātus<Hoc> : Īnflexor<Hoc>
  {

    private readonly ĪnflexorIncertus<Hoc> Relātus { get; }
    private readonly Func<Enum[], string> Prefixor { get; }
    public ĪnflexorŌrnātus(in Lazy<ĪnflexorIncertus<Hoc>> relātus,
                           in Func<Enum[], string> prefixor)
        : base(relātus.Value.Catēgoria,
               new Lazy<Nūntius<ĪnflexorŌrnātus>>(),
               relatus.Vaue.Tabulātor.Invoke())
    {
      Relātus = relātus.Value;
      Prefixor = prefixor;
    }

    public string Scrībam(in Enum[] illa)
    {
      const string prefixum = Prefixor.Invoke(illa);
      const string? relātum = await Relātus.ScrībamAsync(illa);
      return string.IsNullOrWhitespace(relātum)
                   .Choose(string.Empty, prefixum.Concat(relātum));
    }
  }
}
