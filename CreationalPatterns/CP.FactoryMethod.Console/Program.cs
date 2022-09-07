// See https://aka.ms/new-console-template for more information

using CP.FactoryMethod.Lib;

Console.WriteLine("".PadLeft(50,'-'));
Console.WriteLine("Factory method pattern example...");
Console.WriteLine("".PadLeft(50,'-'));

var feature = new SilverFactory().CreateFeature();
Console.WriteLine($"CreditType: {feature.GetCardType()}");
Console.WriteLine($"UploadLimit: {feature.GetUploadLimit()} GB");
Console.WriteLine($"AnnualCharge: {feature.GetAnnualCharge()} T");

Console.ReadKey();