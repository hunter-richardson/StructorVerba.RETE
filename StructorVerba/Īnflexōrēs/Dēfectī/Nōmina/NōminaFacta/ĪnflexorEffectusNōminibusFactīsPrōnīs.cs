// using System;
// using System.Linq;
// using System.Collections.Generic.SortedSet;

// using Nūntiī.Nūntius;
// using Miscella;
// using Praebeunda.Īnflectendum;
// using Ēnumerātiōnēs;

// using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

// namespace Īnfexōrēs.Dēfectī.Nōmina.NōminaFacta
// {
//   [AsyncOverloads]
//   public abstract partial class ĪnflexorDēfectusNōminibusFactīsPrōnīs : ĪnflexorDēfectusNōminibus<Īnflectendum.NōmenFactumPrōnum>
//   {
//     public enum Versiō
//     {
//       Nōmen_Prīmus_Prōnus,
//       Nōmen_Secundus_Prōnus,
//       Nōmen_Tertius_Prōnus,
//       Nōmen_Quārtus_Prōnus
//     }

//     public static readonly Func<Versiō, Task<Lazy<ĪnflexorEffectusNōminibusFactīsPrōnīs?>>> Versor = async versiō => versiō switch
//       {
//         Versiō.Nōmen_Prīmus_Prōnus => null,
//         Versiō.Nōmen_Secundus_Prōnus => null,
//         Versiō.Nōmen_Tertius_Prōnus => null,
//         Versiō.Nōmen_Quārtus_Prōnus => null,
//         _ => new Lazy(null),
//       };

//     protected ĪnflexorDēfectusNōminibusFactīsPrōnīs(in ĪnflexorNumerāmibus.Versiō versiō, in Lazy<Nūntius<ĪnflexorDēfectusNōminibusFactīsPrōnīs>> nūntius,
//                                                     in Func<Īnflectendum.NōmenFactumPrōnum, Enum[], string> rādīcātor)
//                                                                            : base(versiō, nūntius, nameof(Īnflectendum.NōmenFactumPrōnum.Īnfīnītum), rādīcātor,
//                                                                                   Ūtilitātēs.Colligō(Factum.Īnfīnītīvum.SingleItemSet(),
//                                                                                   Ūtilitātēs.Combīnō(Factum.Gerundātīvum.SingleItemSet(),
//                                                                                                      new SortedSet<Casus>() { Casus.Genitīvus, Casus.Datīvus, Casus.Accūsātīvus, Casus.Ablātīvus }))) { }
//     }
//   }
// }
