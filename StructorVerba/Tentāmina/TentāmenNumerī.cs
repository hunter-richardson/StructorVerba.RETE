using Praebeunda.Simplicia.Numerus;

namespace Tentāmina
{
  [AsyncOverloads]
  public sealed partial class TentāmenNumerī : TentāmenVerbī
  {
    public static sealed void Aequētur(in int tentandus, in Numerus? numerus = null,
                                       in string error = string.Empty)
              => new TentāmenNumerī(numerus: numerus)
                        .Aequētur(tentandus: tentandus, error: error);
    public static sealed void Differātur(in int tentandus, in Numerus? numerus = null,
                                         in string error = string.Empty)
              => new TentāmenNumerī(numerus: numerus)
                        .Differātur(tentandus: tentandus, error: error);
    public static sealed void Intersit(in Tuple<int, int> tentandī, in Numerus? numerus = null,
                                       in string error = string.Empty)
              => new TentāmenNumerī(numerus: numerus)
                        .Intersit(tentandī: tentandī, error: error);
    public static sealed void Extrāsit(in Tuple<int, int> tentandī, in Numerus? numerus = null,
                                       in string error = string.Empty)
              => new TentāmenNumerī(numerus: numerus)
                        .Extrāsit(tentandī: tentandī, error: error);
    public static sealed void Subsit(in int tentandus, in Numerus? prōductum = null,
                                     in string error = string.Empty)
              => new TentāmenNumerī(numerus: numerus)
                        .Subsit(tentandus: tentandus, error: error);
    public static sealed void Supersit(in int tentandus, in Numerus? numerus = null,
                                       in string error = string.Empty)
              => new TentāmenNumerī(numerus: numerus)
                        .Supersit(tentandus: tentandus, error: error);
    public static sealed void IntersitAequāturve(in Tuple<int, int> tentandī, in Numerus? numerus = null,
                                                 in string error = string.Empty)
              => new TentāmenNumerī(numerus: numerus)
                        .IntersitAequāturve(tentandī: tentandī, error: error);
    public static sealed void ExtrāsitAequāturve(in Tuple<int, int> tentandī, in Numerus? numerus = null,
                                                 in string error = string.Empty)
              => new TentāmenNumerī(numerus: numerus)
                        .ExtrāsitAequāturve(tentandī: tentandī, error: error);
    public static sealed void SubsitAequāturve(in int tentandus, in Numerus? numerus = null,
                                               in string error = string.Empty)
              => new TentāmenNumerī(numerus: numerus)
                        .SubsitAequāturve(tentandus: tentandus, error: error);
    public static sealed void SupersitAequāturve(in int tentandus, in Numerus? numerus = null,
                                                 in string error = string.Empty)
              => new TentāmenNumerī(numerus: numerus)
                        .SupersitAequāturve(tentandus: tentandus, error: error);

    private readonly TentāmenReī Relātum = new TentāmenReī(prōductum: Verbum?.Minūtal);

    public TentāmenNumerī(in Numerus? numerus = null)
        : base(verbum: numerus);

    public sealed void Differātur(in int tentandus, in string error = string.Empty)
              => await Relātum.DifferāturAsync(tentandum: tentandus, error: error);

    public sealed void Aequētur(in int tentandus, in string error = string.Empty)
              => await Relātum.AequēturAsync(tentandum: tentandus, error: error);

    public sealed void Intersit(in Tuple<int, int> tentandī,
                                in string error = string.Empty)
              => await Relātum.IntersitAsync(tentanda: tentandī, error: error);

    public sealed void Extrāsit(in Tuple<int, int> tentandī,
                                in string error = string.Empty)
              => await Relātum.ExtrāsitAsync(tentanda: tentandī, error: error);

    public sealed void Subsit(in int tentandus,
                              in string error = string.Empty)
              => await Relātum.SubsitAsync(tentandum: tentandus, error: error);

    public sealed void Supersit(in int tentandus,
                                in string error = string.Empty)
              => await Relātum.SupersitAsync(tentandum: tentandus, error: error);

    public sealed void IntersitAequāturve(in Tuple<int, int> tentandī,
                                          in string error = string.Empty)
              => await Relātum.IntersitAequēturveAsync(tentanda: tentandī, error: error);

    public sealed void ExtrāsitAequāturve(in Tuple<int, int> tentandī,
                                          in string error = string.Empty)
              => await Relātum.ExtrāsitAequāturveAsync(tentanda: tentandī, error: error);

    public sealed void SubsitAequāturve(in int tentandus,
                                        in string error = string.Empty)
              => await Relātum.SubsitAequēturveAsync(tentandum: tentandus, error: error);

    public sealed void SupersitAequāturve(in int tentandus,
                                          in string error = string.Empty)
              => await Relātum.SupersitAequēturveAsync(tentandum: tentandus, error: error);
  }
}
