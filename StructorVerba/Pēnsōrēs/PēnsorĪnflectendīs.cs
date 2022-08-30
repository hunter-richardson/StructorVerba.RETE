using System;
using System.Collections.Generic.Dictionary;
using System.Text.Json.JsonElement;
using System.Threading.Tasks.Task;

using Praebeunda;
using Ēnumerātiōnēs.Catēgoria;
using Nūntiī.Nūntius;

namespace Pēnsōrēs
{
  public abstract class PēnsorĪnflectendīs<Hoc, Illud> : Pēnsor<Hoc>
           where Hoc : Īnflectendum<Hoc, Illud> where Illud : Īnflexum<Hoc>
  {
    // TODO: convert Pensor from Categoria and Versio
    public static readonly Func<Ēnumerātiōnēs.Catēgoria, Enum, PēnsorĪnflectendīs> Relātor =
            (catēgoria, versiō) => catēgoria switch
            {
              Ēnumerātiōnēs.Catēgoria.Āctus       => null,
              Ēnumerātiōnēs.Catēgoria.Adiectīvum  => null,
              Ēnumerātiōnēs.Catēgoria.Adverbium   => null,
              Ēnumerātiōnēs.Catēgoria.Nōmen       => null,
              Ēnumerātiōnēs.Catēgoria.Numerāmen   => null,
              Ēnumerātiōnēs.Catēgoria.Prōnōmen    => null
            };

    // TODO: convert Table from Categoria and Versio
    public static Tabula Tabula(in Ēnumerātiōnēs.Catēgoria catēgoria, in Enum versiō) => null;

    public readonly Enum Versiō { get; }
    public readonly Ēnumerātiōnēs.Catēgoria Catēgoria { get; }
    protected PēnsorĪnflectendīs(in Enum versiō, in Ēnumerātiōnēs.Catēgoria catēgoria, in string quaerendī,
                                 in Func<Nūntius<PēnsorĪnflectendīs>> nūntius, in Func<JsonElement, Enum, Task<Hoc>> lēctor)
                                    : base(quaerendī, Tabula(catēgoria, versiō), nūntius,
                                          async legendum => lēctor.Invoke(legendum, versiō))
    {
      Versiō = versiō;
      Catēgoria = catēgoria;
      Nūntius.PlūsGarriōAsync("Fīō");
    }
  }
}
