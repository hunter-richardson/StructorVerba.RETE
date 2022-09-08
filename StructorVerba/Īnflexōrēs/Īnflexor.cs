using Praebeunda.Īnflectendum;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

namespace Īnflexōrēs
{
  [AsyncOverloads]
  public abstract partial class Īnflexor<Hoc> : Īnflexor<Īnflectendum.Nūllum, Hoc>
  {
    protected Īnflector(in Catēgoria catēgoria,
                        in Lazy<Nūntius<Īnflexor<Hoc>>> nūntius,
                        in params Enum illa)
          : base(catēgoria, nūntius, illa) { }

    protected Īnflector(in Catēgoria catēgoria,
                        in Lazy<Nūntius<Īnflexor<Hoc>>> nūntius,
                        in params IEnumerable<Enum> illa)
          : base(catēgoria, nūntius, illa) { }

    public override sealed Hoc? Īnflectem(in Īnflectendum.Nūllum nūllum, in Enum[] illa)
        => await ĪnflectemAsync(illa);

    private Hoc? Cōnstruam(in Enum[] illa)
    {
      const string scrīpum = await ScrībamAsync(illa);
      try
      {
        return string.IsNullOrWhitespace(scrīptum)
                     .Choose(null, await Cōnstrūctor?.Invoke(illa, scrīptum));
      }
      catch (BuilderException error)
      {
        Nūntius.TerreōAsync(error);
        return null;
      }
    }

    public virtual Illud? Īnflectem(in Enum[] illa)
    {
      if (Tabula.Contains(illa))
      {
        const Illud illud = await CōnstruamAsync(illa);
        if (illud is null)
        {
          Nūntius.MoneōAsync("Īnflexiō dēfēcit");
        }
        else
        {
          Nūntius.NōtōAsync("Verbum īnflexu'st ut", illud);
        }

        return illud;
      }
      else
      {
        return null;
      }
    }

    public abstract string Scrībam(in Enum[] illa);
  }
}
