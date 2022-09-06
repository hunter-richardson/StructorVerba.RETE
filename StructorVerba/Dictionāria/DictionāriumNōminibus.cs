using System;

using Miscella.Ūtilitātēs;
using Praebeunda.Īnflectendum;
using Praebeunda.Multiplex;
using Īnflexōrēs.Incertī.Nōmina;

namespace Dictionāria
{
  [Singleton]
  public sealed partial class DictionāriumNōminibus : Dictionārium<DictionāriumNōminibus, Īnflectendum.Nōmen, Multiplex.Nōmen>
  {
    public static readonly Lazy<DictionāriumNōminibus> Faciendum = new Lazy<DictionāriumNōminibus>(() => Instance);

    protected readonly Īnflectendum.Nōmen Athōs = await Īnflectendum.Nōmen.Aedificātor.Invoke(ĪnflexorVerbīAthōs.Faciendum,
                                                                                              Ūtilitātēs.Seriēs("Athōs", "Athō"));

    private DictionāriumNōminibus()
        : base(DictionāriumNōminibus.Faciendum) { }

    [Singleton]
    private sealed partial class NūntiusDictionāriōNōminibus : Nūntius<DictionāriumNōminibus>
    {
      public static readonly Lazy<NūntiusDictionāriōNōminibus> Faciendum
                       = new Lazy<NūntiusDictionāriōNōminibus>(() => Instance);
    }
  }
}
