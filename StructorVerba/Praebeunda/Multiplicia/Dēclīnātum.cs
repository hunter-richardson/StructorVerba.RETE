namespace Praebeunda.Multiplicia
{
  public abstract class Dēclīnātum
  {
    public readonly Casus casus { get; }
    public readonly Numerālis numerālis { get; }

    protected Dēclīnātum(in int minūtal, in Catēgoria catēgoria,
                         in Casus css, in Numerālis nmrls,
                         [StringLength(25, MinimumLength = 1)] in string scrīptum)
                         : base(minūtal, catēgoria, scrīptum)
    {
      casus = css;
      numerālis = nmrls;
    }
  }
}
