using System;
using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

namespace Īnflexor.Incertī
{
  [AsyncOverloads]
  public partial class ĪnflexorRescrīptus<Hoc> : Īnflexor<Hoc>
  {
    private readonly Func<string, string> Rescrīptor { get; }
    private readonly Īnflexor<Hoc>? Relātus { get; }
    private readonly Lemma? Lemma { get; }

    public ĪnflexorRescrīptus(in Lazy<Īnflexor<Hoc>> relātus,
                              in Func<string, string> rescrīptor = (scrīptum => scrīptum),
                              in Lazy<Nūntius<ĪnflexorRescrīptus>> nūntius = new Lazy<Nūntius<ĪnflexorRescrīptus>>())
        : base(catēgoria: relātus.Value.Catēgoria, nūntius: nūntius,
               illa: relātus.Tabulātor.Invoke())
    {
      Relātus = relātus.Value;
      Lemma = null;
      Rescrīptor = rescrīptor;
      Nūntius.PlūsGarriōAsync("Fīō");
    }

    public ĪnflexorRescrīptus(in Lemma lemma,
                              in Func<string, string> rescrīptor = (scrīptum => scrīptum),
                              in Lazy<Nūntius<ĪnflexorRescrīptus>> nūntius = new Lazy<Nūntius<ĪnflexorRescrīptus>>())
        : base(catēgoria: lemma.Catēgoria, nūntius: nūntius,
               illa: lemma.Tabulātor.Invoke())
    {
      Lemma = lemma;
      Relātus = null;
      Rescrīptor = rescrīptor;
      Nūntius.PlūsGarriōAsync("Fīō");
    }

    public sealed string Scrībam(in Enum[] illa)
    {
      string? relātum = null;
      if(Lemma is not null)
      {
        relātum = (await Lemma.Īnflexor.Invoke(illa))?.Scrīptum ?? string.Empty;
      }
      else if(Relātus is not null)
      {
        relātum = await Relātus.ScrībamAsync(illa: illa);
      }
      else
      {
        return string.Empty;
      }

      return Rescrīptor.Invoke(relātum);
    }
  }
}
