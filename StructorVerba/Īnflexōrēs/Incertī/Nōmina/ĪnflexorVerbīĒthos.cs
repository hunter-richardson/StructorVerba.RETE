using System;

using Miscella;
using Nūntiī.Nuntius;
using Praebeunda.Multiplex.Nōmen;
using Praebeunda.Īnflectendum.Nōmen;
using Ēnumerātiōnēs;
using Īnflexōrēs.Effectī.Nōmen;

using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Incertī.Nōmina
{
  [Singleton]
  public sealed partial class ĪnflexorVerbīĒthos : ĪnflexorIncertus<Īnflectendum.Nōmen, Multiplex.Nōmen>
  {
    public static readonly Lazy<ĪnflexorVerbīĒthos> Faciendum = new Lazy<ĪnflexorVerbīĒthos>(() => Instance);
    private ĪnflexorVerbīĒthos()
        : base(Catēgoria.Nōmen, new Lazy<Nūntius<ĪnflexorVerbīĒthos>>(() => new Nūntius<ĪnflexorVerbīĒthos>()),
               Ūtilitātēs.Combīnō(Casus.GetValues().Except(Casus.Dērēctus).ToSortedSet(),
                                  Numerālis.GetValues().Except(Numerālis.Nūllus).ToSortedSet()))
    {
      FōrmamAsync("ēthos", Numerālis.Singulāris, Casus.Nominātīvus);
      FōrmamAsync("ēthea", Numerālis.Plūrālis, Casus.Nominātīvus);
      FōrmamAsync("ētheos", Numerālis.Singulāris, Casus.Genitīvus);
      FōrmamAsync("ēthōn", Numerālis.Plūrālis, Casus.Genitīvus);
      FōrmamAsync("ēthī", Numerālis.Singulāris, Casus.Datīvus);
      FōrmamAsync("ēthesī", Numerālis.Plūrālis, Casus.Datīvus);
      FōrmamAsync("ētheos", Numerālis.Singulāris, Casus.Accūsātīvus);
      FōrmamAsync("ēthōs", Numerālis.Plūrālis, Casus.Accūsātīvus);
      FōrmamAsync("ēthī", Numerālis.Singulāris, Casus.Ablātīvus);
      FōrmamAsync("ēthesī", Numerālis.Plūrālis, Casus.Ablātīvus);
      FōrmamAsync("ēthos", Numerālis.Singulāris, Casus.Vocātīvus);
      FōrmamAsync("ēthea", Numerālis.Plūrālis, Casus.Vocātīvus);
      FōrmamAsync("ēthī", Numerālis.Singulāris, Casus.Locātīvus);
      FōrmamAsync("ēthesī", Numerālis.Plūrālis, Casus.Locātīvus);
      FōrmamAsync("ēthī", Numerālis.Singulāris, Casus.Instrumentālis);
      FōrmamAsync("ēthesī", Numerālis.Plūrālis, Casus.Instrumentālis);
    }
  }
}
