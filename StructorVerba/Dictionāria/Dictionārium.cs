using System.Reflection;
using System;
using System.Collections.Generic.IEnumerable;
using System.Threading.Tasks.Task;

using Miscella;
using Nūntiī.Nūntius;
using Praebeunda.Interfecta.Īnflexum;
using Praebeunda.Īnflectendum;
using Praebeunda.Multiplex;
using Ēnumerātiōnēs.Catēgora;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;

namespace Dictionāria
{
  [AsyncOverloads]
  public abstract partial class Dictionārium<Hoc, Illud, Istud>
      where Hoc : Dictionārium<Hoc, Istud>
      where Illud : Īnflectendum<Illud, Istud>
      where Istud : Īnflexum<Istud>
  {
    protected Predicate<string, Illud> Quaesītor { get; }
    protected readonly Nūntius<Dictionārium<Hoc, Illud, Istud>> Nūntius { get; }

    private readonly Func<Task<IEnumerable<FieldInfo>>> Omnēs
          = async () => from illud in typeof(Hoc).GetFields()
                        where Ūtilitātēs.Omnēs(illud.IsFamily, !illud.IsStatic, illud.FieldType is Illud)
                        orderby illud.Name
                        select illud;

    private readonly Func<FieldInfo, Task<Illud>> Oblātor = async locus => locus.GetObject(this).Cast<Illud>();

    private readonly Func<Task<Illud?>> FortisLātor
          = async () => await Obātor.Invoke(await Omnēs.Invoke().Random());

    public readonly Func<Task<IEnumerable<string>>> Lemmae = async () => (from illud in (await Omnēs.Invoke())
                                                                          select illud.Name.ToLower()).Distinct();

    protected Dictionārium(in Predicate<string, Illud> quaesītor,
                           in Lazy<Nūntius<Dictionārium<Hoc, Illud, Istud>>> nūntius)
    {
      Quaesītor = quaesītor;
      Nūntius = nūntius.Value;
    }

    protected Dictionārium(in Lazy<Nūntius<Dictionārium<Hoc, Illud, Istud>>> nūntius)
        : this((lemma, illud) => string.Equals(lemma, illud.Name, StringComparison.OrdinalIgnoreCase), nūntius) { }

    private sealed Illud? Feram(string lemma)
          => await Obātor.Invoke((from illud in (await Omnēs.Invoke())
                                  where Quaesītor.Invoke(lemma, illud)
                                  select illud).FirstOrDefault());

    public sealed Istud? FeramĪnflectemque(string lemma, in Enum[] illa)
          => await (await FeramAsync(lemma))?.ĪnflectemAsync(illa);

    public sealed Istud? ĪnflexōrīFortisFeram(string lemma)
          => await (await FeramAsync(lemma))?.FortisĪnflexor.Invoke();

    public sealed Istud? ForsFeratĪnflectetque()
          => await (await FortisLātor.Invoke())?.FortisĪnflexor.Invoke();
  }
}
