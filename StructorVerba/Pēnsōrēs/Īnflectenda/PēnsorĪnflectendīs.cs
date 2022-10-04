using System;
using System.Collections.Generic.Dictionary;
using System.Text.Json.JsonElement;
using System.Threading.Tasks.Task;

using Praebeunda;
using Pēnsōrēs.Nōmina;
using Pēnsōrēs.Īnflectenda;
using Ēnumerātiōnēs.Catēgoria;
using Nūntiī.Nūntius;

namespace Pēnsōrēs.Īnflectenda
{
  public abstract class PēnsorĪnflectendīs<Hoc, Illud> : Pēnsor<Hoc>
           where Hoc : Īnflectendum<Hoc, Illud> where Illud : Īnflexum<Hoc>
  {
    public static readonly string ColumnaVersiōnis => Pēnsor.NōmenātorColumnae.Invoke(nameof(Versiō));

    public readonly Func<string, Task<Enum?>> Versor
              = async versiō => (from valor in Ūtilitātēs.Complānō(ComparātorValōrum,
                                                                   PēnsorAdverbiīs.Versiō.GetValues(),
                                                                   PēnsorAdiectīvīs.Versiō.GetValues(),
                                                                   PēnsorNōminibus.Versiō.GetValues(),
                                                                   PēnsorNōminibusFactīs.Versiō.GetValues(),
                                                                   PēnsorNumerāminibus.Versiō.GetValues(),
                                                                   PēnsorĀctibus.Versiō.GetValues())
                                 where valor.ToString().Equals(versiō, StringComparison.OrdinalIgnoreCase)
                                 select valor).FirstNonNull(null);
    public static readonly Func<Ēnumerātiōnēs.Catēgoria, Enum, Lazy<PēnsorĪnflectendīs?>> Relātor =
            (catēgoria, versiō) => catēgoria switch
            {
              Ēnumerātiōnēs.Catēgoria.Āctus => PēnsorĀctibus.Relātor.Invoke(versiō),
              Ēnumerātiōnēs.Catēgoria.Adiectīvum => PēnsorAdiectīvīs.Relātor.Invoke(versiō),
              Ēnumerātiōnēs.Catēgoria.Adverbium => PēnsorAdverbiīs.Lazy,
              Ēnumerātiōnēs.Catēgoria.Numerāmen => PēnsorNumerāminibus.Relātor.Invoke(versiō),
              Ēnumerātiōnēs.Catēgoria.Nōmen => valor.GetType() switch
                                                {
                                                  typeof(PēnsorNōminibusFactīs.Versiō) => PēnsorNōminibusFactīs.Relātor.Invoke(versiō),
                                                  typeof(PēnsorNōminibus.Versiō) => PēnsorNōminibus.Relātor.Invoke(versiō),
                                                  _ => new Lazy(null)
                                                },
              _ => new Lazy(null)
            };

    public readonly Enum Versiō { get; }
    protected PēnsorĪnflectendīs(in Enum versiō, in string quaerendī, in Tabula tabula,
                                 in Lazy<Nūntius<PēnsorĪnflectendīs<Hoc>>> nūntius,
                                 in Func<JsonElement, Task<Hoc>> lēctor)
                                    : base(quaerendī: quaerendī, tabula: tabula, nūntius: nūntius,
                                           lēctor: async legendum => lēctor.Invoke(legendum, versiō))
          => Versiō = versiō;
  }
}
