using System;
using System.Linq;
using System.Collections.Generic.LinkedList;

using Nūntiī.Nūntius;
using Officīnae;
using Ēnumerātiōnēs;

using Lombok.NET.MethodGenerators.AsyncOverloadsAttribute;
using Lombok.NET.PropertyGenerators.SingletonAttribute;

namespace Miscella
{
  [Singleton]
  [AsyncOverloads]
  public sealed partial class Scrīptor
  {
    public static readonly Lazy<Scrīptor> Faciendum = new Lazy(() => Instance);

    private readonly Lazy<OfficīnaPēnsābilium> Coniūctiōnēs = OfficīnaPēnsābilium.Officīnātor.Invoke(Catēgoria.Coniūnctiō);
    private readonly Lazy<OfficīnaPēnsābilium> Interiectiōnēs = OfficīnaPēnsābilium.Officīnātor.Invoke(Catēgoria.Interiectiō);
    private readonly Lazy<OfficīnaPēnsābilium> Praepostiōnēs = OfficīnaPēnsābilium.Officīnātor.Invoke(Catēgoria.Praepositiō);
    private readonly Lazy<OfficīnaĪnflexōrum> Āctūs = OfficīnaĪnflexōrum.Officīnātor.Invoke(Catēgoria.Āctus);
    private readonly Lazy<OfficīnaĪnflexōrum> Adiectīva = OfficīnaĪnflexōrum.Officīnātor.Invoke(Catēgoria.Adiectīvum);
    private readonly Lazy<OfficīnaĪnflexōrum> Adverbia = OfficīnaĪnflexōrum.Officīnātor.Invoke(Catēgoria.Adverbium);
    private readonly Lazy<OfficīnaĪnflexōrum> Nōmina = OfficīnaĪnflexōrum.Officīnātor.Invoke(Catēgoria.Nōmen);
    private readonly Lazy<Nūntius> Nūntius = new Lazy<Nūntius<Scrīptor>>();

    private readonly LinkedList<Verbum> Scrībendum { get; }
    public readonly Action Purgātor = Scrībendum.Clear;
    private readonly Func<Verbum?, Task<Boolean>> Additor = async verbum =>
    {
      if (verbum is not null)
      {
        Scrībendum.Add(verbum);
        return true;
      }
      else
      {
        return false;
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
    public Boolean ForsAddat(in string lemma, in Catēgoria catēgoria)
        => Additor.Invoke(Īnflexor.Invoke(catēgoria).Value?.Fortis.Īnflexor.Invoke());
    public Boolean ForsAddat() => ForsAddat(catēgoria: Catēgoria.GetValues().Except(Catēgoria.Numerāmen, Catēgoria.Numerus).Random());
    public string ToString() => string.Join(' ', Scrībendum.ToArray()).Capitalize();
  }
}
