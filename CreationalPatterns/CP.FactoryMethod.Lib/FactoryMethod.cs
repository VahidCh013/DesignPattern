namespace CP.FactoryMethod.Lib;

/// <summary>
/// Product
/// </summary>
public interface IFeature
{
    string GetCardType();
    int GetUploadLimit();
    int GetAnnualCharge();
}


/// <summary>
/// Creator
/// </summary>
public abstract class FeatureFactory
{
    public abstract IFeature MakeFeature();
    public IFeature CreateFeature() => MakeFeature();
}
/// <summary>
/// Concrete Creator- SilverFactory
/// </summary>
public class SilverFactory : FeatureFactory
{
    public override IFeature MakeFeature()
    {
        IFeature feature = new Silver();
        return feature;
    }
}
/// <summary>
/// Concrete Creator- GoldFactory
/// </summary>
public class GoldFactory : FeatureFactory
{
    public override IFeature MakeFeature()
    {
        IFeature feature = new Gold();
        return feature;
    }
}

/// <summary>
/// Concrete Creator- PlatinumFactory
/// </summary>
public class PlatinumFactory : FeatureFactory
{
    public override IFeature MakeFeature()
    {
        IFeature feature = new Platinum();
        return feature;
    }
}



/// <summary>
/// Concrete Product- Silver
/// </summary>
public class Silver : IFeature
{
    public string GetCardType() => "Silver";

    public int GetUploadLimit() => 15;

    public int GetAnnualCharge() => 250;
}

/// <summary>
/// Concrete Product- Gold
/// </summary>
public class Gold : IFeature
{
    public string GetCardType() => "Gold";

    public int GetUploadLimit() => 30;

    public int GetAnnualCharge() => 500;
}

/// <summary>
/// Concrete Product- Platinum
/// </summary>
public class Platinum : IFeature
{
    public string GetCardType() => "Platinum";

    public int GetUploadLimit() => 50;

    public int GetAnnualCharge() => 750;
}