// See https://aka.ms/new-console-template for more information

using CP.SimpleFactory.Lib;

Console.WriteLine("".PadLeft(50,'-'));
Console.WriteLine("Simple Factory pattern example...");
Console.WriteLine("".PadLeft(50,'-'));

ICreditCard creditCard=CreditCardFactory.CreateCreditCard("Silver");

Console.WriteLine($"CreditType: {creditCard.GetCardType()}");
Console.WriteLine($"UploadLimit: {creditCard.GetUploadLimit()} GB");
Console.WriteLine($"AnnualCharge: {creditCard.GetAnnualCharge()} T");

Console.ReadKey();