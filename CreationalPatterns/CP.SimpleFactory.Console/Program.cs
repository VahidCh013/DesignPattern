// See https://aka.ms/new-console-template for more information

using CP.SimpleFactory.Lib;

Console.WriteLine("".PadLeft(50,'-'));
Console.WriteLine("Simple Factory pattern example...");
Console.WriteLine("".PadLeft(50,'-'));

IFeature feature=FeatureFactory.CreateFeature("Silver");

Console.WriteLine($"CreditType: {feature.GetCardType()}");
Console.WriteLine($"UploadLimit: {feature.GetUploadLimit()} GB");
Console.WriteLine($"AnnualCharge: {feature.GetAnnualCharge()} T");

Console.ReadKey();