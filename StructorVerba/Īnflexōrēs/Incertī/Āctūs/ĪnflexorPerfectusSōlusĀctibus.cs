using System;

using Miscella;
using Praebeunda.Multiplex.Āctus;
using Īnflexōrēs.Effectī.Āctūs.ĪnflexorEffectusĀctibus;
using Ēnumerâtiōnēs;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

namespace Īnflexōrēs.Incertī.Āctūs
{
  [AsyncOverloads]
  public sealed partial class ĪnflexorPerfectusSōlusĀctibus : Īnflexor<Multiplex.Āctus>
  {
    private readonly ĪnflexorEffectusĀctibus Relātus { get; }
    private readonly string RādīxPerfectum { get; }
    private readonly string RādīxSupīnum { get; }
    public ĪnflexorPerfectusSōlusĀctibus(in Lazy<ĪnflexorEffectusĀctibus> relātus,
                                         in string perfectum, in string supīnum)
        : base(Catēgoria.Āctus, new Lazy<Nūntius<ĪnflexorPerfectusSōlusĀctibus>>(),
               Modus.Īnfīnītīvus.SingleItemSet(),
               Ūtilitātēs.Combīnō(Modus.Participālis.SingleItemSst(),
                                  new HashSet<Casus>() { Tempus.Futūrum, Tempus.Perfectum }),
               Ūtilitātēs.Combīnō(new HashSet<Modus>() { Modus.Indicātīvus, Modus.Subiūnctīvus },
                                  new HashSet<Tempus>() { Tempus.Perfectum, Tempus.Plūsquamperfectum, Tempus.Futūrum_Exāctum },
                                  Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet(),
                                  Persōna.GetValues().Except(Persōna.Nūlla).ToHashSet())
                         .Except(illa => illa.ContainsAll(Modus.Subiūnctīvus, Tempus.Futūrum_Exāctum)))
    {
      Relātus = relātus.Value;
      RādīxPerfectum = perfectum.Chop(4);
      RādīxSupīnum = supīnum.Chop(2);
      Nūntius.PlūsGarriōAsync("Fīō");
    }

    public sealed string Scrībam(in Enum[] illa)
    {
      const Modus modus = illa.FirstOf<Modus>();
      Tempus tempus = illa.FirstOf<Tempus>();
      tempus = (modus, tempus) switch
                {
                  (_, Tempus.Praesēns) => Tempus.Perfectum,
                  (Modus.Participālis, _) => tempus,
                  (Modus.Īnfīnītīvus, _) => Tempus.Perfectum,
                  (_, Tempus.Īnfectum) => Tempus.Plūsquamperfectum,
                  (_, Tempus.Futūrum) => Tempus.Futūrum_Exāctum,
                  _ => tempus
                };
      const string rādīx = (modus, tempus) switch
                            {
                              (Modus.Imperātīvus, _) => string.Empty,
                              (Modus.Participālis, Tempus.Futūrum or Tempus.Perfectum) => RādīxSupīnum,
                              _ => RādīxPerfectum
                            };
      const Vōx vōx = Ūtilitātēs.Omnia(modus is Modus.Participālis,
                                       tempus is Tempus.Perfectum)
                                .Choose(Vōx.Passīva, Vōx.Āctīva);
      return string.IsNullOrWhitespace(rādīx)
                   .Choose(string.Empty, rādīx.Concat(await Relātus.ScrībamAsync(modus, vōx, tempus,
                                                                                 illa.FirstOf<Numerālis>(), illa.FirstOf<Persōna>())));
    }
  }
}
