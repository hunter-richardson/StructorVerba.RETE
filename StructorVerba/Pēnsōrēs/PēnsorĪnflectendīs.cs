using System;
using System.Collections.Generic.Dictionary;
using System.Text.Json.JsonElement;
using System.Threading.Tasks.Task;

using Praebeunda;
using Pēnsōrēs.Adverbia;
using Pēnsōrēs.Numerāmina;
using Ēnumerātiōnēs.Catēgoria;
using Nūntiī.Nūntius;

namespace Pēnsōrēs
{
  public abstract class PēnsorĪnflectendīs<Hoc, Illud> : Pēnsor<Hoc>
           where Hoc : Īnflectendum<Hoc, Illud> where Illud : Īnflexum<Hoc>
  {
    // TODO: convert Pensor from Categoria and Versio
    public static readonly Func<Ēnumerātiōnēs.Catēgoria, Enum, Lazy<PēnsorĪnflectendīs?>> Relātor =
            (catēgoria, versiō) => catēgoria switch
            {
              Ēnumerātiōnēs.Catēgoria.Āctus       => null,
              Ēnumerātiōnēs.Catēgoria.Adiectīvum  => null,
              Ēnumerātiōnēs.Catēgoria.Adverbium   => PēnsorAdverbiīs.Faciendum,
              Ēnumerātiōnēs.Catēgoria.Nōmen       => null,
              Ēnumerātiōnēs.Catēgoria.Numerāmen   => PēnsorNumerāminibus.Relātor.Invoke(versiō),
              Ēnumerātiōnēs.Catēgoria.Prōnōmen    => null,
              _ => new Lazy(null)
            };

    public readonly Enum Versiō { get; }
    protected PēnsorĪnflectendīs(in Enum versiō, in string quaerendī, in Tabula tabula,
                                 in Lazy<Nūntius<PēnsorĪnflectendīs<Hoc>>> nūntius,
                                 in Func<JsonElement, Task<Hoc>> lēctor)
                                    : base(quaerendī, tabula, nūntius,
                                           async legendum => lēctor.Invoke(legendum, versiō))
    {
      Versiō = versiō;
      Nūntius.PlūsGarriōAsync("Fīō");
    }
  }
}
