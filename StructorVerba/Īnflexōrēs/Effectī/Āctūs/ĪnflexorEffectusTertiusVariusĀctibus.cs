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
  public sealed partial class ĪnflexorEffectusTertiusVariusĀctibus : ĪnflexorEffectusĀctibus
  {
    public static readonly Lazy<ĪnflexorEffectusTertiusVariusĀctibus> Faciendum = new Lazy(() => Instance);

    private static readonly ĪnflexorEffectusTertiusĀctibus Relātum = ĪnflexorEffectusTertiusĀctibus.Faciendum.Value;

    private ĪnflexorEffectusTertiusVariusĀctibus()
        : base(new Lazy<Nūntius<ĪnflexorEffectusTertiusVariusĀctibus>>()) { }

    public sealed string? IndicātīvumĀctīvum(in Tempus tempus, in Numerālis numerālis, in Persōna persōna)
    {
      const string? suffixum = (tempus, numerālis, persōna) switch
                                {
                                  (Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma) => "ō",
                                  (Tempus.Praesēns, Numerālis.Singulāris, Persōna.Secunda) => "is",
                                  (Tempus.Praesēns, Numerālis.Singulāris, Persōna.Tertia) => "it",
                                  (Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Prīma) => "imus",
                                  (Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Secunda) => "itis",
                                  (Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Tertia) => "unt",
                                  (Tempus.Futūrum, Numerālis.Singulāris, Persōna.Prīma) => "iam",
                                  (Tempus.Futūrum, Numerālis.Singulāris, Persōna.Secunda) => "iēs",
                                  (Tempus.Futūrum, Numerālis.Singulāris, Persōna.Tertia) => "iet",
                                  (Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Prīma) => "iēmus",
                                  (Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Secunda) => "iētis",
                                  (Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Tertia) => "ient",
                                  (Tempus.Perfectum, Numerālis.Singulāris, Persōna.Prīma) => "ī",
                                  (Tempus.Perfectum, Numerālis.Singulāris, Persōna.Secunda) => "istī",
                                  (Tempus.Perfectum, Numerālis.Plūrālis, Persōna.Tertia) => "ērunt",
                                  (Tempus.Futūrum_Exāctum, Numerālis.Singulāris, Persōna.Prīma) => "ō",
                                  (Tempus.Futūrum_Exāctum, Numerālis.Singulāris, Persōna.Secunda) => "is",
                                  (Tempus.Futūrum_Exāctum, Numerālis.Plūrālis, Persōna.Tertia) => "unt",
                                  (Tempus.Perfectum or Tempus.Futūrum_Exāctum, Numerālis.Singulāris, Persōna.Tertia) => "it",
                                  (Tempus.Perfectum or Tempus.Futūrum_Exāctum, Numerālis.Plūrālis, Persōna.Prīma) => "imus",
                                  (Tempus.Perfectum or Tempus.Futūrum_Exāctum, Numerālis.Plūrālis, Persōna.Secunda) => "itis",
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
                                Tempus.Infectum => "iēb",
                                Tempus.Praesēns or Tempus.Futūrum or Tempus.Perfectum => string.Empty,
                                Tempus.Plūsquamperfectum or Tempus.Futūrum_Exāctum => "er",
                                _ => null
                              };
      return īnfīxum?.Concat(suffixum);
    }

    public sealed string? IndicātīvumPassīvum(in Tempus tempus, in Numerālis numerālis, in Persōna persōna)
    {
      const string? suffixum = (tempus, numerālis, persōna) switch
                                {
                                  (Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma) => "ior",
                                  (Tempus.Praesēns, Numerālis.Singulāris, Persōna.Secunda) => "eris",
                                  (Tempus.Praesēns, Numerālis.Singulāris, Persōna.Tertia) => "itur",
                                  (Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Prīma) => "imur",
                                  (Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Secunda) => "iminī",
                                  (Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Tertia) => "untur",
                                  (Tempus.Infectum, Numerālis.Singulāris, Persōna.Prīma) => "ar",
                                  (Tempus.Infectum, Numerālis.Singulāris, Persōna.Secunda) => "āris",
                                  (Tempus.Infectum, Numerālis.Singulāris, Persōna.Tertia) => "ātur",
                                  (Tempus.Infectum, Numerālis.Plūrālis, Persōna.Prīma) => "āmur",
                                  (Tempus.Infectum, Numerālis.Plūrālis, Persōna.Secunda) => "āminī",
                                  (Tempus.Infectum, Numerālis.Plūrālis, Persōna.Tertia) => "antur",
                                  (Tempus.Futūrum, Numerālis.Singulāris, Persōna.Prīma) => "iar",
                                  (Tempus.Futūrum, Numerālis.Singulāris, Persōna.Secunda) => "iēris",
                                  (Tempus.Futūrum, Numerālis.Singulāris, Persōna.Tertia) => "iētur",
                                  (Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Prīma) => "iēmur",
                                  (Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Secunda) => "iēminī",
                                  (Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Tertia) => "ientur",
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
              => await Relātum.SubiūnctīvumĀctīvumAsync(tempus, numerālis, persōna);

    public sealed string? Imperātīvum(in Vōx vōx, in Tempus tempus, in Numerālis numerālis)
              => await Relātum.ImperātīvumAsync(vōx, tempus, numerālis);

    public sealed string? Īnfīnītīvum(in Vōx vōx, in Tempus tempus)
              => await Relātum.ĪnfīnītīvumAsyc(vōx, tempus);

    public sealed string? Participāle(in Vōx vōx, in Tempus tempus)
              => await Relātum.ParticipāleAsync(vōx, tempus);
  }
}
