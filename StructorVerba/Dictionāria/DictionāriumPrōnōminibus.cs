using System;

using Nūntiī.Nūntius;
using Praebeunda.Multiplex.Prōnōmen;
using Īnflexōrēs.Incertī;
using Īnflexōrēs.Incertī.Prōnōmina;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Dictionāria
{
  [Singleton]
  public sealed partial class DictionāriumPrōnōminibus : Dictionārium<Multiplex.Prōnōmen>
  {
    public static readonly Lazy<DictionāriumPrōnōminibus> Faciendum = new Lazy(() => Instance);

    protected readonly Lazy<ĪnflexorIncertus> Sē = ĪnflexorVerbīSē.Faciendum;

    private DictionāriumPrōnōminibus()
         : base(new Lazy<Nūntius<DictionāriumPrōnōminibus>>()) { }
  }
}
