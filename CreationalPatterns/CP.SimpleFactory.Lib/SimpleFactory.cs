namespace CP.SimpleFactory.Lib;


public interface ICreditCard
{
    string GetCardType();
    int GetUploadLimit();
    int GetAnnualCharge();
}

public static class CreditCardFactory
{
    public static ICreditCard CreateCreditCard(string creditCardType)
    {
        ICreditCard creditCard=null;
        if (creditCardType == "Silver")
        {
            creditCard= new Silver();
           
        }
        else if (creditCardType == "Gold")
        {
            creditCard= new Gold();
           
        }
        else if (creditCardType == "Platinum")
        {
            creditCard= new Platinum();
           
        }
        return creditCard;
    }
}

public class Silver : ICreditCard
{
    public string GetCardType() => "Silver";

    public int GetUploadLimit() => 15;

    public int GetAnnualCharge() => 250;
}
public class Gold : ICreditCard
{
    public string GetCardType() => "Gold";

    public int GetUploadLimit() => 30;

    public int GetAnnualCharge() => 500;
}
public class Platinum : ICreditCard
{
    public string GetCardType() => "Platinum";

    public int GetUploadLimit() => 50;

    public int GetAnnualCharge() => 750;
}
