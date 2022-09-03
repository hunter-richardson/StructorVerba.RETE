using System;

using Miscella;
using Nūntiī.Nūntius;
using Īnflexōrēs.Effectī.Āctūs.ĪnflexōrēsEffectusĀctibus.Versiō;
using Ēnumerātiōnēs;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Īnflexōrēs.Effectī.Āctūs
{
  [Singleton]
  [AsyncOverloads]
  public sealed partial class ĪnflexorEffectusQuārtusĀctibus : ĪnflexorEffectusĀctibus
  {
    public static readonly Lazy<ĪnflexorEffectusQuārtusĀctibus> Faciendum
                     = new Lazy<ĪnflexorEffectusQuārtusĀctibus>(() => Instance);

    private ĪnflexorEffectusQuārtusĀctibus()
        : base(Versiō.Quārtus, NūntiusĪnflexōrīEffectōQuārtōĀctibus.Faciendum,
               (āctus, illa) => (illa.FirstOf<Modus>(), illa.FirstOf<Vōx>(), illa.FirstOf<Tempus>()) switch
                                  {
                                    var īnscītum when (modus is default(Modus)) ||
                                                      (tempus is default(Tempus)) ||
                                                      (vōx is default(Vōx)) => string.Empty,
                                    _ => āctus.Īnfīnītīvum.Chop(3),
                                  }) { }

    public sealed string? IndicātīvumĀctīvum(in Tempus tempus, in Numerālis numerālis, in Persōna persōna)
    {
      const string? suffixum = (tempus, numerālis, persōna) switch
                                {
                                  (Tempus.Futūrum, Numerālis.Singulāris, Persōna.Prīma) => "iam",
                                  (Tempus.Futūrum, Numerālis.Singulāris, Persōna.Secunda) => "iēs",
                                  (Tempus.Futūrum, Numerālis.Singulāris, Persōna.Tertia) => "iet",
                                  (Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Prīma) => "iēmus",
                                  (Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Secunda) => "iētis",
                                  (Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Tertia) => "ent",
                                  (Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma) => "iō",
                                  (Tempus.Praesēns, Numerālis.Singulāris, Persōna.Secunda) => "īs",
                                  (Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Tertia) => "iunt",
                                  (Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Secunda) => "ītis",
                                  (Tempus.Perfectum, Numerālis.Singulāris, Persōna.Prīma) => "ī",
                                  (Tempus.Perfectum, Numerālis.Singulāris, Persōna.Secunda) => "istī",
                                  (Tempus.Perfectum, Numerālis.Plūrālis, Persōna.Tertia) => "ērunt",
                                  (Tempus.Perfectum, Numerālis.Plūrālis, Persōna.Secunda) => "istis",
                                  (Tempus.Futūrum_Exāctum, Numerālis.Singulāris, Persōna.Prīma) => "ō",
                                  (Tempus.Futūrum_Exāctum, Numerālis.Singulāris, Persōna.Secunda) => "is",
                                  (Tempus.Futūrum_Exāctum, Numerālis.Plūrālis, Persōna.Tertia) => "int",
                                  (Tempus.Futūrum_Exāctum, Numerālis.Plūrālis, Persōna.Secunda) => "itis",
                                  (Tempus.Praesēns or Tempus.Perfectum or Tempus.Futūrum_Exāctum, Numerālis.Singulāris, Persōna.Tertia) => "it",
                                  (Tempus.Praesēns or Tempus.Perfectum or Tempus.Futūrum_Exāctum, Numerālis.Plūrālis, Persōna.Prīma) => "imus",
                                  (Tempus.Infectum or Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Prīma) => "am",
                                  (Tempus.Infectum or Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Secunda) => "ās",
                                  (Tempus.Infectum or Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Tertia) => "at",
                                  (Tempus.Infectum or Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Prīma) => "āmus",
                                  (Tempus.Infectum or Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Secunda) => "ātis",
                                  (Tempus.Infectum or Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Tertia) => "ant",
                                  _ => null
                                },
                    īnfīxum = tempus switch
                              {
                                Tempus.Perfectum => "īv",
                                Tempus.Infectum => "iēb",
                                Tempus.Praesēns or Tempus.Futūrum => string.Empty,
                                Tempus.Plūsquamperfectum or Tempus.Futūrum_Exāctum => "īver",
                                _ => null
                              };
      return īnfīxum?.Concat(suffixum);
    }

    public sealed string? IndicātīvumPassīvum(in Tempus tempus, in Numerālis numerālis, in Persōna persōna)
    {
      const string? suffixum = (tempus, numerālis, persōna) switch
                                {
                                  (Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma) => "ior",
                                  (Tempus.Praesēns, Numerālis.Singulāris, Persōna.Secunda) => "īris",
                                  (Tempus.Praesēns, Numerālis.Singulāris, Persōna.Tertia) => "ītur",
                                  (Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Prīma) => "īmur",
                                  (Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Secunda) => "īminī",
                                  (Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Tertia) => "iuntur",
                                  (Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma) => "or",
                                  (Tempus.Futūrum, Numerālis.Singulāris, Persōna.Prīma) => "iar",
                                  (Tempus.Futūrum, Numerālis.Singulāris, Persōna.Secunda) => "iēris",
                                  (Tempus.Futūrum, Numerālis.Singulāris, Persōna.Tertia) => "iētur",
                                  (Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Prīma) => "iēmur",
                                  (Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Secunda) => "iēminī",
                                  (Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Tertia) => "ientur",
                                  (Tempus.Infectum, Numerālis.Singulāris, Persōna.Prīma) => "ar",
                                  (Tempus.Infectum, Numerālis.Singulāris, Persōna.Secunda) => "āris",
                                  (Tempus.Infectum, Numerālis.Singulāris, Persōna.Tertia) => "ātur",
                                  (Tempus.Infectum, Numerālis.Plūrālis, Persōna.Prīma) => "āmur",
                                  (Tempus.Infectum, Numerālis.Plūrālis, Persōna.Secunda) => "āminī",
                                  (Tempus.Infectum, Numerālis.Plūrālis, Persōna.Tertia) => "antur",
                                  _ => null
                                },
                    īnfīxum = tempus switch
                              {
                                Tempus.Infectum => "iēb",
                                Tempus.Praesēns or Tempus.Futūrum => string.Empty,
                                _ => null
                              };
      return īnfīxum?.Concat(suffixum);
    }

    public sealed string? SubiūnctīvumĀctīvum(in Tempus tempus, in Numerālis numerālis, in Persōna persōna)
    {
      const string? suffixum = (tempus, numerālis, persōna) switch
                                {
                                  (Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma) => "iam",
                                  (Tempus.Praesēns, Numerālis.Singulāris, Persōna.Secunda) => "iās",
                                  (Tempus.Praesēns, Numerālis.Singulāris, Persōna.Tertia) => "iat",
                                  (Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Prīma) => "iāmus",
                                  (Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Secunda) => "iātis",
                                  (Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Tertia) => "iant",
                                  (Tempus.Perfectum, Numerālis.Singulāris, Persōna.Prīma) => "im",
                                  (Tempus.Perfectum, Numerālis.Singulāris, Persōna.Secunda) => "īs",
                                  (Tempus.Perfectum, Numerālis.Singulāris, Persōna.Tertia) => "it",
                                  (Tempus.Perfectum, Numerālis.Plūrālis, Persōna.Prīma) => "īmus",
                                  (Tempus.Perfectum, Numerālis.Plūrālis, Persōna.Secunda) => "ītis",
                                  (Tempus.Perfectum, Numerālis.Plūrālis, Persōna.Tertia) => "int",
                                  (Tempus.Infectum or Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Prīma) => "em",
                                  (Tempus.Infectum or Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Secunda) => "ēs",
                                  (Tempus.Infectum or Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Tertia) => "et",
                                  (Tempus.Infectum or Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Prīma) => "ēmus",
                                  (Tempus.Infectum or Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Secunda) => "ētis",
                                  (Tempus.Infectum or Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Tertia) => "ent",
                                  _ => null
                                },
                    īnfīxum = tempus switch
                              {
                                Tempus.Praesēns => string.Empty,
                                Tempus.Infectum => "īr",
                                Tempus.Perfectum => "īver",
                                Tempus.Plūsquamperfectum => "īviss",
                                _ => null
                              };
      return īnfīxum?.Concat(suffixum);
    }

    public sealed string? IndicātīvumPassīvum(in Numerālis numerālis, in Persōna persōna)
    {
      const string? suffixum = (numerālis, persōna) switch
                                {
                                  (Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma) => "ior",
                                  (Tempus.Praesēns, Numerālis.Singulāris, Persōna.Secunda) => "īris",
                                  (Tempus.Praesēns, Numerālis.Singulāris, Persōna.Tertia) => "ītur",
                                  (Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Prīma) => "īmur",
                                  (Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Secunda) => "īminī",
                                  (Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Tertia) => "iuntur",
                                  (Tempus.Infectum, Numerālis.Singulāris, Persōna.Prīma) => "ar",
                                  (Tempus.Infectum, Numerālis.Singulāris, Persōna.Secunda) => "āris",
                                  (Tempus.Infectum, Numerālis.Singulāris, Persōna.Tertia) => "ātur",
                                  (Tempus.Infectum, Numerālis.Plūrālis, Persōna.Prīma) => "āmur",
                                  (Tempus.Infectum, Numerālis.Plūrālis, Persōna.Secunda) => "āminī",
                                  (Tempus.Infectum, Numerālis.Plūrālis, Persōna.Tertia) => "antur",
                                  _ => null
                                },
                    īnfīxum = tempus switch
                              {
                                Tempus.Praesēns => string.Empty,
                                Tempus.Infectum => "iēb",
                                _ => null
                              };
      return īnfīxum?.Concat(suffixum);
    }

    public sealed async string? Imperātīvum(in Vōx vōx, in Tempus tempus, in Numerālis numerālis)
              => (vōx, tempus, numerālis) switch
                  {
                    (Vōx.Āctīva, Tempus.Praesēns, Numerālis.Singulāris) => "ī",
                    (Vōx.Āctīva, Tempus.Futūrum, Numerālis.Singulāris) => "ītō",
                    (Vōx.Passīva, Tempus.Praesēns, Numerālis.Plūrālis) => "īminī",
                    (Vōx.Passīva, Tempus.Futūrum, Numerālis.Singulāris) => "ītor",
                    (Vōx.Passīva, Tempus.Futūrum, Numerālis.Plūrālis) => "iuntor",
                    (Vōx.Passīva, Tempus.Praesēns, Numerālis.Singulāris)
                            => await ĪnfīnītīvumAsync(Vōx.Āctīva, tempus),
                    (Vōx.Āctīva, Tempus.Praesēns or Tempus.Futūrum, Numerālis.Plūrālis)
                            => (await ImperātīvumAsync(vōx, tempus, Numerālis.Singulāris)).Concat("te"),
                    _ => null
                  };

    public sealed string? Īnfīnītīvum(in Vōx vōx, in Tempus tempus)
              => (vōx, tempus) switch
                  {
                    (Vōx.Āctīva, Tempus.Praesēns) => "īre",
                    (Vōx.Āctīva, Tempus.Perfectum) => "īvisse",
                    (Vōx.Passīva, _) => (await ĪnfīnītīvumAsync(vōx, Tempus.Praesēns)).Replace("e", "ī"),
                    _ => null
                  };

    public sealed string? Participāle(in Vōx vōx, in Tempus tempus)
              => (vōx, tempus) switch
                  {
                    (Vōx.Āctīva, Tempus.Praesēns) => "iēns",
                    (Vōx.Āctīva, Tempus.Futūrum) => "ītūrum",
                    (Vōx.Passīva, Tempus.Praesēns) => "ītum",
                    (Vōx.Passīva, Tempus.Perfectum) => "iendum",
                    _ => null
                  };

    [Singleton]
    private sealed partial class NūntiusĪnflexōrīEffectōQuārtōĀctibus
                : Nūntius<ĪnflexorEffectusQuārtusĀctibus>
    {
      public static readonly Lazy<NūntiusĪnflexōrīEffectōQuārtōĀctibus> Faciendum
                       = new Lazy<NūntiusĪnflexōrīEffectōQuārtōĀctibus>(() => Instance);
    }
  }
}
