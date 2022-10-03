using System;
using System.Collections.Generic.LinkedList;
using System.Collections.Immutable;
using System.Linq;

using Nūntiī.Nūntius;
using Officīnae;
using Praebeunda.Multiplex.Āctus;
using Ēnumerātiōnēs;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.LazyAttribute;

namespace Miscella
{
  [Lazy]
  [AsyncOverloads]
  public sealed partial class Scrīptor
  {
    private readonly Lazy<OfficīnaPēnsābilium> Coniūctiōnēs = OfficīnaPēnsābilium.Officīnātor.Invoke(Catēgoria.Coniūnctiō);
    private readonly Lazy<OfficīnaPēnsābilium> Interiectiōnēs = OfficīnaPēnsābilium.Officīnātor.Invoke(Catēgoria.Interiectiō);
    private readonly Lazy<OfficīnaPēnsābilium> Praepostiōnēs = OfficīnaPēnsābilium.Officīnātor.Invoke(Catēgoria.Praepositiō);
    private readonly Lazy<OfficīnaĪnflexōrum> Āctūs = OfficīnaĪnflexōrum.Officīnātor.Invoke(Catēgoria.Āctus);
    private readonly Lazy<OfficīnaĪnflexōrum> Adiectīva = OfficīnaĪnflexōrum.Officīnātor.Invoke(Catēgoria.Adiectīvum);
    private readonly Lazy<OfficīnaĪnflexōrum> Adverbia = OfficīnaĪnflexōrum.Officīnātor.Invoke(Catēgoria.Adverbium);
    private readonly Lazy<OfficīnaĪnflexōrum> Nōmina = OfficīnaĪnflexōrum.Officīnātor.Invoke(Catēgoria.Nōmen);
    private readonly Lazy<Nūntius> Nūntius = new Lazy<Nūntius<Scrīptor>>();

    private readonly LinkedList<Verbum> Scrībendum { get; }
    public readonly int Mēnsura => Scrībendum.Count();
    public readonly Func<Task<IEnumerable<Verbum>>> Verba = async () => Scrībendum.ToImmutableList();
    public readonly Action Purgātor = Scrībendum.Clear;
    public readonly Func<Verbum?, Task<Boolean>> Additor = async verbum =>
    {
      if (Ūtilitātēs.Ulla(verbum is null,
          verbum?.Catēgoria is Catēgoria.Numerāmen,
          Ūtilitātēs.Omnia(verbum?.Catēgoria is Catēgoria.Āctus,
                           verbum?.Cast<Āctus>()?.Modus is Modus.Participālis)))
      {
        return false;
      }
      else
      {
        const Verbum praevium = Scrībendum.Last;
        if(Ūtilitātēs.Omnia(praevium.Catēgoria is Catēgoria.Praepositiō,
                            praevium.Scrīptum is "ā" or "ē",
                            Ūtilitātēs.Mūta(verbum.Scrīptum[0])))
        {
          const string scrīptum = praevium.Scrīptum switch
                                  {
                                    "ā" => "ab",
                                    "ē" => "ex",
                                    _ => praevium.Scrīptum
                                  };
          Scrībendum.RemoveLast();
          Scrībendum.Add(Verbum.Cōnstrūctor.Invoke(scrīptum, Catēgoria.Praepositiō));
        }

        Scrībendum.Add(verbum);
        return true;
      }
    };

    private readonly Func<Catēgoria, Lazy<OfficīnaPēnsābilium?>> Pēnsor
        = catēgoria => catēgoria switch
                        {
                          Catēgoria.Coniūnctiō => Coniūnctiōnēs,
                          Catēgoria.Interiectiō => Interiectiōnēs,
                          Catēgoria.Praepositiō => Praepositiōnēs,
                          _ => new Lazy(() => null)
                        };

    private readonly Func<Catēgoria, Lazy<OfficīnaĪnflexōrum?>> Īnflexor
        = catēgoria => catēgoria switch
                        {
                          Catēgoria.Āctus => Āctūs,
                          Catēgoria.Adiectīvum => Adiectīva,
                          Catēgoria.Adverbium => Adverbia,
                          Catēgoria.Nōmen => Nōmina,
                          Catēgoria.Prōnōmen => Prōnōmina,
                          _ => new Lazy(() => null)
                        };

    private Scrīptor() => Nūntius.Value.PlūsGarriōAsync("Fīō");

    public Boolean Addam(in string lemma, in Catēgoria catēgoria)
        => Additor.Invoke(Pēnsor.Invoke(catēgoria).Value?.Inventor(lemma));
    public Boolean Addam(in string lemma, in Catēgoria catēgoria, in Enum[] illa)
        => Additor.Invoke(Īnflexor.Invoke(catēgoria).Value?.Inventor(lemma, illa));
    public Boolean ForsAddat(in Catēgoria catēgoria)
        => Additor.Invoke(catēgoria.Īnflexa().Choose(Īnflexor.Invoke(catēgoria).Value?.FortisĪnflexor,
                                                     Pēnsor.Invoke(catēgoria).Value?.FortisInventor)
                                             .Invoke());
    public Boolean ForsAddat(in Catēgoria catēgoria)
        => Additor.Invoke(Īnflexor.Invoke(catēgoria).Value?.Fortis.Īnflexor.Invoke());
    public Boolean ForsAddat() => ForsAddat(catēgoria: Catēgoria.GetValues().Except(Catēgoria.Numerāmen, Catēgoria.Numerus).Random());
    public string Scrīptum() => string.Join(' ', Scrībendum.ToArray()).Capitalize();
  }
}
