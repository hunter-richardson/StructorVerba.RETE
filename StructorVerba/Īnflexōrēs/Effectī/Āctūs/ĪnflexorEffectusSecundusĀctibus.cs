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
  public sealed partial class ĪnflexorEffectusSecundusĀctibus : ĪnflexorEffectusĀctibus
  {
    public static readonly Lazy<ĪnflexorEffectusSecundusĀctibus> Faciendum = new Lazy(() => Instance);

    private ĪnflexorEffectusSecundusĀctibus()
        : base(new Lazy<Nūntius<ĪnflexorEffectusSecundusĀctibus>>()) { }

    public sealed string? IndicātīvumĀctīvum(in Tempus tempus, in Numerālis numerālis, in Persōna persōna)
    {
      const string? suffixum = (tempus, numerālis, persōna) switch
                                {
                                  (Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma) => "eō",
                                  (Tempus.Praesēns, Numerālis.Singulāris, Persōna.Secunda) => "ēs",
                                  (Tempus.Praesēns, Numerālis.Singulāris, Persōna.Tertia) => "et",
                                  (Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Prīma) => "ēmus",
                                  (Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Secunda) => "ētis",
                                  (Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Tertia) => "ent",
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
                                  (Tempus.Infectum or Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Secunda) => "ās",
                                  (Tempus.Infectum or Tempus.Plūsquamperfectum, Numerālis.Singulāris, Persōna.Tertia) => "at",
                                  (Tempus.Infectum or Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Prīma) => "āmus",
                                  (Tempus.Infectum or Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Secunda) => "ātis",
                                  (Tempus.Infectum or Tempus.Plūsquamperfectum, Numerālis.Plūrālis, Persōna.Tertia) => "ant",
                                  _ => null
                                },
                    īnfīxum = tempus switch
                              {
                                Tempus.Praesēns or Tempus.Perfectum => string.Empty,
                                Tempus.Futūrum or Tempus.Infectum => "ēb",
                                Tempus.Plūsquamperfectum or Tempus.Futūrum_Exāctum => "er",
                                _ => null
                              };
      return īnfīxum?.Concat(suffixum);
    }

    public sealed string? IndicātīvumPassīvum(in Tempus tempus, in Numerālis numerālis, in Persōna persōna)
    {
      const string? suffixum = (tempus, numerālis, persōna) switch
                                {
                                  (Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma) => "eor",
                                  (Tempus.Praesēns, Numerālis.Singulāris, Persōna.Secunda) => "ēris",
                                  (Tempus.Praesēns, Numerālis.Singulāris, Persōna.Tertia) => "ētur",
                                  (Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Prīma) => "ēmur",
                                  (Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Secunda) => "ēminī",
                                  (Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Tertia) => "entur",
                                  (Tempus.Infectum, Numerālis.Singulāris, Persōna.Prīma) => "ar",
                                  (Tempus.Infectum, Numerālis.Singulāris, Persōna.Secunda) => "āris",
                                  (Tempus.Infectum, Numerālis.Singulāris, Persōna.Tertia) => "ātur",
                                  (Tempus.Infectum, Numerālis.Plūrālis, Persōna.Prīma) => "āmur",
                                  (Tempus.Infectum, Numerālis.Plūrālis, Persōna.Secunda) => "āminī",
                                  (Tempus.Infectum, Numerālis.Plūrālis, Persōna.Tertia) => "antur",
                                  (Tempus.Futūrum, Numerālis.Singulāris, Persōna.Prīma) => "or",
                                  (Tempus.Futūrum, Numerālis.Singulāris, Persōna.Secunda) => "eris",
                                  (Tempus.Futūrum, Numerālis.Singulāris, Persōna.Tertia) => "itur",
                                  (Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Prīma) => "imur",
                                  (Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Secunda) => "iminī",
                                  (Tempus.Futūrum, Numerālis.Plūrālis, Persōna.Tertia) => "untur",
                                  _ => null
                                },
                    īnfīxum = tempus switch
                              {
                                Tempus.Praesēns => string.Empty,
                                Tempus.Infectum or Tempus.Futūrum => "ēb",
                                _ => null
                              };
      return īnfīxum?.Concat(suffixum);
    }

    public sealed string? SubiūnctīvumĀctīvum(in Tempus tempus, in Numerālis numerālis, in Persōna persōna)
    {
      const string? suffixum = (tempus, numerālis, persōna) switch
                                {
                                  (Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma) => "eam",
                                  (Tempus.Praesēns, Numerālis.Singulāris, Persōna.Secunda) => "eās",
                                  (Tempus.Praesēns, Numerālis.Singulāris, Persōna.Tertia) => "et",
                                  (Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Prīma) => "eāmus",
                                  (Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Secunda) => "eātis",
                                  (Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Tertia) => "eant",
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
                                Tempus.Infectum => "ēr",
                                Tempus.Perfectum => "er",
                                Tempus.Plūsquamperfectum => "ēss",
                                _ => null
                              };
      return īnfīxum?.Concat(suffixum);
    }

    public sealed string? IndicātīvumPassīvum(in Numerālis numerālis, in Persōna persōna)
    {
      const string? suffixum = (numerālis, persōna) switch
                                {
                                  (Tempus.Praesēns, Numerālis.Singulāris, Persōna.Prīma) => "ear",
                                  (Tempus.Praesēns, Numerālis.Singulāris, Persōna.Secunda) => "eāris",
                                  (Tempus.Praesēns, Numerālis.Singulāris, Persōna.Tertia) => "eātur",
                                  (Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Prīma) => "eāmur",
                                  (Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Secunda) => "eāminī",
                                  (Tempus.Praesēns, Numerālis.Plūrālis, Persōna.Tertia) => "eantur",
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
                      Tempus.Infectum => "ēr",
                      _ => null
                    };
      return īnfīxum?.Concat(suffixum);
    }

    public sealed async string? Imperātīvum(in Vōx vōx, in Tempus tempus, in Numerālis numerālis)
              => (vōx, tempus, numerālis) switch
                  {
                    (Vōx.Āctīva, Tempus.Praesēns, Numerālis.Singulāris) => "ē",
                    (Vōx.Passīva, Tempus.Praesēns, Numerālis.Plūrālis) => "ēminī",
                    (Vōx.Passīva, Tempus.Futūrum, Numerālis.Singulāris) => "ētor",
                    (Vōx.Passīva, Tempus.Futūrum, Numerālis.Plūrālis) => "entor",
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
                    (Vōx.Āctīva, Tempus.Praesēns) => "ēre",
                    (Vōx.Āctīva, Tempus.Perfectum) => "isse",
                    (Vōx.Passīva, _) => (await ĪnfīnītīvumAsync(vōx, Tempus.Praesēns)).Replace("e", "ī"),
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
