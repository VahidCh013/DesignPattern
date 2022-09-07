namespace CP.SimpleFactory.Lib;


public interface IFeature
{
    string GetCardType();
    int GetUploadLimit();
    int GetAnnualCharge();
}

public static class FeatureFactory
{
    public static IFeature CreateFeature(string featureType)
    {
        IFeature feature=null;
        if (featureType == "Silver")
        {
            feature= new Silver();
           
        }
        else if (featureType == "Gold")
        {
            feature= new Gold();
           
        }
        else if (featureType == "Platinum")
        {
            feature= new Platinum();
           
        }
        return feature;
    }
}

public class Silver : IFeature
{
    public string GetCardType() => "Silver";

    public int GetUploadLimit() => 15;

    public int GetAnnualCharge() => 250;
}
public class Gold : IFeature
{
    public string GetCardType() => "Gold";

    public int GetUploadLimit() => 30;

    public int GetAnnualCharge() => 500;
}
public class Platinum : IFeature
{
    public string GetCardType() => "Platinum";

    public int GetUploadLimit() => 50;

    public int GetAnnualCharge() => 750;
}
