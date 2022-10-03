using System;

using Miscella;
using Nūntiī.Nūntius;
using Īnflexōrēs.Effectī.Āctūs.ĪnflexōrēsEffectusĀctibus.Versiō;
using Ēnumerātiōnēs;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Īnflexōrēs.Effectī.Āctūs
{
  [Lazy]
  [AsyncOverloads]
  public sealed partial class ĪnflexorEffectusTertiusĀctibus : ĪnflexorEffectusĀctibus
  {
    private ĪnflexorEffectusTertiusĀctibus()
        : base(new Lazy<Nūntius<ĪnflexorEffectusTertiusĀctibus>>())
        => Nūntius.PlūsGarriōAsync("Fīō");

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
                                  (Tempus.Futūrum, Numerālis.Singulāris, Persōna.Secunda) => "ēs",
                                  (Tempus.Futūrum, Numerālis.Singulāris, Persōna.Tertia) => "et",
                                  (Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Prīma) => "ēmus",
                                  (Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Secunda) => "ētis",
                                  (Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Tertia) => "ent",
                                  (Tempus.Perfectum, Numerālis.Singulāris, Persōna.Prīma) => "ī",
                                  (Tempus.Perfectum, Numerālis.Singulāris, Persōna.Secunda) => "istī",
                                  (Tempus.Perfectum, Numerālis.Plūrālis, Persōna.Tertia) => "ērunt",
                                  (Tempus.Futūrum_Exāctum, Numerālis.Singulāris, Persōna.Prīma) => "ō",
                                  (Tempus.Futūrum_Exāctum, Numerālis.Singulāris, Persōna.Secunda) => "is",
                                  (Tempus.Futūrum_Exāctum, Numerālis.Plūrālis, Persōna.Tertia) => "unt",
                                  (Tempus.Perfectum or Tempus.Futūrum_Exāctum, Numerālis.Singulāris, Persōna.Tertia) => "it",
                                  (Tempus.Perfectum or Tempus.Futūrum_Exāctum, Numerālis.Plūrālis, Persōna.Prīma) => "imus",
                                  (Tempus.Perfectum or Tempus.Futūrum_Exāctum, Numerālis.Plūrālis, Persōna.Secunda) => "itis",
                                  (Tempus.Infectum or Tempus.Futūrum or Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Prīma) => "am",
                                  (Tempus.Infectum or Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Secunda) => "ās",
                                  (Tempus.Infectum or Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Tertia) => "at",
                                  (Tempus.Infectum or Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Prīma) => "āmus",
                                  (Tempus.Infectum or Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Secunda) => "ātis",
                                  (Tempus.Infectum or Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Tertia) => "ant",
                                  _ => null
                                },
                    īnfīxum = tempus switch
                              {
                                Tempus.Infectum => "ēb",
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
                                  (Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma) => "or",
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
                                  (Tempus.Futūrum, Numerālis.Singulāris, Persōna.Prīma) => "ar",
                                  (Tempus.Futūrum, Numerālis.Singulāris, Persōna.Secunda) => "ēris",
                                  (Tempus.Futūrum, Numerālis.Singulāris, Persōna.Tertia) => "ētur",
                                  (Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Prīma) => "ēmur",
                                  (Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Secunda) => "ēminī",
                                  (Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Tertia) => "entur",
                                  _ => null
                                },
                    īnfīxum = tempus switch
                              {
                                Tempus.Infectum => "ēb",
                                Tempus.Praesēns or Tempus.Futūrum => string.Empty,
                                _ => null
                              };
      return īnfīxum?.Concat(suffixum);
    }

    public sealed string? SubiūnctīvumĀctīvum(in Tempus tempus, in Numerālis numerālis, in Persōna persōna)
    {
      const string? suffixum = (tempus, numerālis, persōna) switch
      {
        (Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma) => "am",
        (Tempus.Praesēns, Numerālis.Singulāris, Persōna.Secunda) => "ās",
        (Tempus.Praesēns, Numerālis.Singulāris, Persōna.Tertia) => "at",
        (Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Prīma) => "āmus",
        (Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Secunda) => "ātis",
        (Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Tertia) => "ant",
        (Tempus.Perfectum, Numerālis.Singulāris, Persōna.Prīma) => "im",
        (Tempus.Perfectum, Numerālis.Singulāris, Persōna.Secunda) => "īs",
        (Tempus.Perfectum, Numerālis.Singulāris, Persōna.Tertia) => "it",
        (Tempus.Perfectum, Numerālis.Plūrālis, Persōna.Prīma) => "īmus",
        (Tempus.Perfectum, Numerālis.Plūrālis, Persōna.Secunda) => "ītis",
        (Tempus.Perfectum, Numerālis.Plūrālis, Persōna.Tertia) => "int",
        (Tempus.Praesēns or Tempus.Infectum or Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Prīma) => "em",
        (Tempus.Praesēns or Tempus.Infectum or Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Secunda) => "ēs",
        (Tempus.Praesēns or Tempus.Infectum or Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Tertia) => "et",
        (Tempus.Praesēns or Tempus.Infectum or Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Prīma) => "ēmus",
        (Tempus.Praesēns or Tempus.Infectum or Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Secunda) => "ētis",
        (Tempus.Praesēns or Tempus.Infectum or Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Tertia) => "ent",
        _ => null
      },
                    īnfīxum = tempus switch
                    {
                      Tempus.Praesēns => string.Empty,
                      Tempus.Infectum or Tempus.Perfectum => "er",
                      Tempus.Plūsquamperfectum => "iss",
                      _ => null
                    };
      return īnfīxum?.Concat(suffixum);
    }

    public sealed string? IndicātīvumPassīvum(in Numerālis numerālis, in Persōna persōna)
    {
      const string? suffixum = (numerālis, persōna) switch
                                {
                                  (Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma) => "ar",
                                  (Tempus.Praesēns, Numerālis.Singulāris, Persōna.Secunda) => "āris",
                                  (Tempus.Praesēns, Numerālis.Singulāris, Persōna.Tertia) => "ātur",
                                  (Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Prīma) => "āmur",
                                  (Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Secunda) => "āminī",
                                  (Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Tertia) => "antur",
                                  (Tempus.Infectum, Numerālis.Singulāris, Persōna.Prīma) => "er",
                                  (Tempus.Infectum, Numerālis.Singulāris, Persōna.Secunda) => "ēris",
                                  (Tempus.Infectum, Numerālis.Singulāris, Persōna.Tertia) => "ētur",
                                  (Tempus.Infectum, Numerālis.Plūrālis, Persōna.Prīma) => "ēmur",
                                  (Tempus.Infectum, Numerālis.Plūrālis, Persōna.Secunda) => "ēminī",
                                  (Tempus.Infectum, Numerālis.Plūrālis, Persōna.Tertia) => "entur",
                                  _ => null
                                },
                    īnfīxum = tempus switch
                              {
                                Tempus.Praesēns => string.Empty,
                                Tempus.Infectum => "er",
                                _ => null
                              };
      return īnfīxum?.Concat(suffixum);
    }

    public sealed async string? Imperātīvum(in Vōx vōx, in Tempus tempus, in Numerālis numerālis)
              => (vōx, tempus, numerālis) switch
                  {
                    (Vōx.Āctīva, Tempus.Praesēns, Numerālis.Singulāris) => "e",
                    (Vōx.Āctīva, Tempus.Praesēns, Numerālis.Plūrālis) => "ite",
                    (Vōx.Āctīva, Tempus.Futūrum, Numerālis.Singulāris) => "itō",
                    (Vōx.Passīva, Tempus.Praesēns, Numerālis.Plūrālis) => "iminī",
                    (Vōx.Passīva, Tempus.Futūrum, Numerālis.Singulāris) => "itor",
                    (Vōx.Passīva, Tempus.Futūrum, Numerālis.Plūrālis) => "untor",
                    (Vōx.Passīva, Tempus.Praesēns, Numerālis.Singulāris)
                            => await ĪnfīnītīvumAsync(Vōx.Āctīva, tempus),
                    (Vōx.Āctīva, Tempus.Futūrum, Numerālis.Plūrālis)
                            => (await ImperātīvumAsync(vōx, tempus, Numerālis.Singulāris)).Concat("te"),
                    _ => null
                  };

    public sealed string? Īnfīnītīvum(in Vōx vōx, in Tempus tempus)
              => (vōx, tempus) switch
                  {
                    (Vōx.Āctīva, Tempus.Praesēns) => "ire",
                    (Vōx.Āctīva, Tempus.Perfectum) => "isse",
                    (Vōx.Passīva, _) => "ī",
                    _ => null
                  };

    public sealed string? Participāle(in Vōx vōx, in Tempus tempus)
              => (vōx, tempus) switch
                  {
                    (Vōx.Āctīva, Tempus.Praesēns) => "ēns",
                    (Vōx.Āctīva, Tempus.Futūrum) => "ūrum",
                    (Vōx.Passīva, Tempus.Praesēns) => "um",
                    (Vōx.Passīva, Tempus.Perfectum) => "endum",
                    _ => null
                  };
  }
}
