using System;
using System.Collections.Generic.Dictionary;

using Praebeunda;

namespace Pēnsōrēs.Numerāminibus
{
  public sealed class PēnsorNumerāminibusOmniumPraeterFrāctiōnēs : PēnsorĪnflectendīs<Īnflectendum.NumerāmenOmniumPraeterFrāctiōnēs, Multiplex.Numerāmen>
  {
    private static Dictionary<Enum, PēnsorNumerāminibusOmniumPraeterFrāctiōnēs> Reservātī = new Dictionary<Enum, PēnsorNumerāminibusOmniumPraeterFrāctiōnēs>();

    public static Func<Enum, PēnsorNumerāminibusOmniumPraeterFrāctiōnēs> Faciendum = valor =>
    {
      if (Reservātī.ContainsKey(valor))
      {
        return Reservātī.Item[valor];
      }
      else
      {
        const PēnsorNumerāminibusOmniumPraeterFrāctiōnēs hoc = new PēnsorNumerāminibusOmniumPraeterFrāctiōnēs(valor);
        Reservātī.Add(valor, hoc);
        return hoc;
      }
    };

    private PēnsorNumerāminibusOmniumPraeterFrāctiōnēs(in Enum versiō)
                                                        : base(versiō, Ēnumerātiōnēs.Catēgoria.Numerāmen,
                                                               NūntiusPēnsōrīNumerāminibusOmniumPraeterFrāctiōnēs.Faciendum,
                                                               nameof(Īnflectendum.NumerāmenOmniumPraeterFrāctiōnēs.Numerus),
                                                               Īnflectendum.NumerāmenOmniumPraeterFrāctiōnēs.Lēctor) {  }

    [Singleton]
    private sealed partial class NūntiusPēnsōrīNumerāminibusOmniumPraeterFrāctiōnēs : Nūntius<PēnsōrNumerāminibusOmniumPraeterFrāctiōnēs>
    {
      public static readonly Lazy<NūntiusPēnsōrīNumerāminibusOmniumPraeterFrāctiōnēs> Faciendum =
                         new Lazy<NūntiusPēnsōrīNumerāminibusOmniumPraeterFrāctiōnēs>(() => Instance);
    }
  }
}
