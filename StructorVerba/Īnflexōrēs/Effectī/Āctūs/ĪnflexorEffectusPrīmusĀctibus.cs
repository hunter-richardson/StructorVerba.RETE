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
  public sealed partial class ĪnflexorEffectusPrīmusĀctibus : ĪnflexorEffectusĀctibus
  {
    public static readonly Lazy<ĪnflexorEffectusPrīmusĀctibus> Faciendum
                     = new Lazy<ĪnflexorEffectusPrīmusĀctibus>(() => Instance);

    private ĪnflexorEffectusPrīmusĀctibus()
        : base(NūntiusĪnflexōrīEffectōPrīmōĀctibus.Faciendum) { }

    public sealed string? IndicātīvumĀctīvum(in Tempus tempus, in Numerālis numerālis, in Persōna persōna)
    {
      const string? suffixum = (tempus, numerālis, persōna) switch
                                {
                                  (Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma) => "ō",
                                  (Tempus.Perfectum, Numerālis.Singulāris, Persōna.Prīma) => "ī",
                                  (Tempus.Perfectum, Numerālis.Singulāris, Persōna.Secunda) => "istī",
                                  (Tempus.Perfectum, Numerālis.Plūrālis, Persōna.Tertia) => "ērunt",
                                  (Tempus.Futūrum or Tempus.Futūrum_Exāctum, Numerālis.Singulāris, Persōna.Prīma) => "ō",
                                  (Tempus.Futūrum or Tempus.Futūrum_Exāctum, Numerālis.Singulāris, Persōna.Secunda) => "is",
                                  (Tempus.Futūrum or Tempus.Futūrum_Exāctum, Numerālis.Plūrālis, Persōna.Tertia) => "unt",
                                  (Tempus.Futūrum or Tempus.Perfectum or Tempus.Futūrum_Exāctum, Numerālis.Singulāris, Persōna.Tertia) => "it",
                                  (Tempus.Futūrum or Tempus.Perfectum or Tempus.Futūrum_Exāctum, Numerālis.Plūrālis, Persōna.Prīma) => "imus",
                                  (Tempus.Futūrum or Tempus.Perfectum or Tempus.Futūrum_Exāctum, Numerālis.Plūrālis, Persōna.Secunda) => "itis",
                                  (Tempus.Infectum or Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Prīma) => "am",
                                  (Tempus.Praesēns or Tempus.Infectum or Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Secunda) => "ās",
                                  (Tempus.Praesēns or Tempus.Infectum or Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Tertia) => "at",
                                  (Tempus.Praesēns or Tempus.Infectum or Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Prīma) => "āmus",
                                  (Tempus.Praesēns or Tempus.Infectum or Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Secunda) => "ātis",
                                  (Tempus.Praesēns or Tempus.Infectum or Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Tertia) => "ant",
                                  _ => null
                                },
                    īnfīxum = tempus switch
                              {
                                Tempus.Praesēns => string.Empty,
                                Tempus.Perfectum => "āv",
                                Tempus.Futūrum or Tempus.Infectum => "āb",
                                Tempus.Plūsquamperfectum or Tempus.Futūrum_Exāctum => "āver",
                                _ => null
                              };
      return īnfīxum?.Concat(suffixum);
    }

    public sealed string? IndicātīvumPassīvum(in Tempus tempus, in Numerālis numerālis, in Persōna persōna)
    {
      const string? suffixum = (tempus, numerālis, persōna) switch
                                {
                                  (Tempus.Futūrum, Numerālis.Singulāris, Persōna.Prīma) => "or",
                                  (Tempus.Futūrum, Numerālis.Singulāris, Persōna.Secunda) => "eris",
                                  (Tempus.Futūrum, Numerālis.Singulāris, Persōna.Tertia) => "itur",
                                  (Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Prīma) => "imur",
                                  (Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Secunda) => "iminī",
                                  (Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Tertia) => "untur",
                                  (Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma) => "or",
                                  (Tempus.Infectum, Numerālis.Singulāris, Persōna.Prīma) => "ar",
                                  (Tempus.Praesēns or Tempus.Infectum, Numerālis.Singulāris, Persōna.Secunda) => "āris",
                                  (Tempus.Praesēns or Tempus.Infectum, Numerālis.Singulāris, Persōna.Tertia) => "ātur",
                                  (Tempus.Praesēns or Tempus.Infectum, Numerālis.Plūrālis, Persōna.Prīma) => "āmur",
                                  (Tempus.Praesēns or Tempus.Infectum, Numerālis.Plūrālis, Persōna.Secunda) => "āminī",
                                  (Tempus.Praesēns or Tempus.Infectum, Numerālis.Plūrālis, Persōna.Tertia) => "antur",
                                  _ => null
                                },
                    īnfīxum = tempus switch
                              {
                                Tempus.Praesēns => string.Empty,
                                Tempus.Infectum or Tempus.Futūrum => "āb",
                                _ => null
                              };
      return īnfīxum?.Concat(suffixum);
    }

    public sealed string? SubiūnctīvumĀctīvum(in Tempus tempus, in Numerālis numerālis, in Persōna persōna)
    {
      const string? suffixum = (tempus, numerālis, persōna) switch
                                {
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
                                Tempus.Infectum => "ār",
                                Tempus.Perfectum => "āver",
                                Tempus.Plūsquamperfectum => "āss",
                                _ => null
                              };
      return īnfīxum?.Concat(suffixum);
    }

    public sealed string? IndicātīvumPassīvum(in Numerālis numerālis, in Persōna persōna)
    {
      const string? suffixum = (numerālis, persōna) switch
                                {
                                  (Numerālis.Singulāris, Persōna.Prīma) => "er",
                                  (Numerālis.Singulāris, Persōna.Secunda) => "ēris",
                                  (Numerālis.Singulāris, Persōna.Tertia) => "ētur",
                                  (Numerālis.Plūrālis, Persōna.Prīma) => "ēmur",
                                  (Numerālis.Plūrālis, Persōna.Secunda) => "ēminī",
                                  (Numerālis.Plūrālis, Persōna.Tertia) => "entur",
                                  _ => null
                                },
                    īnfīxum = tempus switch
                              {
                                Tempus.Praesēns => string.Empty,
                                Tempus.Infectum => "ār",
                                _ => null
                              };
      return īnfīxum?.Concat(suffixum);
    }

    public sealed async string? Imperātīvum(in Vōx vōx, in Tempus tempus, in Numerālis numerālis)
              => (vōx, tempus, numerālis) switch
                  {
                    (Vōx.Āctīva, Tempus.Praesēns, Numerālis.Singulāris) => "ā",
                    (Vōx.Passīva, Tempus.Praesēns, Numerālis.Plūrālis) => "āminī",
                    (Vōx.Passīva, Tempus.Futūrum, Numerālis.Singulāris) => "ātor",
                    (Vōx.Passīva, Tempus.Futūrum, Numerālis.Plūrālis) => "antor",
                    (Vōx.Āctīva, Tempus.Futūrum, Numerāis.Singulāris)
                            => (await ImperātīvumAsync(vōx, Tempus.Praesēns, numerāls)).Concat("tō"),
                    (Vōx.Passīva, Tempus.Praesēns, Numerālis.Singulāris)
                            => await ĪnfīnītīvumAsync(Vōx.Āctīva, tempus),
                    (Vōx.Āctīva, Tempus.Praesēns or Tempus.Futūrum, Numerālis.Plūrālis)
                            => (await ImperātīvumAsync(vōx, tempus, Numerālis.Singulāris)).Concat("te"),
                    _ => null
                  };

    public sealed string? Īnfīnītīvum(in Vōx vōx, in Tempus tempus)
              => (vōx, tempus) switch
                  {
                    (Vōx.Āctīva, Tempus.Praesēns) => "āre",
                    (Vōx.Āctīva, Tempus.Perfectum) => "āvisse",
                    (Vōx.Passīva, _) => (await ĪnfīnītīvumAsync(vōx, Tempus.Praesēns)).Replace("e", "ī"),
                    _ => null
                  };

    public sealed string? Participāle(in Vōx vōx, in Tempus tempus)
              => (vōx, tempus) switch
                  {
                    (Vōx.Āctīva, Tempus.Praesēns) => "āns",
                    (Vōx.Āctīva, Tempus.Futūrum) => "ātūrum",
                    (Vōx.Passīva, Tempus.Praesēns) => "ātum",
                    (Vōx.Passīva, Tempus.Perfectum) => "andum",
                    _ => null
                  };

    [Singleton]
    private sealed partial class NūntiusĪnflexōrīEffectōPrīmōĀctibus
                : Nūntius<ĪnflexorEffectusPrīmusĀctibus>
    {
      public static readonly Lazy<NūntiusĪnflexōrīEffectōPrīmōĀctibus> Faciendum
                       = new Lazy<NūntiusĪnflexōrīEffectōPrīmōĀctibus>(() => Instance);
    }
  }
}
