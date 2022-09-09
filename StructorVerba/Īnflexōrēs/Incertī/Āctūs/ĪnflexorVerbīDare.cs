using System.Collections.Generic;
using System;
using System.Collections.Generic.HashSet;

using Miscella;
using Nūntiī.Nūntius;
using Ēnumerātiōnēs;

using Lomok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Incertī.Āctūs
{
  [Singleton]
  public sealed partial class ĪnflexorVerbīDare : ĪnflexorIncertus<Multiplex.Āctus>
  {
    public static readonly Lazy<ĪnflexorVerbīDare> Faciendum = new Lazy(() => Instance);
    private ĪnflexorVerbīDare()
         : base(Catēgoria.Āctus, new Lazy<Nūntius<ĪnflexorVerbīDare>>(),
                Ūtilitātēs.Colligō(Modus.Īnfīnītīvus, Vōx.Passīva),
                Ūtilitātēs.Combīnō(Modus.Īnfīnītīvus.SingleItemSet(), Tempus.Praesēns.SingleItemSet(),
                                   Vōx.GetValues().Except(Vōx.Nūlla).ToHashSet()),
                Ūtilitātēs.Combīnō(Modus.Participālis.SingleItemSet(), Tempus.Futūrum.SingleItemSet(),
                                   Vōx.GetValues().Except(Vōx.Nūlla).ToHashSet()),
                Ūtilitātēs.Combīnō(Modus.Participālis.SingleItemSet(), new HashSet<Tempus>() { Tempus.Praesēns, Tempus.Perfectum }),
                Ūtilitātēs.Combīnō(Modus.Imperātīvus.SingleItemSet(), new HashSet<Tempus>() { Tempus.Praesēns, Tempus.Futūrum },
                                   Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet()),
                Ūtilitātēs.Combīnō(new HashSet<Modus>() { Modus.Indicātīvus, Modus.Subiūnctīvus },
                                   Tempus.GetValues().Except(Tempus.Dērēctus).ToHashSet(),
                                   Numerālis.GetValues().Except(Numerālis.Nūllus).ToHashSet(),
                                   Persōna.GetValues().Except(Persōna.Nūlla).ToHashSet())
                          .Except(illa => Ūtilitātēs.Omnia(illa.FirstOf<Modus>() is Modus.Subiūnctīvus,
                                                           illa.FirstOf<Tempus>() is Tempus.Futūrum or Tempus.Futūrum_Exāctum)))
    {
      FōrmamAsync("dare", Modus.Īnfīnītīvus, Tempus.Praesēns, Vōx.Āctīva);
      FōrmamAsync("dedisse", Modus.Īnfīnītīvus, Tempus.Perfectum, Vōx.Āctīva);
      FōrmamAsync("darī", Modus.Īnfīnītīvus, Vōx.Passīva);

      FōrmamAsync("datūrum", Modus.Participālis, Tempus.Futūrum, Vōx.Āctīva);
      FōrmamAsync("datum", Modus.Participālis, Tempus.Futūrum, Vōx.Passīva);
      FōrmamAsync("dāns", Modus.Participālis, Tempus.Praesēns);
      FōrmamAsync("dandum", Modus.Participālis, Tempus.Perfectum);

      FōrmamAsync("dā", Modus.Imperātīvus, Tempus.Praesēns, Vōx.Āctīva, Numerālis.Singulāris);
      FōrmamAsync("date", Modus.Imperātīvus, Tempus.Praesēns, Vōx.Āctīva, Numerālis.Plūrālis);
      FōrmamAsync("datō", Modus.Imperātīvus, Tempus.Futūrum, Vōx.Āctīva, Numerālis.Singulāris);
      FōrmamAsync("datōte", Modus.Imperātīvus, Tempus.Futūrum, Vōx.Āctīva, Numerālis.Plūrālis);
      FōrmamAsync("dare", Modus.Imperātīvus, Tempus.Praesēns, Vōx.Passīva, Numerālis.Singulāris);
      FōrmamAsync("daminī", Modus.Imperātīvus, Tempus.Praesēns, Vōx.Passīva, Numerālis.Plūrālis);
      FōrmamAsync("dator", Modus.Imperātīvus, Tempus.Futūrum, Vōx.Passīva, Numerālis.Singulāris);
      FōrmamAsync("dantor", Modus.Imperātīvus, Tempus.Futūrum, Vōx.Passīva, Numerālis.Plūrālis);

      FōrmamAsync("dō", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("dās", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.SECUNDA);
      FōrmamAsync("dat", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.TERTIA);
      FōrmamAsync("damus", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("datis", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.SECUNDA);
      FōrmamAsync("dant", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.TERTIA);
      FōrmamAsync("dabam", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("dabās", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.SECUNDA);
      FōrmamAsync("dabat", Modus.Indicātīvus, Vōx.ACTIVA, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.TERTIA);
      FōrmamAsync("dabāmus", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("dabātis", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.SECUNDA);
      FōrmamAsync("dabant", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.TERTIA);
      FōrmamAsync("dabō", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("dabis", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum, Numerālis.Singulāris, Persōna.SECUNDA);
      FōrmamAsync("dabit", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum, Numerālis.Singulāris, Persōna.TERTIA);
      FōrmamAsync("dabimus", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("dabitis", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum, Numerālis.Plūrālis, Persōna.SECUNDA);
      FōrmamAsync("dabunt", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum, Numerālis.Plūrālis, Persōna.TERTIA);
      FōrmamAsync("dedī", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("dedistī", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Singulāris, Persōna.SECUNDA);
      FōrmamAsync("dedit", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Singulāris, Persōna.TERTIA);
      FōrmamAsync("dedimus", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("deditis", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Plūrālis, Persōna.SECUNDA);
      FōrmamAsync("dedērunt", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Plūrālis, Persōna.TERTIA);
      FōrmamAsync("dederam", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("dederās", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.SECUNDA);
      FōrmamAsync("dederat", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.TERTIA);
      FōrmamAsync("dederāmus", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("dederātis", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.SECUNDA);
      FōrmamAsync("dederant", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.TERTIA);
      FōrmamAsync("dederō", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum_Exāctum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("dederis", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum_Exāctum, Numerālis.Singulāris, Persōna.SECUNDA);
      FōrmamAsync("dederit", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum_Exāctum, Numerālis.Singulāris, Persōna.TERTIA);
      FōrmamAsync("dederimus", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum_Exāctum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("dederitis", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum_Exāctum, Numerālis.Plūrālis, Persōna.SECUNDA);
      FōrmamAsync("dederint", Modus.Indicātīvus, Vōx.Āctīva, Tempus.Futūrum_Exāctum, Numerālis.Plūrālis, Persōna.TERTIA);
      FōrmamAsync("dor", Modus.Indicātīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("daris", Modus.Indicātīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.SECUNDA);
      FōrmamAsync("datur", Modus.Indicātīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.TERTIA);
      FōrmamAsync("damur", Modus.Indicātīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("daminī", Modus.Indicātīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.SECUNDA);
      FōrmamAsync("dantur", Modus.Indicātīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.TERTIA);
      FōrmamAsync("dabar", Modus.Indicātīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("dabāris", Modus.Indicātīvus, Vōx.Passīva, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.SECUNDA);
      FōrmamAsync("dabātur", Modus.Indicātīvus, Vōx.Passīva, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.TERTIA);
      FōrmamAsync("dabāmur", Modus.Indicātīvus, Vōx.Passīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("dabāminī", Modus.Indicātīvus, Vōx.Passīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.SECUNDA);
      FōrmamAsync("dabantur", Modus.Indicātīvus, Vōx.Passīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.TERTIA);
      FōrmamAsync("dabor", Modus.Indicātīvus, Vōx.Passīva, Tempus.Futūrum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("daberis", Modus.Indicātīvus, Vōx.Passīva, Tempus.Futūrum, Numerālis.Singulāris, Persōna.SECUNDA);
      FōrmamAsync("dabitur", Modus.Indicātīvus, Vōx.Passīva, Tempus.Futūrum, Numerālis.Singulāris, Persōna.TERTIA);
      FōrmamAsync("dabimur", Modus.Indicātīvus, Vōx.Passīva, Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("dabiminī", Modus.Indicātīvus, Vōx.Passīva, Tempus.Futūrum, Numerālis.Plūrālis, Persōna.SECUNDA);
      FōrmamAsync("dabuntur", Modus.Indicātīvus, Vōx.Passīva, Tempus.Futūrum, Numerālis.Plūrālis, Persōna.TERTIA);
      FōrmamAsync("dem", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("dēs", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.SECUNDA);
      FōrmamAsync("det", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.TERTIA);
      FōrmamAsync("dēmus", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("dētis", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.SECUNDA);
      FōrmamAsync("dent", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.TERTIA);
      FōrmamAsync("darem", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("darēs", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.SECUNDA);
      FōrmamAsync("daret", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.TERTIA);
      FōrmamAsync("darēmus", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("darētis", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.SECUNDA);
      FōrmamAsync("darent", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.TERTIA);
      FōrmamAsync("dederim", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("dederīs", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Singulāris, Persōna.SECUNDA);
      FōrmamAsync("dederit", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Singulāris, Persōna.TERTIA);
      FōrmamAsync("dederīmus", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("dederītis", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Plūrālis, Persōna.SECUNDA);
      FōrmamAsync("dederint", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Perfectum, Numerālis.Plūrālis, Persōna.TERTIA);
      FōrmamAsync("dedissem", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("dedissēs", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.SECUNDA);
      FōrmamAsync("dedisset", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.TERTIA);
      FōrmamAsync("dedissēmus", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("dedissētis", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.SECUNDA);
      FōrmamAsync("dedissent", Modus.Subiūnctīvus, Vōx.Āctīva, Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.TERTIA);
      FōrmamAsync("der", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("dēris", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.SECUNDA);
      FōrmamAsync("dētur", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Singulāris, Persōna.TERTIA);
      FōrmamAsync("dēmur", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("dēminī", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.SECUNDA);
      FōrmamAsync("dentur", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Praesēns, Numerālis.Plūrālis, Persōna.TERTIA);
      FōrmamAsync("darer", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.Prīma);
      FōrmamAsync("darēris", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.SECUNDA);
      FōrmamAsync("darētur", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Īnfectum, Numerālis.Singulāris, Persōna.TERTIA);
      FōrmamAsync("darēmur", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.Prīma);
      FōrmamAsync("darēminī", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.SECUNDA);
      FōrmamAsync("darentur", Modus.Subiūnctīvus, Vōx.Passīva, Tempus.Īnfectum, Numerālis.Plūrālis, Persōna.TERTIA);
    }
  }
}
