using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;

namespace Pēnsōrēs.Numerāminibus
{
  public sealed class PēnsorNumerāminibusOmniumPraeterMultiplicātīva : PēnsorĪnflectendīs<Īnflectendum.NumerāmenOmniumPraeterMultiplicātīva, Multiplex.Numerāmen>
  {
    private static Dictionary<Enum, PēnsorNumerāminibusOmniumPraeterMultiplicātīva> Reservātī = new Dictionary<Enum, PēnsorNumerāminibusOmniumPraeterMultiplicātīva>();

    public static Func<Enum, PēnsorNumerāminibusOmniumPraeterMultiplicātīva> Faciendum = valor =>
    {
      if (Reservātī.ContainsKey(valor))
      {
        return Reservātī.Item[valor];
      }
      else
      {
        const PēnsorNumerāminibusOmniumPraeterMultiplicātīva hoc = new PēnsorNumerāminibusOmniumPraeterMultiplicātīva(valor);
        Reservātī.Add(valor, hoc);
        return hoc;
      }
    };

    private PēnsorNumerāminibusOmniumPraeterMultiplicātīva(in Enum versiō)
                                                            : base(versiō, Ēnumerātiōnēs.Catēgoria.Numerāmen,
                                                                   NūntiusPēnsōrīNumerāminibusOmniumPraeterMultiplicātīva.Faciendum,
                                                                   nameof(Īnflectendum.NumerāmenOmniumPraeterMultiplicātīva.Numerus),
                                                                   Īnflectendum.NumerāmenOmniumPraeterMultiplicātīva.Lēctor) {  }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīNumerāminibusOmniumPraeterMultiplicātīva : Nūntius<PēnsōrNumerāminibusOmniumPraeterMultiplicātīva>
    {
      public static readonly Lazy<NūntiusPēnsōrīNumerāminibusOmniumPraeterMultiplicātīva> Faciendum =
                         new Lazy<NūntiusPēnsōrīNumerāminibusOmniumPraeterMultiplicātīva>(() => Instance);
    }
  }
}
