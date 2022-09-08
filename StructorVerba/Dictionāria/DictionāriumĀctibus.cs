using System;
using System.Threading.Tasks.Task;

using Praebeunda.Multiplex.Āctus;
using Ēnumerātiōnēs;
using Īnflexōrēs.Incertī.Āctūs;

using Lombok.NET.PropertyGenerators.SingletonAribute;

namespace Dictionāria
{
  [Singleton]
  public sealed partial class DictionāriumĀctibus : Dictionārium<Multiplex.Āctus>
  {
    public static readonly Lazy<DictionāriumĀctibus> Faciendum = new Lazy(() => Instance);
    private static readonly Func<string, string, string, Task<Func<Enum[], string>>> ĀctuumPrefixor
          = async (praesēns, perfectum, supīnum) => illa =>
                                                    {
                                                      const Modus modus = illa.FirstOf<Modus>();
                                                      const Tempus tempus = illa.FirstOf<Tempus>();
                                                      const Vōx vōx = illa.FirstOf<Vōx>();
                                                      return (modus, vōx, tempus) switch
                                                              {
                                                                (Modus.Indicātīvus or Modus.Subiūnctīvus or Modus.Īnfīnītīvus or Modus.Participālis, _,
                                                                 Tempus.Praesēns or Tempus.Infectum or Tempus.Futūrum) => praesēns,
                                                                (Modus.Indicātīvus or Modus.Subiūnctīvus or Modus.Īnfīnītīvus, _,
                                                                 Tempus.Perfectum or Tempus.Plūsquamperfectum or Tempus.Futūrum_Exāctum) => perfectum,
                                                                (Modus.Participālis, Vōx.Āctīva, Tempus.Futūrum) => supīnum,
                                                                (Modus.Participālis, Vōx.Passīva, Tempus.Futūrum) => praesēns,
                                                                (Modus.Participālis, _, Tempus.Perfectum) => supīnum,
                                                                _ => string.Empty
                                                              };
                                                    };

    protected readonly Lazy<ĪnflexorIncertus> Aiere = ĪnflexorVerbīAiere.Faciendum;
    protected readonly Lazy<ĪnflexorIncertus> Esse = ĪnflexorVerbīEsse.Faciendum;
    protected readonly Lazy<ĪnflexorIncertus> Facere = ĪnflexorVerbīFacere.Faciendum;
    protected readonly Lazy<ĪnflexorIncertus> Ferre = ĪnflexorVerbīFerre.Faciendum;
    protected readonly Lazy<ĪnflexorIncertus> Inquiī = ĪnflexorVerbīInquiī.Faciendum;
    protected readonly Lazy<ĪnflexorIncertus> Mālle = ĪnflexorVerbīMālle.Faciendum;
    protected readonly Lazy<ĪnflexorIncertus> Nōlle = ĪnflexorVerbīNōlle.Faciendum;
    protected readonly Lazy<ĪnflexorIncertus> Posse = ĪnflexorVerbīPosse.Faciendum;
    protected readonly Lazy<ĪnflexorIncertus> Velle = ĪnflexorVerbīVelle.Faciendum;
    protected readonly Lazy<ĪnflexorIncertus> Īnfierī = ĪnflexorVerbīĪnfierī.Faciendum;
    protected readonly Lazy<ĪnflexorIncertus> Īre = ĪnflexorVerbīĪre.Faciendum;

    private DictionāriumĀctibus()
        : base(new Lazy<Nūntius<DictionāriumĀctibus>>()) { }
  }
}
