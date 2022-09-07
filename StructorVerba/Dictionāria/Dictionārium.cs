using System;
using System.Reflection;
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
  public abstract partial class Dictionārium<Hoc, Illud>
      where Hoc : Dictionārium<Hoc, Illud>
      where Illud : Īnflexum<Illud>
  {
    public static readonly Func<Catēgora, Task<Lazy<Dictionārium?>>> Lēctor
          = async catēgora => catēgora switch
                              {
                                Catēgora.Nōmen => DictionāriumNōminibus.Faciendum,
                                _ => new Lazy(null)
                              };

    protected readonly Nūntius<Dictionārium<Hoc, Illud>> Nūntius { get; }

    private readonly Func<Task<IEnumerable<FieldInfo>>> Omnēs
          = async () => from illud in typeof(Hoc).GetFields()
                        where Ūtilitātēs.Omnēs(illud.IsFamily, !illud.IsStatic,
                                               illud.FieldType is Īnflectendum,
                                               illud.FieldType.GenericTypeArguments.Contains(Illud))
                        orderby illud.Name
                        select illud;

    private readonly Func<FieldInfo, Task<Īnflectendum?>> Oblātor = async locus => locus.GetObject(this).Cast<Īnflectendum>(null);

    private readonly Func<Task<Īnflectendum?>> FortisLātor
          = async () => await Oblātor.Invoke(await (await ĒnumerāAsync()).Random());

    public readonly Func<Task<IEnumerable<string>>> Lemmae = async () => (from illud in (await ĒnumerāAsync())
                                                                          select illud.Name.ToLower()).Distinct();

    protected Dictionārium(in Lazy<Nūntius<Dictionārium<Hoc, Illud>>> nūntius) => Nūntius = nūntius.Value;

    private sealed Īnflectendum? Feram(string lemma)
          => await Obātor.Invoke((from illud in (await ĒnumerāAsync())
                                  where string.Equals(lemma, illud.Name, StringComparison.OrdinalIgnoreCase)
                                  select illud).FirstOrDefault());

    public sealed Illud? FeramĪnflectemque(string lemma, in Enum[] illa)
          => await (await FeramAsync(lemma))?.ĪnflectemAsync(illa);

    public sealed Illud? ĪnflexōrīFortisFeram(string lemma)
          => await (await FeramAsync(lemma))?.FortisĪnflexor.Invoke();

    public sealed Illud? ForsFeratĪnflectetque()
          => await (await FortisLātor.Invoke())?.FortisĪnflexor.Invoke();
  }
}
