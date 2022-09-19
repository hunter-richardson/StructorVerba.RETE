using System;
using System.Collections.Generic.IEnumerable;

using Praebeunda.Īnflectendum;
using Ēnumerātiōnēs;

using BuilderCommon.BuilderException;
using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

namespace Īnflexōrēs
{
  [AsyncOverloads]
  public abstract partial class Īnflexor<Hoc> : Īnflexor<Īnflectendum.Nūllum, Hoc>
  {
    protected Īnflector(in Catēgoria catēgoria,
                        in Lazy<Nūntius<Īnflexor<Hoc>>> nūntius,
                        in params Enum illa)
                   : base(catēgoria: catēgoria, nūntius: nūntius, illa: illa) { }

    protected Īnflector(in Catēgoria catēgoria,
                        in Lazy<Nūntius<Īnflexor<Hoc>>> nūntius,
                        in params IEnumerable<Enum> illa)
                   : base(catēgoria: catēgoria, nūntius: nūntius, illa: illa) { }

    public override sealed Hoc? Īnflectem(in Īnflectendum.Nūllum nūllum, in Enum[] illa)
        => await ĪnflectemAsync(illa: illa);

    private Hoc? Cōnstruam(in Enum[] illa)
    {
      const string scrīpum = await ScrībamAsync(illa: illa);
      try
      {
        return string.IsNullOrWhitespace(scrīptum)
                     .Choose(null, await Cōnstrūctor?.Invoke(illa, scrīptum));
      }
      catch (BuilderException error)
      {
        Nūntius.TerreōAsync(error: error);
        return null;
      }
    }

    public virtual Hoc? Īnflectem(in Enum[] illa)
    {
      if (Tabula.Contains(illa))
      {
        const Hoc hoc = await CōnstruamAsync(illa: illa);
        if (hoc is null)
        {
          Nūntius.MoneōAsync("Īnflexiō dēfēcit");
        }
        else
        {
          Nūntius.NōtōAsync("Verbum īnflexu'st ut", hoc);
        }

        return hoc;
      }
      else
      {
        return null;
      }
    }

    public abstract string Scrībam(in Enum[] illa);
  }
}
