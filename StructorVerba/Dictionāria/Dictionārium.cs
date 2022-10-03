using System;
using System.Linq;
using System.Reflection;
using System.Collections.Generic.IEnumerable;
using System.Threading.Tasks.Task;

using Miscella;
using Nūntiī.Nūntius;
using Praebeunda.Interfecta.Īnflexum;
using Praebeunda.Īnflectendum;
using Praebeunda.Multiplex;
using Ēnumerātiōnēs.Catēgora;
using Īnflexōrēs.Īnflexor;

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
                                Catēgora.Adiectīvum => DictionāriumAdiectīvīs.Lazy,
                                Catēgora.Nōmen => DictionāriumNōminibus.Lazy,
                                Catēgora.Prōnōmen => DictionāriumPrōnōminibus.Lazy,
                                Catēgora.Āctus => DictionāriumĀctibus.Lazy,
                                _ => new Lazy(null)
                              };

    protected readonly Nūntius<Dictionārium<Hoc, Illud>> Nūntius { get; }

    private readonly Func<Task<IEnumerable<FieldInfo>>> Omnia
          = async () => from illud in typeof(Hoc).GetFields()
                        from istud in illud.FieldType.GenericTypeArguments[0]
                        from abstractus in istud?.GenericTypeArguments.Length
                        where Ūtilitātēs.Omnia(illud.IsFamily, !illud.IsStatic,
                                               illud.FieldType is Lazy,
                                               abstractus is 1)
                        orderby illud.Name
                        select illud;

    private readonly Func<FieldInfo, Task<Īnflexor<Illud>?>> Oblātor
          = async locus => locus.GetObject(this).Cast<Īnflexor<Illud>>(null);

    private readonly Func<Task<Īnflexor<Illud>?>> FortisLātor
          = async () => await Oblātor.Invoke(await (await Omnia.Invoke()).Random());

    public readonly Func<Task<IEnumerable<Verbum>>> Lemmae
          = async () => (from illud in (await Omnia.Invoke())
                         select await Verbum.Cōnstrūctor.Invoke(illud.Name.ToLower(), Catēgora)).Distinct();

    private readonly Catēgora Catēgora { get; }

    protected Dictionārium(in Catēgora catēgora, in Lazy<Nūntius<Dictionārium<Hoc, Illud>>> nūntius)
    {
      Catēgora = catēgora;
      Nūntius = nūntius.Value;
    }

    private sealed Īnflexor<Illud>? Feram(string lemma)
          => await Oblātor.Invoke((from illud in (await Omnia.Invoke())
                                   where string.Equals(lemma, illud.Name, StringComparison.OrdinalIgnoreCase)
                                   select illud).FirstOrDefault());

    public sealed Illud? FeramĪnflectemque(string lemma, in Enum[] illa)
          => await (await FeramAsync(lemma: lemma))?.ĪnflectemAsync(illa: illa);

    public sealed Illud? ĪnflexōrīFortisFeram(string lemma)
          => await (await FeramAsync(lemma: lemma))?.FortisĪnflexor.Invoke();

    public sealed Illud? ForsFeratĪnflectetque()
          => await (await FortisLātor.Invoke())?.FortisĪnflexor.Invoke();
  }
}
