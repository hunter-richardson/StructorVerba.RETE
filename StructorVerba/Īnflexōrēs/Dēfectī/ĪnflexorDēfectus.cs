using System;
using System.Collections.Generic.IEnumerable;
using System.Threading.Tasks.Task;

using Miscella.Extensions;
using Īnflexōrēs.Effectī;
using Nūntiī.Nūntius;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

namespace Īnflexōrēs.Dēfectī
{
  [AsyncOverloads]
  public abstract partial class ĪnflexorDēfectus<Hoc, Illud> : Īnflexor<Hoc, Illud>
  {
    private readonly ĪnflexorEffectus<Hoc, Illud> Relātus { get; }
    protected ĪnflexorDēfectus(in Ēnumerātiōnēs.Catēgoria catēgoria, in Lazy<Nūntius<ĪnflexorDēfectus<Hoc, Illud>>> nūntius,
                               in Lazy<ĪnflexorEffectus<Hoc, Illud>> relātus, in params IEnumerable<Enum[]> illa)
                                                   : base(catēgoria, nūntius, Array.Empty)
    {
      Relātus = relātus.Value;
    }

    public abstract Enum[] Referō(in Enum[] illa);

    public sealed Illud? Īnflectem(in Hoc hoc, in Enum[] illa)
    {
      Relātus.Tabulātor.Invoke()
             .ReplaceAll(valōrēs => Referō(valōrēs))
             .ForEach(valōrēs => Tabula.Add(valōrēs));

      return await base.ĪnflectemAsync(hoc, illa);
    }

    public sealed string Scrībam(in Hoc hoc, in Enum[] illa)
              => await Relātus.ScrībamAsync(await ReferōAsync(illa));
  }
}
