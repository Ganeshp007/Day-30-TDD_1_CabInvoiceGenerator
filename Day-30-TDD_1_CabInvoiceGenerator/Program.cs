// See https://aka.ms/new-console-template for more information
using Day_30_TDD_1_CabInvoiceGenerator;

Console.WriteLine("------- Welcome to Cab Invoice Generato -------\n");

InvoiceGenerator invoiceGenerator;
Console.WriteLine("Which type of Suscription do you have :   1. Premium  2. Normal");
Console.Write("Enter you choice :- ");
int suscription_Type = Convert.ToInt32(Console.ReadLine());
switch(suscription_Type)
{
    case 1:
        invoiceGenerator=new InvoiceGenerator(RideType.PREMIUM);
        double fare_for_PremiumUser = invoiceGenerator.CalculateFare(2.0, 5);
        Console.WriteLine($"Fare : {fare_for_PremiumUser}");
        break;
    case 2:
        invoiceGenerator=new InvoiceGenerator(RideType.NORMAL);
        double fare_for_NormalUser = invoiceGenerator.CalculateFare(2.0, 5);
        Console.WriteLine($"Fare : {fare_for_NormalUser}");
        break;
}
Console.ReadLine();